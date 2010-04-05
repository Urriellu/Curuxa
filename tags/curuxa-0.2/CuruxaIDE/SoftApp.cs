using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuruxaIDE {
	/// <summary>
	/// Software application
	/// </summary>
	public abstract class SoftApp {
		public readonly string RealName;
		public readonly string Command;

		protected SoftApp(string RealName, string Command) {
			this.RealName=RealName;
			this.Command=Command;
		}
	}
}
