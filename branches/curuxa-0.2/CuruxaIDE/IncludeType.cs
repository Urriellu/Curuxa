using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuruxaIDE {
	/// <summary>
	/// Type of #include
	/// </summary>
	public enum IncludeType {
		/// <summary>
		/// Quoted form: #include "SomeLibrary.h"
		/// </summary>
		Local,

		/// <summary>
		/// Angle-bracket form: #include <SomeLibrary.h>
		/// </summary>
		Global
	}
}
