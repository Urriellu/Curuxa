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
		UInt16 lastValueAdc;
		float lastVoltage;
		float lastDistance_mm;
		float lastDistance_cm;
		double lastDistance_cm_2dig;
		float lastDegH;
		float lastDegV;
		DateTime lastPosChange = DateTime.Now;

		public FrmManualControl() {
			InitializeComponent();

			ignoreUsableControls.Add(grpSetup);
			ignoreUsableControls.Add(btnActivateManual);
			ignoreUsableControls.Add(btnDeactManual);
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

			UpdateActivDeactivButtons();
		}

		public void UpdateActivDeactivButtons() {
			btnActivateManual.Enabled = Scanner.Mode == ScannerMode.Inactive;
			btnDeactManual.Enabled = Scanner.Mode == ScannerMode.Manual;
		}

		public override void UpdateLang() {
			this.Text = i18n.str("ManualControl");
			grpInstantValue.Text = i18n.str("recManualTitle");
			grpControlH.Text = i18n.str("ManualControlHtitle");
			grpControlV.Text = i18n.str("ManualControlVtitle");
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
			lastDegH = Servo.DutyToDeg((UInt16)manualControlH.Value, ServoID.H);
			lblDegH.Text = i18n.str("DegreesN", lastDegH);

			//send info
			if(Scanner.Mode == ScannerMode.Manual && (DateTime.Now - lastPosChange).TotalMilliseconds > Settings.SendDelayThreshold) {
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
			lastDegV = Servo.DutyToDeg((UInt16)manualControlV.Value, ServoID.V);
			lblDegV.Text = lastDegV + "º";

			//send info
			if(Scanner.Mode == ScannerMode.Manual && (DateTime.Now - lastPosChange).TotalMilliseconds > Settings.SendDelayThreshold) {
				if(manualControlV.Value <= 0 || manualControlV.Value > UInt16.MaxValue || manualControlV.Value > 12000) throw new Exception("Wrong implementation");
				Scanner.SetManualPosVduty((UInt16)manualControlV.Value);
				lastPosChange = DateTime.Now;
			}
		}

		public void SetReceivedManualValue(UInt16 adcValue) {
			lastValueAdc = adcValue;
			UpdateReceivedValues();
		}

		private void UpdateReceivedValues() {
			lastVoltage = Measure.AdcValueToVoltage(lastValueAdc, Settings.AdcMax, (float)numVRefMax.Value);
			lastDistance_mm = Measure.VoltageToDistance(lastVoltage);
			lastDistance_cm = lastDistance_mm / 10;
			lastDistance_cm_2dig = Math.Round(lastDistance_cm, 2);

			lblReceivedValue.Text = i18n.str("recManualValue", lastValueAdc, Settings.AdcMax);
			lblReceivedVoltage.Text = i18n.str("recManualVoltage", lastVoltage, numVRefMax.Value, Settings.AdcMax);
			lblReceivedDistance.Text = i18n.str("recManualDistance", lastDistance_mm);

			// change position of object drawn on screen
			int picObjBorders = 10;
			int picObjMinPosX = picView.Location.X + picView.Width + picObjBorders;
			int picObjMaxPoxX = grpClosestObj.Width - picObjBorders;
			int picObjPosXRange = picObjMaxPoxX - picObjMinPosX;
			float distancePorc = lastDistance_cm / 70;
			int picObjNewOffset = (int)(distancePorc * picObjPosXRange);
			picObject.Location = new Point(picObjMinPosX+picObjNewOffset, picView.Location.Y + picView.Height / 2 - picObject.Height / 2);
		}

		private void numVRefMax_ValueChanged(object sender, EventArgs e) {
			UpdateReceivedValues();
		}

		private void btnActivateManual_Click(object sender, EventArgs e) {
			Scanner.SetMode(ScannerMode.Manual);
		}

		private void btnDeactManual_Click(object sender, EventArgs e) {
			Scanner.SetMode(ScannerMode.Inactive);
		}
	}
}
