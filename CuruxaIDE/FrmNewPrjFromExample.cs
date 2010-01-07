using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuruxaIDE {
	public partial class FrmNewPrjFromExample:Form {
		/// <summary>
		/// Currently selected Example. Null if none selected
		/// </summary>
		public Example ChosenExample;

		public FrmNewPrjFromExample() {
			InitializeComponent();
		}

		private void NewPrjFromExample_Load(object sender, EventArgs e) {
			BtnSaveAs.Image = Globals.LoadImage("fileopen.png");
			UpdateLang();
			UpdateExamplesList();

			//update filter lists
			LstFilterMB.Items.Clear();
			foreach(string MB in Enum.GetNames(typeof(MainBoard))) {
				LstFilterMB.Items.Add(MB);
			}
			LstFilterModules.Items.Clear();
			foreach(string Module in Enum.GetNames(typeof(Module))) {
				LstFilterModules.Items.Add((((Module)Enum.Parse(typeof(Module), Module)).GetRealName()));
			}
		}

		/// <summary>
		/// Updates the list of available examples
		/// </summary>
		private void UpdateExamplesList() {
			LstExamples.Items.Clear();
			foreach(Example ex in Example.AvailableExamples) {
				bool show = true;
				foreach(ListViewItem MbItem in LstFilterMB.Items) {
					if(MbItem.Checked && ex.Project.MainBoard != (MainBoard)Enum.Parse(typeof(MainBoard), MbItem.Text)) show = false;
				}
				foreach(ListViewItem ModItem in LstFilterModules.Items) {
					if(ModItem.Checked && !ex.UsedModules.Contains(ModuleExtensions.GetModuleFromRealName(ModItem.Text))) show = false;
				}
				if(show) LstExamples.Items.Add(ex.Project.Name);
			}
			if(LstExamples.Items.Count > 0) {
				LstExamples.Enabled = true;
				LstExamples.SelectedIndex = 0;
			} else {
				// no available examples
				LstExamples.Enabled = false;
				ChosenExample = null;
				TxtDescription.Enabled = false;
				TxtDescription.Text = i18n.str("NoExample");
				LstExamples.Items.Add(i18n.str("NoExamples"));
			}
			UpdateBtnStatus();
		}

		/// <summary>
		/// Updates the "save" button status
		/// </summary>
		private void UpdateBtnStatus() {
			if(ChosenExample != null && !string.IsNullOrEmpty(TxtPrjFile.Text)) BtnSave.Enabled = true;
			else BtnSave.Enabled = false;
		}

		private void UpdateLang() {
			this.Text = i18n.str("NewPrjFromEx");
			LblAvailEx.Text = i18n.str("ListAvailEx");
			LblSaveAs.Text = i18n.str("SavePrjAs:");
			BtnSave.Text = i18n.str("SaveExample");
			LblFilter.Text = i18n.str("Filter:");
			LblMainBoard.Text = i18n.str("MainBoards:");
			LblModules.Text = i18n.str("Modules:");
		}

		private void BtnSaveAs_Click(object sender, EventArgs e) {
			SaveFileDialog SaveProjectDialog = new SaveFileDialog();
			SaveProjectDialog.AddExtension = true;
			SaveProjectDialog.FileName = i18n.str("NewPrjName");
			SaveProjectDialog.Filter = i18n.str("CrxPrjFilter");
			SaveProjectDialog.OverwritePrompt = true;
			SaveProjectDialog.RestoreDirectory = false;
			SaveProjectDialog.ShowHelp = false;
			SaveProjectDialog.Title = i18n.str("SavePrjAs");
			SaveProjectDialog.ValidateNames = true;
			if(SaveProjectDialog.ShowDialog(this) == DialogResult.OK) {
				TxtPrjFile.Text = SaveProjectDialog.FileName;
			}
			UpdateBtnStatus();
		}

		private void LstExamples_SelectedValueChanged(object sender, EventArgs e) {
			SelectExample(LstExamples.SelectedItem.ToString());
		}

		/// <summary>
		/// Update the environment to show that a given Example has been selected
		/// </summary>
		/// <param name="Name"></param>
		private void SelectExample(string Name) {
			for(int i = 0; i < Example.AvailableExamples.Length; i++) {
				if(Example.AvailableExamples[i].Project.Name == Name) {
					ChosenExample = Example.AvailableExamples[i];
					break;
				}
			}
			Project p = ChosenExample.Project;
			TxtDescription.Enabled = true;
			TxtDescription.Clear();
			string modules = ChosenExample.UsedModules.CommaSeparatedList();
			if(string.IsNullOrEmpty(modules)) modules = i18n.str("none");
			TxtDescription.AppendText(i18n.str("ExampleDescription", p.Name, p.Description, p.Language, p.MainBoard, modules).Replace("\\n", Environment.NewLine));
		}

		private void LstFilterMB_ItemChecked(object sender, ItemCheckedEventArgs e) {
			UpdateExamplesList();
		}

		private void LstFilterModules_ItemChecked(object sender, ItemCheckedEventArgs e) {
			UpdateExamplesList();
		}

		private void BtnSave_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
