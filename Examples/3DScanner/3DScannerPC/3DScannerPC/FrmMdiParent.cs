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
	public partial class FrmMdiParent:FormChild {
		FrmAbout frmAbout = new FrmAbout();

		public FrmManualControl frmManualControl;
		FrmConnection frmConnection;
		FrmSettings frmSettings;
		public FrmLog frmLog;
		public FrmRawMsms frmRawMsms;
		public FrmNewAutoMsm frmNewAutoMsm;
		FrmModels3D frmModels3D;

		public FrmMdiParent() {
			Control.CheckForIllegalCrossThreadCalls = false;
			InitializeComponent();
		}

		private void FrmMdiParent_Load(object sender, EventArgs e) {
			frmManualControl = new FrmManualControl();
			frmManualControl.MdiParent = this;

			frmLog = new FrmLog();
			frmLog.MdiParent = this;

			frmConnection = new FrmConnection();
			frmConnection.MdiParent = this;

			frmSettings = new FrmSettings();
			frmSettings.MdiParent = this;

			frmRawMsms = new FrmRawMsms();
			frmRawMsms.MdiParent = this;

			frmNewAutoMsm = new FrmNewAutoMsm();
			frmNewAutoMsm.MdiParent = this;

			frmModels3D = new FrmModels3D();
			frmModels3D.MdiParent = this;

			SetMdiChildrenDefaultLocations();

			UpdateLang();

			//frmRawMsms.Show();
			frmLog.Show();
			//frmManualControl.Show();
			frmConnection.Show();
			//frmNewAutoMsm.Show();
			frmModels3D.Show();

			Globals.Log(LogType.Information, i18n.str("init"));

			//ShowConnectionStatus(Status.Disconnected);
			UpdateStatus();

			//Communication.Connect();
		}

		private void SetMdiChildrenDefaultLocations() {
			const int t = 30;

			frmManualControl.StartPosition = FormStartPosition.Manual;
			frmManualControl.Location = new Point(Width - frmManualControl.Width - t, 0);

			frmConnection.StartPosition = FormStartPosition.Manual;
			frmConnection.Location = new Point(Width - frmConnection.Width - t, Height - frmConnection.Height - statusStrip.Height - 2 * t);

			frmLog.StartPosition = FormStartPosition.Manual;
			frmLog.Width = Width - frmConnection.Width - 2 * t;
			frmLog.Location = new Point(0, Height - frmLog.Height - statusStrip.Height - 2 * t);

			frmRawMsms.StartPosition = FormStartPosition.Manual;
			frmRawMsms.Location = new Point(0, 0);

			frmNewAutoMsm.StartPosition = FormStartPosition.Manual;
			frmNewAutoMsm.Location = new Point(10, 10);
		}

		public override void UpdateLang() {
			miFile.Text = i18n.str("File");
			miExit.Text = i18n.str("Exit");
			miMode.Text = i18n.str("Mode");
			miModeManual.Text = i18n.str("ManualControl");
			miModeInactive.Text = i18n.str("MenuModeInactiveReadyScan");
			miEdit.Text = i18n.str("Edit");
			miView.Text = i18n.str("View");
			miLanguage.Text = i18n.str("Language");
			miHelp.Text = i18n.str("Help");
			miManualControl.Text = i18n.str("ManualControl");
			miManualControlActivate.Text = i18n.str("Activate");
			miManualControlDeactivate.Text = i18n.str("Deactivate");
			miManualControlStartNewSeries.Text = i18n.str("StartNewSeries");
			miManualControlSaveSeriesInst.Text = i18n.str("SaveInstantSeries");
			miManualControlSaveSeriesAvg.Text = i18n.str("SaveAvgSeries");
			miTools.Text = i18n.str("Tools");
			miSettings.Text = i18n.str("Settings");
			miNewAutoMsm.Text = i18n.str("NewAutoMsm");
			miViewConnection.Text = i18n.str("Connection");
			miViewManualControl.Text = i18n.str("ManualControl");
			miViewRawMsms.Text = i18n.str("RawMsms");
			miViewStatus.Text = i18n.str("StatusBar");
			miViewLog.Text = miLog.Text = i18n.str("Log");
			miLogShow.Text = i18n.str("Show");
			miLogHide.Text = i18n.str("Hide");
			miLogClearAll.Text = i18n.str("ClearAll");
			miShowHideDebug.Text = i18n.str("ShowHideDebug");
			miSaveLogAs.Text = i18n.str("SaveLogAs");
			miViewModels.Text = i18n.str("Models");

			foreach(Form f in MdiChildren) {
				if(f is FormChild) {
					(f as FormChild).UpdateLang();
				} else throw new NotImplementedException("Form not localizable: " + f.Text + " - " + f.GetType().FullName);
			}
		}

		private void OpenFile(object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if(openFileDialog.ShowDialog(this) == DialogResult.OK) {
				string FileName = openFileDialog.FileName;
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) {
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if(saveFileDialog.ShowDialog(this) == DialogResult.OK) {
				string FileName = saveFileDialog.FileName;
			}
		}

		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e) {
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e) {
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e) {
		}

		private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e) {
			statusStrip.Visible = miViewStatus.Checked;
		}

		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) {
			LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) {
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) {
			foreach(Form childForm in MdiChildren) {
				childForm.Hide();
			}
		}

		private void miManualControl_Click(object sender, EventArgs e) {
			frmManualControl.Show();
		}

		private void miAbout_Click(object sender, EventArgs e) {
			frmAbout.ShowDialog(this);
		}

		private void miEnglish_Click(object sender, EventArgs e) {
			i18n.CurrLang = "en";
			UpdateLang();
		}

		private void miSpanish_Click(object sender, EventArgs e) {
			i18n.CurrLang = "es";
			UpdateLang();
		}

		private void miFrench_Click(object sender, EventArgs e) {
			i18n.CurrLang = "fr";
			UpdateLang();
		}

		private void miLog_Click(object sender, EventArgs e) {
			frmLog.Show();
		}

		/// <summary>
		/// Update GUI to show connection status and current scanner mode
		/// </summary>
		public void UpdateStatus() {
			if(Scanner.Status == Status.Connected) {
				if(Scanner.Authenticated) {
					tsStatus.Text = i18n.str("Connected") + " (" + i18n.str("Mode" + Scanner.Mode) + ")";
					tsStatus.ForeColor = Color.Green;
				} else {
					tsStatus.Text = i18n.str("ConnectedNotAuth");
					tsStatus.ForeColor = Color.Magenta;
				}
			} else {
				tsStatus.Text = i18n.str("Disconnected");
				tsStatus.ForeColor = Color.Red;
			}
			frmConnection.UpdateStatus();
			frmManualControl.UpdateStatus();
			frmManualControl.Usable = (Scanner.Status == Status.Connected && Scanner.Mode == ScannerMode.Manual);
			frmNewAutoMsm.Usable = (Scanner.Status == Status.Connected && Scanner.Mode == ScannerMode.Inactive);
			miMode.Enabled = (Scanner.Status == Status.Connected);
		}

		private void FrmMdiParent_FormClosing(object sender, FormClosingEventArgs e) {
			Properties.Settings.SaveAllSettings();
			Scanner.Disconnect();
			foreach(Form childForm in MdiChildren) {
				childForm.Close();
			}
			Environment.Exit(0);
		}

		public void SetReceivedManualValue(UInt16 value) {
			frmManualControl.SetReceivedManualValue(value);
		}

		public void SetReceivedAutoValue(UInt16 CcpServoH, UInt16 CcpServoV, UInt16 adcValue) {
			frmNewAutoMsm.SetReceivedAutoValue(CcpServoH, CcpServoV, adcValue);
		}

		private void miModeManual_Click(object sender, EventArgs e) {
			Scanner.SetMode(ScannerMode.Manual);
		}

		private void miConnection_Click(object sender, EventArgs e) {
			frmConnection.Show();
		}

		private void miWindowsDefaultPos_Click(object sender, EventArgs e) {
			SetMdiChildrenDefaultLocations();
		}

		private void miModeInactive_Click(object sender, EventArgs e) {
			Scanner.SetMode(ScannerMode.Inactive);
		}

		private void miLogClearAll_Click(object sender, EventArgs e) {
			frmLog.txtLog.Clear();
		}

		private void miLogShow_Click(object sender, EventArgs e) {
			miLog_Click(null, null);
		}

		private void miLogHide_Click(object sender, EventArgs e) {
			frmLog.Hide();
		}

		private void miLogSaveRTF_Click(object sender, EventArgs e) {
			SaveFileDialog svf = new SaveFileDialog();

			svf.DefaultExt = "*.rtf";
			svf.Filter = "RTF Files|*.rtf";

			if(svf.ShowDialog() == System.Windows.Forms.DialogResult.OK && svf.FileName.Length > 0) {
				frmLog.txtLog.SaveFile(svf.FileName, RichTextBoxStreamType.RichText);
			}
		}

		private void miLogSaveTxt_Click(object sender, EventArgs e) {
			SaveFileDialog svf = new SaveFileDialog();

			svf.DefaultExt = "*.txt";
			svf.Filter = "Plain Text Files|*.txt";

			if(svf.ShowDialog() == System.Windows.Forms.DialogResult.OK && svf.FileName.Length > 0) {
				frmLog.txtLog.SaveFile(svf.FileName, RichTextBoxStreamType.PlainText);
			}
		}

		private void miLogSaveUnicode_Click(object sender, EventArgs e) {
			SaveFileDialog svf = new SaveFileDialog();

			svf.DefaultExt = "*.txt";
			svf.Filter = "Plain Text Files|*.txt";

			if(svf.ShowDialog() == System.Windows.Forms.DialogResult.OK && svf.FileName.Length > 0) {
				frmLog.txtLog.SaveFile(svf.FileName, RichTextBoxStreamType.UnicodePlainText);
			}
		}

		private void miShowHideDebug_Click(object sender, EventArgs e) {
			Settings.Default.PrintDebugLogs = !Settings.Default.PrintDebugLogs;
		}

		private void miOptions_Click(object sender, EventArgs e) {
			frmSettings.Show();
		}

		private void miManualControlActivate_Click(object sender, EventArgs e) {
			miModeManual_Click(null, null);
		}

		private void miManualControlDeactivate_Click(object sender, EventArgs e) {
			miModeInactive_Click(null, null);
		}

		private void nSStartNewSeriesToolStripMenuItem_Click(object sender, EventArgs e) {
			frmManualControl.SetupNewSeries();
		}

		public void miManualControlSaveSeriesInst_Click(object sender, EventArgs e) {
			SaveRawMsm(frmManualControl.rawMsm);
		}

		/// <summary>
		/// Ask where to save a raw measurement and save it
		/// </summary>
		/// <param name="rawMeasurement">The RAW Measurement</param>
		/// <returns>True if successful. False otherwise</returns>
		public bool SaveRawMsm(RawMeasurement rawMeasurement) {
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.FileName = rawMeasurement.Name + "." + Settings.Default.RawMsmExtension;
			sfd.Filter = Settings.Default.RawMsmFileFilter;
			sfd.Title = rawMeasurement.Name;

			if(sfd.ShowDialog(this) == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName)) {
				rawMeasurement.Save(sfd.FileName);
				RawMeasurement.OpenRawMsm(sfd.FileName);
				/*frmRawMsms.Show();
				frmRawMsms.BringToFront();
				frmRawMsms.Update();*/
				return true;
			} else return false;
		}

		public void OpenRawMsm() {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.FileName = "*." + Settings.Default.RawMsmExtension;
			ofd.Filter = Settings.Default.RawMsmFileFilter;

			if(ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName)) {
				RawMeasurement.OpenRawMsm(ofd.FileName);
			}
		}

		public void OpenModel3D() {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.FileName = "*." + Settings.Default.ModelExtension;
			ofd.Filter = Settings.Default.ModelFileFilter;

			if(ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName)) {
				Model3D.OpenModel(ofd.FileName);
			}
		}

		public void miManualControlSaveSeriesAvg_Click(object sender, EventArgs e) {
			SaveRawMsm(frmManualControl.rawMsmAvg);
		}

		internal void UpdateListOpenRawMsms() {
			frmRawMsms.UpdateListOpenRawMsms();
		}

		internal void UpdateListOpenModels() {
			frmModels3D.UpdateListOpenModels();
		}

		private void miViewRawMsms_Click(object sender, EventArgs e) {
			frmRawMsms.Show();
		}

		private void nSNewAutoMsmToolStripMenuItem_Click(object sender, EventArgs e) {
			frmNewAutoMsm.Show();
		}

		private void miViewModels_Click(object sender, EventArgs e) {
			frmModels3D.Show();
		}
	}
}
