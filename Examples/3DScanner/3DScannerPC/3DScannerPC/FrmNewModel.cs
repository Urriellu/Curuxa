using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _3DScannerPC.Properties;

namespace _3DScannerPC {
	public partial class FrmNewModel:FormChild {
		public FrmNewModel() {
			InitializeComponent();
		}

		public bool ok = false;

		private void FrmNewModel_Load(object sender, EventArgs e) {
			UpdateLang();

			txtName.Text = "Model3D " + DateTime.Now.ShortDateTime();
			txtFileName.Text = "C:\\myscan.3dmodel";
		}

		public override void UpdateLang() {
			this.Text = i18n.str("NewModel");
			lblName.Text = i18n.str("Name");
			btnOk.Text = i18n.str("Ok");
			btnCancel.Text = i18n.str("Cancel");
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			ok = false;
			this.Close();
		}

		private void btnOk_Click(object sender, EventArgs e) {
			if(!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtFileName.Text)) ok = true;
			this.Close();
		}

		private void txtFileName_MouseClick(object sender, MouseEventArgs e) {
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.FileName = txtName.Text + "." + Settings.Default.ModelExtension;
			sfd.Filter = Settings.Default.ModelFileFilter;
			//sfd.Title = rawMeasurement.Name;

			if(sfd.ShowDialog(this) == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName)) {
				txtFileName.Text = sfd.FileName;
			}
		}
	}
}
