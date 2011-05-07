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
			Settings.Default.Save();
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
			numDutyH0.Value = Servo.H.Duty0deg;
			numDutyH180.Value = Servo.H.Duty180deg;
			numDutyV0.Value = Servo.V.Duty0deg;
			numDutyV180.Value = Servo.V.Duty180deg;
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

		private void numDutyH0_ValueChanged(object sender, EventArgs e) {
			Servo.H.Duty0deg = (UInt16)numDutyH0.Value;
		}

		private void numDutyH180_ValueChanged(object sender, EventArgs e) {
			Servo.H.Duty180deg = (UInt16)numDutyH180.Value;
		}

		private void numDutyV0_ValueChanged(object sender, EventArgs e) {
			Servo.V.Duty0deg = (UInt16)numDutyV0.Value;
		}

		private void numDutyV180_ValueChanged(object sender, EventArgs e) {
			Servo.V.Duty180deg = (UInt16)numDutyV180.Value;
		}
	}
}
