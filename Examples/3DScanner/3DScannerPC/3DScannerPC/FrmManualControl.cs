using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3DScannerPC {
	public partial class FrmManualControl:Form, ILocalizable {
		UInt16 value;

		public FrmManualControl() {
			InitializeComponent();
		}

		private void FrmManualControl_Load(object sender, EventArgs e) {
			UpdateLang();
		}

		public void UpdateLang() {
			this.Text = i18n.str("ManualControl");
			lblRecvTitle.Text = i18n.str("recManualTitle");
			SetReceivedManualValue(0);
		}

		private void FrmManualControl_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = true;
			Hide();
		}

		private void manualNumControlH_ValueChanged(object sender, EventArgs e) {
			manualControlH.Value = (int)manualNumControlH.Value;
		}

		private void manualControlH_Scroll(object sender, EventArgs e) {
			manualNumControlH.Value = manualControlH.Value;
		}


		private void manualNumControlV_ValueChanged(object sender, EventArgs e) {
			manualControlV.Value = (int)manualNumControlV.Value;
		}

		private void manualControlV_Scroll(object sender, EventArgs e) {
			manualNumControlV.Value = manualControlV.Value;
		}

		public void SetReceivedManualValue(UInt16 value) {
			this.value = value;
			UpdateReceivedValues();
		}

		private void UpdateReceivedValues() {
			lblReceivedValue.Text = i18n.str("recManualValue", value, Settings.AdcMax);
			float voltage = Measure.AdcValueToVoltage(value, Settings.AdcMax, (float)numVRefMax.Value);
			lblReceivedVoltage.Text = i18n.str("recManualVoltage", voltage, numVRefMax.Value, Settings.AdcMax);
			float distance = Measure.VoltageToDistance(voltage);
			lblReceivedDistance.Text = i18n.str("recManualDistance", distance);
		}

		private void numVRefMax_ValueChanged(object sender, EventArgs e) {
			UpdateReceivedValues();
		}
	}
}
