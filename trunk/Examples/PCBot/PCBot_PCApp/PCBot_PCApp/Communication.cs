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
	}

	public enum ControlByteLight {
		FrontLeftOn = 50,
		FrontLeftOff = 51,
		FrontRightOn = 52,
		FrontRightOff = 53
	}

	public static class Communication {
		public static Status Status { get; private set; }
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
				Status = Status.Connected;
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
			Global.Log("Disconnected");
		}

		public static void Send(byte B) {
			if(SP != null && SP.IsOpen) {
				try {
					SP.WriteByte(B);
					Global.Log("Byte sent: " + B.ToString());
				} catch(Exception e) {
					Global.Log("Error while sending byte \"" + B.ToString() + "\": " + e.Message);
				}
			} else {
				Global.Log("Unable to send byte: " + B.ToString());
			}
		}

		public static void Send(ControlByte CB) {
			Send((byte)CB);
		}

		public static void SetLight(ControlByteLight CBL) {
			Send(ControlByte.SetLight);
			Send((byte)CBL);
		}

		/// <summary>
		/// Función ejecutada en un segundo hilo que hace polling al puerto serie y procesa los datos recibidos
		/// </summary>
		public static void DataReceiver() {
			Global.Log("Starting receiver thread");
			while(SP != null && Global.MainWindow != null) {
				byte Rcv = (byte)SP.ReadByte();
				Console.WriteLine(Rcv);
				ControlByte BC = (ControlByte)Rcv;

				switch(BC) {
					/*case ControlByte.IdActual:
						Log("Recibiendo ID del arrollamiento actual");
						MiFormulario.ArroActID((byte)Global.Puerto.ReadByte());
						break;
					case ControlByte.NoArrollando:
						Log("No se está arrollando ninguna bobina");
						MiFormulario.ArroActEstado(false);
						break;
					case ControlByte.VelocidadActual:
						Log("Recibiendo datos de la velocidad actual");
						MiFormulario.ArroActV(Puerto.ReadUInt16());
						break;
					case ControlByte.TempActual:
						Log("Recibiendo datos de la temperatura actual");
						sbyte Temp = (sbyte)Global.Puerto.ReadByte();
						MiFormulario.TempAct(Temp);
						break;
					case ControlByte.Duracion:
						Log("Recibiendo la duración del arrollamiento actual");
						MiFormulario.ArroActDuracion(new TimeSpan(0, 0, (int)Puerto.ReadUInt32()));
						break;
					case ControlByte.VelMedia:
						Log("Recibiendo datos de la velocidad media");
						MiFormulario.ArroActVmedia(Puerto.ReadUInt16());
						break;
					case ControlByte.VelMax:
						Log("Recibiendo datos de la velocidad máxima");
						MiFormulario.ArroActVmax(Puerto.ReadUInt16());
						break;
					case ControlByte.NumArros:
						Log("Recibiendo el número de arrollamientos almacenados");
						MiFormulario.SetNumArros(Puerto.ReadByte());
						break;
					case ControlByte.InfoArro:
						Log("Recibiendo toda la información sobre cierto arrollamiento");
						byte ArroID = Puerto.ReadByte();
						UInt16 Vmax = Puerto.ReadUInt16();
						UInt16 Vmedia = Puerto.ReadUInt16();
						UInt32 Duracion = Puerto.ReadUInt32();
						if(VentanasArros.ContainsKey(ArroID)) {
							Log("ID={0}, Vmax={1}, Vmedia={2}, Duracion={3}seg", ArroID, Vmax, Vmedia, Duracion);
							VentanasArros[ArroID].NuevaVmax(Vmax);
							VentanasArros[ArroID].NuevaVmedia(Vmedia);
							VentanasArros[ArroID].NuevaDuracion(new TimeSpan(0, 0, (int)Duracion));
							VentanasArros[ArroID].BorrarVsInst();
						}
						UInt16 Vinst = 0;
						do {
							Vinst = Puerto.ReadUInt16();
							Log(Vinst.ToString());
							if(Vinst != 0xFFFF && VentanasArros.ContainsKey(ArroID)) {
								VentanasArros[ArroID].NuevaVinst(Vinst);
							}
						} while(Vinst != 0xFFFF);
						break;*/
					default:
						Global.Log("Unknown control byte: " + BC.ToString());
						break;
				}
			}
			Global.Log("Closing receiver thread");
		}
	}
}
