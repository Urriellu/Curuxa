using System;
using System.Windows.Forms;
using SWF = System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace PCBot_PCApp {
	public partial class FrmMainWindow:Form {
		SWF.Timer EventsTimer = new SWF.Timer();
		ControlByteBaseMv BaseMvCurrentStatus = ControlByteBaseMv.Stop;
		bool LightFrontLeftON = false;
		bool LightFrontRightON = false;

		public FrmMainWindow() {
			InitializeComponent();
			Global.MainWindow = this;
		}

		public void SetConnectionStatus(Status st) {
			if(st == Status.Connected) {
				LblConnStatus.Text = "Connected";
				LblConnStatus.ForeColor = Color.Green;
			} else {
				LblConnStatus.Text = "Disconnected";
				LblConnStatus.ForeColor = Color.Red;
				SetDefaults();
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

		public void SetBaseMvStatus(ControlByteBaseMv BaseMvStatus) {
			BaseMvCurrentStatus = BaseMvStatus;
			ImgBaseMvFwd.Hide();
			ImgBaseStop.Hide();
			ImgBaseMvBck.Hide();
			ImgBaseTurnL.Hide();
			ImgBaseTurnR.Hide();
			ImgBaseRotateL.Hide();
			ImgBaseRorateR.Hide();
			switch(BaseMvStatus) {
				case ControlByteBaseMv.Forward:
					ImgBaseMvFwd.Show();
					break;
				case ControlByteBaseMv.Stop:
					ImgBaseStop.Show();
					break;
				case ControlByteBaseMv.Backwards:
					ImgBaseMvBck.Show();
					break;
				case ControlByteBaseMv.TurnLeft:
					ImgBaseTurnL.Show();
					break;
				case ControlByteBaseMv.TurnRight:
					ImgBaseTurnR.Show();
					break;
				case ControlByteBaseMv.RotateLeft:
					ImgBaseRotateL.Show();
					break;
				case ControlByteBaseMv.RotateRight:
					ImgBaseRorateR.Show();
					break;
				default:
					Global.Log("Unknown base movement status: " + BaseMvStatus.ToString());
					break;
			}
		}

		private void MainWindow_Load(object sender, EventArgs e) {
			SetConnectionStatus(Status.Disconnected); //it also sets all default values
			Communication.Connect();
			EventsTimer.Tick += new EventHandler(EventsTimer_Tick);
			EventsTimer.Interval = 100;
			EventsTimer.Start();
		}

		private void SetDefaults() {
			ImgBumperFrontLeft.Hide();
			ImgBumperFrontRight.Hide();
			ImgLightFrontLeftOff.BringToFront();
			ImgLightFrontRightOff.BringToFront();
			SetBaseMvStatus(ControlByteBaseMv.Stop);
		}

		private void BtnLightFrontLeftOn_Click(object sender, EventArgs e) {
			Global.Log("Turning ON front left light");
			ImgLightFrontLeftOn.BringToFront();
			Communication.SetLight(ControlByteLight.FrontLeftOn);
			LightFrontLeftON = true;
		}

		private void BtnLightFrontLeftOff_Click(object sender, EventArgs e) {
			Global.Log("Turning OFF front left light");
			ImgLightFrontLeftOff.BringToFront();
			Communication.SetLight(ControlByteLight.FrontLeftOff);
			LightFrontLeftON = false;
		}

		private void FrmMainWindow_FormClosed(object sender, FormClosedEventArgs e) {
			Global.Log("Closing main window");
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
			LightFrontRightON = true;
		}

		private void BtnLightFrontRightOff_Click(object sender, EventArgs e) {
			Global.Log("Turning OFF front right light");
			ImgLightFrontRightOff.BringToFront();
			Communication.SetLight(ControlByteLight.FrontRightOff);
			LightFrontRightON = false;
		}

		private void BtnLightFrontOn_Click(object sender, EventArgs e) {
			BtnLightFrontLeftOn.PerformClick();
			Thread.Sleep(50);
			BtnLightFrontRightOn.PerformClick();
		}

		private void BtnLightFrontOff_Click(object sender, EventArgs e) {
			BtnLightFrontLeftOff.PerformClick();
			Thread.Sleep(50);
			BtnLightFrontRightOff.PerformClick();
		}

		private void BtnBaseMvFwd_Click(object sender, EventArgs e) {
			Communication.SetBaseMv(ControlByteBaseMv.Forward);
		}

		private void BtnBaseMvStop_Click(object sender, EventArgs e) {
			Communication.SetBaseMv(ControlByteBaseMv.Stop);
		}

		private void BtnBaseMvBck_Click(object sender, EventArgs e) {
			Communication.SetBaseMv(ControlByteBaseMv.Backwards);
		}

		private void BtnBaseMvTurnL_Click(object sender, EventArgs e) {
			Communication.SetBaseMv(ControlByteBaseMv.TurnLeft);
		}

		private void BtnBaseMvTurnR_Click(object sender, EventArgs e) {
			Communication.SetBaseMv(ControlByteBaseMv.TurnRight);
		}

		private void BtnBaseMvRotateL_Click(object sender, EventArgs e) {
			Communication.SetBaseMv(ControlByteBaseMv.RotateLeft);
		}

		private void BtnBaseMvRotateR_Click(object sender, EventArgs e) {
			Communication.SetBaseMv(ControlByteBaseMv.RotateRight);
		}

		/// <summary>
		/// Mouse threshold
		/// </summary>
		const int thr = 10;

		/// <summary>
		/// Previous mouse position
		/// </summary>
		Point PrevMouse;

		bool InteractiveMode {
			get {
				return _InteractiveMode;
			}
			set {
				if(value) BtnInteractive.ForeColor = Color.Green;
				else BtnInteractive.ForeColor = Color.Red;
				_InteractiveMode = value;
			}
		}
		bool _InteractiveMode = false;

		void EventsTimer_Tick(object sender, EventArgs e) {
			if(PrevMouse == null) PrevMouse = MousePosition;
			if(InteractiveMode) {
				if(MousePosition.Y < PrevMouse.Y - thr) BaseMvFwd();
				if(MousePosition.Y > PrevMouse.Y + thr) BaseMvBck();
				if(MousePosition.X < PrevMouse.X - thr) BaseMvLeft();
				if(MousePosition.X > PrevMouse.X + thr) BaseMvRight();
			}
			PrevMouse = new Point(MousePosition.X, MousePosition.Y);
		}

		void BaseMvFwd() {
			if(BaseMvCurrentStatus == ControlByteBaseMv.Backwards) BtnBaseMvStop.PerformClick();
			else if(BaseMvCurrentStatus == ControlByteBaseMv.RotateLeft) BtnBaseMvTurnL.PerformClick();
			else if(BaseMvCurrentStatus == ControlByteBaseMv.RotateRight) BtnBaseMvTurnR.PerformClick();
			else BtnBaseMvFwd.PerformClick();
		}

		void BaseMvBck() {
			if(BaseMvCurrentStatus == ControlByteBaseMv.Forward) BtnBaseMvStop.PerformClick();
			else BtnBaseMvBck.PerformClick();
		}

		void BaseMvLeft() {
			if(BaseMvCurrentStatus == ControlByteBaseMv.TurnRight) BtnBaseMvFwd.PerformClick();
			else if(BaseMvCurrentStatus == ControlByteBaseMv.Forward) BtnBaseMvTurnL.PerformClick();
			else if(BaseMvCurrentStatus == ControlByteBaseMv.RotateRight) BtnBaseMvStop.PerformClick();
			else BtnBaseMvRotateL.PerformClick();
		}

		void BaseMvRight() {
			if(BaseMvCurrentStatus == ControlByteBaseMv.TurnLeft) BtnBaseMvFwd.PerformClick();
			else if(BaseMvCurrentStatus == ControlByteBaseMv.Forward) BtnBaseMvTurnR.PerformClick();
			else if(BaseMvCurrentStatus == ControlByteBaseMv.RotateLeft) BtnBaseMvStop.PerformClick();
			else BtnBaseMvRotateR.PerformClick();
		}

		private void BtnInteractive_Click(object sender, EventArgs e) {
			// switch interactive/normal mode
			InteractiveMode = !InteractiveMode;
		}

		private void FrmMainWindow_KeyDown(object sender, KeyEventArgs e) {
			switch(e.KeyCode) {
				case Keys.Escape:
					BtnBaseMvStop.PerformClick();
					break;
				case Keys.F5:
					InteractiveMode = !InteractiveMode;
					break;
				case Keys.L:
				case Keys.Space:
					if(LightFrontLeftON && LightFrontRightON) BtnLightFrontOff.PerformClick();
					else BtnLightFrontOn.PerformClick();
					break;
				case Keys.W:
					BaseMvFwd();
					break;
				case Keys.S:
					BaseMvBck();
					break;
				case Keys.A:
					BaseMvLeft();
					break;
				case Keys.D:
					BaseMvRight();
					break;
			}
		}
	}
}
