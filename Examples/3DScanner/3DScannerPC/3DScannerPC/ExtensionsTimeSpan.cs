using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DScannerPC {
	static class ExtensionsTimeSpan {
		public static string NormalTime(this TimeSpan d) {
			return string.Format("{0}d, {1}h, {2}m, {3}s", d.Days, d.Hours, d.Minutes, d.Seconds);
		}

		public static string ShortTime(this TimeSpan d) {
			return string.Format("{0:00}{1:00}{2:00}{3:00}", d.Days, d.Hours, d.Minutes, d.Seconds);
		}
	}
}
