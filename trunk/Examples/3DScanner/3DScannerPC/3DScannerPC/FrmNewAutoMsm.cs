using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3DScannerPC {
	public partial class FrmNewAutoMsm:FormChild {
		public FrmNewAutoMsm() {
			InitializeComponent();
		}

		private void FrmNewAutoMsm_Load(object sender, EventArgs e) {
			UpdateLang();

			UpdateDefaultValues();
		}

		private void UpdateDefaultValues() {
			
		}

		public override void UpdateLang() {
			this.Text = i18n.str("NewAutoMsm");
		}

		private void FrmNewAutoMsm_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = true;
			Hide();
		}
	}
}
