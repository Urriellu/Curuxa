using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuruxaIDE {
	/// <summary>
	/// List of available microcontroller programmers
	/// </summary>
	public enum Programmer {
		/// <summary>
		/// Microchip PICkit 2 programmer
		/// </summary>
		PICkit2
	}

	public static class ProgrammerExtensions {
		/// <summary>
		/// Gets the software application used for communicating with the given programmer
		/// </summary>
		public static ProgrammerApp GetProgrammerApp(this Programmer prog) {
			switch(prog) {
				case Programmer.PICkit2:
					return ProgrammerApp.pk2cmd;
				default:
					throw new NotImplementedException();
			}
		}
	}
}
