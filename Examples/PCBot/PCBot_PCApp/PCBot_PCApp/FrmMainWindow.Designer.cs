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
			this.BtnLightFrontLeftOn = new System.Windows.Forms.Button();
			this.BtnLightFrontLeftOff = new System.Windows.Forms.Button();
			this.ImgLightFrontLeftOff = new System.Windows.Forms.PictureBox();
			this.ImgLightFrontLeftOn = new System.Windows.Forms.PictureBox();
			this.ImgBody = new System.Windows.Forms.PictureBox();
			this.ImgBumperFrontLeft = new System.Windows.Forms.PictureBox();
			this.ImgBumperFrontRight = new System.Windows.Forms.PictureBox();
			this.ImgLightFrontRightOff = new System.Windows.Forms.PictureBox();
			this.BtnLightFrontRightOff = new System.Windows.Forms.Button();
			this.BtnLightFrontRightOn = new System.Windows.Forms.Button();
			this.ImgLightFrontRightOn = new System.Windows.Forms.PictureBox();
			this.BtnAbout = new System.Windows.Forms.Button();
			this.BtnLightFrontOn = new System.Windows.Forms.Button();
			this.BtnLightFrontOff = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontLeftOff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontLeftOn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBody)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBumperFrontLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBumperFrontRight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontRightOff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontRightOn)).BeginInit();
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
			// BtnLightFrontLeftOn
			// 
			this.BtnLightFrontLeftOn.Location = new System.Drawing.Point(128, 39);
			this.BtnLightFrontLeftOn.Name = "BtnLightFrontLeftOn";
			this.BtnLightFrontLeftOn.Size = new System.Drawing.Size(38, 23);
			this.BtnLightFrontLeftOn.TabIndex = 2;
			this.BtnLightFrontLeftOn.Text = "ON";
			this.BtnLightFrontLeftOn.UseVisualStyleBackColor = true;
			this.BtnLightFrontLeftOn.Click += new System.EventHandler(this.BtnLightFrontLeftOn_Click);
			// 
			// BtnLightFrontLeftOff
			// 
			this.BtnLightFrontLeftOff.Location = new System.Drawing.Point(128, 66);
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
			this.ImgLightFrontLeftOff.Location = new System.Drawing.Point(85, 39);
			this.ImgLightFrontLeftOff.Name = "ImgLightFrontLeftOff";
			this.ImgLightFrontLeftOff.Size = new System.Drawing.Size(37, 50);
			this.ImgLightFrontLeftOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgLightFrontLeftOff.TabIndex = 4;
			this.ImgLightFrontLeftOff.TabStop = false;
			// 
			// ImgLightFrontLeftOn
			// 
			this.ImgLightFrontLeftOn.Image = ((System.Drawing.Image)(resources.GetObject("ImgLightFrontLeftOn.Image")));
			this.ImgLightFrontLeftOn.Location = new System.Drawing.Point(85, 39);
			this.ImgLightFrontLeftOn.Name = "ImgLightFrontLeftOn";
			this.ImgLightFrontLeftOn.Size = new System.Drawing.Size(37, 50);
			this.ImgLightFrontLeftOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgLightFrontLeftOn.TabIndex = 5;
			this.ImgLightFrontLeftOn.TabStop = false;
			// 
			// ImgBody
			// 
			this.ImgBody.Image = ((System.Drawing.Image)(resources.GetObject("ImgBody.Image")));
			this.ImgBody.Location = new System.Drawing.Point(15, 95);
			this.ImgBody.Name = "ImgBody";
			this.ImgBody.Size = new System.Drawing.Size(372, 441);
			this.ImgBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgBody.TabIndex = 6;
			this.ImgBody.TabStop = false;
			// 
			// ImgBumperFrontLeft
			// 
			this.ImgBumperFrontLeft.Image = ((System.Drawing.Image)(resources.GetObject("ImgBumperFrontLeft.Image")));
			this.ImgBumperFrontLeft.Location = new System.Drawing.Point(15, 66);
			this.ImgBumperFrontLeft.Name = "ImgBumperFrontLeft";
			this.ImgBumperFrontLeft.Size = new System.Drawing.Size(64, 30);
			this.ImgBumperFrontLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgBumperFrontLeft.TabIndex = 7;
			this.ImgBumperFrontLeft.TabStop = false;
			// 
			// ImgBumperFrontRight
			// 
			this.ImgBumperFrontRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ImgBumperFrontRight.Image = ((System.Drawing.Image)(resources.GetObject("ImgBumperFrontRight.Image")));
			this.ImgBumperFrontRight.Location = new System.Drawing.Point(323, 66);
			this.ImgBumperFrontRight.Name = "ImgBumperFrontRight";
			this.ImgBumperFrontRight.Size = new System.Drawing.Size(64, 30);
			this.ImgBumperFrontRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgBumperFrontRight.TabIndex = 8;
			this.ImgBumperFrontRight.TabStop = false;
			// 
			// ImgLightFrontRightOff
			// 
			this.ImgLightFrontRightOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ImgLightFrontRightOff.Image = ((System.Drawing.Image)(resources.GetObject("ImgLightFrontRightOff.Image")));
			this.ImgLightFrontRightOff.Location = new System.Drawing.Point(280, 39);
			this.ImgLightFrontRightOff.Name = "ImgLightFrontRightOff";
			this.ImgLightFrontRightOff.Size = new System.Drawing.Size(37, 50);
			this.ImgLightFrontRightOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgLightFrontRightOff.TabIndex = 11;
			this.ImgLightFrontRightOff.TabStop = false;
			// 
			// BtnLightFrontRightOff
			// 
			this.BtnLightFrontRightOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnLightFrontRightOff.Location = new System.Drawing.Point(236, 66);
			this.BtnLightFrontRightOff.Name = "BtnLightFrontRightOff";
			this.BtnLightFrontRightOff.Size = new System.Drawing.Size(38, 23);
			this.BtnLightFrontRightOff.TabIndex = 10;
			this.BtnLightFrontRightOff.Text = "OFF";
			this.BtnLightFrontRightOff.UseVisualStyleBackColor = true;
			this.BtnLightFrontRightOff.Click += new System.EventHandler(this.BtnLightFrontRightOff_Click);
			// 
			// BtnLightFrontRightOn
			// 
			this.BtnLightFrontRightOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnLightFrontRightOn.Location = new System.Drawing.Point(236, 39);
			this.BtnLightFrontRightOn.Name = "BtnLightFrontRightOn";
			this.BtnLightFrontRightOn.Size = new System.Drawing.Size(38, 23);
			this.BtnLightFrontRightOn.TabIndex = 9;
			this.BtnLightFrontRightOn.Text = "ON";
			this.BtnLightFrontRightOn.UseVisualStyleBackColor = true;
			this.BtnLightFrontRightOn.Click += new System.EventHandler(this.BtnLightFrontRightOn_Click);
			// 
			// ImgLightFrontRightOn
			// 
			this.ImgLightFrontRightOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ImgLightFrontRightOn.Image = ((System.Drawing.Image)(resources.GetObject("ImgLightFrontRightOn.Image")));
			this.ImgLightFrontRightOn.Location = new System.Drawing.Point(280, 39);
			this.ImgLightFrontRightOn.Name = "ImgLightFrontRightOn";
			this.ImgLightFrontRightOn.Size = new System.Drawing.Size(37, 50);
			this.ImgLightFrontRightOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgLightFrontRightOn.TabIndex = 12;
			this.ImgLightFrontRightOn.TabStop = false;
			// 
			// BtnAbout
			// 
			this.BtnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnAbout.Location = new System.Drawing.Point(365, 4);
			this.BtnAbout.Name = "BtnAbout";
			this.BtnAbout.Size = new System.Drawing.Size(22, 23);
			this.BtnAbout.TabIndex = 13;
			this.BtnAbout.Text = "?";
			this.BtnAbout.UseVisualStyleBackColor = true;
			this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
			// 
			// BtnLightFrontOn
			// 
			this.BtnLightFrontOn.Location = new System.Drawing.Point(172, 39);
			this.BtnLightFrontOn.Name = "BtnLightFrontOn";
			this.BtnLightFrontOn.Size = new System.Drawing.Size(58, 23);
			this.BtnLightFrontOn.TabIndex = 14;
			this.BtnLightFrontOn.Text = "ON";
			this.BtnLightFrontOn.UseVisualStyleBackColor = true;
			this.BtnLightFrontOn.Click += new System.EventHandler(this.BtnLightFrontOn_Click);
			// 
			// BtnLightFrontOff
			// 
			this.BtnLightFrontOff.Location = new System.Drawing.Point(172, 68);
			this.BtnLightFrontOff.Name = "BtnLightFrontOff";
			this.BtnLightFrontOff.Size = new System.Drawing.Size(58, 23);
			this.BtnLightFrontOff.TabIndex = 15;
			this.BtnLightFrontOff.Text = "OFF";
			this.BtnLightFrontOff.UseVisualStyleBackColor = true;
			this.BtnLightFrontOff.Click += new System.EventHandler(this.BtnLightFrontOff_Click);
			// 
			// FrmMainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 550);
			this.Controls.Add(this.BtnLightFrontOff);
			this.Controls.Add(this.BtnLightFrontOn);
			this.Controls.Add(this.BtnAbout);
			this.Controls.Add(this.BtnLightFrontRightOff);
			this.Controls.Add(this.BtnLightFrontRightOn);
			this.Controls.Add(this.ImgBumperFrontRight);
			this.Controls.Add(this.ImgBumperFrontLeft);
			this.Controls.Add(this.ImgLightFrontLeftOff);
			this.Controls.Add(this.BtnLightFrontLeftOff);
			this.Controls.Add(this.BtnLightFrontLeftOn);
			this.Controls.Add(this.LblConnStatus);
			this.Controls.Add(this.ImgLightFrontLeftOn);
			this.Controls.Add(this.ImgBody);
			this.Controls.Add(this.ImgLightFrontRightOff);
			this.Controls.Add(this.ImgLightFrontRightOn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FrmMainWindow";
			this.Text = "PCBot";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMainWindow_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontLeftOff)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontLeftOn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBody)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBumperFrontLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBumperFrontRight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontRightOff)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontRightOn)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblConnStatus;
		private System.Windows.Forms.Button BtnLightFrontLeftOn;
		private System.Windows.Forms.Button BtnLightFrontLeftOff;
		private System.Windows.Forms.PictureBox ImgLightFrontLeftOff;
		private System.Windows.Forms.PictureBox ImgLightFrontLeftOn;
		private System.Windows.Forms.PictureBox ImgBody;
		private System.Windows.Forms.PictureBox ImgBumperFrontLeft;
		private System.Windows.Forms.PictureBox ImgBumperFrontRight;
		private System.Windows.Forms.PictureBox ImgLightFrontRightOff;
		private System.Windows.Forms.Button BtnLightFrontRightOff;
		private System.Windows.Forms.Button BtnLightFrontRightOn;
		private System.Windows.Forms.PictureBox ImgLightFrontRightOn;
		private System.Windows.Forms.Button BtnAbout;
		private System.Windows.Forms.Button BtnLightFrontOn;
		private System.Windows.Forms.Button BtnLightFrontOff;
	}
}

