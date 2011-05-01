using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DScannerPC {
	public static class UInt16Extensions {
		public static byte[] GetBytes(this UInt16 n) {
			byte[] bytes = new byte[2];
			bytes[1] = (byte)(n >> 8);
			bytes[0] = (byte)n;
			return bytes;
		}
	}

	public static class UInt32Extensions {
		public static byte[] GetBytes(this UInt32 n) {
			byte[] bytes = new byte[4];
			bytes[3] = (byte)(n >> 24);
			bytes[2] = (byte)(n >> 16);
			bytes[1] = (byte)(n >> 8);
			bytes[0] = (byte)n;
			return bytes;
		}
	}
}
