using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DScannerPC {
	/// <summary>
	/// Mode in which the scanner is currently working
	/// </summary>
	public enum ScannerMode {
		/// <summary>
		/// The scanner is inactive
		/// </summary>
		Inactive = 0,

		/// <summary>
		/// Manual Mode
		/// </summary>
		Manual = 1,

		/// <summary>
		/// Automatic scan mode
		/// </summary>
		Scan = 2
	}
}
