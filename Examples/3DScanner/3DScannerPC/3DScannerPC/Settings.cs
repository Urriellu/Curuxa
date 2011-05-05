using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DScannerPC {
	public static class Settings {
		public static byte ScannerID = 97;

		public static int AdcMax = 1024;

		/// <summary>
		/// Minimum amount of milliseconds between data sent
		/// </summary>
		public static int SendDelayThreshold = 10;

		public static bool RequireAuthentication = false;

		public static UInt16 T1preload = 0xA23F;
	}
}
