using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Net;

namespace CuruxaIDE {
	static class Globals {
		public static Project ActiveProject {
			get {
				return _ActiveProject;
			}
			set {
				_ActiveProject = value;
				if(MainWindow != null) MainWindow.UpdateActivePrj(value);
			}
		}
		private static Project _ActiveProject;

		public static SrcFile ActiveSrcFile;

		public static FrmMainWindow MainWindow;

		public static FrmDebugWindow DebugWindow;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			//if you want to generate a new Example, uncomment the following line
			//GenerateExample();

#if !DEBUG
			Application.SetUnhandledExceptionMode(System.Windows.Forms.UnhandledExceptionMode.CatchException);
			Application.ThreadException += delegate(object sender, System.Threading.ThreadExceptionEventArgs ar) {
				Crash(ar.Exception);
			};
			AppDomain.CurrentDomain.UnhandledException += delegate(object sender, UnhandledExceptionEventArgs ar) {
				Crash(ar.ExceptionObject);
			};
#endif
			try {
				Settings.Load();
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(true);
#if DEBUG
				Globals.DebugWindow = new FrmDebugWindow();
				Globals.DebugWindow.Show();
#endif
				Application.Run(MainWindow = new FrmMainWindow());
			} catch(TypeInitializationException e) {
				if(e.TargetSite.ReflectedType.FullName == "System.Windows.Forms.Application" && e.TargetSite.Name == "EnableVisualStyles") {
					Console.WriteLine("Windows Forms not supported!!!");
				} else throw e;
			}
#if !DEBUG
 catch(Exception e) {
				Crash(e);
			}
#endif
		}

		private static void GenerateExample() {
			Example NewExample = new Example();
			NewExample.Project.Name = "MBP18_test01";
			NewExample.Project.Description = "Example program for testing MBP18";
			NewExample.Project.Language = Language.C;
			NewExample.Project.MainBoard = MainBoard.MBP18;
			NewExample.Project.SrcFiles.Add(new SrcFile(NewExample.Project, NewExample.Project.Name + "." + NewExample.Project.Language.GetExtension()));
			NewExample.Save(NewExample.Project.Name + "." + Example.ExampleExtension);
		}

		private static void Crash(object Error) {
			new FrmCrash(Error).ShowDialog();
		}

		/// <summary>
		/// Put some text in the Curuxa IDE log
		/// </summary>
		public static void LogIDE(string Text) {
			Debug("[IDE] " + Text);
			if(MainWindow != null) MainWindow.LogIDE(Text, false);
		}

		/// <summary>
		/// Put some text in the build log
		/// </summary>
		public static void LogBuild(string Text) {
			if(MainWindow != null) MainWindow.LogBuild(Text);
		}

		/// <summary>
		/// Put some text in the programmer log
		/// </summary>
		public static void LogProgrammer(string Text) {
			if(MainWindow != null) MainWindow.LogProgrammer(Text);
		}

		public static void Debug(string Text) {
			Console.WriteLine(string.Format("[{0:00}:{1:00}:{2:00}.{3:000}] {4}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond, Text));
#if DEBUG
			if(Globals.DebugWindow != null) Globals.DebugWindow.LogDebug(Text);
#endif
		}

		public static void Debug(string Text, params object[] p) {
			Debug(string.Format(Text, p));
		}

		/// <summary>
		/// Sets up a new build log. Focus the log's tab and clears the previous logs
		/// </summary>
		public static void SetupNewBuildLog() {
			if(MainWindow != null) {
				MainWindow.TxtLogBuild.Clear();
				MainWindow.TabsMsg.SelectedTab = MainWindow.TabBuildLog;
			}
		}

		/// <summary>
		/// Sets up a new programmer log. Focus the log's tab and clears the previous logs
		/// </summary>
		public static void SetupNewProgrammerLog() {
			if(MainWindow != null) {
				MainWindow.TxtLogProgrammer.Clear();
				MainWindow.TabsMsg.SelectedTab = MainWindow.TabProgLog;
			}
		}

		public static Image LoadImage(string FileName) {
			string path = Settings.ImagesDir + "/" + FileName;
			if(File.Exists(path)) return Image.FromFile(path);
			else {
				LogIDE("Image not found: " + FileName);
				Bitmap blank = new Bitmap(1, 1);
				blank.SetPixel(0, 0, Color.White);
				return blank;
			}
		}
	}
}
