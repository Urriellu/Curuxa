using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuruxaIDE {
	/// <summary>
	/// Managed a set of tabs containing source code editors
	/// </summary>
	public partial class SrcTabControl:TabControl {
		Dictionary<SrcFile, SrcTabPage> Tabs = new Dictionary<SrcFile, SrcTabPage>();

		public SrcTabControl():base() {
		}

		/// <summary>
		/// Opens a source file. It doesn't matter if the source file is already open
		/// </summary>
		public void OpenSrc(SrcFile src) {
			if(!Tabs.ContainsKey(src)) {
				SrcTabPage NewTab = new SrcTabPage(src);
				Tabs.Add(src, NewTab);
				TabPages.Add(NewTab);
			}
			SelectedTab = Tabs[src];
		}
	}
}
