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
			this.manualNumControlV = new System.Windows.Forms.NumericUpDown();
			this.manualNumControlH = new System.Windows.Forms.NumericUpDown();
			this.manualControlV = new System.Windows.Forms.TrackBar();
			this.manualControlH = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.numVRefMax = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.lblReceivedValue = new System.Windows.Forms.Label();
			this.lblRecvTitle = new System.Windows.Forms.Label();
			this.lblReceivedDistance = new System.Windows.Forms.Label();
			this.lblReceivedVoltage = new System.Windows.Forms.Label();
			this.lblDegH = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblDegV = new System.Windows.Forms.Label();
			this.lblTitleH = new System.Windows.Forms.Label();
			this.lblTitleV = new System.Windows.Forms.Label();
			this.btnActivateManual = new System.Windows.Forms.Button();
			this.btnDeactManual = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.manualNumControlV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.manualNumControlH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.manualControlV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.manualControlH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numVRefMax)).BeginInit();
			this.SuspendLayout();
			// 
			// manualNumControlV
			// 
			this.manualNumControlV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.manualNumControlV.Location = new System.Drawing.Point(424, 25);
			this.manualNumControlV.Name = "manualNumControlV";
			this.manualNumControlV.Size = new System.Drawing.Size(64, 20);
			this.manualNumControlV.TabIndex = 11;
			this.manualNumControlV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.manualNumControlV.ValueChanged += new System.EventHandler(this.manualNumControlV_ValueChanged);
			// 
			// manualNumControlH
			// 
			this.manualNumControlH.Location = new System.Drawing.Point(15, 71);
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
			this.manualControlV.Location = new System.Drawing.Point(460, 67);
			this.manualControlV.Maximum = 100;
			this.manualControlV.Name = "manualControlV";
			this.manualControlV.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.manualControlV.Size = new System.Drawing.Size(42, 211);
			this.manualControlV.TabIndex = 9;
			this.manualControlV.Value = 50;
			this.manualControlV.Scroll += new System.EventHandler(this.manualControlV_Scroll);
			// 
			// manualControlH
			// 
			this.manualControlH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.manualControlH.Location = new System.Drawing.Point(110, 71);
			this.manualControlH.Maximum = 100;
			this.manualControlH.Name = "manualControlH";
			this.manualControlH.Size = new System.Drawing.Size(281, 42);
			this.manualControlH.TabIndex = 8;
			this.manualControlH.Value = 50;
			this.manualControlH.Scroll += new System.EventHandler(this.manualControlH_Scroll);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 137);
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
			this.numVRefMax.Location = new System.Drawing.Point(45, 135);
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
			this.label2.Location = new System.Drawing.Point(114, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 13);
			this.label2.TabIndex = 14;
			this.label2.Tag = "Voltage reference";
			this.label2.Text = "Volt";
			// 
			// lblReceivedValue
			// 
			this.lblReceivedValue.AutoSize = true;
			this.lblReceivedValue.Location = new System.Drawing.Point(45, 202);
			this.lblReceivedValue.Name = "lblReceivedValue";
			this.lblReceivedValue.Size = new System.Drawing.Size(103, 13);
			this.lblReceivedValue.TabIndex = 15;
			this.lblReceivedValue.Text = "Value: UNDEFINED";
			// 
			// lblRecvTitle
			// 
			this.lblRecvTitle.AutoSize = true;
			this.lblRecvTitle.Location = new System.Drawing.Point(12, 182);
			this.lblRecvTitle.Name = "lblRecvTitle";
			this.lblRecvTitle.Size = new System.Drawing.Size(183, 13);
			this.lblRecvTitle.TabIndex = 16;
			this.lblRecvTitle.Text = "NOT SET (title: latest received value)";
			// 
			// lblReceivedDistance
			// 
			this.lblReceivedDistance.AutoSize = true;
			this.lblReceivedDistance.Location = new System.Drawing.Point(45, 245);
			this.lblReceivedDistance.Name = "lblReceivedDistance";
			this.lblReceivedDistance.Size = new System.Drawing.Size(137, 13);
			this.lblReceivedDistance.TabIndex = 17;
			this.lblReceivedDistance.Text = "Distance: UNDEFINED mm";
			// 
			// lblReceivedVoltage
			// 
			this.lblReceivedVoltage.AutoSize = true;
			this.lblReceivedVoltage.Location = new System.Drawing.Point(45, 224);
			this.lblReceivedVoltage.Name = "lblReceivedVoltage";
			this.lblReceivedVoltage.Size = new System.Drawing.Size(205, 13);
			this.lblReceivedVoltage.TabIndex = 18;
			this.lblReceivedVoltage.Text = "Voltage: UNDEFINED (0V=xxxx, 5V=xxxx)";
			// 
			// lblDegH
			// 
			this.lblDegH.AutoSize = true;
			this.lblDegH.Location = new System.Drawing.Point(58, 94);
			this.lblDegH.Name = "lblDegH";
			this.lblDegH.Size = new System.Drawing.Size(25, 13);
			this.lblDegH.TabIndex = 19;
			this.lblDegH.Text = "XXº";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(86, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "µs";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(491, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(18, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "µs";
			// 
			// lblDegV
			// 
			this.lblDegV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDegV.AutoSize = true;
			this.lblDegV.Location = new System.Drawing.Point(463, 51);
			this.lblDegV.Name = "lblDegV";
			this.lblDegV.Size = new System.Drawing.Size(25, 13);
			this.lblDegV.TabIndex = 22;
			this.lblDegV.Text = "XXº";
			// 
			// lblTitleH
			// 
			this.lblTitleH.AutoSize = true;
			this.lblTitleH.Location = new System.Drawing.Point(12, 55);
			this.lblTitleH.Name = "lblTitleH";
			this.lblTitleH.Size = new System.Drawing.Size(281, 13);
			this.lblTitleH.TabIndex = 23;
			this.lblTitleH.Text = "NOT SET [Horizontal movement (duty cycle and degrees)]";
			// 
			// lblTitleV
			// 
			this.lblTitleV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitleV.AutoSize = true;
			this.lblTitleV.Location = new System.Drawing.Point(421, 9);
			this.lblTitleV.Name = "lblTitleV";
			this.lblTitleV.Size = new System.Drawing.Size(69, 13);
			this.lblTitleV.TabIndex = 24;
			this.lblTitleV.Text = "NS [Vertical:]";
			// 
			// btnActivateManual
			// 
			this.btnActivateManual.Location = new System.Drawing.Point(12, 12);
			this.btnActivateManual.Name = "btnActivateManual";
			this.btnActivateManual.Size = new System.Drawing.Size(127, 23);
			this.btnActivateManual.TabIndex = 25;
			this.btnActivateManual.Text = "NS (Activate manual)";
			this.btnActivateManual.UseVisualStyleBackColor = true;
			this.btnActivateManual.Click += new System.EventHandler(this.btnActivateManual_Click);
			// 
			// btnDeactManual
			// 
			this.btnDeactManual.Location = new System.Drawing.Point(145, 12);
			this.btnDeactManual.Name = "btnDeactManual";
			this.btnDeactManual.Size = new System.Drawing.Size(127, 23);
			this.btnDeactManual.TabIndex = 26;
			this.btnDeactManual.Text = "NS (Deactivate manual)";
			this.btnDeactManual.UseVisualStyleBackColor = true;
			this.btnDeactManual.Click += new System.EventHandler(this.btnDeactManual_Click);
			// 
			// FrmManualControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 280);
			this.Controls.Add(this.btnDeactManual);
			this.Controls.Add(this.btnActivateManual);
			this.Controls.Add(this.lblTitleV);
			this.Controls.Add(this.lblTitleH);
			this.Controls.Add(this.lblDegV);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblDegH);
			this.Controls.Add(this.lblReceivedVoltage);
			this.Controls.Add(this.lblReceivedDistance);
			this.Controls.Add(this.lblRecvTitle);
			this.Controls.Add(this.lblReceivedValue);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numVRefMax);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.manualNumControlV);
			this.Controls.Add(this.manualNumControlH);
			this.Controls.Add(this.manualControlV);
			this.Controls.Add(this.manualControlH);
			this.MinimumSize = new System.Drawing.Size(529, 307);
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
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.Label lblRecvTitle;
		private System.Windows.Forms.Label lblReceivedDistance;
		private System.Windows.Forms.Label lblReceivedVoltage;
		private System.Windows.Forms.Label lblDegH;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblDegV;
		private System.Windows.Forms.Label lblTitleH;
		private System.Windows.Forms.Label lblTitleV;
		private System.Windows.Forms.Button btnActivateManual;
		private System.Windows.Forms.Button btnDeactManual;
	}
}