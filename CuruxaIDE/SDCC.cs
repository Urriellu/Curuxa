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

		string LogBuild;

		public override int Build(Project prj) {
			ProcessStartInfo ProcInfo;
			Process proc;

			if(prj.MainFile == null) {
				Globals.LogIDE(i18n.str("NoMainSrc"));
				return 1;
			}

			string OldDir = Environment.CurrentDirectory;
			Environment.CurrentDirectory = prj.Path;

			string args = "-I " + Settings.IncludesDir;
			string SdccInstallPath = Environment.GetEnvironmentVariable("ProgramFiles") + @"\SDCC";
			string GputilsInstallPath = Environment.GetEnvironmentVariable("ProgramFiles") + @"\gputils";

			//on Windows, SDCCand GPUTILS binary directories are only set in the $PATH of the user who installed them. We try to fix it
			if(Environment.OSVersion.Platform != PlatformID.Unix) {
				//add "%ProgramFiles%\SDCC\bin" to the PATH
				Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ";" + Environment.GetEnvironmentVariable("ProgramFiles") + @"\SDCC\bin", EnvironmentVariableTarget.Process);

				//add "%ProgramFiles%\gputils\bin" to the PATH
				Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ";" + Environment.GetEnvironmentVariable("ProgramFiles") + @"\gputils\bin", EnvironmentVariableTarget.Process);

				//SDCC can't find its own libraries by itself on Windows!! :-(
				//args += " -I \"" + Environment.GetEnvironmentVariable("ProgramFiles") + "\\SDCC\\include\"";

				//gpasm can't find its own header files
				//args += " -Wa_I\"" + Environment.GetEnvironmentVariable("ProgramFiles") + "\\gputils\\header\"";

				Environment.SetEnvironmentVariable("SDCC_HOME", SdccInstallPath);
				//Environment.SetEnvironmentVariable("SDCC_INCLUDE", SdccInstallPath+@"\include");
				//Environment.SetEnvironmentVariable("SDCC_LIB", ????);
				Environment.SetEnvironmentVariable("GPUTILS_HEADER_PATH", GputilsInstallPath + @"\header");
				Environment.SetEnvironmentVariable("GPUTILS_LKR_PATH", GputilsInstallPath + @"\lkr");
				//Environment.SetEnvironmentVariable("GPUTILS_LIB_PATH", SdccInstallPath);
			}

			args += " -mpic14 -" + prj.MainBoard.GetMCU().ToString().ToLowerInvariant().Replace("pic", "p") + " \"" + prj.MainFile.FullPath + "\" -o temp";
			//SDCC segmentation fault when output file contains spaces

			try {
				LogBuild = "";
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

				Globals.LogBuild(LogBuild);

				Environment.CurrentDirectory = OldDir;
				return proc.ExitCode;
			} catch(System.ComponentModel.Win32Exception) {
				string msg = i18n.str("NoApp", RealName);
				Globals.LogIDE(msg);
				Globals.LogBuild(msg);
				Environment.CurrentDirectory = OldDir;
				return 1;
			}
		}

		void proc_ErrorDataReceived(object sender, DataReceivedEventArgs e) {
			lock(LogBuild) {
				if(string.IsNullOrEmpty(e.Data)) return;
				for(int i = 0; i <= e.Data.Length; i++) {
					if(i == e.Data.Length) return;
					if(e.Data[i] != ' ') break;
				}
				//Globals.LogBuild("[" + RealName + " Error] " + e.Data);
				LogBuild += "[" + RealName + " Error] " + e.Data + Environment.NewLine;
			}
		}

		void proc_OutputDataReceived(object sender, DataReceivedEventArgs e) {
			lock(LogBuild) {
				//remove empty messages
				if(string.IsNullOrEmpty(e.Data)) return;
				for(int i = 0; i <= e.Data.Length; i++) {
					if(i == e.Data.Length) return;
					if(e.Data[i] != ' ') break;
				}

				//hide unwanted messages
				if(e.Data.Contains("message: using default linker script")) return;

				//Globals.LogBuild("[" + RealName + "] " + e.Data);
				LogBuild += "[" + RealName + "] " + e.Data + Environment.NewLine;
			}
		}
	}
}
