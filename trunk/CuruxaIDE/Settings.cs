using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace CuruxaIDE {
	/// <summary>
	/// Application settings
	/// </summary>
	public class Settings {
		#region instance members
		public List<string> OpenProjects = new List<string>();
		#endregion

		#region static members
		static Settings s = new Settings();

		/// <summary>
		/// Charset used by Curuxa IDE
		/// </summary>
		public static readonly Encoding Charset = Encoding.UTF8;

		public const string Version = "0.1-svn";

		/// <summary>
		/// Add the path of a project to the list of opened projects
		/// </summary>
		/// <param name="path"></param>
		public static void AddOpenProject(string path) {
			if(!s.OpenProjects.Contains(path)) {
				Globals.Debug("Adding to the list of open projects: " + path);
				s.OpenProjects.Add(path);
			}
		}

		/// <summary>
		/// Remove the path of a project from the list of opened projects
		/// </summary>
		/// <param name="path"></param>
		public static void RemoveOpenProject(string path) {
			Globals.Debug("Removing path from the list of opened projects (at the settings file): " + path);
			s.OpenProjects.Remove(path);
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

		/// <summary>
		/// Full path to the directory containing libraries used by final users. Last character is NOT a slash ('/')
		/// </summary>
		public static string IncludesDir {
			get {
				return ExeLocation + "/UserIncludes";
			}
		}

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
			Globals.Debug("Saving settings file: " + SettingsFile);
			if(!Directory.Exists(AppDataPath)) {
				try {
					Directory.CreateDirectory(AppDataPath);
				} catch(UnauthorizedAccessException) {
					Globals.Log("Can't create directory: " + AppDataPath);
				}
			}
			StreamWriter sw = null;
			try {
				sw = new StreamWriter(SettingsFile);
				XmlSerializer xs = new XmlSerializer(s.GetType());
				xs.Serialize(sw, s);
			} catch(IOException e) {
				Globals.Log(i18n.str("UnableSaveSettings"));
				Globals.Debug(e.Message);
			} finally {
				sw.Close();
			}
		}

		public static void Load() {
			FileInfo fi = new FileInfo(SettingsFile);
			if(fi.Exists) {
				Globals.Debug("Loading settings file: " + SettingsFile);
				try {
					XmlSerializer xs = new XmlSerializer(s.GetType());
					s = (Settings)xs.Deserialize(new StreamReader(SettingsFile));
					foreach(string PrjPath in s.OpenProjects) {
						Project.Open(PrjPath);
					}
				} catch(IOException e) {
					Globals.Log(i18n.str("UnableLoadSettings"));
					Globals.Debug(e.Message);
				}
			}
		}
		#endregion
	}
}
