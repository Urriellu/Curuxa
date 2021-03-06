﻿using System;
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
		public Dictionary<SrcFile, SrcTabPage> Tabs = new Dictionary<SrcFile, SrcTabPage>();

		public SrcTabControl()
			: base() {
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

		internal void RemoveAllFromPrj(Project p) {
			bool mod;
			do {
				mod = false;
				foreach(KeyValuePair<SrcFile, SrcTabPage> pair in Tabs) {
					if(pair.Key.ParentProject == p) {
						i18n.str("ClosingTab", pair.Key.ParentProject.Name, pair.Value.Name);
						CloseSrc(pair.Key);
						mod = true;
						break;
					}
				}
			} while(mod);
		}

		public void CloseSrc(SrcFile src) {
			if(src != null && Tabs.ContainsKey(src)) {
				//there is a weird bug here I can't fix. It happens on Mono+Linux
				if(TabPages.Contains(Tabs[src])) TabPages.Remove(Tabs[src]);
				Tabs.Remove(src);
			}
		}
	}
}
