using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3DScannerPC {
	public partial class FrmManualControl:FormChild {
		UInt16 value;
		DateTime lastPosChange = DateTime.Now;

		public FrmManualControl() {
			InitializeComponent();
		}

		private void FrmManualControl_Load(object sender, EventArgs e) {
			UpdateLang();

			//set ranges for servos
			manualControlH.SetRange(Servo.ServoRanges[ServoID.H].Duty0deg, Servo.ServoRanges[ServoID.H].Duty180deg);
			manualNumControlH.Minimum = Servo.ServoRanges[ServoID.H].Duty0deg;
			manualNumControlH.Maximum = Servo.ServoRanges[ServoID.H].Duty180deg;
			manualNumControlH.Value = manualControlH.Value = (Servo.ServoRanges[ServoID.H].Duty180deg + Servo.ServoRanges[ServoID.H].Duty0deg) / 2;

			manualControlV.SetRange(Servo.ServoRanges[ServoID.V].Duty0deg, Servo.ServoRanges[ServoID.V].Duty180deg);
			manualNumControlV.Minimum = Servo.ServoRanges[ServoID.V].Duty0deg;
			manualNumControlV.Maximum = Servo.ServoRanges[ServoID.V].Duty180deg;
			manualNumControlV.Value = manualControlV.Value = (Servo.ServoRanges[ServoID.V].Duty180deg + Servo.ServoRanges[ServoID.V].Duty0deg) / 2;
		}

		public override void UpdateLang() {
			this.Text = i18n.str("ManualControl");
			lblRecvTitle.Text = i18n.str("recManualTitle");
			lblTitleH.Text = i18n.str("ManualControlHtitle");
			lblTitleV.Text = i18n.str("ManualControlVtitle");
			SetReceivedManualValue(0);
		}

		private void FrmManualControl_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = true;
			Hide();
		}

		private void manualNumControlH_ValueChanged(object sender, EventArgs e) {
			manualControlH.Value = (int)manualNumControlH.Value;
			manualControlH_Scroll(null, null);
		}

		private void manualControlH_Scroll(object sender, EventArgs e) {
			manualNumControlH.Value = manualControlH.Value;
			if((DateTime.Now - lastPosChange).TotalMilliseconds > Settings.SendDelayThreshold) {
				if(manualControlH.Value <= 0 || manualControlH.Value > UInt16.MaxValue || manualControlH.Value > 12000) throw new Exception("Wrong implementation");
				Scanner.SetManualPosHduty((UInt16)manualControlH.Value);
				lastPosChange = DateTime.Now;
			}
		}


		private void manualNumControlV_ValueChanged(object sender, EventArgs e) {
			manualControlV.Value = (int)manualNumControlV.Value;
			manualControlV_Scroll(null, null);
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
