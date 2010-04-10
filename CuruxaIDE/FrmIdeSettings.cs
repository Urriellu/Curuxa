using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuruxaIDE {
	public partial class FrmIdeSettings:Form {
		public FrmIdeSettings() {
			InitializeComponent();
		}

		private void FrmIdeSettings_Load(object sender, EventArgs e) {
			UpdateLang();
			LoadCurrentSettings();
		}

		private void LoadCurrentSettings() {
			//languages
			cmbLang.Items.Clear();
			foreach(string lang in i18n.AvailableLanguages) {
				cmbLang.Items.Add(i18n.GetNativeName(lang));
			}
			cmbLang.SelectedItem = i18n.GetNativeName(i18n.CurrentLanguage);

			//enable syntax highlight
			if(Settings.EnableSyntaxHighlight) cbEnbSynHgl.Checked = true;
			else cbEnbSynHgl.Checked = false;
		}

		private void UpdateLang() {
			Text = i18n.str("Preferences");
			BtnRestart.Text = i18n.str("Restart");
			BtnOk.Text = i18n.str("Ok");
			BtnCancel.Text = i18n.str("Cancel");
			lblLang.Text = i18n.str("HumanLanguage:");
			cbEnbSynHgl.Text = i18n.str("EnableSyntaxHighlight");
		}

		private void BtnRestart_Click(object sender, EventArgs e) {
			LoadCurrentSettings();
		}

		private void BtnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void BtnOk_Click(object sender, EventArgs e) {
			SavePreferences();
			Close();
		}

		private void SavePreferences() {
			i18n.CurrentLanguage = i18n.GetLangFromNativeName((string)cmbLang.SelectedItem);
			((FrmMainWindow)Owner).UpdateLang();
			Settings.EnableSyntaxHighlight = cbEnbSynHgl.Checked;
		}
	}
}
