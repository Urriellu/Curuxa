using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3DScannerPC {
	public partial class FrmMdiParent:FormChild {
		FrmAbout frmAbout = new FrmAbout();
		FrmManualControl frmManualControl;
		FrmConnection frmConnection;
		public FrmLog frmLog;

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

			SetMdiChildrenDefaultLocations();

			UpdateLang();

			frmManualControl.Show();
			frmLog.Show();
			frmConnection.Show();

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
			statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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

		/*/// <summary>
		/// Update GUI to show connection status
		/// </summary>
		public void ShowConnectionStatus(Status st) {
			if(st == Status.Connected) {
				tsStatus.Text = i18n.str("Connected");
				tsStatus.ForeColor = Color.Green;
			} else {
				tsStatus.Text = i18n.str("Disconnected");
				tsStatus.ForeColor = Color.Red;
			}
		}*/

		/// <summary>
		/// Update GUI to show connection status and current scanner mode
		/// </summary>
		public void UpdateStatus() {
			if(Scanner.Status == Status.Connected) {
				tsStatus.Text = i18n.str("Connected") + " (" + i18n.str("Mode" + Scanner.ScannerMode) + ")";
				tsStatus.ForeColor = Color.Green;
			} else {
				tsStatus.Text = i18n.str("Disconnected");
				tsStatus.ForeColor = Color.Red;
			}
			frmConnection.UpdateStatus();
			frmManualControl.Usable = (Scanner.Status == Status.Connected && Scanner.ScannerMode == ScannerMode.Manual);
			miMode.Enabled = (Scanner.Status == Status.Connected);
		}

		private void FrmMdiParent_FormClosing(object sender, FormClosingEventArgs e) {
			Scanner.Disconnect();
			foreach(Form childForm in MdiChildren) {
				childForm.Close();
			}
			Environment.Exit(0);
		}

		public void SetReceivedManualValue(UInt16 value) {
			frmManualControl.SetReceivedManualValue(value);
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
	}
}
