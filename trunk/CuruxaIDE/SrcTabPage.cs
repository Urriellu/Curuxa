using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CuruxaIDE {
	public partial class SrcTabPage:TabPage {
		public readonly SrcFile src;
		public SyntaxRichTextBox TxtCode;

		public SrcTabPage(SrcFile src)
			: base() {
			this.src = src;
			UpdateTitle();
			Enter += new EventHandler(SrcTabPage_Enter);
			TxtCode = new SyntaxRichTextBox(src.Language);
			TxtCode.Parent = this;
			TxtCode.Dock = DockStyle.Fill;
			TxtCode.Text = src.Content;
			TxtCode.ProcessAllLines();
			TxtCode.TextChanged += new EventHandler(TxtCode_TextChanged);
			TxtCode.SelectionChanged += new EventHandler(TxtCode_SelectionChanged);
		}

		void SrcTabPage_Enter(object sender, EventArgs e) {
			Globals.ActiveSrcFile = src;
		}

		void TxtCode_SelectionChanged(object sender, EventArgs e) {
			Point pt = new Point();
			CursorLocation c;
			int index = TxtCode.SelectionStart;
			c.Line = TxtCode.GetLineFromCharIndex(index) + 1;
			pt = TxtCode.GetPositionFromCharIndex(index);
			pt.X = 0;
			c.Column = index - TxtCode.GetCharIndexFromPosition(pt) + 1;
			Globals.MainWindow.CursorLocationChanged(c);
		}

		void TxtCode_TextChanged(object sender, EventArgs e) {
			bool m = src.Modified;
			src.Content = TxtCode.Text;
			if(m == false) UpdateTitle();
			TxtCode.ProcessChangedText();
		}

		public void UpdateTitle() {
			if(src.Modified) Text = src.Name + " *";
			else Text = src.Name;
		}
	}
}
