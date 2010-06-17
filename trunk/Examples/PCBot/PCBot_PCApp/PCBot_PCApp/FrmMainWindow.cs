using System;
using System.Windows.Forms;
using SWF = System.Windows.Forms;
using System.Drawing;

namespace PCBot_PCApp {
	public partial class FrmMainWindow:Form {
		/// <summary>
		/// Timer which tries to reconnect after a connection problem
		/// </summary>
		SWF.Timer ConnectionTimer = new SWF.Timer();

		public FrmMainWindow() {
			InitializeComponent();
			Global.MainWindow = this;
		}

		void ConnectionTimer_Tick(object sender, EventArgs e) {
			if(Communication.Status == Status.Disconnected) Communication.Connect();
		}

		public void SetConnectionStatus(Status st) {
			switch(st) {
				case Status.Connected:
					LblConnStatus.Text = "Connected";
					LblConnStatus.ForeColor = Color.Green;
					break;
				case Status.Disconnected:
					LblConnStatus.Text = "Disconnected";
					LblConnStatus.ForeColor = Color.Red;
					break;
				default:
					throw new NotImplementedException();
			}
		}

		public void SetBumperStatus(ControlByteBumper BumperStatus) {
			switch(BumperStatus) {
				case ControlByteBumper.FrontLeftPressed:
					ImgBumperFrontLeft.Show();
					break;
				case ControlByteBumper.FrontLeftReleased:
					ImgBumperFrontLeft.Hide();
					break;
				case ControlByteBumper.FrontRightPressed:
					ImgBumperFrontRight.Show();
					break;
				case ControlByteBumper.FrontRightReleased:
					ImgBumperFrontRight.Hide();
					break;
				default:
					Global.Log("Unknown bumper status: " + BumperStatus.ToString());
					break;
			}
		}

		private void MainWindow_Load(object sender, EventArgs e) {
			// set default values and messages
			SetConnectionStatus(Communication.Status);
			ImgBumperFrontLeft.Hide();
			ImgBumperFrontRight.Hide();
			ImgLightFrontLeftOff.BringToFront();
			ImgLightFrontRightOff.BringToFront();

			ConnectionTimer.Tick += new EventHandler(ConnectionTimer_Tick);
			ConnectionTimer.Interval = 1000;
			ConnectionTimer.Start();
		}

		private void BtnLightFrontLeftOn_Click(object sender, EventArgs e) {
			Global.Log("Turning ON front left light");
			ImgLightFrontLeftOn.BringToFront();
			Communication.SetLight(ControlByteLight.FrontLeftOn);
		}

		private void BtnLightFrontLeftOff_Click(object sender, EventArgs e) {
			Global.Log("Turning OFF front left light");
			ImgLightFrontLeftOff.BringToFront();
			Communication.SetLight(ControlByteLight.FrontLeftOff);
		}

		private void FrmMainWindow_FormClosed(object sender, FormClosedEventArgs e) {
			ConnectionTimer.Stop();
			ConnectionTimer.Dispose();
			ConnectionTimer = null;
			Communication.Disconnect();
		}

		private void BtnAbout_Click(object sender, EventArgs e) {
			FrmAbout f = new FrmAbout();
			f.ShowDialog(this);
		}

		private void BtnLightFrontRightOn_Click(object sender, EventArgs e) {
			Global.Log("Turning ON front right light");
			ImgLightFrontRightOn.BringToFront();
			Communication.SetLight(ControlByteLight.FrontRightOn);
		}

		private void BtnLightFrontRightOff_Click(object sender, EventArgs e) {
			Global.Log("Turning OFF front right light");
			ImgLightFrontRightOff.BringToFront();
			Communication.SetLight(ControlByteLight.FrontRightOff);
		}

		private void BtnLightFrontOn_Click(object sender, EventArgs e) {
			BtnLightFrontLeftOn.PerformClick();
			BtnLightFrontRightOn.PerformClick();
		}

		private void BtnLightFrontOff_Click(object sender, EventArgs e) {
			BtnLightFrontLeftOff.PerformClick();
			BtnLightFrontRightOff.PerformClick();
		}
	}
}
