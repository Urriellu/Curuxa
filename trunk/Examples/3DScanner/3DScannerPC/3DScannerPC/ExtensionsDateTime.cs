using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DScannerPC {
	public static class ExtensionsDateTime {
		public static string NormalDate(this DateTime d) {
			return d.Day + "/" + d.Month + "/" + d.Year;
		}

		public static string NormalTime(this DateTime d) {
			return string.Format("{0}h, {1}m, {2}s", d.Hour, d.Minute, d.Second);
		}

		public static string NormalDateTime(this DateTime d) {
			return d.NormalDate() + ". " + d.NormalTime();
		}

		public static string ShortDate(this DateTime d) {
			return string.Format("{0:0000}{1:00}{2:00}", d.Year, d.Month, d.Day);
		}

		public static string ShortTime(this DateTime d) {
			return string.Format("{0:00}{1:00}{2:00}", d.Hour, d.Minute, d.Second);
		}

		public static string ShortDateTime(this DateTime d) {
			return d.ShortDate() + "_" + d.ShortTime();
		}
	}
}
