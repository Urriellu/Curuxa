using System;
using System.Windows.Forms;
using SWF = System.Windows.Forms;

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

		/*void Log(string Text) {
			string LogText = string.Format("[{0:00}:{1:00}:{2:00}.{3:000}] {4}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond, Text);
			TxtLog.AppendText(LogText);
			Global.Log(Text);
		}*/

		private void MainWindow_Load(object sender, EventArgs e) {
			//default values
			UpdateConnectionStatus();
			TxtLog.Clear();

			ConnectionTimer.Tick += new EventHandler(ConnectionTimer_Tick);
			ConnectionTimer.Interval = 1000;
			ConnectionTimer.Start();
		}

		private void UpdateConnectionStatus() {
			switch(Communication.Status) {
				case Status.Connected:
					LblConnStatus.Text = "Connected";
					break;
				case Status.Disconnected:
					LblConnStatus.Text = "Disconnected";
					break;
				default:
					throw new NotImplementedException();
			}
		}

		private void FrmMainWindow_Leave(object sender, EventArgs e) {
			ConnectionTimer.Stop();
			ConnectionTimer.Dispose();
			ConnectionTimer = null;
			Communication.Disconnect();
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
	}
}
