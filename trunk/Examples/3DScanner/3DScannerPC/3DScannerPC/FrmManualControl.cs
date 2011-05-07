﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _3DScannerPC.Properties;
using ZedGraph;

namespace _3DScannerPC {
	public partial class FrmManualControl:FormChild {
		UInt16 lastValueAdc;
		float lastVoltage;
		float lastDistance_mm;
		float lastDistance_mm_slowChange;
		float lastDistance_cm;
		double lastDistance_cm_2dig;
		float lastDegH;
		float lastDegV;
		DateTime lastPosChange = DateTime.Now;

		bool graphModified = false;
		PointPairList graphPtInst = new PointPairList();
		LineItem curveInst;
		Timer tmrUpdtGraph;
		DateTime graphStartTime = DateTime.Now;

		public FrmManualControl() {
			InitializeComponent();

			ignoreUsableControls.Add(grpSetup);
			ignoreUsableControls.Add(btnActivateManual);
			ignoreUsableControls.Add(btnDeactManual);
		}

		private void FrmManualControl_Load(object sender, EventArgs e) {
			UpdateLang();

			UpdateServoRanges();

			UpdateStatus();

			//setup graph
			graph.GraphPane.Title.Text = "TITLE NOT SET";
			graph.GraphPane.XAxis.Title.Text = "TITLE AXIS X";
			graph.GraphPane.XAxis.Scale.Min = 0;
			graph.GraphPane.YAxis.Title.Text = "TITLE AXIS Y [cm]";
			graph.GraphPane.YAxis.Scale.Min = 0;
			graph.GraphPane.YAxis.Scale.Max = 80;
			curveInst = graph.GraphPane.AddCurve("NS (Instant Value)", graphPtInst, Color.Blue, SymbolType.Circle);
			UpdateGraph();

			//setup timer for updating the graph
			tmrUpdtGraph = new Timer();
			tmrUpdtGraph.Interval = 1000;
			tmrUpdtGraph.Tick += new EventHandler(tmrUpdtGraph_Tick);
			tmrUpdtGraph.Start();
		}

		public void UpdateServoRanges() {
			//set ranges for servos
			manualControlH.SetRange(Servo.H.Duty0deg, Servo.H.Duty180deg);
			manualNumControlH.Minimum = Servo.H.Duty0deg;
			manualNumControlH.Maximum = Servo.H.Duty180deg;
			manualNumControlH.Value = manualControlH.Value = Servo.H.Duty90deg;

			manualControlV.SetRange(Servo.V.Duty0deg, Servo.V.Duty180deg);
			manualNumControlV.Minimum = Servo.V.Duty0deg;
			manualNumControlV.Maximum = Servo.V.Duty180deg;
			manualNumControlV.Value = manualControlV.Value = Servo.V.Duty90deg;
		}

		void tmrUpdtGraph_Tick(object sender, EventArgs e) {
			if(graphModified) UpdateGraph();
		}

		ScannerMode prevStatus = ScannerMode.Inactive;

		public void UpdateStatus() {
			btnActivateManual.Enabled = Scanner.Mode == ScannerMode.Inactive;
			btnDeactManual.Enabled = Scanner.Mode == ScannerMode.Manual;

			if(prevStatus != ScannerMode.Manual && Scanner.Mode == ScannerMode.Manual) {
				//we just entered manual mode
				graphPtInst.Clear();
				graphStartTime = DateTime.Now;
				UpdateServoRanges();
			}

			prevStatus = Scanner.Mode;
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
			if(Scanner.Mode == ScannerMode.Manual && (DateTime.Now - lastPosChange).TotalMilliseconds > Settings.Default.SendDelayThreshold) {
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
			if(Scanner.Mode == ScannerMode.Manual && (DateTime.Now - lastPosChange).TotalMilliseconds > Settings.Default.SendDelayThreshold) {
				if(manualControlV.Value <= 0 || manualControlV.Value > UInt16.MaxValue || manualControlV.Value > 12000) throw new Exception("Wrong implementation");
				Scanner.SetManualPosVduty((UInt16)manualControlV.Value);
				lastPosChange = DateTime.Now;
			}
		}

		public void SetReceivedManualValue(UInt16 adcValue) {
			lastValueAdc = adcValue;
			UpdateReceivedValues();

			//add instant position to graph
			graphPtInst.Add((DateTime.Now-graphStartTime).TotalSeconds, lastDistance_cm);
			graphModified = true;
		}

		private void UpdateReceivedValues() {
			lastVoltage = Measure.AdcValueToVoltage(lastValueAdc, Settings.Default.AdcMax, (float)numVRefMax.Value);
			lastDistance_mm = Measure.VoltageToDistance(lastVoltage);
			lastDistance_cm = lastDistance_mm / 10;
			lastDistance_cm_2dig = Math.Round(lastDistance_cm, 2);
			if(float.IsInfinity(lastDistance_mm_slowChange)) lastDistance_mm_slowChange = lastDistance_mm;
			lastDistance_mm_slowChange = (float)(lastDistance_mm_slowChange * 0.2 + lastDistance_mm * 0.8);

			lblReceivedValue.Text = i18n.str("recManualValue", lastValueAdc, Settings.Default.AdcMax);
			lblReceivedVoltage.Text = i18n.str("recManualVoltage", lastVoltage, numVRefMax.Value, Settings.Default.AdcMax);
			lblReceivedDistance.Text = i18n.str("recManualDistance", lastDistance_mm);

			// change position of object drawn on screen
			int picObjBorders = 10;
			int picObjMinPosX = picView.Location.X + picView.Width + picObjBorders;
			int picObjMaxPoxX = grpClosestObj.Width - picObjBorders;
			int picObjPosXRange = picObjMaxPoxX - picObjMinPosX;
			float distancePorc = lastDistance_mm_slowChange / 700;
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

		/// <summary>
		/// Redibuja la gráfica (debe llamarse tras modificar cualquier dato)
		/// </summary>
		private void UpdateGraph() {
			graph.Invalidate();
			graph.AxisChange();
			graph.Update();
			graphModified = false;
		}
	}
}
