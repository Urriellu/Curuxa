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

		public void Log(string format, params object[] p) {
			txtLog.AppendText(string.Format(format, p) + Environment.NewLine);
		}

		private void FrmLog_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = true;
			Hide();
		}
	}
}
