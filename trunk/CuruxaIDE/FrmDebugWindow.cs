using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuruxaIDE {
	public partial class FrmDebugWindow:Form {
		public FrmDebugWindow() {
			InitializeComponent();
		}

		public void LogDebug(string text) {
			txtDebug.AppendText(text + Environment.NewLine);
		}

		private void FrmDebugWindow_Load(object sender, EventArgs e) {

		}

		private void FrmDebugWindow_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = true;
			Hide();
		}
	}
}
