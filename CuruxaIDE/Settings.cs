using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;

namespace CuruxaIDE {
	/// <summary>
	/// Application settings
	/// </summary>
	public class Settings {
		//instance members are the ones saved to the config file, with their default values
		#region instance members
		public List<string> _OpenProjects = new List<string>();
		public System.Windows.Forms.FormWindowState _MainWinState = System.Windows.Forms.FormWindowState.Normal;
		public bool _EnableSyntaxHighlight = (Environment.OSVersion.Platform == PlatformID.Unix) ? false : true;
		#endregion

		#region static members
		static Settings s = new Settings();

		/// <summary>
		/// Charset used by Curuxa IDE
		/// </summary>
		public static readonly Encoding Charset = Encoding.UTF8;

		public const string Version = "0.2-svn";

		public static Color PrjListBackColor = Color.White;
		public static Color PrjListSettingsColor = Color.Blue;
		public static Color PrjListSrcColor = Color.Black;
		public static Color PrjListLibsColor = Color.Gray;

		/// <summary>
		/// Add the path of a project to the list of opened projects
		/// </summary>
		/// <param name="path"></param>
		public static void AddOpenProject(string path) {
			if(!s._OpenProjects.Contains(path)) {
				Globals.Debug("Adding to the list of open projects: " + path);
				s._OpenProjects.Add(path);
			}
		}

		/// <summary>
		/// Remove the path of a project from the list of opened projects
		/// </summary>
		/// <param name="path"></param>
		public static void RemoveOpenProject(string path) {
			Globals.Debug("Removing path from the list of opened projects (at the settings file): " + path);
			s._OpenProjects.Remove(path);
		}

		/// <summary>
		/// Full path to the running executable file
		/// </summary>
		public static string ExePath {
			get {
				if(_ExePath == null) _ExePath = System.Reflection.Assembly.GetEntryAssembly().Location;
				return _ExePath;
			}
		}
		private static string _ExePath;

		/// <summary>
		/// Full path to the directory that contains the running executable file. The last character is NOT a slash ('/')
		/// </summary>
		public static string ExeLocation {
			get {
				if(_ExeLocation == null) _ExeLocation = System.IO.Path.GetDirectoryName(ExePath);
				return _ExeLocation;
			}
		}
		private static string _ExeLocation;

		/// <summary>
		/// Full path to the directory containing third party libraries and apps shipped along Curuxa IDE
		/// </summary>
		public static string ThirdPartyDir {
			get {
				return ExeLocation + "/ThirdParty";
			}
		}

		/// <summary>
		/// Path to pk2cmd-windows binaries
		/// </summary>
		public static string Pk2cmdWinDir {
			get {
				return ThirdPartyDir + "/pk2cmd-win";
			}
		}

		/// <summary>
		/// Full path to the directory containing the language files. Last character is NOT a slash ('/')
		/// </summary>
		public static string LanguageFilesDir {
			get {
				return ExeLocation + "/i18n";
			}
		}

		/// <summary>
		/// Full path to the directory containing the source code templates. Last character is NOT a slash ('/')
		/// </summary>
		public static string TemplatesDir {
			get {
				return ExeLocation + "/Templates";
			}
		}

		/// <summary>
		/// Full path to the directory containing the examples. Last character is NOT a slash ('/')
		/// </summary>
		public static string ExamplesDir {
			get {
				return ExeLocation + "/Examples";
			}
		}

		/// <summary>
		/// Full path to the directory containing the images. Last character is NOT a slash ('/')
		/// </summary>
		public static string ImagesDir {
			get {
				return ExeLocation + "/Images";
			}
		}

		public static System.Windows.Forms.FormWindowState MainWindowState {
			get {
				return s._MainWinState;
			}
			set {
				s._MainWinState = value;
			}
		}

		public static bool EnableSyntaxHighlight {
			get {
				return s._EnableSyntaxHighlight;
			}
			set {
				s._EnableSyntaxHighlight = value;
			}
		}

		/// <summary>
		/// Full path to the directory containing libraries used by final users. Last character is NOT a slash ('/')
		/// </summary>
		public static string IncludesDir {
			get {
				if(string.IsNullOrEmpty(_IncludesDir)) {
					string[] PossibleLocations = {
						"/usr/share/curuxa/lib", //default install path
						ExeLocation + "/../../../lib", //relative path when debugging (running Curuxa IDE without installation)
						ExeLocation + "/../lib", //non-standard install path
						ExeLocation + "/lib", //non-standard install path
						ExeLocation //aaaarrrrrgggggg!!!!!
					};
					foreach(string L in PossibleLocations) {
						Globals.Debug("Looking for libraries in " + L);
						if(File.Exists(L + "/MBP.h")) {
							_IncludesDir = L;
						}
					}
				}
				if(string.IsNullOrEmpty(_IncludesDir)) Globals.LogIDE(i18n.str("LibsNotFound"));
				return _IncludesDir;
			}
		}
		protected static string _IncludesDir;

		/// <summary>
		/// Path to the directory where all user-related settings and temp files are stored. Last character is NOT a slash ('/')
		/// </summary>
		public static string AppDataPath {
			get {
				//choose the config path
				if(_AppDataPath == null) {
					Globals.Debug("Looking for the user settings folder");
					if(Environment.OSVersion.Platform == PlatformID.Unix) {
						_AppDataPath = Environment.GetEnvironmentVariable("HOME") + "/.curuxa";
					} else {
						_AppDataPath = "C:" + Environment.GetEnvironmentVariable("HOMEPATH") + "\\curuxa";
					}
					Globals.Debug("User settings folder: {0}", _AppDataPath);
				}
				return _AppDataPath;
			}
		}
		private static string _AppDataPath;

		public static string SettingsFile {
			get {
				if(_SettingsFile == null) {
					_SettingsFile = AppDataPath + "/CuruxaIDE.conf";
				}
				return _SettingsFile;
			}
		}
		private static string _SettingsFile;

		public static void Save() {
			if(Globals.MainWindow != null) s._MainWinState = Globals.MainWindow.WindowState;

			Globals.Debug("Saving settings file: " + SettingsFile);
			if(!Directory.Exists(AppDataPath)) {
				try {
					Directory.CreateDirectory(AppDataPath);
				} catch(UnauthorizedAccessException) {
					Globals.LogIDE("Can't create directory: " + AppDataPath);
				}
			}
			StreamWriter sw = null;
			try {
				sw = new StreamWriter(SettingsFile);
				XmlSerializer xs = new XmlSerializer(s.GetType());
				xs.Serialize(sw, s);
			} catch(IOException e) {
				Globals.LogIDE(i18n.str("UnableSaveSettings"));
				Globals.Debug(e.Message);
			} finally {
				if(sw != null) sw.Close();
			}
		}

		public static void Load() {
			FileInfo fi = new FileInfo(SettingsFile);
			if(fi.Exists) {
				Globals.Debug("Loading settings file: " + SettingsFile);
				try {
					XmlSerializer xs = new XmlSerializer(s.GetType());
					s = (Settings)xs.Deserialize(new StreamReader(SettingsFile));
					foreach(string PrjPath in s._OpenProjects) {
						Project.Open(PrjPath);
					}
				} catch(IOException e) {
					Globals.LogIDE(i18n.str("UnableLoadSettings"));
					Globals.Debug(e.Message);
				}
			}
		}
		#endregion
	}
}
