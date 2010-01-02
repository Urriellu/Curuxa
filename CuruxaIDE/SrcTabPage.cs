using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuruxaIDE {
	public partial class SrcTabPage:TabPage {
		public readonly SrcFile src;
		private SyntaxRichTextBox TxtCode;

		public SrcTabPage(SrcFile src)
			: base() {
			this.src = src;
			UpdateTitle();
			TxtCode = new SyntaxRichTextBox(src.Language);
			TxtCode.Parent = this;
			TxtCode.Dock = DockStyle.Fill;
			TxtCode.Text = src.Content;
			TxtCode.ProcessAllLines();
			TxtCode.TextChanged += new EventHandler(TxtCode_TextChanged);
		}

		void TxtCode_TextChanged(object sender, EventArgs e) {
			if(src.Modified == false) {
				src.Modified = true;
				src.Content = Text;
				UpdateTitle();
			}
			TxtCode.ProcessChangedText();
		}

		public void UpdateTitle() {
			if(src.Modified) Text = src.Name + " *";
			else Text = src.Name;
		}
	}
}
