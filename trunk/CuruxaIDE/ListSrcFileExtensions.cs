using System;
using System.Collections.Generic;

namespace CuruxaIDE {
	public static class ListSrcFileExtensions {
		/// <summary>
		/// Checks whether a file name exists in the collection or not
		/// </summary>
		public static bool ContainsFileName(this List<SrcFile> sources, string FileName) {
			foreach(SrcFile src in sources) {
				if(src.FileName == FileName) return true;
			}
			return false;
		}

		/// <summary>
		/// Checks whether a file exists in the collection or not, given the full path to it
		/// </summary>
		public static bool ContainsFullPath(this List<SrcFile> sources, string FullPath) {
			foreach(SrcFile src in sources) {
				if(src.FullPath == FullPath) return true;
			}
			return false;
		}

		/// <summary>
		/// Retrieves a SrcFile from the collection, given its FileName
		/// </summary>
		public static SrcFile GetByFileName(this List<SrcFile> sources, string FileName) {
			foreach(SrcFile src in sources) {
				if(src.FileName == FileName) return src;
			}
			throw new ArgumentException("File name \"" + FileName + "\" not found in List<SrcFile>");
		}

		/// <summary>
		/// Retrieves a SrcFile from the collection, given its full path
		/// </summary>
		public static SrcFile GetByFullPath(this List<SrcFile> sources, string FullPath) {
			foreach(SrcFile src in sources) {
				if(src.FullPath == FullPath) return src;
			}
			throw new ArgumentException("Full path \"" + FullPath + "\" not found in List<SrcFile>");
		}
	}
}
