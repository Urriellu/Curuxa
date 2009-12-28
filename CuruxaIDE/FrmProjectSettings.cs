using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuruxaIDE {
	public partial class FrmProjectSettings:Form {
		Project Prj;

		public FrmProjectSettings(Project Prj) {
			InitializeComponent();
			this.Prj = Prj;
			UpdateLang();
		}

		private void UpdateLang() {
			this.Text = i18n.str("ProjectSettings");
			LblDescription.Text = i18n.str("Description:");
			LblName.Text = i18n.str("Name:");
			LblMainBoard.Text = i18n.str("MainBoard:");
			LblVoltage.Text = i18n.str("Voltage:");
			LblLanguage.Text = i18n.str("Language:");
			BtnOK.Text = i18n.str("OK");
		}

		private void ProjectSettings_Load(object sender, EventArgs e) {
			CmbMainBoard.Items.Clear();
			foreach(string MB in Enum.GetNames(typeof(MainBoard))) {
				CmbMainBoard.Items.Add(MB);
			}
			TxtName.Text = Prj.Name;
			CmbMainBoard.SelectedItem = Prj.MainBoard.ToString();
			Voltage.Increment = 0.1M;
			Voltage.Value = (decimal)Prj.Voltage;
			CmbLanguage.Items.Clear();
			foreach(string lang in Enum.GetNames(typeof(Language))) {
				CmbLanguage.Items.Add(lang);
			}
			CmbLanguage.SelectedItem = Prj.Language.ToString();
			TxtDescription.Text = Prj.Description;
		}

		private void LblOK_Click(object sender, EventArgs e) {
			SaveSettings();
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void SaveSettings() {
			Prj.Name = TxtName.Text;
			Prj.MainBoard = (MainBoard)Enum.Parse(typeof(MainBoard), (string)CmbMainBoard.SelectedItem);
			Prj.Voltage = (float)Voltage.Value;
			Prj.Language = (Language)Enum.Parse(typeof(Language), (string)CmbLanguage.SelectedItem);
			Prj.Description = TxtDescription.Text;
		}

		private void TxtName_TextChanged(object sender, EventArgs e) {
			CheckParams();
		}

		/// <summary>
		/// Check if all the options are correct and enable or disable the OK button as needed
		/// </summary>
		private void CheckParams() {
			if(TxtName.Text.Length > 0) BtnOK.Enabled = true;
			else BtnOK.Enabled = false;
		}
	}
}
