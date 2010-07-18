using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CuruxaIDE {
	/// <summary>
	/// Represents a file containing source code
	/// </summary>
	public class SrcFile {
		public static List<SrcFile> KnownSrcFiles = new List<SrcFile>();

		public readonly Project ParentProject;

		/// <summary>
		/// File name, including extension, excluding path
		/// </summary>
		public string FileName { get; protected set; }

		/// <summary>
		/// Indicates if this source file is read-only
		/// </summary>
		public bool IsReadOnly {
			get {
				if(!IsLocal || new FileInfo(FullPath).IsReadOnly) return true;
				else return false;
			}
		}

		/// <summary>
		/// Indicates when the content of this file hasn't been save to disk yet
		/// </summary>
		public bool Modified {
			get {
				return _Modified;
			}
			set {
				if(value == true) {
					//it's being set to true
					if(ParentProject != null) ParentProject.Modified = true;
				}
				if(_Modified == false && value == true) {
					//it's being set from false to true
					//(removed code. We used to do something here)
				}
				_Modified = value;
			}
		}
		private bool _Modified = false;

		/// <summary>
		/// This source file is local or not (same path as project)
		/// </summary>
		public bool IsLocal {
			get {
				if(ParentProject != null && ParentProject.Path == SrcPath) return true;
				else return false;
			}
		}

		/// <summary>
		/// Full path to the source file (path to the directory + file name)
		/// </summary>
		public string FullPath {
			get {
				return Path.GetFullPath(SrcPath + "/" + FileName);
			}
		}

		/// <summary>
		/// Directory where this source file can be found
		/// </summary>
		/// NOTE FOR DEVS: leave _SrcPath empty for retrieving the same path as the parent project
		public string SrcPath {
			get {
				if(_SrcPath == null) {
					if(ParentProject == null) return "";
					else return ParentProject.Path;
				} else {
					return _SrcPath;
				}
			}
			protected set {
				_SrcPath = value;
			}
		}
		protected string _SrcPath;

		/// <summary>
		/// File name, excluding extension and path
		/// </summary>
		public string Name {
			get {
				return new FileInfo(FileName).Name;
			}
		}

		/// <summary>
		/// File Extension, without point
		/// </summary>
		public string Extension {
			get {
				return new FileInfo(FileName).Extension.Remove(0, 1);
			}
		}

		public Language Language {
			get {
				return LanguageExtensions.GetFromExtension(Extension);
			}
		}

		/// <summary>
		/// Creates a new empty source file at the given location
		/// </summary>
		/// <param name="FileName">File name, including extension, excluding path</param>
		public SrcFile(Project ParentProject, string FileName)
			: this(FileName) {
			this.ParentProject = ParentProject;
		}

		/// <summary>
		/// Creates a new empty source file
		/// </summary>
		/// <param name="FileName">File name, including extension, excluding path</param>
		protected SrcFile(string FileName) {
			this.FileName = FileName;
			KnownSrcFiles.Add(this);
		}

		/// <summary>
		/// Creates a new empty source file at the given location from a template
		/// </summary>
		/// <param name="FileName">File name, including extension, excluding path</param>
		public static SrcFile GetFromTemplate(Project ParentProject, string FileName, MainBoard MainBoard, Language Language) {
			SrcFile src = new SrcFile(ParentProject, FileName);
			string file = string.Format("{0}/{1}.{2}", Settings.TemplatesDir, MainBoard, Language.GetExtension());
			if(!File.Exists(file)) file = string.Format("{0}/{1}.{2}", Settings.TemplatesDir, "Default", Language.GetExtension());
			src.Content = File.ReadAllText(file, Settings.Charset);
			return src;
		}

		/// <summary>
		/// Gets an instance of SrcFile which represents a library
		/// </summary>
		/// <param name="type">Library type (local or global)</param>
		/// <param name="LibName">Library name</param>
		/// <param name="RefFrom">Source file that has an include to this one</param>
		/// <returns>
		/// An instance of SrcFile which represents the library.
		/// Null if the library was not found
		/// </returns>
		public static SrcFile GetFromLibrary(IncludeType type, string LibName, SrcFile RefFrom) {
			SrcFile src = new SrcFile(RefFrom.ParentProject, LibName);
			//src.IsReadOnly = true;

			//find lib path
			Queue<string> PossiblePaths = new Queue<string>();
			if(type == IncludeType.Local) PossiblePaths.Enqueue(RefFrom.SrcPath);
			PossiblePaths.Enqueue(Settings.IncludesDir);
			foreach(string path in RefFrom.ParentProject.Language.GetToolsuite().IncludePaths) {
				PossiblePaths.Enqueue(path);
			}
			while(PossiblePaths.Count > 0) {
				string SomePath = PossiblePaths.Dequeue();
				string SomeFullPath = Path.GetFullPath(SomePath + "/" + LibName);
				if(File.Exists(SomeFullPath)) {
					//library found
					src.SrcPath = Path.GetDirectoryName(SomeFullPath);
					break;
				}
			}

			if(!string.IsNullOrEmpty(src._SrcPath)) {
				if(KnownSrcFiles.ContainsFullPath(src.FullPath)) {
					//Return a previously known object instead of the newly created one
					return KnownSrcFiles.GetByFullPath(src.FullPath);
				}

				src.Content = File.ReadAllText(src.FullPath, Settings.Charset);
				return src;
			} else {
				//Return null if the library was not found
				return null;
			}
		}

		/// <summary>
		/// Libraries referenced from this source file
		/// </summary>
		public SrcFile[] RefLibs {
			get {
				List<SrcFile> libs = new List<SrcFile>();
				//libs.Add(SrcFile.GetFromLibrary(IncludeType.Global, "MBP18.h", this));

				foreach(string line in Content.Split('\n', '\r')) {
					if(line.Length < 10) continue;
					if(line.StartsWith("#include")) {
						IncludeType type = IncludeType.Global;
						string lib = "";
						if(line.Contains('<') && line.Contains('>')) {
							//this is a #include <lib.h> line
							lib = line.Replace("#include", "");
							lib = lib.TrimStart(' ', '\t');
							lib = lib.TrimEnd(' ', '\t');
							lib = lib.TrimStart('<');
							lib = lib.TrimEnd('>');
						} else if(line.Contains('"')) {
							//this is a #include "lib.h" line
							lib = line.Replace("#include", "");
							lib = lib.TrimStart(' ', '\t');
							lib = lib.TrimEnd(' ', '\t');
							lib = lib.TrimStart('"');
							lib = lib.TrimEnd('"');
							type = IncludeType.Local;
						}
						SrcFile NewLib = SrcFile.GetFromLibrary(type, lib, this);
						if(NewLib != null) libs.Add(NewLib);
						else Globals.LogIDE(i18n.str("LibNotFound", lib));
					}
				}

				return libs.ToArray();
			}
		}

		/// <summary>
		/// Source file contents
		/// </summary>
		public string Content {
			get {
				if(string.IsNullOrEmpty(_Content)) ReadFile();
				return _Content;
			}
			set {
				_Content = value;
				Modified = true;
			}
		}
		protected string _Content;

		/// <summary>
		/// Reads the content of the file
		/// </summary>
		public void ReadFile() {
			try {
				Content = File.ReadAllText(FullPath, Settings.Charset);
				Modified = false;
			} catch(FileNotFoundException) {
				Globals.LogIDE(i18n.str("FileNotFound", FullPath));
			}
		}

		/// <summary>
		/// Saves the contents to disk
		/// </summary>
		public void SaveFile() {
			if(IsReadOnly) {
				Globals.LogIDE(i18n.str("CantSaveIsReadOnly", FullPath));
			} else {
				Globals.LogIDE(i18n.str("SavingFile", FullPath));
				File.WriteAllText(FullPath, Content, Settings.Charset);
				Modified = false;
				if(Globals.MainWindow != null) Globals.MainWindow.UpdatePrjList();
			}
		}

		public static bool operator ==(SrcFile a, SrcFile b) {
			if(object.ReferenceEquals(a, b)) return true;
			else if((object)a == null || (object)b == null) return false;
			else return a.FullPath == b.FullPath;
		}

		public static bool operator !=(SrcFile a, SrcFile b) {
			return !(a == b);
		}
	}
}
