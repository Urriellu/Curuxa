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

		public static Status Status {
			get {
				return _Status;
			}
			private set {
				_Status = value;
				if(Globals.MainWindow != null) Globals.MainWindow.SetConnectionStatus(value);
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
		public static void Connect() {
			Globals.Log("Trying to connect");
			if(Communication.SP != null && Communication.SP.IsOpen) Communication.SP.Close();
			Communication.SP = new SerialPort(Settings.SpName, Settings.BaudRate, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
			try {
				Communication.SP.Open();
				Globals.Log("Connected to " + Settings.SpName);
				if(ThreadReceiver == null) {
					ThreadReceiver = new Thread(Communication.DataReceiver);
					ThreadReceiver.Start();
				}
				//Check();
			} catch(Exception e) {
				Globals.Log("Unable to connect: " + e.Message);
				Status = Status.Disconnected;
			}
		}

		static void AuthTimer_Tick(object sender, EventArgs e) {
			// ask for authentification
			Check();

			if((DateTime.Now - LastAuthentication).TotalSeconds > 2.5) {
				Globals.Log("Not authenticated for too long...");
				//Disconnect();
				Authenticated = false;
			}

			if(Status == Status.Disconnected) Connect();
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
			Globals.Log("Disconnected");
		}

		//THIS ONE MUST NOT CONTAIN A LOCK
		public static void Send(byte B) {
			if(SP != null && SP.IsOpen) {
				try {
					SP.WriteByte(B);
					Globals.Log("Byte sent: " + B.ToString());
					Thread.Sleep(10);
				} catch(Exception e) {
					Globals.Log("Error while sending byte \"" + B.ToString() + "\": " + e.Message);
				}
			} else {
				Globals.Log("Unable to send byte: " + B.ToString());
			}
		}

		public static void Check() {
			lock(s) {
				Send(ControlByte.AuthID);
			}
		}

		public static void Send(ControlByte CB) {
			lock(s) {
				Send((byte)CB);
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
			Globals.Log("Starting receiver thread");
			do {
				while(SP != null && SP.IsOpen && Globals.MainWindow != null) {
					try {
						byte Rcv = (byte)SP.ReadByte();
						ControlByte BC = (ControlByte)Rcv;
						if(BC == ControlByte.AuthID) {
							Rcv = (byte)SP.ReadByte();
							if(Rcv == Settings.RobotID) {
								// auth success
								Status = Status.Connected;
								Authenticated = true;
								LastAuthentication = DateTime.Now;
							} else {
								Globals.Log("Authentication failure, disconnecting...");
								Disconnect();
							}
						}

						if(Authenticated) {
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
								default:
									Globals.Log("Unknown control byte: " + BC.ToString());
									break;
							}
						} else {
							Globals.Log("Not authenticated, ignoring received byte: " + Rcv);
						}
					} catch(Exception e) {
						Globals.Log("Error receiving data: " + e.Message);
					}
				}
				Thread.Sleep(100);
			} while(true);
			Globals.Log("Closing receiver thread");
			Disconnect(); //avoid being connected with no DataReceiver
		}
	}
}
