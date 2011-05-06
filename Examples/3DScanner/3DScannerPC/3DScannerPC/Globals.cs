using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using _3DScannerPC.Properties;

namespace _3DScannerPC {
	class Globals {
		public static FrmMdiParent MainWindow;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MainWindow = new FrmMdiParent();
			Application.Run(MainWindow);
		}

		public static void Log(string format, params object[] p) {
			Log(LogType.Normal, format, p);
		}

		public static void Log(LogType type, string format, params object[] p) {
			if(type == LogType.Debug && Settings.Default.PrintDebugLogs == false) return;

			string LogText = string.Format(format, p);
			if(LogText[0] != '[') LogText = string.Format("[{0:00}:{1:00}:{2:00}.{3:000}] {4}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond, LogText);
			Console.WriteLine(LogText);
			Color textColor;
			switch(type) {
				case LogType.Normal:
					textColor = Color.Black;
					break;
				case LogType.Error:
					textColor = Color.Red;
					break;
				case LogType.Information:
					textColor = Color.Blue;
					break;
				case LogType.Warning:
					textColor = Color.Orange;
					break;
				case LogType.Success:
					textColor = Color.Green;
					break;
				case LogType.Debug:
					textColor = Color.Gray;
					break;
				default:
					throw new NotImplementedException("Unknown log type: " + type.ToString());
			}
			MainWindow.frmLog.Log(textColor, LogText);
		}
	}
}
