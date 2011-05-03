using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SWF = System.Windows.Forms;

namespace _3DScannerPC {
	class Dummy {
	}

	public static class Communication {
		static SWF.Timer AuthTimer;
		static DateTime LastAuthentication = new DateTime(1900, 1, 1);
		static Dummy s = new Dummy();
		public static bool Authenticated { get; private set; }
		public static ScannerMode ScannerMode = ScannerMode.Inactive;

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

		static Communication() {
			AuthTimer = new SWF.Timer();
			AuthTimer.Tick += new EventHandler(AuthTimer_Tick);
			AuthTimer.Interval = 1000;
			AuthTimer.Start();
		}

		/// <summary>
		/// Connect to the microcontroller
		/// </summary>
		public static void Connect(string portName, int baudRate) {
			Globals.Log("Trying to connect");
			if(Communication.SP != null && Communication.SP.IsOpen) Communication.SP.Close();
			SP = new SerialPort(portName, baudRate, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
			try {
				//SP.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SP_DataReceived);
				SP.Open();
				Globals.Log("Connected to " + portName);
				if(ThreadReceiver == null) {
					ThreadReceiver = new Thread(Communication.DataReceiver);
					ThreadReceiver.Start();
				}
				//Check();
				Status = Status.Connected;
			} catch(Exception e) {
				Globals.Log("Unable to connect: " + e.Message);
				Status = Status.Disconnected;
			}
			Globals.MainWindow.UpdateStatus();
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
			if(ThreadReceiver != null) {
				ThreadReceiver.Abort();
				ThreadReceiver = null;
			}
			if(SP != null) {
				SP.Close();
				SP.Dispose();
				SP = null;
			}
			Authenticated = false;
			Status = Status.Disconnected;
			ScannerMode = ScannerMode.Inactive;
			Globals.Log("Disconnected");
			Globals.MainWindow.UpdateStatus();
		}

		//THIS ONE MUST NOT CONTAIN A LOCK
		public static bool Send(byte B) {
			if(SP != null && SP.IsOpen) {
				try {
					SP.WriteByte(B);
					Globals.Log("Byte sent: " + B.ToString());
					Thread.Sleep(10);
					return true;
				} catch(Exception e) {
					Globals.Log("Error while sending byte \"" + B.ToString() + "\": " + e.Message);
					return false;
				}
			} else {
				Globals.Log("Unable to send byte: " + B.ToString());
				return false;
			}
		}

		public static void Check() {
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
		public static void DataReceiver() {
		//public static void SP_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) {
			Globals.Log("Starting receiver thread");
			do {
				while(SP != null && SP.IsOpen && Globals.MainWindow != null) {
					try {
						byte Rcv = (byte)SP.ReadByte();
						ControlByte BC = (ControlByte)Rcv;
						if(BC == ControlByte.AuthID) {
							Rcv = (byte)SP.ReadByte();
							if(Rcv == Settings.ScannerID) {
								// auth success
								Status = Status.Connected;
								Authenticated = true;
								LastAuthentication = DateTime.Now;
							} else {
								Globals.Log("Authentication failure (received ID: " + Rcv + "), disconnecting...");
								Disconnect();
							}
						}

						//if(Authenticated) {
						switch(BC) {
							case ControlByte.AuthID:
								break;
							/*case ControlByte.StatusBumpers:
								Globals.Log("Received bumper status...");
								Rcv = (byte)SP.ReadByte();
								ControlByteBumper BumperStatus = ((ControlByteBumper)Enum.Parse(typeof(ControlByteBumper), Rcv.ToString()));
								Globals.Log("..." + BumperStatus.ToString());
								if(Globals.MainWindow != null) Globals.MainWindow.SetBumperStatus(BumperStatus);
								break;
							case ControlByte.StatusBaseMovement:
								Globals.Log("Received base movement status...");
								Rcv = (byte)SP.ReadByte();
								ControlByteBaseMv BaseMvStatus = ((ControlByteBaseMv)Enum.Parse(typeof(ControlByteBaseMv), Rcv.ToString()));
								Globals.Log("..." + BaseMvStatus.ToString());
								if(Globals.MainWindow != null) Globals.MainWindow.SetBaseMvStatus(BaseMvStatus);
								break;*/
							case ControlByte.ManualTxValue:
								UInt16 receivedValue = (UInt16)((byte)SP.ReadByte() << 8);
								receivedValue += (byte)SP.ReadByte();
								Globals.MainWindow.SetReceivedManualValue(receivedValue);
								Globals.Log("Received manual value: " + receivedValue);
								break;
							default:
								Globals.Log("Unknown control byte: " + BC.ToString());
								break;
						}
						/*} else {
							Globals.Log("Not authenticated, ignoring received byte: " + Rcv);
						}*/
					} catch(Exception ex) {
						Globals.Log("Error receiving data: " + ex.Message);
					}
				}
				Thread.Sleep(100);
			} while(true);
			Globals.Log("Closing receiver thread");
			Disconnect(); //avoid being connected with no DataReceiver
		}

		public static void SetMode(ScannerMode scannerMode) {
			lock(s) {
				Globals.Log("Activating manual mode");
				if(Send(ControlByte.ActivateManualMode)) ScannerMode = ScannerMode.Manual;
				Globals.MainWindow.UpdateStatus();
			}
		}
	}
}
