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
		/// Retrieves a SrcFile from the collection, given its FileName
		/// </summary>
		public static SrcFile GetByFileName(this List<SrcFile> sources, string FileName) {
			foreach(SrcFile src in sources) {
				if(src.FileName == FileName) return src;
			}
			throw new ArgumentException("File name \"" + FileName + "\" not found in List<SrcFile>");
		}
	}
}
