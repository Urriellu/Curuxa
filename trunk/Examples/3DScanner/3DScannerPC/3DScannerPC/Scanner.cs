using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SWF = System.Windows.Forms;

namespace _3DScannerPC {
	class DummyLocker {
	}

	public static class Scanner {
		static SWF.Timer AuthTimer;
		static DateTime LastAuthentication = new DateTime(1900, 1, 1);
		static DummyLocker s = new DummyLocker();
		public static bool Authenticated { get; private set; }
		public static ScannerMode Mode = ScannerMode.Inactive;

		public static Status Status {
			get {
				return _Status;
			}
			private set {
				_Status = value;
				if(Globals.MainWindow != null) Globals.MainWindow.UpdateStatus();
				if(value == Status.Disconnected) Authenticated = false;
			}
		}
		private static Status _Status = Status.Disconnected;

		static SerialPort SP;

		/// <summary>
		/// Thread to do Serial Port polling looking for new received data
		/// </summary>
		static Thread ThreadReceiver;

		static Scanner() {
			AuthTimer = new SWF.Timer();
			AuthTimer.Tick += new EventHandler(AuthTimer_Tick);
			AuthTimer.Interval = 1000;
			AuthTimer.Start();
		}

		/// <summary>
		/// Connect to the microcontroller
		/// </summary>
		public static void Connect(string portName, int baudRate) {
			Globals.Log(LogType.Information, "Trying to connect");
			if(Scanner.SP != null && Scanner.SP.IsOpen) Scanner.SP.Close();
			SP = new SerialPort(portName, baudRate, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
			try {
				SP.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SP_DataReceived);
				SP.Open();
				Globals.Log(LogType.Success, "Connected to " + portName);
				if(ThreadReceiver == null) {
					//ThreadReceiver = new Thread(Scanner.DataReceiver);
					//ThreadReceiver.Start();
				}
				Status = Status.Connected;
				AskAuth();
			} catch(Exception e) {
				Globals.Log(LogType.Error, "Unable to connect: " + e.Message);
				Status = Status.Disconnected;
			}
			Globals.MainWindow.UpdateStatus();
		}

		static byte ReadByte() {
			byte Rcv = SP.ReadByte();
			Globals.Log(LogType.Debug, "Received byte: " + Rcv);
			return Rcv;
		}

		static void SP_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) {
			while(SP.IsOpen && SP.BytesToRead > 0) {
				byte Rcv = ReadByte();
				ControlByte BC = (ControlByte)Rcv;
				if(BC == ControlByte.AuthID) {
					Rcv = (byte)ReadByte();
					if(Rcv == Settings.ScannerID) {
						// auth success
						Status = Status.Connected;
						Authenticated = true;
						LastAuthentication = DateTime.Now;
						Globals.Log(LogType.Success, "Authentication successful");
					} else {
						Globals.Log(LogType.Error, "Authentication failure (received ID: " + Rcv + "), disconnecting...");
						Disconnect();
					}
				}

				if(Authenticated || !Settings.RequireAuthentication) {
					switch(BC) {
						case ControlByte.AuthID:
							break;
						case ControlByte.Error:
							ControlByteError error = (ControlByteError)ReadByte();
							Globals.Log(LogType.Error, "Microcontroller error: " + error);
							break;
						case ControlByte.ManualTxValue:
							UInt16 receivedValue = (UInt16)((byte)ReadByte() << 8);
							receivedValue += (byte)ReadByte();
							Globals.MainWindow.SetReceivedManualValue(receivedValue);
							Globals.Log(LogType.Information, "Received manual value: " + receivedValue);
							break;
						default:
							Globals.Log(LogType.Error, "Unknown control byte: " + BC.ToString());
							break;
					}
				} else {
					Globals.Log(LogType.Error, "Not authenticated, ignoring received byte: " + Rcv);
				}
			}
		}

		static void AuthTimer_Tick(object sender, EventArgs e) {
			// ask for authentification
			/*if(Status == Status.Connected) {
				Check();

				if((DateTime.Now - LastAuthentication).TotalSeconds > 2.5) {
					Globals.Log("Not authenticated for too long...");
					//Disconnect();
					Authenticated = false;
				}
			}*/

			//if(Status == Status.Disconnected) Connect();
		}

		public static void Disconnect() {
			SetMode(ScannerMode.Inactive);
			if(ThreadReceiver != null) {
				ThreadReceiver.Abort();
				//ThreadReceiver = null;
			}
			if(SP != null) {
				SP.Close();
				//SP.Dispose();
				//SP = null;
			}
			Authenticated = false;
			Status = Status.Disconnected;
			Mode = ScannerMode.Inactive;
			Globals.Log(LogType.Information, "Disconnected");
			Globals.MainWindow.UpdateStatus();
		}

