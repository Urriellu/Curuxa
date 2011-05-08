namespace _3DScannerPC {
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.numDutyV180 = new System.Windows.Forms.NumericUpDown();
			this.numDutyV0 = new System.Windows.Forms.NumericUpDown();
			this.numDutyH180 = new System.Windows.Forms.NumericUpDown();
			this.numDutyH0 = new System.Windows.Forms.NumericUpDown();
			this.lblDutyV180 = new System.Windows.Forms.Label();
			this.lblDutyV0 = new System.Windows.Forms.Label();
			this.lblDutyH0 = new System.Windows.Forms.Label();
			this.lblDutyH180 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nbT1preload)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nbTimeChangesThres)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nbScannerId)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDutyV180)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDutyV0)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDutyH180)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDutyH0)).BeginInit();
			this.SuspendLayout();
			// 
			// cbPrintDebugLogs
			// 
			this.cbPrintDebugLogs.AutoSize = true;
			this.cbPrintDebugLogs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbPrintDebugLogs.Location = new System.Drawing.Point(3, 26);
			this.cbPrintDebugLogs.Name = "cbPrintDebugLogs";
			this.cbPrintDebugLogs.Size = new System.Drawing.Size(256, 17);
			this.cbPrintDebugLogs.TabIndex = 0;
			this.cbPrintDebugLogs.Text = "NS (Print debug logs)";
			this.cbPrintDebugLogs.UseVisualStyleBackColor = true;
			this.cbPrintDebugLogs.CheckedChanged += new System.EventHandler(this.cbPrintDebugLogs_CheckedChanged);
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.Location = new System.Drawing.Point(362, 260);
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
			this.lblT1preload.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblT1preload.Location = new System.Drawing.Point(3, 98);
			this.lblT1preload.Name = "lblT1preload";
			this.lblT1preload.Size = new System.Drawing.Size(256, 26);
			this.lblT1preload.TabIndex = 2;
			this.lblT1preload.Text = "NS (T1 preload)";
			this.lblT1preload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nbT1preload
			// 
			this.nbT1preload.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nbT1preload.Location = new System.Drawing.Point(265, 101);
			this.nbT1preload.Maximum = new decimal(new int[] {
            65534,
            0,
            0,
            0});
			this.nbT1preload.Name = "nbT1preload";
			this.nbT1preload.Size = new System.Drawing.Size(188, 20);
			this.nbT1preload.TabIndex = 4;
			this.nbT1preload.ValueChanged += new System.EventHandler(this.nbT1preload_ValueChanged);
			// 
			// nbTimeChangesThres
			// 
			this.nbTimeChangesThres.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nbTimeChangesThres.Location = new System.Drawing.Point(265, 75);
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
			this.nbTimeChangesThres.Size = new System.Drawing.Size(188, 20);
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
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 26);
			this.label1.TabIndex = 6;
			this.label1.Text = "NS (On manual control, send changes at least every:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbReqAuth
			// 
			this.cbReqAuth.AutoSize = true;
			this.cbReqAuth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbReqAuth.Location = new System.Drawing.Point(3, 3);
			this.cbReqAuth.Name = "cbReqAuth";
			this.cbReqAuth.Size = new System.Drawing.Size(256, 17);
			this.cbReqAuth.TabIndex = 7;
			this.cbReqAuth.Text = "NS (Require authentication)";
			this.cbReqAuth.UseVisualStyleBackColor = true;
			this.cbReqAuth.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// nbScannerId
			// 
			this.nbScannerId.Dock = System.Windows.Forms.DockStyle.Fill;
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
			this.nbScannerId.Size = new System.Drawing.Size(188, 20);
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
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(256, 26);
			this.label2.TabIndex = 9;
			this.label2.Text = "NS (Scanner ID)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.nbTimeChangesThres, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.numDutyV180, 1, 8);
			this.tableLayoutPanel1.Controls.Add(this.numDutyV0, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.numDutyH180, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.numDutyH0, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.lblDutyV180, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.lblDutyV0, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.nbT1preload, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.lblT1preload, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.nbScannerId, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblDutyH0, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.lblDutyH180, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.cbReqAuth, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.cbPrintDebugLogs, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 10;
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
			this.tableLayoutPanel1.Size = new System.Drawing.Size(456, 242);
			this.tableLayoutPanel1.TabIndex = 12;
			// 
			// numDutyV180
			// 
			this.numDutyV180.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numDutyV180.Location = new System.Drawing.Point(265, 205);
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
			this.numDutyV180.Size = new System.Drawing.Size(188, 20);
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
			this.numDutyV0.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numDutyV0.Location = new System.Drawing.Point(265, 179);
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
			this.numDutyV0.Size = new System.Drawing.Size(188, 20);
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
			this.numDutyH180.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numDutyH180.Location = new System.Drawing.Point(265, 153);
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
			this.numDutyH180.Size = new System.Drawing.Size(188, 20);
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
			this.numDutyH0.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numDutyH0.Location = new System.Drawing.Point(265, 127);
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
			this.numDutyH0.Size = new System.Drawing.Size(188, 20);
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
			this.lblDutyV180.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDutyV180.Location = new System.Drawing.Point(3, 202);
			this.lblDutyV180.Name = "lblDutyV180";
			this.lblDutyV180.Size = new System.Drawing.Size(256, 26);
			this.lblDutyV180.TabIndex = 16;
			this.lblDutyV180.Text = "NS (Duty for 180º, vertical servo)";
			this.lblDutyV180.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDutyV0
			// 
			this.lblDutyV0.AutoSize = true;
			this.lblDutyV0.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDutyV0.Location = new System.Drawing.Point(3, 176);
			this.lblDutyV0.Name = "lblDutyV0";
			this.lblDutyV0.Size = new System.Drawing.Size(256, 26);
			this.lblDutyV0.TabIndex = 16;
			this.lblDutyV0.Text = "NS (Duty for 0º, vertical servo)";
			this.lblDutyV0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDutyH0
			// 
			this.lblDutyH0.AutoSize = true;
			this.lblDutyH0.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDutyH0.Location = new System.Drawing.Point(3, 124);
			this.lblDutyH0.Name = "lblDutyH0";
			this.lblDutyH0.Size = new System.Drawing.Size(256, 26);
			this.lblDutyH0.TabIndex = 15;
			this.lblDutyH0.Text = "NS (Duty for 0º, horizontal servo)";
			this.lblDutyH0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDutyH180
			// 
			this.lblDutyH180.AutoSize = true;
			this.lblDutyH180.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDutyH180.Location = new System.Drawing.Point(3, 150);
			this.lblDutyH180.Name = "lblDutyH180";
			this.lblDutyH180.Size = new System.Drawing.Size(256, 26);
			this.lblDutyH180.TabIndex = 16;
			this.lblDutyH180.Text = "NS (Duty for 180º, horizontal servo)";
			this.lblDutyH180.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FrmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 295);
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
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDutyV180)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDutyV0)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDutyH180)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDutyH0)).EndInit();
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
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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