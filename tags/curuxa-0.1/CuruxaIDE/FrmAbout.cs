using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CuruxaIDE {
	partial class FrmAbout:Form {
		public FrmAbout() {
			InitializeComponent();
		}

		private void okButton_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start("http://curuxa.org/");
		}

		private void FrmAbout_Load(object sender, EventArgs e) {
			UpdateLangStrings();
			Logo.ImageLocation = Settings.ImagesDir + "/CuruxaLogo.png";
		}

		private void UpdateLangStrings() {
			this.Text = i18n.str("About");
			LblVersion.Text = i18n.str("Version:", Settings.Version);
			TxtDescription.Text = i18n.str("CuruxaDescription").Replace("\\n", Environment.NewLine);
		}
	}
}
