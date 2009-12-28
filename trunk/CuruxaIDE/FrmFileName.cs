using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuruxaIDE {
	public partial class FrmFileName:Form {
		public FrmFileName(string FileName) {
			InitializeComponent();
			TxtFileName.Text = FileName;
		}

		private void FrmFileName_Load(object sender, EventArgs e) {
			UpdateLang();
		}

		private void UpdateLang() {
			this.Text = i18n.str("SaveMainFileAs");
			LblFileName.Text = i18n.str("FileName") + ":";
			BtnOk.Text = i18n.str("OK");
		}

		private void BtnOk_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
