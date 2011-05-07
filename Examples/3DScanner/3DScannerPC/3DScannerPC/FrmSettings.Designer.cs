﻿namespace _3DScannerPC {
	partial class FrmSettings {
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
			this.cbPrintDebugLogs = new System.Windows.Forms.CheckBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.lblT1preload = new System.Windows.Forms.Label();
			this.nbT1preload = new System.Windows.Forms.NumericUpDown();
			this.nbTimeChangesThres = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.cbReqAuth = new System.Windows.Forms.CheckBox();
			this.nbScannerId = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nbAdcMaxVal = new System.Windows.Forms.NumericUpDown();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.numDutyV180 = new System.Windows.Forms.NumericUpDown();
			this.numDutyV0 = new System.Windows.Forms.NumericUpDown();
			this.numDutyH180 = new System.Windows.Forms.NumericUpDown();
			this.numDutyH0 = new System.Windows.Forms.NumericUpDown();
			this.lblDutyV180 = new System.Windows.Forms.Label();
			this.lblDutyV0 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.lblDutyH0 = new System.Windows.Forms.Label();
			this.lblDutyH180 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nbT1preload)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nbTimeChangesThres)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nbScannerId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nbAdcMaxVal)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDutyV180)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDutyV0)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDutyH180)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDutyH0)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbPrintDebugLogs
			// 
			this.cbPrintDebugLogs.AutoSize = true;
			this.cbPrintDebugLogs.Location = new System.Drawing.Point(265, 26);
			this.cbPrintDebugLogs.Name = "cbPrintDebugLogs";
			this.cbPrintDebugLogs.Size = new System.Drawing.Size(126, 17);
			this.cbPrintDebugLogs.TabIndex = 0;
			this.cbPrintDebugLogs.Text = "NS (Print debug logs)";
			this.cbPrintDebugLogs.UseVisualStyleBackColor = true;
			this.cbPrintDebugLogs.CheckedChanged += new System.EventHandler(this.cbPrintDebugLogs_CheckedChanged);
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.Location = new System.Drawing.Point(362, 301);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(106, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "NS (OK)";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// lblT1preload
			// 
			this.lblT1preload.AutoSize = true;
			this.lblT1preload.Location = new System.Drawing.Point(3, 130);
			this.lblT1preload.Name = "lblT1preload";
			this.lblT1preload.Size = new System.Drawing.Size(82, 13);
			this.lblT1preload.TabIndex = 2;
			this.lblT1preload.Text = "NS (T1 preload)";
			// 
			// nbT1preload
			// 
			this.nbT1preload.Location = new System.Drawing.Point(265, 133);
			this.nbT1preload.Maximum = new decimal(new int[] {
            65534,
            0,
            0,
            0});
			this.nbT1preload.Name = "nbT1preload";
			this.nbT1preload.Size = new System.Drawing.Size(126, 20);
			this.nbT1preload.TabIndex = 4;
			this.nbT1preload.ValueChanged += new System.EventHandler(this.nbT1preload_ValueChanged);
			// 
			// nbTimeChangesThres
			// 
			this.nbTimeChangesThres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.nbTimeChangesThres.Location = new System.Drawing.Point(3, 3);
			this.nbTimeChangesThres.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.nbTimeChangesThres.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nbTimeChangesThres.Name = "nbTimeChangesThres";
			this.nbTimeChangesThres.Size = new System.Drawing.Size(123, 20);
			this.nbTimeChangesThres.TabIndex = 5;
			this.nbTimeChangesThres.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nbTimeChangesThres.ValueChanged += new System.EventHandler(this.nbTimeChangesThres_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "NS (On manual control, send changes at least every:";
			// 
			// cbReqAuth
			// 
			this.cbReqAuth.AutoSize = true;
			this.cbReqAuth.Location = new System.Drawing.Point(265, 3);
			this.cbReqAuth.Name = "cbReqAuth";
			this.cbReqAuth.Size = new System.Drawing.Size(157, 17);
			this.cbReqAuth.TabIndex = 7;
			this.cbReqAuth.Text = "NS (Require authentication)";
			this.cbReqAuth.UseVisualStyleBackColor = true;
			this.cbReqAuth.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// nbScannerId
			// 
			this.nbScannerId.Location = new System.Drawing.Point(265, 49);
			this.nbScannerId.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
			this.nbScannerId.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.nbScannerId.Name = "nbScannerId";
			this.nbScannerId.Size = new System.Drawing.Size(126, 20);
			this.nbScannerId.TabIndex = 8;
			this.nbScannerId.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.nbScannerId.ValueChanged += new System.EventHandler(this.nbScabberId_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "NS (Scanner ID)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "NS (Adc maximum value)";
			// 
			// nbAdcMaxVal
			// 
			this.nbAdcMaxVal.Location = new System.Drawing.Point(265, 107);
			this.nbAdcMaxVal.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
			this.nbAdcMaxVal.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.nbAdcMaxVal.Name = "nbAdcMaxVal";
			this.nbAdcMaxVal.Size = new System.Drawing.Size(126, 20);
			this.nbAdcMaxVal.TabIndex = 10;
			this.nbAdcMaxVal.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.nbAdcMaxVal.ValueChanged += new System.EventHandler(this.nbAdcMaxVal_ValueChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.numDutyV180, 1, 9);
			this.tableLayoutPanel1.Controls.Add(this.numDutyV0, 1, 8);
			this.tableLayoutPanel1.Controls.Add(this.numDutyH180, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.numDutyH0, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.lblDutyV180, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.lblDutyV0, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.cbReqAuth, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.nbT1preload, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.lblT1preload, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.cbPrintDebugLogs, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.nbAdcMaxVal, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.nbScannerId, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblDutyH0, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.lblDutyH180, 0, 7);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 11;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(456, 283);
			this.tableLayoutPanel1.TabIndex = 12;
			// 
			// numDutyV180
			// 
			this.numDutyV180.Location = new System.Drawing.Point(265, 237);
			this.numDutyV180.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numDutyV180.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numDutyV180.Name = "numDutyV180";
			this.numDutyV180.Size = new System.Drawing.Size(126, 20);
			this.numDutyV180.TabIndex = 14;
			this.numDutyV180.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numDutyV180.ValueChanged += new System.EventHandler(this.numDutyV180_ValueChanged);
			// 
			// numDutyV0
			// 
			this.numDutyV0.Location = new System.Drawing.Point(265, 211);
			this.numDutyV0.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numDutyV0.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numDutyV0.Name = "numDutyV0";
			this.numDutyV0.Size = new System.Drawing.Size(126, 20);
			this.numDutyV0.TabIndex = 14;
			this.numDutyV0.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numDutyV0.ValueChanged += new System.EventHandler(this.numDutyV0_ValueChanged);
			// 
			// numDutyH180
			// 
			this.numDutyH180.Location = new System.Drawing.Point(265, 185);
			this.numDutyH180.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numDutyH180.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numDutyH180.Name = "numDutyH180";
			this.numDutyH180.Size = new System.Drawing.Size(126, 20);
			this.numDutyH180.TabIndex = 14;
			this.numDutyH180.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numDutyH180.ValueChanged += new System.EventHandler(this.numDutyH180_ValueChanged);
			// 
			// numDutyH0
			// 
			this.numDutyH0.Location = new System.Drawing.Point(265, 159);
			this.numDutyH0.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numDutyH0.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numDutyH0.Name = "numDutyH0";
			this.numDutyH0.Size = new System.Drawing.Size(126, 20);
			this.numDutyH0.TabIndex = 13;
			this.numDutyH0.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numDutyH0.ValueChanged += new System.EventHandler(this.numDutyH0_ValueChanged);
			// 
			// lblDutyV180
			// 
			this.lblDutyV180.AutoSize = true;
			this.lblDutyV180.Location = new System.Drawing.Point(3, 234);
			this.lblDutyV180.Name = "lblDutyV180";
			this.lblDutyV180.Size = new System.Drawing.Size(162, 13);
			this.lblDutyV180.TabIndex = 16;
			this.lblDutyV180.Text = "NS (Duty for 180º, vertical servo)";
			// 
			// lblDutyV0
			// 
			this.lblDutyV0.AutoSize = true;
			this.lblDutyV0.Location = new System.Drawing.Point(3, 208);
			this.lblDutyV0.Name = "lblDutyV0";
			this.lblDutyV0.Size = new System.Drawing.Size(150, 13);
			this.lblDutyV0.TabIndex = 16;
			this.lblDutyV0.Text = "NS (Duty for 0º, vertical servo)";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
			this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.nbTimeChangesThres, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(265, 75);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(246, 26);
			this.tableLayoutPanel2.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(132, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(20, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "ms";
			// 
			// lblDutyH0
			// 
			this.lblDutyH0.AutoSize = true;
			this.lblDutyH0.Location = new System.Drawing.Point(3, 156);
			this.lblDutyH0.Name = "lblDutyH0";
			this.lblDutyH0.Size = new System.Drawing.Size(161, 13);
			this.lblDutyH0.TabIndex = 15;
			this.lblDutyH0.Text = "NS (Duty for 0º, horizontal servo)";
			// 
			// lblDutyH180
			// 
			this.lblDutyH180.AutoSize = true;
			this.lblDutyH180.Location = new System.Drawing.Point(3, 182);
			this.lblDutyH180.Name = "lblDutyH180";
			this.lblDutyH180.Size = new System.Drawing.Size(173, 13);
			this.lblDutyH180.TabIndex = 16;
			this.lblDutyH180.Text = "NS (Duty for 180º, horizontal servo)";
			// 
			// FrmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 336);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.btnOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MinimumSize = new System.Drawing.Size(486, 239);
			this.Name = "FrmSettings";
			this.Text = "NOT SET (Settings)";
			this.Load += new System.EventHandler(this.FrmSettings_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSettings_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.nbT1preload)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nbTimeChangesThres)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nbScannerId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nbAdcMaxVal)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDutyV180)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDutyV0)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDutyH180)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDutyH0)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckBox cbPrintDebugLogs;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Label lblT1preload;
		private System.Windows.Forms.NumericUpDown nbT1preload;
		private System.Windows.Forms.NumericUpDown nbTimeChangesThres;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox cbReqAuth;
		private System.Windows.Forms.NumericUpDown nbScannerId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nbAdcMaxVal;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblDutyH0;
		private System.Windows.Forms.Label lblDutyH180;
		private System.Windows.Forms.Label lblDutyV0;
		private System.Windows.Forms.Label lblDutyV180;
		private System.Windows.Forms.NumericUpDown numDutyV180;
		private System.Windows.Forms.NumericUpDown numDutyV0;
		private System.Windows.Forms.NumericUpDown numDutyH180;
		private System.Windows.Forms.NumericUpDown numDutyH0;
	}
}