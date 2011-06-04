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
	public partial class FrmRawMsms:FormChild {
		/* listMsms
		 * Key: file to the RawMeasurement
		 * Value: Name of RawMeasurement
		 */

		/// <summary>
		/// Collection that relates each ListViewItem in the ListView "listMsms" (which contains the list of open RawMeasurements) and the string to the file where they are stored
		/// </summary>
		Dictionary<ListViewItem, string> listedRawMsms = new Dictionary<ListViewItem, string>();

		/// <summary>
		/// File for the current select RAW Measurement
		/// </summary>
		string selRawMsmFile = null;

		RawMeasurement selRawMsm {
			get {
				return RawMeasurement.KnownRMs[selRawMsmFile];
			}
		}

		public FrmRawMsms() {
			InitializeComponent();
		}

		private void FrmRawMsms_Load(object sender, EventArgs e) {
			//clear development stuff
			lstPoints.Items.Clear();

			UpdateLang();

			//show the currently open RAW Measurements
			UpdateListOpenRawMsms();

			//and update the data
			UpdateShownDataOneMsm();
		}

		public override void UpdateLang() {
			this.Text = i18n.str("RawMsms");
			lblName.Text = i18n.str("Name") + ":";
			lblDateTitle.Text = i18n.str("Date") + ":";
			lblBaseLoc.Text = i18n.str("BaseLocation") + ":";
			lblBaseRot.Text = i18n.str("BaseRotation") + ":";
			btnOpen.Text = i18n.str("Open");
			btnRemove.Text = i18n.str("Remove");
		}

		/// <summary>
		/// Shows on the form all the data for the selected RAW Measurement
		/// </summary>
		private void UpdateShownDataOneMsm() {
			if(string.IsNullOrEmpty(selRawMsmFile)) {
				//no RAW Measurement selected
				splitMain.Panel2.Enabled = false;
			} else {
				splitMain.Panel2.Enabled = true;
				txtName.Text = selRawMsm.Name;
				numVRef.Value = (decimal)selRawMsm.VRef;
				numAdcMax.Value = selRawMsm.AdcMax;
				lblDateValue.Text = selRawMsm.Date.NormalDateTime();
				numBaseLocX.Value = (decimal)selRawMsm.BaseLocation.X;
				numBaseLocY.Value = (decimal)selRawMsm.BaseLocation.Y;
				numBaseLocZ.Value = (decimal)selRawMsm.BaseLocation.Z;
				numBaseRot.Value = (decimal)selRawMsm.BaseRotation;

				//create new depth graph
				float mmMin = selRawMsm.Closest.Distance_mm;
				float mmMax = selRawMsm.Farthest.Distance_mm;
				picBox.Image = new Bitmap((int)(selRawMsm.HRangeDeg + 2), (int)(selRawMsm.VRangeDeg + 2), System.Drawing.Imaging.PixelFormat.Format32bppRgb);

				lstPoints.Items.Clear();
				for(int i = 0; i < selRawMsm.Count; i++) {
					RawMeasuredPoint p = selRawMsm[i];
					ListViewItem lvi = new ListViewItem(i.ToString());
					lvi.SubItems.Add(p.ServoHdeg.ToString());
					lvi.SubItems.Add(p.ServoVdeg.ToString());
					lvi.SubItems.Add(p.DistanceAdcValue.ToString());
					lvi.SubItems.Add(p.DistanceVolts.ToString());
					lvi.SubItems.Add(p.Distance_mm.ToString());
					lstPoints.Items.Add(lvi);

					//add point to depth graph
					int colorScale = (int)((p.Distance_mm - mmMin) * 255 / (mmMax - mmMin));
					Color pointColor = Color.FromArgb(255 - colorScale, 255 - colorScale, 255);
					(picBox.Image as Bitmap).SetPixel(picBox.Image.Width - (int)(p.ServoHdeg - selRawMsm.RightMost.ServoHdeg) - 1, (int)(p.ServoVdeg - selRawMsm.Highest.ServoVdeg), pointColor);
				}
			}
		}

		private void btnOpen_Click(object sender, EventArgs e) {
			Globals.MainWindow.OpenRawMsm();
		}

		private void btnRemove_Click(object sender, EventArgs e) {
			RawMeasurement.CloseRawMwm(selRawMsmFile);
		}

		public void UpdateListOpenRawMsms() {
			lstMsms.Clear();
			listedRawMsms.Clear();
			foreach(var rm in RawMeasurement.KnownRMs) {
				ListViewItem lvi = new ListViewItem(rm.Value.Name);
				lstMsms.Items.Add(lvi);
				listedRawMsms.Add(lvi, rm.Key);
				lstMsms.SelectedItems.Clear();
			}
		}

		private void listMsms_SelectedIndexChanged(object sender, EventArgs e) {
			if(lstMsms.SelectedItems.Count > 0) {
				//item selected
				selRawMsmFile = listedRawMsms[lstMsms.SelectedItems[0]];
			} else {
				//no items selected
				selRawMsmFile = null;
			}
			UpdateShownDataOneMsm();
		}

		private void FrmRawMsms_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = true;
			Hide();
		}
	}
}
