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

		public bool IsNotInstalled { get; protected set; }

		protected SoftApp(string RealName, string Command) {
			this.RealName=RealName;
			this.Command=Command;
		}

		/// <summary>
		/// Add the full path of a directory to the $PATH / %PATH% environment variable
		/// </summary>
		/// <param name="path"></param>
		protected void AddToPath(string path) {
			Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ";" + path);
		}
	}
}
