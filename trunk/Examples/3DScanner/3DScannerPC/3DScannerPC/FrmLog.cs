using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3DScannerPC {
	public partial class FrmLog:FormChild {
		public FrmLog() {
			InitializeComponent();
		}

		private void FrmLog_Load(object sender, EventArgs e) {
			UpdateLang();
		}

		public override void UpdateLang() {
		}

		public void Log(Color color, string format, params object[] p) {
			int start = txtLog.TextLength;
			txtLog.AppendText(string.Format(format, p) + Environment.NewLine);
			int end = txtLog.TextLength;

			// Textbox may transform chars, so (end-start) != text.Length
			txtLog.Select(start, end - start);
			txtLog.SelectionColor = color; // could set box.SelectionBackColor, box.SelectionFont too.
			txtLog.SelectionLength = 0; // clear
		}

		private void FrmLog_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = true;
			Hide();
		}
	}
}
