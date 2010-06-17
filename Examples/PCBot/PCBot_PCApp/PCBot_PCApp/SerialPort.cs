using System;
using System.IO.Ports;
using BclSP = System.IO.Ports.SerialPort;

namespace PCBot_PCApp {
	/// <summary>
	/// Represents a Serial Port
	/// </summary>
	public class SerialPort:BclSP {
		public SerialPort(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
			: base(portName, baudRate, parity, dataBits, stopBits) {
		}

		public new byte ReadByte() {
			return (byte)base.ReadByte();
		}

		public UInt16 ReadUInt16() {
			byte Byte1, Byte0;
			Byte1 = (byte)ReadByte();
			Byte0 = (byte)ReadByte();
			return (UInt16)((Byte1 << 8) + Byte0);
		}

		public UInt32 ReadUInt32() {
			byte Byte3, Byte2, Byte1, Byte0;
			Byte3 = (byte)ReadByte();
			Byte2 = (byte)ReadByte();
			Byte1 = (byte)ReadByte();
			Byte0 = (byte)ReadByte();
			return (UInt32)(((UInt32)Byte3 << 24) + ((UInt32)Byte2 << 16) + ((UInt32)Byte1 << 8) + (UInt32)Byte0);
		}

		public void WriteByte(byte Byte) {
			Write(new byte[] { Byte }, 0, 1);
		}

		public void WriteUInt16(UInt16 Value) {
			Write(Value.GetBytes(), 0, 2);
		}

		public void WriteUInt32(UInt32 Value) {
			Write(Value.GetBytes(), 0, 4);
		}
	}
}
