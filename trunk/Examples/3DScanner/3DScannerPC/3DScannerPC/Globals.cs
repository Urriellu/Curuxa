using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
			string LogText = string.Format(format, p);
			if(LogText[0] != '[') LogText = string.Format("[{0:00}:{1:00}:{2:00}.{3:000}] {4}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond, LogText);
			Console.WriteLine(LogText);
			MainWindow.frmLog.Log(LogText);
		}
	}
}
