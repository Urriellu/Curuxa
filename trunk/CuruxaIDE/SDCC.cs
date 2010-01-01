using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace CuruxaIDE {
	/// <summary>
	/// Small Device C Compiler
	/// </summary>
	public sealed class SDCC:Toolsuite {
		public SDCC()
			: base("SDCC", "sdcc") {
		}

		public override int Build(Project prj) {
			ProcessStartInfo ProcInfo;
			Process proc;

			if(prj.MainFile == null) {
				Globals.LogIDE(i18n.str("NoMainSrc"));
				return 1;
			}

			string OldDir = Environment.CurrentDirectory;
			Environment.CurrentDirectory = prj.Path;

			string args = "-I " + Settings.IncludesDir + " -mpic14 -" + prj.MainBoard.GetMCU().ToString().ToLowerInvariant().Replace("pic", "p") + " \"" + prj.MainFile.FullPath + "\" -o temp";
			//SDCC segmentation fault when output file contains spaces

			try {
				Globals.SetupNewBuildLog();

				ProcInfo = new ProcessStartInfo(Command, args);
				ProcInfo.CreateNoWindow = true;
				ProcInfo.ErrorDialog = false;
				ProcInfo.RedirectStandardError = true;
				ProcInfo.RedirectStandardOutput = true;
				ProcInfo.UseShellExecute = false;
				proc = new Process();
				proc.StartInfo = ProcInfo;
				proc.OutputDataReceived += new DataReceivedEventHandler(proc_OutputDataReceived);
				proc.ErrorDataReceived += new DataReceivedEventHandler(proc_ErrorDataReceived);
				Globals.Debug("Executing: {0} {1}", Command, args);
				proc.Start();
				Globals.Debug("Reading outputs");
				proc.BeginErrorReadLine();
				proc.BeginOutputReadLine();
				Globals.Debug("Waiting for exit...");
				proc.WaitForExit();

				Environment.CurrentDirectory = OldDir;
				return proc.ExitCode;
			} catch(System.ComponentModel.Win32Exception) {
				Globals.LogIDE(i18n.str("NoApp", RealName));
				Environment.CurrentDirectory = OldDir;
				return 1;
			}
		}

		void proc_ErrorDataReceived(object sender, DataReceivedEventArgs e) {
			if(string.IsNullOrEmpty(e.Data)) return;
			for(int i = 0; i <= e.Data.Length; i++) {
				if(i == e.Data.Length) return;
				if(e.Data[i] != ' ') break;
			}
			Globals.LogBuild("[" + RealName + " Error] " + e.Data);
		}

		void proc_OutputDataReceived(object sender, DataReceivedEventArgs e) {
			//remove empty messages
			if(string.IsNullOrEmpty(e.Data)) return;
			for(int i = 0; i <= e.Data.Length; i++) {
				if(i == e.Data.Length) return;
				if(e.Data[i] != ' ') break;
			}

			//hide unwanted messages
			if(e.Data.Contains("message: using default linker script")) return;

			Globals.LogBuild("[" + RealName + "] " + e.Data);
		}
	}
}
