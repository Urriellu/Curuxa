using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuruxaIDE {
	/// <summary>
	/// Microcontroller programmer
	/// </summary>
	public abstract class ProgrammerApp:SoftApp {
		protected ProgrammerApp(string RealName, string Command)
			: base(RealName, Command) {
		}

		/// <summary>
		/// Write the given program to the microcontroller
		/// </summary>
		public abstract int Write(Project prj);

		/// <summary>
		/// Power the circuit at the given voltage so the program in the microcontroller starts running
		/// </summary>
		public abstract int Run(Project prj);

		/// <summary>
		/// Power-down the circuit
		/// </summary>
		public abstract int Stop(Project prj);

		/// <summary>
		/// Detects the Microcontroller plugged to the programmer
		/// </summary>
		public abstract Microcontroller? Detect();

		public static pk2cmd pk2cmd = new pk2cmd();
	}
}
