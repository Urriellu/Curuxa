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
			TxtCode.AcceptsTab = true;
			TxtCode.Font = new Font("Courier New", 10f, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

			if(src.IsReadOnly) {
				//Read-only file
				TxtCode.ReadOnly = true;
				TxtCode.BackColor = Color.LightGray;
			} else {
				//Normal, writable file
				TxtCode.ReadOnly = false;
				TxtCode.BackColor = SystemColors.Window;
			}
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
			string title = src.Name;
			if(src.IsReadOnly) title += i18n.str("TitleReadOnly");
			if(src.Modified) title += " *";
			Text = title;
		}
	}
}
