using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _3DScannerPC {
	public partial class FrmModels3D:FormChild {
		/// <summary>
		/// File for the current selected Model
		/// </summary>
		string selModelFile = null;

		/// <summary>
		/// Collection that relates each ListViewItem in the ListView "listModels" (which contains the list of open Model3D) and the string to the file where they are stored
		/// </summary>
		Dictionary<ListViewItem, string> listedModels = new Dictionary<ListViewItem, string>();

		Model3D selModel {
			get {
				return Model3D.KnownModels[selModelFile];
			}
		}

		public FrmModels3D() {
			InitializeComponent();
		}

		private void FrmModels3D_Load(object sender, EventArgs e) {
			lblDate.Text = "";

			//clear development stuff
			lstPoints.Items.Clear();

			UpdateLang();

			//show the currently open Models
			UpdateListOpenModels();

			//and update the data
			UpdateShownDataOneModel();
		}

		public override void UpdateLang() {
			this.Text = i18n.str("Models");
			lblName.Text=i18n.str("Name");
			btnOpenModel.Text = i18n.str("Open");
			btnRemoveModel.Text = i18n.str("Remove");
			btnNewModel.Text = i18n.str("NewModel");
			btnImport.Text = i18n.str("ImportPoints");
			btnSave.Text = i18n.str("Save");
			lblExport.Text = i18n.str("Export") + ":";
			btnExportTabbed.Text = i18n.str("tabbed");
			btnExportComma.Text = i18n.str("comma-separated");
		}

		private void btnOpenModel_Click(object sender, EventArgs e) {
			Globals.MainWindow.OpenModel3D();
		}

		private void btnRemoveModel_Click(object sender, EventArgs e) {
			Model3D.CloseModel(selModelFile);
		}

		public void UpdateListOpenModels() {
			lstModels.Clear();
			listedModels.Clear();
			foreach(var rm in Model3D.KnownModels) {
				ListViewItem lvi = new ListViewItem(rm.Value.Name);
				lstModels.Items.Add(lvi);
				listedModels.Add(lvi, rm.Key);
				lstModels.SelectedItems.Clear();
			}
		}

		private void btnNewModel_Click(object sender, EventArgs e) {
			FrmNewModel fnm = new FrmNewModel();
			fnm.ShowDialog(this);
			if(fnm.ok) {
				Model3D nm = new Model3D(fnm.txtName.Text);
				nm.Save(fnm.txtFileName.Text);
				Model3D.OpenModel(fnm.txtFileName.Text);
			}
		}

		private void btnSave_Click(object sender, EventArgs e) {
			selModel.Save(selModelFile);
		}

		private void lstModels_SelectedIndexChanged(object sender, EventArgs e) {
			if(lstModels.SelectedItems.Count > 0) {
				//item selected
				selModelFile = listedModels[lstModels.SelectedItems[0]];
			} else {
				//no items selected
				selModelFile = null;
			}
			UpdateShownDataOneModel();
		}

		/// <summary>
		/// Shows on the form all the data for the selected RAW Measurement
		/// </summary>
		private void UpdateShownDataOneModel() {
			if(string.IsNullOrEmpty(selModelFile)) {
				//no Model3D selected
				lstPoints.Enabled = false;
				btnRemoveModel.Enabled = false;
				//btnNewModel.Enabled = false;
				btnImport.Enabled = false;
				btnSave.Enabled = false;
				btnExportTabbed.Enabled = false;
				btnExportComma.Enabled = false;
			} else {
				lstPoints.Enabled = true;
				btnRemoveModel.Enabled = true;
				//btnNewModel.Enabled = true;
				btnImport.Enabled = true;
				btnSave.Enabled = true;
				btnExportTabbed.Enabled = true;
				btnExportComma.Enabled = true;

				txtName.Text = selModel.Name;
				lblDate.Text = selModel.Date.NormalDateTime();
			
				lstPoints.Items.Clear();
				for(int i = 0; i < selModel.Count; i++) {
					Vector3 p = selModel[i];
					ListViewItem lvi = new ListViewItem(i.ToString());
					lvi.SubItems.Add(p.X.ToString());
					lvi.SubItems.Add(p.Y.ToString());
					lvi.SubItems.Add(p.X.ToString());
					lstPoints.Items.Add(lvi);
				}
			}
		}

		private void btnNew_Click(object sender, EventArgs e) {
			RawMeasurement rawMsm = Globals.MainWindow.frmRawMsms.selRawMsm;
			if(rawMsm!=null){
				selModel.ImportRawPoints(rawMsm);
			}
			UpdateShownDataOneModel();
		}

		private void FrmModels3D_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = true;
			Hide();
		}

		private void btnExportTabbed_Click(object sender, EventArgs e) {
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Path.GetDirectoryName(selModelFile);
			saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if(saveFileDialog.ShowDialog(this) == DialogResult.OK) {
				string FileName = saveFileDialog.FileName;
				string result = "";
				for(int i = 0; i < selModel.Count; i++) result += selModel[i].X.ToString() + "\t" + selModel[i].Y.ToString() + "\t" + selModel[i].Z.ToString() + Environment.NewLine;
				File.WriteAllText(FileName, result);
			}
		}

		private void btnExportComma_Click(object sender, EventArgs e) {
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Path.GetDirectoryName(selModelFile);
			saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if(saveFileDialog.ShowDialog(this) == DialogResult.OK) {
				string FileName = saveFileDialog.FileName;
				string result = "";
				for(int i = 0 ; i < selModel.Count ; i++) result += selModel[i].X.ToString().Replace(",", ".") + ";" + selModel[i].Y.ToString().Replace(",", ".") + ";" + selModel[i].Z.ToString().Replace(",", ".") + Environment.NewLine;
				File.WriteAllText(FileName, result);
			}
		}
	}
}
