using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCBot_PCApp {
	public class Global {
		public static FrmMainWindow MainWindow;

		public static void Log(string p) {
			string LogText = p;
			if(p[0] != '[') LogText = string.Format("[{0:00}:{1:00}:{2:00}.{3:000}] {4}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond, p);
			Console.WriteLine(LogText);
			//if(MainWindow != null) MainWindow.TxtLog.AppendText(p);
		}
	}
}
