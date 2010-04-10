using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace CuruxaIDE {
	/// <summary>
	/// Represents a PICkit2 programmer
	/// </summary>
	public class pk2cmd:ProgrammerApp {
		public pk2cmd()
			: base("pk2cmd", "pk2cmd") {

			SetupEnvironment();
		}

		private void SetupEnvironment() {
			if(Environment.OSVersion.Platform == PlatformID.Win32NT || Environment.OSVersion.Platform == PlatformID.Win32Windows) {
				//add pk2cmd-win to the PATH
				Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ";" + Settings.Pk2cmdWinDir, EnvironmentVariableTarget.Process);
				string s = Environment.GetEnvironmentVariable("PATH");
			}
		}


		public override int Write(Project prj) {
			ProcessStartInfo ProcInfo;
			Process proc;

			string HexFile = prj.Path + "/temp.hex"; //it has to be full path!!!

			if(!File.Exists(HexFile)) {
				Globals.LogIDE(i18n.str("NoHex"));
				Globals.LogProgrammer(i18n.str("NoHex"));
				return 1;
			}

			//pk2cmd -PPIC16Fxxx -M -F/home/my_user/my_program.hex
			string args = "-P" + prj.MainBoard.GetMCU() + " -M -F" + HexFile;

			try {
				if(!CheckMB(prj)) Globals.LogIDE(i18n.str("WrongMB", prj.MainBoard));

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

				return proc.ExitCode;
			} catch(System.ComponentModel.Win32Exception) {
				string msg = i18n.str("NoApp", RealName);
				Globals.LogIDE(msg);
				Globals.LogProgrammer(msg);
				return 1;
			}
		}

		void proc_ErrorDataReceived(object sender, DataReceivedEventArgs e) {
			if(string.IsNullOrEmpty(e.Data)) return;
			for(int i = 0; i <= e.Data.Length; i++) {
				if(i == e.Data.Length) return;
				if(e.Data[i] != ' ') break;
			}
			Globals.LogProgrammer("[" + RealName + " Error] " + e.Data);
		}

		void proc_OutputDataReceived(object sender, DataReceivedEventArgs e) {
			//remove empty messages
			if(string.IsNullOrEmpty(e.Data)) return;
			for(int i = 0; i <= e.Data.Length; i++) {
				if(i == e.Data.Length) return;
				if(e.Data[i] != ' ') break;
			}

			Globals.LogProgrammer("[" + RealName + "] " + e.Data);
		}

		public override int Run(Project prj) {
			ProcessStartInfo ProcInfo;
			Process proc;

			//pk2cmd -PPIC16Fxxx -Ax.x -T
			string args = "-P" + prj.MainBoard.GetMCU() + " -A" + prj.Voltage + " -T";

			try {
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

				return proc.ExitCode;
			} catch(System.ComponentModel.Win32Exception) {
				Globals.LogIDE(i18n.str("NoApp", RealName));
				return 1;
			}
		}

		public override int Stop(Project prj) {
			ProcessStartInfo ProcInfo;
			Process proc;

			//pk2cmd -PPIC16Fxxx -R
			string args = "-P" + prj.MainBoard.GetMCU() + " -R";

			try {
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

				return proc.ExitCode;
			} catch(System.ComponentModel.Win32Exception e) {
				Globals.LogIDE(i18n.str("NoApp", RealName));
				return 1;
			}
		}

		private Microcontroller? DetectedMCU;

		public override Microcontroller? Detect() {
			ProcessStartInfo ProcInfo;
			Process proc;
			DetectedMCU = null;

			//pk2cmd -P
			string args = "-P";

			try {
				ProcInfo = new ProcessStartInfo(Command, args);
				ProcInfo.CreateNoWindow = true;
				ProcInfo.ErrorDialog = false;
				ProcInfo.RedirectStandardError = true;
				ProcInfo.RedirectStandardOutput = true;
				ProcInfo.UseShellExecute = false;
				proc = new Process();
				proc.StartInfo = ProcInfo;
				proc.OutputDataReceived += new DataReceivedEventHandler(proc_DataReceivedCheckMCU);
				proc.ErrorDataReceived += new DataReceivedEventHandler(proc_ErrorDataReceived);
				Globals.Debug("Executing: {0} {1}", Command, args);
				proc.Start();
				Globals.Debug("Reading outputs");
				proc.BeginErrorReadLine();
				proc.BeginOutputReadLine();
				Globals.Debug("Waiting for exit...");
				proc.WaitForExit();
			} catch(System.ComponentModel.Win32Exception) {
				Globals.LogIDE(i18n.str("NoApp", RealName));
			}
			return DetectedMCU;
		}

		void proc_DataReceivedCheckMCU(object sender, DataReceivedEventArgs e) {
			string StrToDetect = "Auto-Detect: Found part ";
			if(e != null && e.Data != null && e.Data.Contains(StrToDetect)) {
				string MCU = e.Data.Remove(0, e.Data.IndexOf(StrToDetect) + StrToDetect.Length).TrimEnd(' ', '.');
				try {
					DetectedMCU = (Microcontroller)Enum.Parse(typeof(Microcontroller), MCU);
				} catch {
					DetectedMCU = null;
				}
			}
		}

		/// <summary>
		/// Check whether there is a Main Board plugged to the programmer and it's the correct one
		/// </summary>
		public bool CheckMB(Project prj) {
			Microcontroller? MCU = Detect();
			if(MCU.HasValue && prj.MainBoard.GetMCU() == MCU.Value) return true;
			else return false;
		}
	}
}
