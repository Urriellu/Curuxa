namespace _3DScannerPC {
	partial class FrmManualControl {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManualControl));
			this.manualNumControlV = new System.Windows.Forms.NumericUpDown();
			this.manualNumControlH = new System.Windows.Forms.NumericUpDown();
			this.manualControlV = new System.Windows.Forms.TrackBar();
			this.manualControlH = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.numVRefMax = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.lblReceivedValue = new System.Windows.Forms.Label();
			this.lblReceivedDistance = new System.Windows.Forms.Label();
			this.lblReceivedVoltage = new System.Windows.Forms.Label();
			this.lblDegH = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblDegV = new System.Windows.Forms.Label();
			this.btnActivateManual = new System.Windows.Forms.Button();
			this.btnDeactManual = new System.Windows.Forms.Button();
			this.picObject = new System.Windows.Forms.PictureBox();
			this.picView = new System.Windows.Forms.PictureBox();
			this.grpClosestObj = new System.Windows.Forms.GroupBox();
			this.grpInstantValue = new System.Windows.Forms.GroupBox();
			this.grpSetup = new System.Windows.Forms.GroupBox();
			this.lblAdcMax = new System.Windows.Forms.Label();
			this.numAdcMax = new System.Windows.Forms.NumericUpDown();
			this.grpControlH = new System.Windows.Forms.GroupBox();
			this.lblDuty = new System.Windows.Forms.Label();
			this.grpControlV = new System.Windows.Forms.GroupBox();
			this.grpMeasPoints = new System.Windows.Forms.GroupBox();
			this.lblAvgEvery = new System.Windows.Forms.Label();
			this.numAvg = new System.Windows.Forms.NumericUpDown();
			this.lblPoints = new System.Windows.Forms.Label();
			this.graph = new ZedGraph.ZedGraphControl();
			((System.ComponentModel.ISupportInitialize)(this.manualNumControlV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.manualNumControlH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.manualControlV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.manualControlH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numVRefMax)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picObject)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
			this.grpClosestObj.SuspendLayout();
			this.grpInstantValue.SuspendLayout();
			this.grpSetup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAdcMax)).BeginInit();
			this.grpControlH.SuspendLayout();
			this.grpControlV.SuspendLayout();
			this.grpMeasPoints.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAvg)).BeginInit();
			this.SuspendLayout();
			// 
			// manualNumControlV
			// 
			this.manualNumControlV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.manualNumControlV.Location = new System.Drawing.Point(18, 32);
			this.manualNumControlV.Name = "manualNumControlV";
			this.manualNumControlV.Size = new System.Drawing.Size(64, 20);
			this.manualNumControlV.TabIndex = 11;
			this.manualNumControlV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.manualNumControlV.ValueChanged += new System.EventHandler(this.manualNumControlV_ValueChanged);
			// 
			// manualNumControlH
			// 
			this.manualNumControlH.Location = new System.Drawing.Point(51, 26);
			this.manualNumControlH.Name = "manualNumControlH";
			this.manualNumControlH.Size = new System.Drawing.Size(68, 20);
			this.manualNumControlH.TabIndex = 10;
			this.manualNumControlH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.manualNumControlH.ValueChanged += new System.EventHandler(this.manualNumControlH_ValueChanged);
			// 
			// manualControlV
			// 
			this.manualControlV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.manualControlV.Location = new System.Drawing.Point(40, 78);
			this.manualControlV.Maximum = 100;
			this.manualControlV.Name = "manualControlV";
			this.manualControlV.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.manualControlV.Size = new System.Drawing.Size(42, 508);
			this.manualControlV.TabIndex = 9;
			this.manualControlV.Value = 50;
			this.manualControlV.Scroll += new System.EventHandler(this.manualControlV_Scroll);
			// 
			// manualControlH
			// 
			this.manualControlH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.manualControlH.Location = new System.Drawing.Point(146, 26);
			this.manualControlH.Maximum = 100;
			this.manualControlH.Name = "manualControlH";
			this.manualControlH.Size = new System.Drawing.Size(262, 42);
			this.manualControlH.TabIndex = 8;
			this.manualControlH.Value = 50;
			this.manualControlH.Scroll += new System.EventHandler(this.manualControlH_Scroll);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 12;
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
			this.numVRefMax.Location = new System.Drawing.Point(43, 29);
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
			this.numVRefMax.TabIndex = 13;
			this.numVRefMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numVRefMax.Value = new decimal(new int[] {
            500,
            0,
            0,
            131072});
			this.numVRefMax.ValueChanged += new System.EventHandler(this.numVRefMax_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(112, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 13);
			this.label2.TabIndex = 14;
			this.label2.Tag = "Voltage reference";
			this.label2.Text = "Volt";
			// 
			// lblReceivedValue
			// 
			this.lblReceivedValue.AutoSize = true;
			this.lblReceivedValue.Location = new System.Drawing.Point(13, 27);
			this.lblReceivedValue.Name = "lblReceivedValue";
			this.lblReceivedValue.Size = new System.Drawing.Size(103, 13);
			this.lblReceivedValue.TabIndex = 15;
			this.lblReceivedValue.Text = "Value: UNDEFINED";
			// 
			// lblReceivedDistance
			// 
			this.lblReceivedDistance.AutoSize = true;
			this.lblReceivedDistance.Location = new System.Drawing.Point(13, 70);
			this.lblReceivedDistance.Name = "lblReceivedDistance";
			this.lblReceivedDistance.Size = new System.Drawing.Size(137, 13);
			this.lblReceivedDistance.TabIndex = 17;
			this.lblReceivedDistance.Text = "Distance: UNDEFINED mm";
			// 
			// lblReceivedVoltage
			// 
			this.lblReceivedVoltage.AutoSize = true;
			this.lblReceivedVoltage.Location = new System.Drawing.Point(13, 49);
			this.lblReceivedVoltage.Name = "lblReceivedVoltage";
			this.lblReceivedVoltage.Size = new System.Drawing.Size(205, 13);
			this.lblReceivedVoltage.TabIndex = 18;
			this.lblReceivedVoltage.Text = "Voltage: UNDEFINED (0V=xxxx, 5V=xxxx)";
			// 
			// lblDegH
			// 
			this.lblDegH.AutoSize = true;
			this.lblDegH.Location = new System.Drawing.Point(13, 55);
			this.lblDegH.Name = "lblDegH";
			this.lblDegH.Size = new System.Drawing.Size(71, 13);
			this.lblDegH.TabIndex = 19;
			this.lblDegH.Text = "Degrees: XXº";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(122, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "µs";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(85, 34);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(18, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "µs";
			// 
			// lblDegV
			// 
			this.lblDegV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDegV.AutoSize = true;
			this.lblDegV.Location = new System.Drawing.Point(15, 62);
			this.lblDegV.Name = "lblDegV";
			this.lblDegV.Size = new System.Drawing.Size(25, 13);
			this.lblDegV.TabIndex = 22;
			this.lblDegV.Text = "XXº";
			// 
			// btnActivateManual
			// 
			this.btnActivateManual.Location = new System.Drawing.Point(13, 61);
			this.btnActivateManual.Name = "btnActivateManual";
			this.btnActivateManual.Size = new System.Drawing.Size(127, 23);
			this.btnActivateManual.TabIndex = 25;
			this.btnActivateManual.Text = "NS (Activate manual)";
			this.btnActivateManual.UseVisualStyleBackColor = true;
			this.btnActivateManual.Click += new System.EventHandler(this.btnActivateManual_Click);
			// 
			// btnDeactManual
			// 
			this.btnDeactManual.Location = new System.Drawing.Point(146, 61);
			this.btnDeactManual.Name = "btnDeactManual";
			this.btnDeactManual.Size = new System.Drawing.Size(127, 23);
			this.btnDeactManual.TabIndex = 26;
			this.btnDeactManual.Text = "NS (Deactivate manual)";
			this.btnDeactManual.UseVisualStyleBackColor = true;
			this.btnDeactManual.Click += new System.EventHandler(this.btnDeactManual_Click);
			// 
			// picObject
			// 
			this.picObject.Image = ((System.Drawing.Image)(resources.GetObject("picObject.Image")));
			this.picObject.Location = new System.Drawing.Point(81, 29);
			this.picObject.Name = "picObject";
			this.picObject.Size = new System.Drawing.Size(48, 48);
			this.picObject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picObject.TabIndex = 27;
			this.picObject.TabStop = false;
			// 
			// picView
			// 
			this.picView.Image = ((System.Drawing.Image)(resources.GetObject("picView.Image")));
			this.picView.Location = new System.Drawing.Point(13, 39);
			this.picView.Name = "picView";
			this.picView.Size = new System.Drawing.Size(49, 27);
			this.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picView.TabIndex = 28;
			this.picView.TabStop = false;
			// 
			// grpClosestObj
			// 
			this.grpClosestObj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpClosestObj.Controls.Add(this.picView);
			this.grpClosestObj.Controls.Add(this.picObject);
			this.grpClosestObj.Location = new System.Drawing.Point(12, 312);
			this.grpClosestObj.Name = "grpClosestObj";
			this.grpClosestObj.Size = new System.Drawing.Size(414, 94);
			this.grpClosestObj.TabIndex = 29;
			this.grpClosestObj.TabStop = false;
			this.grpClosestObj.Text = "NS (closest object)";
			// 
			// grpInstantValue
			// 
			this.grpInstantValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpInstantValue.Controls.Add(this.lblReceivedValue);
			this.grpInstantValue.Controls.Add(this.lblReceivedDistance);
			this.grpInstantValue.Controls.Add(this.lblReceivedVoltage);
			this.grpInstantValue.Enabled = false;
			this.grpInstantValue.Location = new System.Drawing.Point(12, 206);
			this.grpInstantValue.Name = "grpInstantValue";
			this.grpInstantValue.Size = new System.Drawing.Size(414, 100);
			this.grpInstantValue.TabIndex = 30;
			this.grpInstantValue.TabStop = false;
			this.grpInstantValue.Text = "NS (latest received value)";
			// 
			// grpSetup
			// 
			this.grpSetup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpSetup.Controls.Add(this.lblAdcMax);
			this.grpSetup.Controls.Add(this.numAdcMax);
			this.grpSetup.Controls.Add(this.btnActivateManual);
			this.grpSetup.Controls.Add(this.btnDeactManual);
			this.grpSetup.Controls.Add(this.label1);
			this.grpSetup.Controls.Add(this.numVRefMax);
			this.grpSetup.Controls.Add(this.label2);
			this.grpSetup.Location = new System.Drawing.Point(12, 12);
			this.grpSetup.Name = "grpSetup";
			this.grpSetup.Size = new System.Drawing.Size(414, 100);
			this.grpSetup.TabIndex = 31;
			this.grpSetup.TabStop = false;
			this.grpSetup.Text = "NS (Setup)";
			// 
			// lblAdcMax
			// 
			this.lblAdcMax.AutoSize = true;
			this.lblAdcMax.Location = new System.Drawing.Point(218, 31);
			this.lblAdcMax.Name = "lblAdcMax";
			this.lblAdcMax.Size = new System.Drawing.Size(55, 13);
			this.lblAdcMax.TabIndex = 27;
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
			this.numAdcMax.Location = new System.Drawing.Point(279, 29);
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
			this.numAdcMax.TabIndex = 28;
			this.numAdcMax.Value = new decimal(new int[] {
            1023,
            0,
            0,
            0});
			this.numAdcMax.ValueChanged += new System.EventHandler(this.numAdcMax_ValueChanged);
			// 
			// grpControlH
			// 
			this.grpControlH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpControlH.Controls.Add(this.lblDuty);
			this.grpControlH.Controls.Add(this.manualControlH);
			this.grpControlH.Controls.Add(this.manualNumControlH);
			this.grpControlH.Controls.Add(this.lblDegH);
			this.grpControlH.Controls.Add(this.label4);
			this.grpControlH.Location = new System.Drawing.Point(12, 118);
			this.grpControlH.Name = "grpControlH";
			this.grpControlH.Size = new System.Drawing.Size(414, 82);
			this.grpControlH.TabIndex = 32;
			this.grpControlH.TabStop = false;
			this.grpControlH.Text = "NS (Horizontal Control)";
			// 
			// lblDuty
			// 
			this.lblDuty.AutoSize = true;
			this.lblDuty.Location = new System.Drawing.Point(13, 28);
			this.lblDuty.Name = "lblDuty";
			this.lblDuty.Size = new System.Drawing.Size(32, 13);
			this.lblDuty.TabIndex = 21;
			this.lblDuty.Text = "Duty:";
			// 
			// grpControlV
			// 
			this.grpControlV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpControlV.Controls.Add(this.manualNumControlV);
			this.grpControlV.Controls.Add(this.manualControlV);
			this.grpControlV.Controls.Add(this.label5);
			this.grpControlV.Controls.Add(this.lblDegV);
			this.grpControlV.Location = new System.Drawing.Point(432, 12);
			this.grpControlV.Name = "grpControlV";
			this.grpControlV.Size = new System.Drawing.Size(121, 592);
			this.grpControlV.TabIndex = 33;
			this.grpControlV.TabStop = false;
			this.grpControlV.Text = "NS (Vertical Control)";
			// 
			// grpMeasPoints
			// 
			this.grpMeasPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpMeasPoints.Controls.Add(this.lblAvgEvery);
			this.grpMeasPoints.Controls.Add(this.numAvg);
			this.grpMeasPoints.Controls.Add(this.lblPoints);
			this.grpMeasPoints.Controls.Add(this.graph);
			this.grpMeasPoints.Location = new System.Drawing.Point(12, 412);
			this.grpMeasPoints.Name = "grpMeasPoints";
			this.grpMeasPoints.Size = new System.Drawing.Size(414, 192);
			this.grpMeasPoints.TabIndex = 34;
			this.grpMeasPoints.TabStop = false;
			this.grpMeasPoints.Text = "NS (Measured points)";
			// 
			// lblAvgEvery
			// 
			this.lblAvgEvery.AutoSize = true;
			this.lblAvgEvery.Location = new System.Drawing.Point(13, 28);
			this.lblAvgEvery.Name = "lblAvgEvery";
			this.lblAvgEvery.Size = new System.Drawing.Size(100, 13);
			this.lblAvgEvery.TabIndex = 15;
			this.lblAvgEvery.Tag = "";
			this.lblAvgEvery.Text = "NS (Average every)";
			// 
			// numAvg
			// 
			this.numAvg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numAvg.Location = new System.Drawing.Point(119, 26);
			this.numAvg.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numAvg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numAvg.Name = "numAvg";
			this.numAvg.Size = new System.Drawing.Size(63, 20);
			this.numAvg.TabIndex = 16;
			this.numAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numAvg.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// lblPoints
			// 
			this.lblPoints.AutoSize = true;
			this.lblPoints.Location = new System.Drawing.Point(188, 28);
			this.lblPoints.Name = "lblPoints";
			this.lblPoints.Size = new System.Drawing.Size(59, 13);
			this.lblPoints.TabIndex = 17;
			this.lblPoints.Tag = "Voltage reference";
			this.lblPoints.Text = "NS (points)";
			// 
			// graph
			// 
			this.graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.graph.Location = new System.Drawing.Point(6, 52);
			this.graph.Name = "graph";
			this.graph.ScrollGrace = 0;
			this.graph.ScrollMaxX = 0;
			this.graph.ScrollMaxY = 0;
			this.graph.ScrollMaxY2 = 0;
			this.graph.ScrollMinX = 0;
			this.graph.ScrollMinY = 0;
			this.graph.ScrollMinY2 = 0;
			this.graph.Size = new System.Drawing.Size(402, 134);
			this.graph.TabIndex = 0;
			// 
			// FrmManualControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 616);
			this.Controls.Add(this.grpMeasPoints);
			this.Controls.Add(this.grpControlV);
			this.Controls.Add(this.grpControlH);
			this.Controls.Add(this.grpSetup);
			this.Controls.Add(this.grpInstantValue);
			this.Controls.Add(this.grpClosestObj);
			this.MinimumSize = new System.Drawing.Size(573, 643);
			this.Name = "FrmManualControl";
			this.ShowIcon = false;
			this.Text = "NOT SET (Manual Control)";
			this.Load += new System.EventHandler(this.FrmManualControl_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmManualControl_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.manualNumControlV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.manualNumControlH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.manualControlV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.manualControlH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numVRefMax)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picObject)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
			this.grpClosestObj.ResumeLayout(false);
			this.grpClosestObj.PerformLayout();
			this.grpInstantValue.ResumeLayout(false);
			this.grpInstantValue.PerformLayout();
			this.grpSetup.ResumeLayout(false);
			this.grpSetup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAdcMax)).EndInit();
			this.grpControlH.ResumeLayout(false);
			this.grpControlH.PerformLayout();
			this.grpControlV.ResumeLayout(false);
			this.grpControlV.PerformLayout();
			this.grpMeasPoints.ResumeLayout(false);
			this.grpMeasPoints.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAvg)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NumericUpDown manualNumControlV;
		private System.Windows.Forms.NumericUpDown manualNumControlH;
		private System.Windows.Forms.TrackBar manualControlV;
		private System.Windows.Forms.TrackBar manualControlH;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numVRefMax;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblReceivedValue;
		private System.Windows.Forms.Label lblReceivedDistance;
		private System.Windows.Forms.Label lblReceivedVoltage;
		private System.Windows.Forms.Label lblDegH;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblDegV;
		private System.Windows.Forms.Button btnActivateManual;
		private System.Windows.Forms.Button btnDeactManual;
		private System.Windows.Forms.PictureBox picObject;
		private System.Windows.Forms.PictureBox picView;
		private System.Windows.Forms.GroupBox grpClosestObj;
		private System.Windows.Forms.GroupBox grpInstantValue;
		private System.Windows.Forms.GroupBox grpSetup;
		private System.Windows.Forms.GroupBox grpControlH;
		private System.Windows.Forms.GroupBox grpControlV;
		private System.Windows.Forms.Label lblDuty;
		private System.Windows.Forms.GroupBox grpMeasPoints;
		private ZedGraph.ZedGraphControl graph;
		private System.Windows.Forms.Label lblAdcMax;
		private System.Windows.Forms.NumericUpDown numAdcMax;
		private System.Windows.Forms.Label lblAvgEvery;
		private System.Windows.Forms.NumericUpDown numAvg;
		private System.Windows.Forms.Label lblPoints;
	}
}