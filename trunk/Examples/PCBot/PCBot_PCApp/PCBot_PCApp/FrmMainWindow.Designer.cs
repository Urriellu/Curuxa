namespace PCBot_PCApp {
	partial class FrmMainWindow {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainWindow));
			this.LblConnStatus = new System.Windows.Forms.Label();
			this.TxtLog = new System.Windows.Forms.TextBox();
			this.BtnLightFrontLeftOn = new System.Windows.Forms.Button();
			this.BtnLightFrontLeftOff = new System.Windows.Forms.Button();
			this.ImgLightFrontLeftOff = new System.Windows.Forms.PictureBox();
			this.ImgLightFrontLeftOn = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontLeftOff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontLeftOn)).BeginInit();
			this.SuspendLayout();
			// 
			// LblConnStatus
			// 
			this.LblConnStatus.AutoSize = true;
			this.LblConnStatus.Location = new System.Drawing.Point(12, 9);
			this.LblConnStatus.Name = "LblConnStatus";
			this.LblConnStatus.Size = new System.Drawing.Size(148, 13);
			this.LblConnStatus.TabIndex = 0;
			this.LblConnStatus.Text = "Connection status (NOT SET)";
			// 
			// TxtLog
			// 
			this.TxtLog.BackColor = System.Drawing.SystemColors.Window;
			this.TxtLog.Location = new System.Drawing.Point(744, 12);
			this.TxtLog.Multiline = true;
			this.TxtLog.Name = "TxtLog";
			this.TxtLog.ReadOnly = true;
			this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TxtLog.Size = new System.Drawing.Size(260, 249);
			this.TxtLog.TabIndex = 1;
			this.TxtLog.Text = "Log entries go here. Nothing yet.";
			// 
			// BtnLightFrontLeftOn
			// 
			this.BtnLightFrontLeftOn.Location = new System.Drawing.Point(115, 75);
			this.BtnLightFrontLeftOn.Name = "BtnLightFrontLeftOn";
			this.BtnLightFrontLeftOn.Size = new System.Drawing.Size(38, 23);
			this.BtnLightFrontLeftOn.TabIndex = 2;
			this.BtnLightFrontLeftOn.Text = "ON";
			this.BtnLightFrontLeftOn.UseVisualStyleBackColor = true;
			this.BtnLightFrontLeftOn.Click += new System.EventHandler(this.BtnLightFrontLeftOn_Click);
			// 
			// BtnLightFrontLeftOff
			// 
			this.BtnLightFrontLeftOff.Location = new System.Drawing.Point(115, 104);
			this.BtnLightFrontLeftOff.Name = "BtnLightFrontLeftOff";
			this.BtnLightFrontLeftOff.Size = new System.Drawing.Size(38, 23);
			this.BtnLightFrontLeftOff.TabIndex = 3;
			this.BtnLightFrontLeftOff.Text = "OFF";
			this.BtnLightFrontLeftOff.UseVisualStyleBackColor = true;
			this.BtnLightFrontLeftOff.Click += new System.EventHandler(this.BtnLightFrontLeftOff_Click);
			// 
			// ImgLightFrontLeftOff
			// 
			this.ImgLightFrontLeftOff.Image = ((System.Drawing.Image)(resources.GetObject("ImgLightFrontLeftOff.Image")));
			this.ImgLightFrontLeftOff.Location = new System.Drawing.Point(159, 77);
			this.ImgLightFrontLeftOff.Name = "ImgLightFrontLeftOff";
			this.ImgLightFrontLeftOff.Size = new System.Drawing.Size(37, 50);
			this.ImgLightFrontLeftOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgLightFrontLeftOff.TabIndex = 4;
			this.ImgLightFrontLeftOff.TabStop = false;
			// 
			// ImgLightFrontLeftOn
			// 
			this.ImgLightFrontLeftOn.Image = ((System.Drawing.Image)(resources.GetObject("ImgLightFrontLeftOn.Image")));
			this.ImgLightFrontLeftOn.Location = new System.Drawing.Point(159, 77);
			this.ImgLightFrontLeftOn.Name = "ImgLightFrontLeftOn";
			this.ImgLightFrontLeftOn.Size = new System.Drawing.Size(37, 50);
			this.ImgLightFrontLeftOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgLightFrontLeftOn.TabIndex = 5;
			this.ImgLightFrontLeftOn.TabStop = false;
			// 
			// FrmMainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 273);
			this.Controls.Add(this.ImgLightFrontLeftOff);
			this.Controls.Add(this.BtnLightFrontLeftOff);
			this.Controls.Add(this.BtnLightFrontLeftOn);
			this.Controls.Add(this.TxtLog);
			this.Controls.Add(this.LblConnStatus);
			this.Controls.Add(this.ImgLightFrontLeftOn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FrmMainWindow";
			this.Text = "PCBot";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.Leave += new System.EventHandler(this.FrmMainWindow_Leave);
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontLeftOff)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontLeftOn)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblConnStatus;
		public System.Windows.Forms.TextBox TxtLog;
		private System.Windows.Forms.Button BtnLightFrontLeftOn;
		private System.Windows.Forms.Button BtnLightFrontLeftOff;
		private System.Windows.Forms.PictureBox ImgLightFrontLeftOff;
		private System.Windows.Forms.PictureBox ImgLightFrontLeftOn;
	}
}

