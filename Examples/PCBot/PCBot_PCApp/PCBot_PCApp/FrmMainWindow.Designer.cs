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
			this.BtnBaseMvFwd = new System.Windows.Forms.Button();
			this.ImgBaseMvFwd = new System.Windows.Forms.PictureBox();
			this.BtnBaseMvTurnL = new System.Windows.Forms.Button();
			this.BtnBaseMvTurnR = new System.Windows.Forms.Button();
			this.BtnBaseMvRotateR = new System.Windows.Forms.Button();
			this.BtnBaseMvRotateL = new System.Windows.Forms.Button();
			this.BtnBaseMvBck = new System.Windows.Forms.Button();
			this.BtnBaseMvStop = new System.Windows.Forms.Button();
			this.ImgBaseStop = new System.Windows.Forms.PictureBox();
			this.ImgBaseRotateL = new System.Windows.Forms.PictureBox();
			this.ImgBaseRorateR = new System.Windows.Forms.PictureBox();
			this.ImgBaseTurnL = new System.Windows.Forms.PictureBox();
			this.ImgBaseTurnR = new System.Windows.Forms.PictureBox();
			this.ImgBaseMvBck = new System.Windows.Forms.PictureBox();
			this.BtnInteractive = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontLeftOff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontLeftOn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBody)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBumperFrontLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBumperFrontRight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontRightOff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontRightOn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBaseMvFwd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBaseStop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBaseRotateL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBaseRorateR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBaseTurnL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBaseTurnR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBaseMvBck)).BeginInit();
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
			this.ImgBumperFrontLeft.Location = new System.Drawing.Point(15, 65);
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
			this.ImgBumperFrontRight.Location = new System.Drawing.Point(323, 65);
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
			// BtnBaseMvFwd
			// 
			this.BtnBaseMvFwd.Image = ((System.Drawing.Image)(resources.GetObject("BtnBaseMvFwd.Image")));
			this.BtnBaseMvFwd.Location = new System.Drawing.Point(181, 193);
			this.BtnBaseMvFwd.Name = "BtnBaseMvFwd";
			this.BtnBaseMvFwd.Size = new System.Drawing.Size(38, 38);
			this.BtnBaseMvFwd.TabIndex = 16;
			this.BtnBaseMvFwd.UseVisualStyleBackColor = true;
			this.BtnBaseMvFwd.Click += new System.EventHandler(this.BtnBaseMvFwd_Click);
			// 
			// ImgBaseMvFwd
			// 
			this.ImgBaseMvFwd.BackColor = System.Drawing.Color.White;
			this.ImgBaseMvFwd.Image = ((System.Drawing.Image)(resources.GetObject("ImgBaseMvFwd.Image")));
			this.ImgBaseMvFwd.Location = new System.Drawing.Point(166, 237);
			this.ImgBaseMvFwd.Name = "ImgBaseMvFwd";
			this.ImgBaseMvFwd.Size = new System.Drawing.Size(68, 120);
			this.ImgBaseMvFwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgBaseMvFwd.TabIndex = 17;
			this.ImgBaseMvFwd.TabStop = false;
			// 
			// BtnBaseMvTurnL
			// 
			this.BtnBaseMvTurnL.Image = ((System.Drawing.Image)(resources.GetObject("BtnBaseMvTurnL.Image")));
			this.BtnBaseMvTurnL.Location = new System.Drawing.Point(96, 193);
			this.BtnBaseMvTurnL.Name = "BtnBaseMvTurnL";
			this.BtnBaseMvTurnL.Size = new System.Drawing.Size(38, 38);
			this.BtnBaseMvTurnL.TabIndex = 18;
			this.BtnBaseMvTurnL.UseVisualStyleBackColor = true;
			this.BtnBaseMvTurnL.Click += new System.EventHandler(this.BtnBaseMvTurnL_Click);
			// 
			// BtnBaseMvTurnR
			// 
			this.BtnBaseMvTurnR.Image = ((System.Drawing.Image)(resources.GetObject("BtnBaseMvTurnR.Image")));
			this.BtnBaseMvTurnR.Location = new System.Drawing.Point(266, 193);
			this.BtnBaseMvTurnR.Name = "BtnBaseMvTurnR";
			this.BtnBaseMvTurnR.Size = new System.Drawing.Size(38, 38);
			this.BtnBaseMvTurnR.TabIndex = 19;
			this.BtnBaseMvTurnR.UseVisualStyleBackColor = true;
			this.BtnBaseMvTurnR.Click += new System.EventHandler(this.BtnBaseMvTurnR_Click);
			// 
			// BtnBaseMvRotateR
			// 
			this.BtnBaseMvRotateR.Image = ((System.Drawing.Image)(resources.GetObject("BtnBaseMvRotateR.Image")));
			this.BtnBaseMvRotateR.Location = new System.Drawing.Point(266, 276);
			this.BtnBaseMvRotateR.Name = "BtnBaseMvRotateR";
			this.BtnBaseMvRotateR.Size = new System.Drawing.Size(38, 38);
			this.BtnBaseMvRotateR.TabIndex = 20;
			this.BtnBaseMvRotateR.UseVisualStyleBackColor = true;
			this.BtnBaseMvRotateR.Click += new System.EventHandler(this.BtnBaseMvRotateR_Click);
			// 
			// BtnBaseMvRotateL
			// 
			this.BtnBaseMvRotateL.Image = ((System.Drawing.Image)(resources.GetObject("BtnBaseMvRotateL.Image")));
			this.BtnBaseMvRotateL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BtnBaseMvRotateL.Location = new System.Drawing.Point(96, 276);
			this.BtnBaseMvRotateL.Name = "BtnBaseMvRotateL";
			this.BtnBaseMvRotateL.Size = new System.Drawing.Size(38, 38);
			this.BtnBaseMvRotateL.TabIndex = 21;
			this.BtnBaseMvRotateL.UseVisualStyleBackColor = true;
			this.BtnBaseMvRotateL.Click += new System.EventHandler(this.BtnBaseMvRotateL_Click);
			// 
			// BtnBaseMvBck
			// 
			this.BtnBaseMvBck.Image = ((System.Drawing.Image)(resources.GetObject("BtnBaseMvBck.Image")));
			this.BtnBaseMvBck.Location = new System.Drawing.Point(181, 363);
			this.BtnBaseMvBck.Name = "BtnBaseMvBck";
			this.BtnBaseMvBck.Size = new System.Drawing.Size(38, 38);
			this.BtnBaseMvBck.TabIndex = 22;
			this.BtnBaseMvBck.UseVisualStyleBackColor = true;
			this.BtnBaseMvBck.Click += new System.EventHandler(this.BtnBaseMvBck_Click);
			// 
			// BtnBaseMvStop
			// 
			this.BtnBaseMvStop.Image = ((System.Drawing.Image)(resources.GetObject("BtnBaseMvStop.Image")));
			this.BtnBaseMvStop.Location = new System.Drawing.Point(181, 407);
			this.BtnBaseMvStop.Name = "BtnBaseMvStop";
			this.BtnBaseMvStop.Size = new System.Drawing.Size(38, 38);
			this.BtnBaseMvStop.TabIndex = 23;
			this.BtnBaseMvStop.UseVisualStyleBackColor = true;
			this.BtnBaseMvStop.Click += new System.EventHandler(this.BtnBaseMvStop_Click);
			// 
			// ImgBaseStop
			// 
			this.ImgBaseStop.BackColor = System.Drawing.Color.White;
			this.ImgBaseStop.Image = ((System.Drawing.Image)(resources.GetObject("ImgBaseStop.Image")));
			this.ImgBaseStop.Location = new System.Drawing.Point(140, 237);
			this.ImgBaseStop.Name = "ImgBaseStop";
			this.ImgBaseStop.Size = new System.Drawing.Size(120, 120);
			this.ImgBaseStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgBaseStop.TabIndex = 24;
			this.ImgBaseStop.TabStop = false;
			// 
			// ImgBaseRotateL
			// 
			this.ImgBaseRotateL.BackColor = System.Drawing.Color.White;
			this.ImgBaseRotateL.Image = ((System.Drawing.Image)(resources.GetObject("ImgBaseRotateL.Image")));
			this.ImgBaseRotateL.Location = new System.Drawing.Point(140, 237);
			this.ImgBaseRotateL.Name = "ImgBaseRotateL";
			this.ImgBaseRotateL.Size = new System.Drawing.Size(120, 120);
			this.ImgBaseRotateL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgBaseRotateL.TabIndex = 25;
			this.ImgBaseRotateL.TabStop = false;
			// 
			// ImgBaseRorateR
			// 
			this.ImgBaseRorateR.BackColor = System.Drawing.Color.White;
			this.ImgBaseRorateR.Image = ((System.Drawing.Image)(resources.GetObject("ImgBaseRorateR.Image")));
			this.ImgBaseRorateR.Location = new System.Drawing.Point(140, 237);
			this.ImgBaseRorateR.Name = "ImgBaseRorateR";
			this.ImgBaseRorateR.Size = new System.Drawing.Size(120, 120);
			this.ImgBaseRorateR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgBaseRorateR.TabIndex = 26;
			this.ImgBaseRorateR.TabStop = false;
			// 
			// ImgBaseTurnL
			// 
			this.ImgBaseTurnL.BackColor = System.Drawing.Color.White;
			this.ImgBaseTurnL.Image = ((System.Drawing.Image)(resources.GetObject("ImgBaseTurnL.Image")));
			this.ImgBaseTurnL.Location = new System.Drawing.Point(166, 237);
			this.ImgBaseTurnL.Name = "ImgBaseTurnL";
			this.ImgBaseTurnL.Size = new System.Drawing.Size(68, 120);
			this.ImgBaseTurnL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgBaseTurnL.TabIndex = 27;
			this.ImgBaseTurnL.TabStop = false;
			// 
			// ImgBaseTurnR
			// 
			this.ImgBaseTurnR.BackColor = System.Drawing.Color.White;
			this.ImgBaseTurnR.Image = ((System.Drawing.Image)(resources.GetObject("ImgBaseTurnR.Image")));
			this.ImgBaseTurnR.Location = new System.Drawing.Point(166, 237);
			this.ImgBaseTurnR.Name = "ImgBaseTurnR";
			this.ImgBaseTurnR.Size = new System.Drawing.Size(68, 120);
			this.ImgBaseTurnR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgBaseTurnR.TabIndex = 28;
			this.ImgBaseTurnR.TabStop = false;
			// 
			// ImgBaseMvBck
			// 
			this.ImgBaseMvBck.BackColor = System.Drawing.Color.White;
			this.ImgBaseMvBck.Image = ((System.Drawing.Image)(resources.GetObject("ImgBaseMvBck.Image")));
			this.ImgBaseMvBck.Location = new System.Drawing.Point(166, 237);
			this.ImgBaseMvBck.Name = "ImgBaseMvBck";
			this.ImgBaseMvBck.Size = new System.Drawing.Size(68, 120);
			this.ImgBaseMvBck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImgBaseMvBck.TabIndex = 29;
			this.ImgBaseMvBck.TabStop = false;
			// 
			// BtnInteractive
			// 
			this.BtnInteractive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnInteractive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnInteractive.ForeColor = System.Drawing.Color.Red;
			this.BtnInteractive.Location = new System.Drawing.Point(337, 4);
			this.BtnInteractive.Name = "BtnInteractive";
			this.BtnInteractive.Size = new System.Drawing.Size(22, 23);
			this.BtnInteractive.TabIndex = 30;
			this.BtnInteractive.Text = "i";
			this.BtnInteractive.UseVisualStyleBackColor = true;
			this.BtnInteractive.Click += new System.EventHandler(this.BtnInteractive_Click);
			// 
			// FrmMainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 550);
			this.Controls.Add(this.BtnInteractive);
			this.Controls.Add(this.ImgBaseMvBck);
			this.Controls.Add(this.ImgBaseTurnR);
			this.Controls.Add(this.ImgBaseTurnL);
			this.Controls.Add(this.ImgBaseMvFwd);
			this.Controls.Add(this.ImgBaseRorateR);
			this.Controls.Add(this.ImgBaseRotateL);
			this.Controls.Add(this.BtnBaseMvStop);
			this.Controls.Add(this.BtnBaseMvBck);
			this.Controls.Add(this.BtnBaseMvRotateL);
			this.Controls.Add(this.BtnBaseMvRotateR);
			this.Controls.Add(this.BtnBaseMvTurnR);
			this.Controls.Add(this.BtnBaseMvTurnL);
			this.Controls.Add(this.BtnBaseMvFwd);
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
			this.Controls.Add(this.ImgLightFrontRightOff);
			this.Controls.Add(this.ImgLightFrontRightOn);
			this.Controls.Add(this.ImgBaseStop);
			this.Controls.Add(this.ImgBody);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "FrmMainWindow";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "PCBot";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMainWindow_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMainWindow_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontLeftOff)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontLeftOn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBody)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBumperFrontLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBumperFrontRight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontRightOff)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgLightFrontRightOn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBaseMvFwd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBaseStop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBaseRotateL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBaseRorateR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBaseTurnL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBaseTurnR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImgBaseMvBck)).EndInit();
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
		private System.Windows.Forms.Button BtnBaseMvFwd;
		private System.Windows.Forms.PictureBox ImgBaseMvFwd;
		private System.Windows.Forms.Button BtnBaseMvTurnL;
		private System.Windows.Forms.Button BtnBaseMvTurnR;
		private System.Windows.Forms.Button BtnBaseMvRotateR;
		private System.Windows.Forms.Button BtnBaseMvRotateL;
		private System.Windows.Forms.Button BtnBaseMvBck;
		private System.Windows.Forms.Button BtnBaseMvStop;
		private System.Windows.Forms.PictureBox ImgBaseStop;
		private System.Windows.Forms.PictureBox ImgBaseRotateL;
		private System.Windows.Forms.PictureBox ImgBaseRorateR;
		private System.Windows.Forms.PictureBox ImgBaseTurnL;
		private System.Windows.Forms.PictureBox ImgBaseTurnR;
		private System.Windows.Forms.PictureBox ImgBaseMvBck;
		private System.Windows.Forms.Button BtnInteractive;
	}
}

