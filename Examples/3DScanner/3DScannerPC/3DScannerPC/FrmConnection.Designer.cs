namespace _3DScannerPC {
	partial class FrmConnection {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.cmbPort = new System.Windows.Forms.ComboBox();
			this.btnUpdateListPorts = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.cmbBaud = new System.Windows.Forms.ComboBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.lblBauds = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cmbPort
			// 
			this.cmbPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPort.FormattingEnabled = true;
			this.cmbPort.Location = new System.Drawing.Point(15, 41);
			this.cmbPort.Name = "cmbPort";
			this.cmbPort.Size = new System.Drawing.Size(137, 21);
			this.cmbPort.TabIndex = 0;
			// 
			// btnUpdateListPorts
			// 
			this.btnUpdateListPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdateListPorts.Location = new System.Drawing.Point(158, 39);
			this.btnUpdateListPorts.Name = "btnUpdateListPorts";
			this.btnUpdateListPorts.Size = new System.Drawing.Size(96, 23);
			this.btnUpdateListPorts.TabIndex = 1;
			this.btnUpdateListPorts.Text = "NS (Update list)";
			this.btnUpdateListPorts.UseVisualStyleBackColor = true;
			this.btnUpdateListPorts.Click += new System.EventHandler(this.btnUpdateListPorts_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.ForeColor = System.Drawing.Color.Blue;
			this.lblStatus.Location = new System.Drawing.Point(12, 9);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(223, 17);
			this.lblStatus.TabIndex = 2;
			this.lblStatus.Text = "NOT SET (Connection status)";
			// 
			// cmbBaud
			// 
			this.cmbBaud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBaud.FormattingEnabled = true;
			this.cmbBaud.Items.AddRange(new object[] {
            "9600"});
			this.cmbBaud.Location = new System.Drawing.Point(15, 68);
			this.cmbBaud.Name = "cmbBaud";
			this.cmbBaud.Size = new System.Drawing.Size(137, 21);
			this.cmbBaud.TabIndex = 3;
			// 
			// btnConnect
			// 
			this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnConnect.Location = new System.Drawing.Point(15, 95);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(137, 23);
			this.btnConnect.TabIndex = 4;
			this.btnConnect.Text = "NS (Connect)";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDisconnect.Location = new System.Drawing.Point(158, 95);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(96, 23);
			this.btnDisconnect.TabIndex = 5;
			this.btnDisconnect.Text = "NS (Disconnect)";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
			// 
			// lblBauds
			// 
			this.lblBauds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBauds.AutoSize = true;
			this.lblBauds.Location = new System.Drawing.Point(158, 71);
			this.lblBauds.Name = "lblBauds";
			this.lblBauds.Size = new System.Drawing.Size(60, 13);
			this.lblBauds.TabIndex = 6;
			this.lblBauds.Text = "NS (bauds)";
			// 
			// FrmConnection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(266, 134);
			this.Controls.Add(this.lblBauds);
			this.Controls.Add(this.cmbBaud);
			this.Controls.Add(this.btnUpdateListPorts);
			this.Controls.Add(this.cmbPort);
			this.Controls.Add(this.btnDisconnect);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.lblStatus);
			this.MaximumSize = new System.Drawing.Size(800, 161);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(274, 161);
			this.Name = "FrmConnection";
			this.Text = "NOT SET (Connection)";
			this.Load += new System.EventHandler(this.FrmConnection_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConnection_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbPort;
		private System.Windows.Forms.Button btnUpdateListPorts;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ComboBox cmbBaud;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Label lblBauds;
	}
}