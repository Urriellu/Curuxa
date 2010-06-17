using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PCBot_PCApp {
	/// <summary>
	/// Serial Port Status
	/// </summary>
	public enum Status {
		Disconnected,
		Connected
	}

	/// <summary>
	/// Bytes de control del puerto serie. Indican la operación a realizar a continuación
	/// </summary>
	public enum ControlByte {
		/// <summary>
		/// Ask for authentification ID
		/// </summary>
		AuthID = 1,

		/// <summary>
		/// Set the status of a light
		/// </summary>
		SetLight = 10,

		/// <summary>
		/// Get the status of a light
		/// </summary>
		StatusLight = 100,

		/// <summary>
		/// Gets the status of a bumper
		/// </summary>
		StatusBumpers = 102,
	}

	public enum ControlByteLight {
		FrontLeftOn = 50,
		FrontLeftOff = 51,
		FrontRightOn = 52,
		FrontRightOff = 53
	}

	public enum ControlByteBumper {
		FrontLeftPressed = 70,
		FrontLeftReleased = 71,
		FrontRightPressed = 72,
		FrontRightReleased = 73
	}

	class Dummy {
	}

	public static class Communication {
		static Dummy s = new Dummy();

		public static Status Status {
			get {
				return _Status;
			}
			private set {
				_Status = value;
				if(Global.MainWindow != null) Global.MainWindow.SetConnectionStatus(value);
			}
		}
		private static Status _Status = Status.Disconnected;

		static SerialPort SP;

		/// <summary>
		/// Thread to do Serial Port polling looking for new received data
		/// </summary>
		static Thread ThreadReceiver;

		/// <summary>
		/// Connect to the microcontroller
		/// </summary>
		public static void Connect() {
			Global.Log("Trying to connect");
			if(Communication.SP != null && Communication.SP.IsOpen) Communication.SP.Close();
			Communication.SP = new SerialPort(Settings.SpName, Settings.BaudRate, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
			try {
				Communication.SP.Open();
				Global.Log("Connected to " + Settings.SpName);
				ThreadReceiver = new Thread(Communication.DataReceiver);
				ThreadReceiver.Start();
				Check();
			} catch(Exception e) {
				Global.Log("Unable to connect: " + e.Message);
				Status = Status.Disconnected;
			}
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
			Status = Status.Disconnected;
			Global.Log("Disconnected");
		}

		//THIS ONE MUST NOT CONTAIN A LOCK
		public static void Send(byte B) {
			if(SP != null && SP.IsOpen) {
				try {
					SP.WriteByte(B);
					Global.Log("Byte sent: " + B.ToString());
					Thread.Sleep(10);
				} catch(Exception e) {
					Global.Log("Error while sending byte \"" + B.ToString() + "\": " + e.Message);
				}
			} else {
				Global.Log("Unable to send byte: " + B.ToString());
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
		
		public static void SetLight(ControlByteLight CBL) {
			lock(s) {
				Send(ControlByte.SetLight);
				Send((byte)CBL);
			}
		}

		/// <summary>
		/// Función ejecutada en un segundo hilo que hace polling al puerto serie y procesa los datos recibidos
		/// </summary>
		public static void DataReceiver() {
			Global.Log("Starting receiver thread");
			while(SP != null && SP.IsOpen && Global.MainWindow != null) {
				try {
					byte Rcv = (byte)SP.ReadByte();
					ControlByte BC = (ControlByte)Rcv;

					switch(BC) {
						case ControlByte.AuthID:
							Rcv = (byte)SP.ReadByte();
							if(Rcv == Settings.RobotID) {
								// auth success
								Status = Status.Connected;
							} else {
								Global.Log("Authentication failure");
								Disconnect();
							}
							break;
						case ControlByte.StatusBumpers:
							Global.Log("Received bumper status...");
							Rcv = (byte)SP.ReadByte();
							ControlByteBumper BumperStatus = ((ControlByteBumper)Enum.Parse(typeof(ControlByteBumper), Rcv.ToString()));
							Global.Log("..." + BumperStatus.ToString());
							if(Global.MainWindow != null) Global.MainWindow.SetBumperStatus(BumperStatus);
							break;
						default:
							Global.Log("Unknown control byte: " + BC.ToString());
							break;
					}
				} catch(Exception e) {
					Global.Log("Error receiving data: " + e.Message);
				}
			}
			Global.Log("Closing receiver thread");
			Disconnect(); //avoid being connected with no DataReceiver
		}
	}
}
