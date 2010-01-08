using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CuruxaIDE {
	public static class ListViewGroupCollectionExtensions {
		/// <summary>
		/// Checks if there is any group with a given name in the collection
		/// </summary>
		public static bool ContainsName(this ListViewGroupCollection lvgc, string Name) {
			foreach(ListViewGroup group in lvgc) {
				if(group.Name == Name) return true;
			}
			return false;
		}
	}
}
