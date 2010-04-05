using System;

namespace CuruxaIDE {
	public static class ProjectArrayExtensions {
		/// <summary>
		/// Return a project from an array by its given name
		/// </summary>
		public static Project GetByName(this Project[] prjs, string Name) {
			foreach(Project prj in prjs) {
				if(prj.Name == Name) return prj;
			}
			throw new ArgumentException("Unknown project");
		}

		/// <summary>
		/// Checks if a project is already open, given the full path to the project file
		/// </summary>
		public static bool ContainsPrjPath(this Project[] prjs, string PrjPath) {
			foreach(Project prj in prjs) {
				if(prj.PrjFilePath == PrjPath) return true;
			}
			return false;
		}
	}
}
