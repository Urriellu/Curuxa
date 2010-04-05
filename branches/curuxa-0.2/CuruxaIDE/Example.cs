using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace CuruxaIDE {
	/// <summary>
	/// Represents an Example Project
	/// </summary>
	[Serializable]
	public class Example {
		public const string ExampleExtension = "CuruxaExample";

		/// <summary>
		/// Curuxa IDE Project containing this example
		/// </summary>
		public Project Project = new Project();

		/// <summary>
		/// List of Curuxa Modules used by this Example
		/// </summary>
		public List<Module> UsedModules = new List<Module>();

		/// <summary>
		/// Save example
		/// </summary>
		public void Save(string ExFile) {
			XmlSerializer xs = new XmlSerializer(this.GetType());
			StreamWriter sw = new StreamWriter(ExFile);
			xs.Serialize(sw, this);
			sw.Close();
		}

		#region static members
		/*public static string[] AvailableExamples {
			get {
				DirectoryInfo di = new DirectoryInfo(Settings.ExamplesDir);
				FileInfo[] rgFiles = di.GetFiles("*." + ExampleExtension);
				string[] ex = new string[rgFiles.Length];
				for(int i = 0; i < ex.Length; i++) ex[i] = rgFiles[i].Name.Replace("." + ExampleExtension, "");
				return ex;
			}
		}*/

		public static Example[] AvailableExamples {
			get {
				if(_AvailableExamples == null) {
					DirectoryInfo di = new DirectoryInfo(Settings.ExamplesDir);
					FileInfo[] files = di.GetFiles("*." + ExampleExtension);
					Example[] examples = new Example[files.Length];
					for(int i = 0; i < examples.Length; i++) {
						examples[i] = Load(files[i].Name.Replace("." + ExampleExtension, ""));
					}
					_AvailableExamples = examples;
				}
				return _AvailableExamples;
			}
		}
		protected static Example[] _AvailableExamples;

		/// <summary>
		/// Load example from a file
		/// </summary>
		/// <param name="PrjFile">Path to the example file</param>
		/// <returns>Example object if found. Null if it doesn't exist</returns>
		public static Example Load(string Name) {
			string file = string.Format("{0}/{1}.{2}", Settings.ExamplesDir, Name, ExampleExtension);
			Example NewEx = null;
			FileInfo fi = new FileInfo(file);
			if(fi.Exists) {
				Globals.Debug("Loading example file: " + Name);
				XmlSerializer xs = new XmlSerializer(typeof(Example));
				NewEx = (Example)xs.Deserialize(new StreamReader(file));
				NewEx.Project.Path = Settings.ExamplesDir;
			} else Globals.LogIDE(i18n.str("ExFileNotExist", file));
			return NewEx;
		}
		#endregion
	}
}
