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
	public partial class FrmSettings:FormChild {
		public FrmSettings() {
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e) {
			Hide();
		}

		private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = true;
			Hide();
		}

		private void FrmSettings_Load(object sender, EventArgs e) {
			LoadSettings();
		}

		private void LoadSettings() {
			cbReqAuth.Checked = Settings.Default.RequireAuthentication;
			cbPrintDebugLogs.Checked = Settings.Default.PrintDebugLogs;
			nbScannerId.Value = Settings.Default.ScannerID;
			nbTimeChangesThres.Value = Settings.Default.SendDelayThreshold;
			nbAdcMaxVal.Value = Settings.Default.AdcMax;
			nbT1preload.Value = Settings.Default.T1preload;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e) {
			Settings.Default.RequireAuthentication = cbReqAuth.Checked;
		}

		private void cbPrintDebugLogs_CheckedChanged(object sender, EventArgs e) {
			Settings.Default.PrintDebugLogs = cbPrintDebugLogs.Checked;
		}

		private void nbScabberId_ValueChanged(object sender, EventArgs e) {
			Settings.Default.ScannerID = (byte)nbScannerId.Value;
		}

		private void nbTimeChangesThres_ValueChanged(object sender, EventArgs e) {
			Settings.Default.SendDelayThreshold = (int)nbTimeChangesThres.Value;
		}

		private void nbAdcMaxVal_ValueChanged(object sender, EventArgs e) {
			Settings.Default.AdcMax = (int)nbAdcMaxVal.Value;
		}

		private void nbT1preload_ValueChanged(object sender, EventArgs e) {
			Settings.Default.T1preload = (UInt16)nbT1preload.Value;
		}
	}
}
