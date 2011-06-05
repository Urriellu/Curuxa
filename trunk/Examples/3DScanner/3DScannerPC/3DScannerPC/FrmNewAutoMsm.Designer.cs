namespace _3DScannerPC {
	partial class FrmNewAutoMsm {
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
			this.lblAdcMax = new System.Windows.Forms.Label();
			this.numAdcMax = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.numVRefMax = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.lblRemainingTime = new System.Windows.Forms.Label();
			this.lblReceivedXPoints = new System.Windows.Forms.Label();
			this.lblElapsedTime = new System.Windows.Forms.Label();
			this.grpDepth = new System.Windows.Forms.GroupBox();
			this.lblMeasPerPoint = new System.Windows.Forms.Label();
			this.numMeasPerPnt = new System.Windows.Forms.NumericUpDown();
			this.lblMsBetweenMeas = new System.Windows.Forms.Label();
			this.numTimeIntervalMs = new System.Windows.Forms.NumericUpDown();
			this.grpSetup = new System.Windows.Forms.GroupBox();
			this.grpHRes = new System.Windows.Forms.GroupBox();
			this.lblSummaryHRes = new System.Windows.Forms.Label();
			this.numMaxValH = new System.Windows.Forms.NumericUpDown();
			this.lblAndH = new System.Windows.Forms.Label();
			this.numMinValH = new System.Windows.Forms.NumericUpDown();
			this.lblTakeMeasBetweenH = new System.Windows.Forms.Label();
			this.lblIntervalsOfH = new System.Windows.Forms.Label();
			this.numIntervalH = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblSummaryVRes = new System.Windows.Forms.Label();
			this.numMaxValV = new System.Windows.Forms.NumericUpDown();
			this.lblAndV = new System.Windows.Forms.Label();
			this.numMinValV = new System.Windows.Forms.NumericUpDown();
			this.lblTakeMeasBetweenV = new System.Windows.Forms.Label();
			this.lblIntervalsOfV = new System.Windows.Forms.Label();
			this.numIntervalV = new System.Windows.Forms.NumericUpDown();
			this.btnStartNewAutoScan = new System.Windows.Forms.Button();
			this.btnForceStop = new System.Windows.Forms.Button();
			this.grpResults = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.numAdcMax)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numVRefMax)).BeginInit();
			this.grpDepth.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMeasPerPnt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numTimeIntervalMs)).BeginInit();
			this.grpSetup.SuspendLayout();
			this.grpHRes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMaxValH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMinValH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numIntervalH)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMaxValV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMinValV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numIntervalV)).BeginInit();
			this.grpResults.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblAdcMax
			// 
			this.lblAdcMax.AutoSize = true;
			this.lblAdcMax.Location = new System.Drawing.Point(12, 52);
			this.lblAdcMax.Name = "lblAdcMax";
			this.lblAdcMax.Size = new System.Drawing.Size(55, 13);
			this.lblAdcMax.TabIndex = 32;
			this.lblAdcMax.Tag = "";
			this.lblAdcMax.Text = "ADC Max:";
			// 
			// numAdcMax
			// 
			this.numAdcMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numAdcMax.Location = new System.Drawing.Point(73, 50);
			this.numAdcMax.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numAdcMax.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.numAdcMax.Name = "numAdcMax";
			this.numAdcMax.Size = new System.Drawing.Size(63, 20);
			this.numAdcMax.TabIndex = 33;
			this.numAdcMax.Value = new decimal(new int[] {
            1023,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 29;
			this.label1.Tag = "Voltage reference";
			this.label1.Text = "Ref:";
			// 
			// numVRefMax
			// 
			this.numVRefMax.DecimalPlaces = 2;
			this.numVRefMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numVRefMax.Location = new System.Drawing.Point(45, 24);
			this.numVRefMax.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.numVRefMax.Minimum = new decimal(new int[] {
            36,
            0,
            0,
            65536});
			this.numVRefMax.Name = "numVRefMax";
			this.numVRefMax.Size = new System.Drawing.Size(63, 20);
			this.numVRefMax.TabIndex = 30;
			this.numVRefMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numVRefMax.Value = new decimal(new int[] {
            500,
            0,
            0,
            131072});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(114, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 13);
			this.label2.TabIndex = 31;
			this.label2.Tag = "Voltage reference";
			this.label2.Text = "Volt";
			// 
			// lblRemainingTime
			// 
			this.lblRemainingTime.AutoSize = true;
			this.lblRemainingTime.Location = new System.Drawing.Point(12, 49);
			this.lblRemainingTime.Name = "lblRemainingTime";
			this.lblRemainingTime.Size = new System.Drawing.Size(171, 13);
			this.lblRemainingTime.TabIndex = 34;
			this.lblRemainingTime.Text = "NS (Remaining Time: UNKNOWN)";
			// 
			// lblReceivedXPoints
			// 
			this.lblReceivedXPoints.AutoSize = true;
			this.lblReceivedXPoints.Location = new System.Drawing.Point(12, 74);
			this.lblReceivedXPoints.Name = "lblReceivedXPoints";
			this.lblReceivedXPoints.Size = new System.Drawing.Size(158, 13);
			this.lblReceivedXPoints.TabIndex = 35;
			this.lblReceivedXPoints.Text = "NS (Received X points out of Y)";
			// 
			// lblElapsedTime
			// 
			this.lblElapsedTime.AutoSize = true;
			this.lblElapsedTime.Location = new System.Drawing.Point(12, 25);
			this.lblElapsedTime.Name = "lblElapsedTime";
			this.lblElapsedTime.Size = new System.Drawing.Size(159, 13);
			this.lblElapsedTime.TabIndex = 36;
			this.lblElapsedTime.Text = "NS (Elapsed Time: UNKNOWN)";
			// 
			// grpDepth
			// 
			this.grpDepth.Controls.Add(this.lblMeasPerPoint);
			this.grpDepth.Controls.Add(this.numMeasPerPnt);
			this.grpDepth.Controls.Add(this.lblMsBetweenMeas);
			this.grpDepth.Controls.Add(this.numTimeIntervalMs);
			this.grpDepth.Location = new System.Drawing.Point(17, 108);
			this.grpDepth.Name = "grpDepth";
			this.grpDepth.Size = new System.Drawing.Size(321, 85);
			this.grpDepth.TabIndex = 37;
			this.grpDepth.TabStop = false;
			this.grpDepth.Text = "NS Depth";
			// 
			// lblMeasPerPoint
			// 
			this.lblMeasPerPoint.AutoSize = true;
			this.lblMeasPerPoint.Location = new System.Drawing.Point(90, 53);
			this.lblMeasPerPoint.Name = "lblMeasPerPoint";
			this.lblMeasPerPoint.Size = new System.Drawing.Size(120, 13);
			this.lblMeasPerPoint.TabIndex = 42;
			this.lblMeasPerPoint.Text = "NS (measures per point)";
			// 
			// numMeasPerPnt
			// 
			this.numMeasPerPnt.Location = new System.Drawing.Point(15, 51);
			this.numMeasPerPnt.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
			this.numMeasPerPnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numMeasPerPnt.Name = "numMeasPerPnt";
			this.numMeasPerPnt.Size = new System.Drawing.Size(69, 20);
			this.numMeasPerPnt.TabIndex = 41;
			this.numMeasPerPnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numMeasPerPnt.ValueChanged += new System.EventHandler(this.numMeasPerPnt_ValueChanged);
			// 
			// lblMsBetweenMeas
			// 
			this.lblMsBetweenMeas.AutoSize = true;
			this.lblMsBetweenMeas.Location = new System.Drawing.Point(90, 27);
			this.lblMsBetweenMeas.Name = "lblMsBetweenMeas";
			this.lblMsBetweenMeas.Size = new System.Drawing.Size(179, 13);
			this.lblMsBetweenMeas.TabIndex = 40;
			this.lblMsBetweenMeas.Text = "NS (milliseconds between measures)";
			// 
			// numTimeIntervalMs
			// 
			this.numTimeIntervalMs.Location = new System.Drawing.Point(15, 25);
			this.numTimeIntervalMs.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numTimeIntervalMs.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numTimeIntervalMs.Name = "numTimeIntervalMs";
			this.numTimeIntervalMs.Size = new System.Drawing.Size(69, 20);
			this.numTimeIntervalMs.TabIndex = 39;
			this.numTimeIntervalMs.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numTimeIntervalMs.ValueChanged += new System.EventHandler(this.numTimeIntervalMs_ValueChanged);
			// 
			// grpSetup
			// 
			this.grpSetup.Controls.Add(this.label1);
			this.grpSetup.Controls.Add(this.label2);
			this.grpSetup.Controls.Add(this.numVRefMax);
			this.grpSetup.Controls.Add(this.numAdcMax);
			this.grpSetup.Controls.Add(this.lblAdcMax);
			this.grpSetup.Location = new System.Drawing.Point(17, 12);
			this.grpSetup.Name = "grpSetup";
			this.grpSetup.Size = new System.Drawing.Size(321, 90);
			this.grpSetup.TabIndex = 38;
			this.grpSetup.TabStop = false;
			this.grpSetup.Text = "NS Setup";
			// 
			// grpHRes
			// 
			this.grpHRes.Controls.Add(this.lblSummaryHRes);
			this.grpHRes.Controls.Add(this.numMaxValH);
			this.grpHRes.Controls.Add(this.lblAndH);
			this.grpHRes.Controls.Add(this.numMinValH);
			this.grpHRes.Controls.Add(this.lblTakeMeasBetweenH);
			this.grpHRes.Controls.Add(this.lblIntervalsOfH);
			this.grpHRes.Controls.Add(this.numIntervalH);
			this.grpHRes.Location = new System.Drawing.Point(17, 199);
			this.grpHRes.Name = "grpHRes";
			this.grpHRes.Size = new System.Drawing.Size(657, 99);
			this.grpHRes.TabIndex = 40;
			this.grpHRes.TabStop = false;
			this.grpHRes.Text = "NS (Horizontal Resolution)";
			// 
			// lblSummaryHRes
			// 
			this.lblSummaryHRes.AutoSize = true;
			this.lblSummaryHRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSummaryHRes.Location = new System.Drawing.Point(12, 65);
			this.lblSummaryHRes.Name = "lblSummaryHRes";
			this.lblSummaryHRes.Size = new System.Drawing.Size(396, 17);
			this.lblSummaryHRes.TabIndex = 44;
			this.lblSummaryHRes.Text = "NS (Will measure X points between Yº and Zº, XX times each)";
			// 
			// numMaxValH
			// 
			this.numMaxValH.Location = new System.Drawing.Point(327, 28);
			this.numMaxValH.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numMaxValH.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numMaxValH.Name = "numMaxValH";
			this.numMaxValH.Size = new System.Drawing.Size(80, 20);
			this.numMaxValH.TabIndex = 43;
			this.numMaxValH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numMaxValH.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numMaxValH.ValueChanged += new System.EventHandler(this.numMaxValH_ValueChanged);
			// 
			// lblAndH
			// 
			this.lblAndH.Location = new System.Drawing.Point(263, 26);
			this.lblAndH.Name = "lblAndH";
			this.lblAndH.Size = new System.Drawing.Size(58, 20);
			this.lblAndH.TabIndex = 42;
			this.lblAndH.Text = "NS (and)";
			this.lblAndH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numMinValH
			// 
			this.numMinValH.Location = new System.Drawing.Point(177, 28);
			this.numMinValH.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numMinValH.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numMinValH.Name = "numMinValH";
			this.numMinValH.Size = new System.Drawing.Size(80, 20);
			this.numMinValH.TabIndex = 41;
			this.numMinValH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numMinValH.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numMinValH.ValueChanged += new System.EventHandler(this.numMinValH_ValueChanged);
			// 
			// lblTakeMeasBetweenH
			// 
			this.lblTakeMeasBetweenH.Location = new System.Drawing.Point(12, 26);
			this.lblTakeMeasBetweenH.Name = "lblTakeMeasBetweenH";
			this.lblTakeMeasBetweenH.Size = new System.Drawing.Size(159, 20);
			this.lblTakeMeasBetweenH.TabIndex = 2;
			this.lblTakeMeasBetweenH.Text = "NS (Take measures between)";
			this.lblTakeMeasBetweenH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblIntervalsOfH
			// 
			this.lblIntervalsOfH.Location = new System.Drawing.Point(413, 26);
			this.lblIntervalsOfH.Name = "lblIntervalsOfH";
			this.lblIntervalsOfH.Size = new System.Drawing.Size(140, 20);
			this.lblIntervalsOfH.TabIndex = 1;
			this.lblIntervalsOfH.Text = "NS (with intervals of)";
			this.lblIntervalsOfH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numIntervalH
			// 
			this.numIntervalH.Location = new System.Drawing.Point(559, 28);
			this.numIntervalH.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numIntervalH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numIntervalH.Name = "numIntervalH";
			this.numIntervalH.Size = new System.Drawing.Size(80, 20);
			this.numIntervalH.TabIndex = 0;
			this.numIntervalH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numIntervalH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numIntervalH.ValueChanged += new System.EventHandler(this.numIntervalH_ValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblSummaryVRes);
			this.groupBox1.Controls.Add(this.numMaxValV);
			this.groupBox1.Controls.Add(this.lblAndV);
			this.groupBox1.Controls.Add(this.numMinValV);
			this.groupBox1.Controls.Add(this.lblTakeMeasBetweenV);
			this.groupBox1.Controls.Add(this.lblIntervalsOfV);
			this.groupBox1.Controls.Add(this.numIntervalV);
			this.groupBox1.Location = new System.Drawing.Point(17, 304);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(657, 99);
			this.groupBox1.TabIndex = 41;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "NS (Vertical Resolution)";
			// 
			// lblSummaryVRes
			// 
			this.lblSummaryVRes.AutoSize = true;
			this.lblSummaryVRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSummaryVRes.Location = new System.Drawing.Point(12, 65);
			this.lblSummaryVRes.Name = "lblSummaryVRes";
			this.lblSummaryVRes.Size = new System.Drawing.Size(396, 17);
			this.lblSummaryVRes.TabIndex = 44;
			this.lblSummaryVRes.Text = "NS (Will measure X points between Yº and Zº, XX times each)";
			// 
			// numMaxValV
			// 
			this.numMaxValV.Location = new System.Drawing.Point(327, 28);
			this.numMaxValV.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numMaxValV.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numMaxValV.Name = "numMaxValV";
			this.numMaxValV.Size = new System.Drawing.Size(80, 20);
			this.numMaxValV.TabIndex = 43;
			this.numMaxValV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numMaxValV.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numMaxValV.ValueChanged += new System.EventHandler(this.numMaxValV_ValueChanged);
			// 
			// lblAndV
			// 
			this.lblAndV.Location = new System.Drawing.Point(263, 26);
			this.lblAndV.Name = "lblAndV";
			this.lblAndV.Size = new System.Drawing.Size(58, 20);
			this.lblAndV.TabIndex = 42;
			this.lblAndV.Text = "NS (and)";
			this.lblAndV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numMinValV
			// 
			this.numMinValV.Location = new System.Drawing.Point(177, 28);
			this.numMinValV.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numMinValV.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numMinValV.Name = "numMinValV";
			this.numMinValV.Size = new System.Drawing.Size(80, 20);
			this.numMinValV.TabIndex = 41;
			this.numMinValV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numMinValV.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numMinValV.ValueChanged += new System.EventHandler(this.numMinValV_ValueChanged);
			// 
			// lblTakeMeasBetweenV
			// 
			this.lblTakeMeasBetweenV.Location = new System.Drawing.Point(12, 26);
			this.lblTakeMeasBetweenV.Name = "lblTakeMeasBetweenV";
			this.lblTakeMeasBetweenV.Size = new System.Drawing.Size(159, 20);
			this.lblTakeMeasBetweenV.TabIndex = 2;
			this.lblTakeMeasBetweenV.Text = "NS (Take measures between)";
			this.lblTakeMeasBetweenV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblIntervalsOfV
			// 
			this.lblIntervalsOfV.Location = new System.Drawing.Point(413, 26);
			this.lblIntervalsOfV.Name = "lblIntervalsOfV";
			this.lblIntervalsOfV.Size = new System.Drawing.Size(140, 20);
			this.lblIntervalsOfV.TabIndex = 1;
			this.lblIntervalsOfV.Text = "NS (with intervals of)";
			this.lblIntervalsOfV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numIntervalV
			// 
			this.numIntervalV.Location = new System.Drawing.Point(559, 28);
			this.numIntervalV.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numIntervalV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numIntervalV.Name = "numIntervalV";
			this.numIntervalV.Size = new System.Drawing.Size(80, 20);
			this.numIntervalV.TabIndex = 0;
			this.numIntervalV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numIntervalV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numIntervalV.ValueChanged += new System.EventHandler(this.numIntervalV_ValueChanged);
			// 
			// btnStartNewAutoScan
			// 
			this.btnStartNewAutoScan.Location = new System.Drawing.Point(373, 25);
			this.btnStartNewAutoScan.Name = "btnStartNewAutoScan";
			this.btnStartNewAutoScan.Size = new System.Drawing.Size(301, 23);
			this.btnStartNewAutoScan.TabIndex = 42;
			this.btnStartNewAutoScan.Text = "NS (Start New Automatic Measurement)";
			this.btnStartNewAutoScan.UseVisualStyleBackColor = true;
			this.btnStartNewAutoScan.Click += new System.EventHandler(this.btnStartNewAutoScan_Click);
			// 
			// btnForceStop
			// 
			this.btnForceStop.Enabled = false;
			this.btnForceStop.Location = new System.Drawing.Point(568, 54);
			this.btnForceStop.Name = "btnForceStop";
			this.btnForceStop.Size = new System.Drawing.Size(106, 23);
			this.btnForceStop.TabIndex = 43;
			this.btnForceStop.Text = "NS (Force Stop)";
			this.btnForceStop.UseVisualStyleBackColor = true;
			// 
			// grpResults
			// 
			this.grpResults.Controls.Add(this.lblElapsedTime);
			this.grpResults.Controls.Add(this.lblReceivedXPoints);
			this.grpResults.Controls.Add(this.lblRemainingTime);
			this.grpResults.Location = new System.Drawing.Point(358, 91);
			this.grpResults.Name = "grpResults";
			this.grpResults.Size = new System.Drawing.Size(316, 102);
			this.grpResults.TabIndex = 42;
			this.grpResults.TabStop = false;
			this.grpResults.Text = "NS (Results)";
			// 
			// FrmNewAutoMsm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(688, 415);
			this.Controls.Add(this.btnForceStop);
			this.Controls.Add(this.grpResults);
			this.Controls.Add(this.btnStartNewAutoScan);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grpHRes);
			this.Controls.Add(this.grpDepth);
			this.Controls.Add(this.grpSetup);
			this.Name = "FrmNewAutoMsm";
			this.Text = "NS (new auto msm)";
			this.Load += new System.EventHandler(this.FrmNewAutoMsm_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNewAutoMsm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.numAdcMax)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numVRefMax)).EndInit();
			this.grpDepth.ResumeLayout(false);
			this.grpDepth.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMeasPerPnt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numTimeIntervalMs)).EndInit();
			this.grpSetup.ResumeLayout(false);
			this.grpSetup.PerformLayout();
			this.grpHRes.ResumeLayout(false);
			this.grpHRes.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMaxValH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMinValH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numIntervalH)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMaxValV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMinValV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numIntervalV)).EndInit();
			this.grpResults.ResumeLayout(false);
			this.grpResults.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblAdcMax;
		private System.Windows.Forms.NumericUpDown numAdcMax;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numVRefMax;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblRemainingTime;
		private System.Windows.Forms.Label lblReceivedXPoints;
		private System.Windows.Forms.Label lblElapsedTime;
		private System.Windows.Forms.GroupBox grpDepth;
		private System.Windows.Forms.Label lblMsBetweenMeas;
		private System.Windows.Forms.NumericUpDown numTimeIntervalMs;
		private System.Windows.Forms.GroupBox grpSetup;
		private System.Windows.Forms.Label lblMeasPerPoint;
		private System.Windows.Forms.NumericUpDown numMeasPerPnt;
		private System.Windows.Forms.GroupBox grpHRes;
		private System.Windows.Forms.NumericUpDown numMaxValH;
		private System.Windows.Forms.Label lblAndH;
		private System.Windows.Forms.NumericUpDown numMinValH;
		private System.Windows.Forms.Label lblTakeMeasBetweenH;
		private System.Windows.Forms.Label lblIntervalsOfH;
		private System.Windows.Forms.NumericUpDown numIntervalH;
		private System.Windows.Forms.Label lblSummaryHRes;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblSummaryVRes;
		private System.Windows.Forms.NumericUpDown numMaxValV;
		private System.Windows.Forms.Label lblAndV;
		private System.Windows.Forms.NumericUpDown numMinValV;
		private System.Windows.Forms.Label lblTakeMeasBetweenV;
		private System.Windows.Forms.Label lblIntervalsOfV;
		private System.Windows.Forms.NumericUpDown numIntervalV;
		private System.Windows.Forms.Button btnStartNewAutoScan;
		private System.Windows.Forms.Button btnForceStop;
		private System.Windows.Forms.GroupBox grpResults;
	}
}