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
			/* ADD AT THE END */
			int start = txtLog.TextLength;
			txtLog.AppendText(string.Format(format, p) + Environment.NewLine);
			int end = txtLog.TextLength;

			txtLog.Select(start, end - start);
			txtLog.SelectionColor = color;

			txtLog.Select();
			txtLog.SelectionStart = txtLog.GetFirstCharIndexFromLine(txtLog.Lines.Length - 1);

			/* ADD AT THE BEGINNING (problem: no color)
			string newText = string.Format(format, p);
			txtLog.Text = newText + Environment.NewLine + txtLog.Text;
			txtLog.Select(0, newText.Length);
			txtLog.SelectionColor = color;
			txtLog.SelectionLength = 0;*/
		}

		private void FrmLog_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = true;
			Hide();
		}
	}
}
