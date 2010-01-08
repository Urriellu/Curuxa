using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace CuruxaIDE {
	[Serializable]
	public class Project {
		/// <summary>
		/// Project name
		/// </summary>
		public string Name = "UNDEFINED";

		/// <summary>
		/// Path to the project directory
		/// </summary>
		[XmlIgnore]
		public string Path = "UNDEFINED";

		/// <summary>
		/// Project Description
		/// </summary>
		/// <remarks>
		/// A text any user can modify to explain what this project do
		/// </remarks>
		public string Description;

		/// <summary>
		/// Indicates if this project has been properly compiled (and not modified since then)
		/// </summary>
		[XmlIgnore]
		public bool IsCompiled { get; protected set; }

		/// <summary>
		/// Indicates if this project has been properly burnt into the microcontroller (and not modified since then)
		/// </summary>
		[XmlIgnore]
		public bool IsBurnt { get; protected set; }

		/// <summary>
		/// Indicates if this project is running
		/// </summary>
		[XmlIgnore]
		public bool IsRunning { get; protected set; }

		/// <summary>
		/// Full path to the project file
		/// </summary>
		[XmlIgnore]
		public string PrjFilePath {
			get {
				return Path + "/" + Name + ".crx";
			}
			set {
				FileInfo FI = new FileInfo(value);
				Path = FI.DirectoryName;
				Name = FI.Name.Replace(".crx", "");
			}
		}

		/// <summary>
		/// List of source files. Paths relative to the project directory
		/// </summary>
		[XmlIgnore]
		public List<SrcFile> SrcFiles = new List<SrcFile>();

		/// <summary>
		/// List of libraries used in this project
		/// </summary>
		[XmlIgnore]
		public List<SrcFile> Libs {
			get {
				_Libs.Clear();
				foreach(SrcFile src in SrcFiles) {
					foreach(SrcFile lib in src.RefLibs) {
						ParseRefLib(lib);
					}
				}
				return _Libs;
			}
		}
		protected List<SrcFile> _Libs = new List<SrcFile>();

		/// <summary>
		/// Add a library and all its references to the list of referenced libraries, only if they don't exist yet
		/// </summary>
		/// <param name="lib">Library referenced by this project</param>
		protected void ParseRefLib(SrcFile lib) {
			if(!_Libs.Contains(lib)) {
				_Libs.Add(lib);
				foreach(SrcFile reflib in lib.RefLibs) {
					ParseRefLib(reflib);
				}
			}
		}

		public void AddSrcFile(SrcFile src) {
			SrcFiles.Add(src);
		}

		public void AddSrcFile(string FilePath) {
			SrcFiles.Add(new SrcFile(this, FilePath));
		}

		public string[] SrcFileNames {
			get {
				string[] fn = new string[SrcFiles.Count];
				for(int i = 0; i < fn.Length; i++) {
					fn[i] = SrcFiles[i].FileName;
				}
				return fn;
			}
			set {
				SrcFiles.Clear();
				foreach(string file in value) {
					SrcFile s = new SrcFile(this, file);
					if(!SrcFiles.Contains(s)) SrcFiles.Add(s);
				}
			}
		}

		/// <summary>
		/// Gets the project's main file
		/// </summary>
		public SrcFile MainFile {
			get {
				switch(Language) {
					case Language.C:
						foreach(SrcFile src in SrcFiles) {
							if(src.Extension == "c") return src;
						}
						break;
					default:
						throw new NotImplementedException();
				}
				return null;
			}
		}

		/// <summary>
		/// Directory where output files (after compilation) are stored. It's relative to the project directory
		/// </summary>
		public string OutputPath = "/bin";

		/// <summary>
		/// Full path to the directory where output files (after compilation) are stored
		/// </summary>
		public string OutputFullPath {
			get {
				return Path + OutputPath;
			}
		}

		/// <summary>
		/// Main Board used in this project
		/// </summary>
		public MainBoard MainBoard = MainBoard.MBP18;

		/// <summary>
		/// Voltage at which the project should be powered
		/// </summary>
		public float Voltage = 5f;

		/// <summary>
		/// Programming language
		/// </summary>
		public Language Language = Language.C;

		public Programmer Programmer = Programmer.PICkit2;


		/// <summary>
		/// Indicates if this project has been modified
		/// </summary>
		[XmlIgnore]
		public bool Modified {
			get {
				return _Modified;
			}
			set {
				if(value == true) {
					IsCompiled = false;
					IsBurnt = false;
				}
				_Modified = value;
			}
		}
		private bool _Modified = false;

		/// <summary>
		/// Save project and its source files
		/// </summary>
		public void SaveAll() {
			Save();
			foreach(SrcFile src in SrcFiles) src.SaveFile();
		}

		/// <summary>
		/// Save project
		/// </summary>
		public void Save() {
			XmlSerializer xs = new XmlSerializer(this.GetType());
			StreamWriter sw = null;
			try {
				sw = new StreamWriter(PrjFilePath);
				xs.Serialize(sw, this);
				Modified = false;
				Globals.LogIDE(i18n.str("SavingFile", PrjFilePath));
			} catch(IOException e) {
				Globals.LogIDE(i18n.str("UnableSaveFile", PrjFilePath));
				Globals.Debug(e.Message);
			} finally {
				if(sw != null) sw.Close();
			}
		}

		/// <summary>
		/// Closes this project
		/// </summary>
		public void Close() {
			Globals.Debug("Removing project {0} from the list of open projects", this.Name);
			_OpenProjects.Remove(this);
			Settings.RemoveOpenProject(this.PrjFilePath);
			if(Globals.ActiveProject == this) {
				Globals.ActiveProject = null;
				Globals.ActiveSrcFile = null;
			}
			if(Globals.MainWindow != null) Globals.MainWindow.UpdatePrjList();
		}

		/// <summary>
		/// Build project
		/// </summary>
		public int Build() {
			Globals.LogIDE(i18n.str("BuildingPrj", Name));
			int r = Language.GetToolsuite().Build(this);
			if(r == 0) IsCompiled = true;
			return r;
		}

		/// <summary>
		/// Write project contents to microcontroller
		/// </summary>
		public int Burn() {
			Globals.LogIDE(i18n.str("BurningPrj", Name));
			Globals.SetupNewProgrammerLog();
			int r = Programmer.GetProgrammerApp().Write(this);
			if(r == 0) IsBurnt = true;
			return r;
		}

		/// <summary>
		/// Powers-up the microcontroller so its program starts running
		/// </summary>
		public int Run() {
			Globals.LogIDE(i18n.str("RunningPrj", Name));
			Globals.SetupNewProgrammerLog();
			int r = Programmer.GetProgrammerApp().Run(this);
			if(r == 0) IsRunning = true;
			return r;
		}

		/// <summary>
		/// Powers-down the microcontroller so its program stops running
		/// </summary>
		public int Stop() {
			Globals.LogIDE(i18n.str("StoppingPrj", Name));
			Globals.SetupNewProgrammerLog();
			int r = Programmer.GetProgrammerApp().Stop(this);
			if(r == 0) IsRunning = false;
			return r;
		}

		~Project() {
			if(IsRunning) Stop();
		}

		#region static members
		static List<Project> _OpenProjects = new List<Project>();

		/// <summary>
		/// Get the list of currently open projects
		/// </summary>
		public static Project[] OpenProjects {
			get {
				return _OpenProjects.ToArray();
			}
		}

		/// <summary>
		/// Open a project from a file and adds it to the list of open projects
		/// </summary>
		/// <param name="PrjFile">Project file</param>
		public static void Open(string PrjFile) {
			if(File.Exists(PrjFile)) {
				Project np = LoadFromFile(PrjFile);
				Add(np);
			} else {
				Globals.LogIDE(i18n.str("FileNotFound", PrjFile));
			}
		}

		/// <summary>
		/// Add an existing project to the list of open projects
		/// </summary>
		/// <param name="Prj">Project being added to the list</param>
		public static void Add(Project Prj) {
			Globals.Debug("Adding an existing project to the list of open projects");
			_OpenProjects.Add(Prj);
			Settings.AddOpenProject(Prj.PrjFilePath);
			if(Globals.MainWindow != null) Globals.MainWindow.UpdatePrjList();
		}

		/// <summary>
		/// Load a project from a file
		/// </summary>
		/// <param name="PrjFile">Path to the project file</param>
		public static Project LoadFromFile(string PrjFile) {
			Project NewPrj = null;
			FileInfo fi = new FileInfo(PrjFile);
			if(fi.Exists) {
				Globals.Debug("Loading project file: " + PrjFile);
				XmlSerializer xs = new XmlSerializer(typeof(Project));
				NewPrj = (Project)xs.Deserialize(new StreamReader(PrjFile));
				/*foreach(string PrjPath in s.OpenProjects) {
					Project.Open(PrjPath);
				}*/
				NewPrj.PrjFilePath = PrjFile;
				foreach(SrcFile src in NewPrj.SrcFiles) {
					src.Modified = false;
				}
			} else Globals.LogIDE(i18n.str("PrjFileNotExist", PrjFile));
			return NewPrj;
		}
		#endregion
	}
}
