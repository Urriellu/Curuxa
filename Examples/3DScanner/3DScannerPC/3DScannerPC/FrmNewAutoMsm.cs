using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3DScannerPC {
	public partial class FrmNewAutoMsm:FormChild {
		TimeSpan elapsedTime = new TimeSpan(0);
		TimeSpan totalTime = new TimeSpan();
		TimeSpan remainingTime {
			get {
				return totalTime - elapsedTime;
			}
		}
		UInt16 pointsToReceiveH = 0;
		UInt16 pointsToReceiveV = 0;
		UInt32 pointsToReceive {
			get {
				return (UInt32)(pointsToReceiveH * pointsToReceiveV * MeasuresPerPoint);
			}
		}
		UInt16 receivedPoints = 0;

		UInt16 MeasuresPerPoint {
			get {
				return (UInt16)numMeasPerPnt.Value;
			}
		}

		public FrmNewAutoMsm() {
			InitializeComponent();
			ignoreUsableControls.Add(btnForceStop);
		}

		private void FrmNewAutoMsm_Load(object sender, EventArgs e) {
			UpdateLang();

			UpdateDefaultValues();
		}

		bool updateSummaries = false;

		private void UpdateDefaultValues() {
			numMinValH.Minimum = numMaxValH.Minimum = Servo.H.Duty0deg;
			numMinValH.Maximum = numMaxValH.Maximum = Servo.H.Duty180deg;
			numMaxValH.Value = Servo.H.DutyFromDeg(120);
			numMinValH.Value = Servo.H.DutyFromDeg(60);

			numMinValV.Minimum = numMaxValV.Minimum = Servo.V.Duty0deg;
			numMinValV.Maximum = numMaxValV.Maximum = Servo.V.Duty180deg;
			numMaxValV.Value = Servo.V.DutyFromDeg(120);
			numMinValV.Value = Servo.V.DutyFromDeg(60);

			updateSummaries = true;
			UpdateHResSummary();
			UpdateVResSummary();
		}

		public override void UpdateLang() {
			this.Text = i18n.str("NewAutoMsm");
			btnStartNewAutoScan.Text = i18n.str("StartNewAutoMsm");
			btnForceStop.Text = i18n.str("ForceStop");
		}

		private void FrmNewAutoMsm_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = true;
			Hide();
		}

		private void numMinValH_ValueChanged(object sender, EventArgs e) {
			if(!updateSummaries) return;

			if(numMinValH.Value > numMaxValH.Value-1) numMinValH.Value = numMaxValH.Value-1;
			UpdateHResSummary();
		}

		private void numMaxValH_ValueChanged(object sender, EventArgs e) {
			if(!updateSummaries) return;

			if(numMaxValH.Value < numMinValH.Value+1) numMaxValH.Value = numMinValH.Value+1;
			UpdateHResSummary();
		}

		private void numMeasPerPnt_ValueChanged(object sender, EventArgs e) {
			if(!updateSummaries) return;

			UpdateHResSummary();
			UpdateVResSummary();
		}

		private void numMinValV_ValueChanged(object sender, EventArgs e) {
			if(!updateSummaries) return;

			if(numMinValV.Value > numMaxValV.Value-1) numMinValV.Value = numMaxValV.Value-1;
			UpdateVResSummary();
		}

		private void numMaxValV_ValueChanged(object sender, EventArgs e) {
			if(!updateSummaries) return;

			if(numMaxValV.Value < numMinValV.Value+1) numMaxValV.Value = numMinValV.Value+1;
			UpdateVResSummary();
		}

		private void numIntervalH_ValueChanged(object sender, EventArgs e) {
			UpdateHResSummary();
		}

		private void numIntervalV_ValueChanged(object sender, EventArgs e) {
			UpdateVResSummary();
		}

		private void CalculateTotalPointsToReceive() {
		}

		private void UpdateHResSummary() {
			UInt16 minDuty = (UInt16)numMinValH.Value;
			UInt16 maxDuty = (UInt16)numMaxValH.Value;
			UInt16 dutyRange = (UInt16)(maxDuty - minDuty);
			pointsToReceiveH = (UInt16)((maxDuty - minDuty) / (UInt16)numIntervalH.Value);
			float minDeg = Servo.H.DutyToDeg(minDuty);
			float maxDeg = Servo.H.DutyToDeg(maxDuty);
			lblSummaryHRes.Text = i18n.str("AutoScanResolutionSummaryH", pointsToReceiveH, minDeg, maxDeg, numMeasPerPnt.Value);
			UpdateTotalTime();
		}

		private void UpdateVResSummary() {
			UInt16 minDuty = (UInt16)numMinValV.Value;
			UInt16 maxDuty = (UInt16)numMaxValV.Value;
			UInt16 dutyRange = (UInt16)(maxDuty - minDuty);
			pointsToReceiveV = (UInt16)((maxDuty - minDuty) / (UInt16)numIntervalV.Value);
			float minDeg = Servo.V.DutyToDeg(minDuty);
			float maxDeg = Servo.V.DutyToDeg(maxDuty);
			lblSummaryVRes.Text = i18n.str("AutoScanResolutionSummaryV", pointsToReceiveV, minDeg, maxDeg);
			UpdateTotalTime();
		}

		private void UpdateTotalTime() {
			totalTime = new TimeSpan(0);
			UInt64 totalSec = (UInt64)(numTimeIntervalMs.Value / 1000 * pointsToReceive);
			while(totalSec>int.MaxValue){
				totalTime += new TimeSpan(0, 0, int.MaxValue);
				totalSec -= int.MaxValue;
			}
			totalTime += new TimeSpan(0, 0, (int)totalSec);
			UpdateResults();
		}

		private void UpdateResults() {
			lblElapsedTime.Text = i18n.str("ElapsedTime") + elapsedTime.NormalTime();
			lblRemainingTime.Text = i18n.str("RemainingTime") + remainingTime.NormalTime();
			lblReceivedXPoints.Text = i18n.str("ReceivedXpointsOfY", receivedPoints, pointsToReceive);
		}

		private void numTimeIntervalMs_ValueChanged(object sender, EventArgs e) {
			UpdateTotalTime();
		}

		private void btnStartNewAutoScan_Click(object sender, EventArgs e) {

		}
	}
}
