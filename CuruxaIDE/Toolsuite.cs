using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuruxaIDE {
	/// <summary>
	/// Utility for compiling or assembling a program
	/// </summary>
	public abstract class Toolsuite:SoftApp {
		protected Toolsuite(string RealName, string Command)
			: base(RealName, Command) {
		}

		/// <summary>
		/// List of global include paths
		/// </summary>
		/// <remarks>
		/// The ones on top are always checked first
		/// </remarks>
		public Queue<string> IncludePaths = new Queue<string>();

		/// <summary>
		/// Builds (compile or assemble) a project
		/// </summary>
		/// <param name="prj">Project being built</param>
		public abstract int Build(Project prj);

		public static SDCC SDCC = new SDCC();

		public static gpasm GPASM = new gpasm();
	}
}
