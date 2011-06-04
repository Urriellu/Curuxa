using System;
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
		/// <summary>
		/// Number of points to make the average to show the object moving
		/// </summary>
		const int PointAvgObj = 5;

		public RawMeasurement rawMsm;
		public RawMeasurement rawMsmAvg;

		float lastDegH;
		float lastDegV;
		DateTime lastPosHChange = new DateTime(2000, 1, 1);
		DateTime lastPosVChange = new DateTime(2000, 1, 1);

		bool graphModified = false;
		PointPairList graphPtInst = new PointPairList();
		PointPairList graphPtAvg = new PointPairList();
		LineItem curveInst;
		LineItem curveAvg;
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
			curveInst = graph.GraphPane.AddCurve("NS (Instant Value)", graphPtInst, Color.Red, SymbolType.Circle);
			curveAvg = graph.GraphPane.AddCurve("NS (Average Value)", graphPtAvg, Color.Blue, SymbolType.Circle);
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
				SetupNewSeries();
			}

			prevStatus = Scanner.Mode;
		}

		/// <summary>
		/// Setup a new series of measurements
		/// </summary>
		public void SetupNewSeries() {
			string newName = "ManualControl " + DateTime.Now.ShortDate() + " " + DateTime.Now.ShortTime();
			string newNameAvg = "ManualControlAvg " + DateTime.Now.ShortDate() + " " + DateTime.Now.ShortTime();
			rawMsm = new RawMeasurement(newName, (float)numVRefMax.Value, (UInt16)numAdcMax.Value);
			rawMsmAvg = new RawMeasurement(newNameAvg, (float)numVRefMax.Value, (UInt16)numAdcMax.Value);
			graphPtInst.Clear();
			graphPtAvg.Clear();
			graphStartTime = DateTime.Now;
			UpdateServoRanges();
			manualControlH_Scroll(null, null);
			manualControlV_Scroll(null, null);
		}

		public override void UpdateLang() {
			this.Text = i18n.str("ManualControl");
			grpInstantValue.Text = i18n.str("recManualTitle");
			grpControlH.Text = i18n.str("ManualControlHtitle");
			grpControlV.Text = i18n.str("ManualControlVtitle");
			grpSetup.Text = i18n.str("Setup");
			lblAvgEvery.Text = i18n.str("AvgEvery");
			lblPoints.Text = i18n.str("points");
			btnActivateManual.Text = i18n.str("Activate");
			btnDeactManual.Text = i18n.str("Deactivate");
			grpClosestObj.Text = i18n.str("ClosestObject");
			grpMeasPoints.Text = i18n.str("MeasuredPoints");
			//SetReceivedManualValue(0);
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
			if(Scanner.Mode == ScannerMode.Manual && (DateTime.Now - lastPosHChange).TotalMilliseconds > Settings.Default.SendDelayThreshold) {
				if(manualControlH.Value <= 0 || manualControlH.Value > UInt16.MaxValue || manualControlH.Value > 12000) throw new Exception("Wrong implementation");
				Scanner.SetManualPosHduty((UInt16)manualControlH.Value);
				lastPosHChange = DateTime.Now;
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
			if(Scanner.Mode == ScannerMode.Manual && (DateTime.Now - lastPosVChange).TotalMilliseconds > Settings.Default.SendDelayThreshold) {
				if(manualControlV.Value <= 0 || manualControlV.Value > UInt16.MaxValue || manualControlV.Value > 12000) throw new Exception("Wrong implementation");
				Scanner.SetManualPosVduty((UInt16)manualControlV.Value);
				lastPosVChange = DateTime.Now;
			}
		}

		public void SetReceivedManualValue(UInt16 adcValue) {
			if(rawMsm == null || rawMsmAvg == null) SetupNewSeries();

			rawMsm.Add(lastDegH, lastDegV, adcValue);
			rawMsmAvg.Add(rawMsm.AvgLastPoints((int)numAvg.Value));
			UpdateReceivedValues();

			//add instant position to graph
			double s = (DateTime.Now - graphStartTime).TotalSeconds;
			graphPtInst.Add(s, rawMsm.Last.Distance_cm);
			graphPtAvg.Add(s, rawMsmAvg.Last.Distance_cm);
			graphModified = true;
		}

		/// <summary>
		/// Update the representation of latest received values
		/// </summary>
		private void UpdateReceivedValues() {
			if(rawMsm.Count > 0) {
				lblReceivedValue.Text = i18n.str("recManualValue", rawMsm.Last.DistanceAdcValue, numVRefMax.Value, numAdcMax.Value);
				lblReceivedVoltage.Text = i18n.str("recManualVoltage", rawMsm.Last.DistanceVolts);
				lblReceivedDistance.Text = float.IsInfinity(rawMsm.Last.Distance_mm) ? " - " : i18n.str("recManualDistance", rawMsm.Last.Distance_mm);

				// change position of object drawn on screen
				int picObjBorders = 10;
				int picObjMinPosX = picView.Location.X + picView.Width + picObjBorders;
				int picObjMaxPoxX = grpClosestObj.Width - picObjBorders;
				int picObjPosXRange = picObjMaxPoxX - picObjMinPosX;
				float distancePorc = rawMsm.AvgLastPoints(PointAvgObj).Distance_mm / 700;
				int picObjNewOffset = (int)(distancePorc * picObjPosXRange);
				picObject.Location = new Point(picObjMinPosX + picObjNewOffset, picView.Location.Y + picView.Height / 2 - picObject.Height / 2);
			}
		}

		private void numVRefMax_ValueChanged(object sender, EventArgs e) {
			rawMsm.VRef = (float)numVRefMax.Value;
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

		private void numAdcMax_ValueChanged(object sender, EventArgs e) {
			rawMsm.AdcMax = (UInt16)numAdcMax.Value;
		}

		private void btnSaveInst_Click(object sender, EventArgs e) {
			Globals.MainWindow.miManualControlSaveSeriesInst_Click(null, null);
		}

		private void btnSaveAvg_Click(object sender, EventArgs e) {
			Globals.MainWindow.miManualControlSaveSeriesAvg_Click(null, null);
		}
	}
}