		//THIS ONE MUST NOT CONTAIN A LOCK
		public static bool Send(byte B) {
			if(Settings.RequireAuthentication && !Authenticated && B != (byte)ControlByte.AuthID) {
				Globals.Log(LogType.Error, "Unable to send byte: " + B.ToString() + ". Not authenticated");
				return false;
			}
			if(SP != null && SP.IsOpen) {
				try {
					SP.WriteByte(B);
					Globals.Log(LogType.Debug, "Byte sent: " + B.ToString());
					Thread.Sleep(10);
					return true;
				} catch(Exception e) {
					Globals.Log(LogType.Error, "Error while sending byte \"" + B.ToString() + "\": " + e.Message);
					return false;
				}
			} else {
				Globals.Log(LogType.Error, "Unable to send byte: " + B.ToString());
				return false;
			}
		}

		public static void AskAuth() {
			lock(s) {
				Send(ControlByte.AuthID);
			}
		}

		public static bool Send(ControlByte CB) {
			lock(s) {
				return Send((byte)CB);
			}
		}

		/*public static void SetLight(ControlByteLight CBL) {
			lock(s) {
				Send(ControlByte.SetLight);
				Send((byte)CBL);
			}
		}

		static DateTime LastBaseMvChange = DateTime.Now;

		public static void SetBaseMv(ControlByteBaseMv CBB) {
			//don't send changes too fast
			if((DateTime.Now - LastBaseMvChange).TotalMilliseconds < 400) return;

			lock(s) {
				Send(ControlByte.SetBaseMovement);
				Send((byte)CBB);
			}
			LastBaseMvChange = DateTime.Now;
		}*/

		/// <summary>
		/// Method run on a separate thread which maked polling to the serial port and processes received data
		/// </summary>
		/*public static void DataReceiver() {
			Globals.Log("Starting receiver thread");
			do {
				while(SP != null && SP.IsOpen && Globals.MainWindow != null) {
					try {
						byte Rcv = (byte)ReadByte();
						Globals.Log("Received byte: " + Rcv);
						ControlByte BC = (ControlByte)Rcv;
						if(BC == ControlByte.AuthID) {
							Rcv = (byte)ReadByte();
							if(Rcv == Settings.ScannerID) {
								// auth success
								Status = Status.Connected;
								Authenticated = true;
								LastAuthentication = DateTime.Now;
								Globals.Log("Authentication successful");
							} else {
								Globals.Log("Authentication failure (received ID: " + Rcv + "), disconnecting...");
								Disconnect();
							}
						}

						if(Authenticated || !Settings.RequireAuthentication) {
							switch(BC) {
								case ControlByte.AuthID:
									break;
								case ControlByte.ManualTxValue:
									UInt16 receivedValue = (UInt16)((byte)ReadByte() << 8);
									receivedValue += (byte)ReadByte();
									Globals.MainWindow.SetReceivedManualValue(receivedValue);
									Globals.Log("Received manual value: " + receivedValue);
									break;
								default:
									Globals.Log("Unknown control byte: " + BC.ToString());
									break;
							}
						} else {
							Globals.Log("Not authenticated, ignoring received byte: " + Rcv);
						}
					} catch(Exception ex) {
						Globals.Log("Error receiving data: " + ex.Message);
					}
				}
				Thread.Sleep(100);
			} while(true);
			Globals.Log("Closing receiver thread");
			Disconnect(); //avoid being connected with no DataReceiver
		}*/

		public static void SetMode(ScannerMode scannerMode) {
			lock(s) {
				bool ok;
				switch(scannerMode) {
					case ScannerMode.Manual:
						Globals.Log(LogType.Information, "Activating manual mode");
						ok = Send(ControlByte.SetModeManual);
						if(ok) Mode = ScannerMode.Manual;
						break;
					case ScannerMode.Inactive:
						Globals.Log(LogType.Information, "Setting scanner in inactive mode");
						ok = Send(ControlByte.SetModeInactive);
						if(ok) Mode = ScannerMode.Inactive;
						break;
					default:
						throw new NotImplementedException();
				}
				Globals.MainWindow.UpdateStatus();
			}
		}

		public static void SetManualPosHduty(UInt16 pos) {
			SetManualPosHccp(Servo.DutyToCcp(pos));
		}

		public static void SetManualPosHccp(UInt16 pos) {
			Send(ControlByte.ManualSetPosH); //Control code
			Send(pos.GetBytes()[1]); //MSByte
			Send(pos.GetBytes()[0]); //LSByte
		}

		public static void SetManualPosVduty(UInt16 pos) {
			SetManualPosVccp(Servo.DutyToCcp(pos));
		}

		public static void SetManualPosVccp(UInt16 pos) {
			Send(ControlByte.ManualSetPosV); //Control code
			Send(pos.GetBytes()[1]); //MSByte
			Send(pos.GetBytes()[0]); //LSByte
		}
	}
}
