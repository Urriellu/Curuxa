using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace CuruxaIDE {
	/// <summary>
	/// GNU PIC Assembler
	/// </summary>
	public sealed class gpasm:Toolsuite {
		public gpasm()
			: base("GPASM", "gpasm") {
			GetIncludePaths();

			SetupEnvironment();
		}

		private void SetupEnvironment() {
			string GputilsInstallPath = Environment.GetEnvironmentVariable("ProgramFiles") + @"\gputils";

			//on Windows, SDCCand GPUTILS binary directories are only set in the $PATH of the user who installed them. We try to fix it
			if(Environment.OSVersion.Platform != PlatformID.Unix) {
				//add "%ProgramFiles%\gputils\bin" to the PATH
				Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ";" + GputilsInstallPath + @"\bin", EnvironmentVariableTarget.Process);

				Environment.SetEnvironmentVariable("GPUTILS_HEADER_PATH", GputilsInstallPath + @"\header");
				Environment.SetEnvironmentVariable("GPUTILS_LKR_PATH", GputilsInstallPath + @"\lkr");
				//Environment.SetEnvironmentVariable("GPUTILS_LIB_PATH", SdccInstallPath);
			}
		}

		/// <summary>
		/// Gets the list of global include paths
		/// </summary>
		/// <remarks>
		/// This list is retrieved executing the command: "sdcc --print-search-dirs" 
		/// </remarks>
		private void GetIncludePaths() {
			IncludePaths.Clear();
			ProcessStartInfo ProcInfo;
			Process proc;
			try {
				string args = "";
				ProcInfo = new ProcessStartInfo(Command, args);
				ProcInfo.CreateNoWindow = true;
				ProcInfo.ErrorDialog = false;
				ProcInfo.RedirectStandardOutput = true;
				ProcInfo.UseShellExecute = false;
				proc = new Process();
				proc.StartInfo = ProcInfo;
				Globals.Debug("Executing: {0} {1}", Command, args);
				proc.Start();
				proc.WaitForExit(8000); //wait 8 seconds
				Globals.Debug("Reading outputs");

				foreach(string OutLine in proc.StandardOutput.ReadToEnd().Split('\n', '\r')) {
					if(OutLine.Contains("Default header file path")) {
						string HeaderPath = OutLine.Replace("Default header file path", "").Trim();
						Globals.Debug("New GPASM header path: " + HeaderPath);
						IncludePaths.Enqueue(HeaderPath);
					}
				}

				Globals.LogBuild(LogBuild);
			} catch(System.ComponentModel.Win32Exception) {
				string msg = i18n.str("NoApp", RealName);
				Globals.LogIDE(msg);
				Globals.LogBuild(msg);
			}
		}

		private string LogBuild;

		public override int Build(Project prj) {
			ProcessStartInfo ProcInfo;
			Process proc;

			if(prj.MainFile == null) {
				Globals.LogIDE(i18n.str("NoMainSrc"));
				return 1;
			}

			string OldDir = Environment.CurrentDirectory;
			Environment.CurrentDirectory = prj.Path;

			string args = "";

			args += "-o temp.hex \"" + prj.MainFile.FullPath + "\"";

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

				LogBuild += "[" + RealName + "] " + e.Data + Environment.NewLine;
			}
		}
	}
}
