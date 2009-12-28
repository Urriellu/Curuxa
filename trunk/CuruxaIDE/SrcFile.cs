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
		public readonly Project ParentProject;

		/// <summary>
		/// File name, including extension, excluding path
		/// </summary>
		public string FileName;

		/// <summary>
		/// Indicates when the content of this file hasn't been save to disk yet
		/// </summary>
		public bool Modified {
			get {
				return _Modified;
			}
			set {
				if(!_Modified && value) {
					_Modified = value;
					if(Globals.MainWindow != null) Globals.MainWindow.UpdatePrjList();
				} else {
					_Modified = value;
				}
			}
		}
		private bool _Modified = false;

		public string FullPath {
			get {
				return ParentProject.Path + "/" + FileName;
			}
		}

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

		/// <summary>
		/// Creates a new empty source file at the given location
		/// </summary>
		/// <param name="FileName">File name, including extension, excluding path</param>
		public SrcFile(Project ParentProject, string FileName) {
			this.ParentProject = ParentProject;
			this.FileName = FileName;
		}

		/// <summary>
		/// Creates a new empty source file at the given location from a template
		/// </summary>
		/// <param name="FileName">File name, including extension, excluding path</param>
		public SrcFile(Project ParentProject, string FileName, MainBoard MainBoard, Language Language) {
			this.ParentProject = ParentProject;
			this.FileName = FileName;
			string file = string.Format("{0}/{1}.{2}", Settings.TemplatesDir, MainBoard, Language.GetExtension());
			if(!File.Exists(file)) file = string.Format("{0}/{1}.{2}", Settings.TemplatesDir, "Default", Language.GetExtension());
			Content = File.ReadAllText(file, Settings.Charset);
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
			} catch(FileNotFoundException) {
				Globals.Log(i18n.str("FileNotFound", FullPath));
			}
		}

		/// <summary>
		/// Saves the contents to disk
		/// </summary>
		public void SaveFile() {
			Globals.Log("Saving file " + FullPath);
			File.WriteAllText(FullPath, Content, Settings.Charset);
			Modified = false;
			if(Globals.MainWindow != null) Globals.MainWindow.UpdatePrjList();
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
