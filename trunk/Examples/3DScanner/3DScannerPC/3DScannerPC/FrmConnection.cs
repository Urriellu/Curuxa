using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3DScannerPC {
	public partial class FrmConnection:FormChild {
		public FrmConnection() {
			InitializeComponent();
		}

		private void FrmConnection_Load(object sender, EventArgs e) {
			UpdateLang();
			cmbBaud.SelectedIndex = 0;
			btnUpdateListPorts.PerformClick();
		}

		public override void UpdateLang() {
			this.Text = i18n.str("Connection");
			btnUpdateListPorts.Text = i18n.str("UpdateList");
			lblBauds.Text = i18n.str("bauds");
			btnConnect.Text = i18n.str("Connect");
			btnDisconnect.Text = i18n.str("Disconnect");
			UpdateStatus();
		}

		public void UpdateStatus() {
			btnConnect.Enabled = (Scanner.Status == Status.Disconnected);
			btnDisconnect.Enabled = (Scanner.Status == Status.Connected);
			if(Scanner.Status == Status.Connected) {
				lblStatus.Text = i18n.str("Connected");
				lblStatus.ForeColor = Color.Green;
			} else {
				lblStatus.Text = i18n.str("Disconnected");
				lblStatus.ForeColor = Color.Red;
			}
		}

		/// <summary>
		/// Update list of ports
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnUpdateListPorts_Click(object sender, EventArgs e) {
			cmbPort.Items.Clear();
			foreach(string port in SerialPort.GetPortNames()) {
				cmbPort.Items.Add(port);
			}
			if(cmbPort.Items.Count == 0) cmbPort.Items.Add("(none)");
			cmbPort.SelectedIndex = 0;
		}

		private void btnConnect_Click(object sender, EventArgs e) {
			Scanner.Connect(cmbPort.Text, int.Parse(cmbBaud.Text));
		}

		private void btnDisconnect_Click(object sender, EventArgs e) {
			Scanner.Disconnect();
		}

		private void FrmConnection_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = true;
			Hide();
		}
	}
}
