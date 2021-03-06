﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SWF = System.Windows.Forms;
using _3DScannerPC.Properties;

namespace _3DScannerPC {
	class DummyLocker {
	}

	public static class Scanner {
		static DateTime LastAuthentication = new DateTime(1900, 1, 1);
		static DummyLocker s = new DummyLocker();
		public static ScannerMode Mode = ScannerMode.Inactive;

		public static bool Authenticated {
			get {
				return _Authenticated;
			}
			private set {
				_Authenticated = value;
				Globals.MainWindow.UpdateStatus();
			}
		}
		public static bool _Authenticated;

		public static Status Status {
			get {
				return _Status;
			}
			private set {
				_Status = value;
				if(value == Status.Disconnected) Authenticated = false;
				Globals.MainWindow.UpdateStatus();
			}
		}
		private static Status _Status = Status.Disconnected;

		static SerialPort SP;

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

		static UInt16 ReadUInt16() {
			UInt16 receivedValue = (UInt16)((byte)SP.ReadByte() << 8);
			receivedValue += (byte)SP.ReadByte();
			Globals.Log(LogType.Debug, "Received UInt16: " + receivedValue);
			return receivedValue;
		}

		/// <summary>
		/// Method called when a new byte is received
		/// </summary>
		static void SP_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) {
			while(SP.IsOpen && SP.BytesToRead > 0) {
				byte Rcv = ReadByte();
				ControlByte BC = (ControlByte)Rcv;
				if(BC == ControlByte.AuthID) {
					Rcv = (byte)ReadByte();
					if(Rcv == Settings.Default.ScannerID) {
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

				if(Authenticated || !Settings.Default.RequireAuthentication) {
					switch(BC) {
						case ControlByte.AuthID:
							break;
						case ControlByte.Error:
							ControlByteError error = (ControlByteError)ReadByte();
							Globals.Log(LogType.Error, "Microcontroller error: " + error);
							break;
						case ControlByte.ManualTxValue:
							/*UInt16 receivedValue = (UInt16)((byte)ReadByte() << 8);
							receivedValue += (byte)ReadByte();*/
							UInt16 receivedValue = ReadUInt16();
							Globals.MainWindow.SetReceivedManualValue(receivedValue);
							Globals.Log(LogType.Debug, "Received manual value: " + receivedValue);
							break;
						case ControlByte.AutoTxValue:
							UInt16 CcpServoH = ReadUInt16();
							UInt16 CcpServoV = ReadUInt16();
							UInt16 adcValue = ReadUInt16();
							Globals.MainWindow.SetReceivedAutoValue(CcpServoH, CcpServoV, adcValue);
							Globals.Log(LogType.Debug, string.Format("Received automatic value: CcpH={0}, CcpV={1}, ADC={2}", CcpServoH, CcpServoV, adcValue));
							break;
						case ControlByte.EndModeAutoScan:
							Globals.MainWindow.frmNewAutoMsm.EndAutoScan();
							Globals.Log(LogType.Debug, "End of automatic scan");
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

		public static void Disconnect() {
			SetMode(ScannerMode.Inactive);
			if(SP != null) {
				SP.Close();
			}
			Authenticated = false;
			Status = Status.Disconnected;
			Mode = ScannerMode.Inactive;
			Globals.Log(LogType.Information, "Disconnected");
		}

		//THIS ONE MUST NOT CONTAIN A LOCK
		public static bool Send(byte B) {
			if(Settings.Default.RequireAuthentication && !Authenticated && B != (byte)ControlByte.AuthID) {
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
					case ScannerMode.Scan:
						Globals.Log(LogType.Information, string.Format("Starting new automatic scan: {0} points, {1}", Globals.MainWindow.frmNewAutoMsm.TotalPointsToReceive, Globals.MainWindow.frmNewAutoMsm.totalTime.NormalTime()));
						
						Send(ControlByte.SetModeScan); //control code, set mode scan

						Send(Globals.MainWindow.frmNewAutoMsm.MeasuresPerPoint);

						//send min CCP H
						Send(Globals.MainWindow.frmNewAutoMsm.MinCcpH.GetBytes()[1]); //MSByte
						Send(Globals.MainWindow.frmNewAutoMsm.MinCcpH.GetBytes()[0]); //LSByte

						//send max CCP H
						Send(Globals.MainWindow.frmNewAutoMsm.MaxCcpH.GetBytes()[1]); //MSByte
						Send(Globals.MainWindow.frmNewAutoMsm.MaxCcpH.GetBytes()[0]); //LSByte
						
						//send interval duty H
						// NOTE: this is interval for duty. On the microcontroller we have to multiply this by 2, to convert it to CCP interval
						Send(Globals.MainWindow.frmNewAutoMsm.DutyIntervalH);
						
						//send min CCP V
						Send(Globals.MainWindow.frmNewAutoMsm.MinCcpV.GetBytes()[1]); //MSByte
						Send(Globals.MainWindow.frmNewAutoMsm.MinCcpV.GetBytes()[0]); //LSByte

						//send max CCP V
						Send(Globals.MainWindow.frmNewAutoMsm.MaxCcpV.GetBytes()[1]); //MSByte
						Send(Globals.MainWindow.frmNewAutoMsm.MaxCcpV.GetBytes()[0]); //LSByte
						
						//send interval duty V
						// NOTE: this is interval for duty. On the microcontroller we have to multiply this by 2, to convert it to CCP interval
						Send(Globals.MainWindow.frmNewAutoMsm.DutyIntervalV);
						
						Mode = ScannerMode.Scan;
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
