namespace _3DScannerPC {
	partial class FrmRawMsms {
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("first one");
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("second one");
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "fdh",
            "a02",
            "b03",
            "c04",
            "d05"}, -1);
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.splitMain = new System.Windows.Forms.SplitContainer();
			this.lstMsms = new System.Windows.Forms.ListView();
			this.columnName = new System.Windows.Forms.ColumnHeader();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lstPoints = new System.Windows.Forms.ListView();
			this.columnId = new System.Windows.Forms.ColumnHeader();
			this.columnPosH = new System.Windows.Forms.ColumnHeader();
			this.columnPosV = new System.Windows.Forms.ColumnHeader();
			this.columnAdcValue = new System.Windows.Forms.ColumnHeader();
			this.columnVolts = new System.Windows.Forms.ColumnHeader();
			this.columnDistanceMm = new System.Windows.Forms.ColumnHeader();
			this.picBox = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.numAdcMax = new System.Windows.Forms.NumericUpDown();
			this.lblAdcMax = new System.Windows.Forms.Label();
			this.lblVRef = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.numBaseLocZ = new System.Windows.Forms.NumericUpDown();
			this.numBaseLocY = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.numBaseLocX = new System.Windows.Forms.NumericUpDown();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblDateTitle = new System.Windows.Forms.Label();
			this.lblDateValue = new System.Windows.Forms.Label();
			this.lblBaseLoc = new System.Windows.Forms.Label();
			this.lblBaseRot = new System.Windows.Forms.Label();
			this.numBaseRot = new System.Windows.Forms.NumericUpDown();
			this.numVRef = new System.Windows.Forms.NumericUpDown();
			this.splitMain.Panel1.SuspendLayout();
			this.splitMain.Panel2.SuspendLayout();
			this.splitMain.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAdcMax)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numBaseLocZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numBaseLocY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numBaseLocX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numBaseRot)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numVRef)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnOpen.Location = new System.Drawing.Point(12, 391);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 1;
			this.btnOpen.Text = "NS (Open)";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRemove.Enabled = false;
			this.btnRemove.Location = new System.Drawing.Point(93, 391);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 2;
			this.btnRemove.Text = "NS Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// splitMain
			// 
			this.splitMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitMain.Location = new System.Drawing.Point(12, 12);
			this.splitMain.Name = "splitMain";
			// 
			// splitMain.Panel1
			// 
			this.splitMain.Panel1.Controls.Add(this.lstMsms);
			// 
			// splitMain.Panel2
			// 
			this.splitMain.Panel2.Controls.Add(this.splitContainer1);
			this.splitMain.Panel2.Controls.Add(this.tableLayoutPanel1);
			this.splitMain.Size = new System.Drawing.Size(903, 373);
			this.splitMain.SplitterDistance = 135;
			this.splitMain.TabIndex = 3;
			// 
			// lstMsms
			// 
			this.lstMsms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName});
			this.lstMsms.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstMsms.HideSelection = false;
			this.lstMsms.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
			this.lstMsms.Location = new System.Drawing.Point(0, 0);
			this.lstMsms.MultiSelect = false;
			this.lstMsms.Name = "lstMsms";
			this.lstMsms.Size = new System.Drawing.Size(135, 373);
			this.lstMsms.TabIndex = 1;
			this.lstMsms.UseCompatibleStateImageBehavior = false;
			this.lstMsms.View = System.Windows.Forms.View.List;
			this.lstMsms.SelectedIndexChanged += new System.EventHandler(this.listMsms_SelectedIndexChanged);
			// 
			// columnName
			// 
			this.columnName.Text = "NS (Name)";
			this.columnName.Width = 300;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(2, 92);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lstPoints);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.picBox);
			this.splitContainer1.Size = new System.Drawing.Size(762, 281);
			this.splitContainer1.SplitterDistance = 355;
			this.splitContainer1.TabIndex = 5;
			// 
			// lstPoints
			// 
			this.lstPoints.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.lstPoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnPosH,
            this.columnPosV,
            this.columnAdcValue,
            this.columnVolts,
            this.columnDistanceMm});
			this.lstPoints.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstPoints.HideSelection = false;
			listViewItem3.StateImageIndex = 0;
			this.lstPoints.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
			this.lstPoints.LabelEdit = true;
			this.lstPoints.Location = new System.Drawing.Point(0, 0);
			this.lstPoints.MultiSelect = false;
			this.lstPoints.Name = "lstPoints";
			this.lstPoints.Size = new System.Drawing.Size(355, 281);
			this.lstPoints.TabIndex = 2;
			this.lstPoints.UseCompatibleStateImageBehavior = false;
			this.lstPoints.View = System.Windows.Forms.View.Details;
			// 
			// columnId
			// 
			this.columnId.Text = "ID";
			this.columnId.Width = 37;
			// 
			// columnPosH
			// 
			this.columnPosH.Text = "H [º]";
			this.columnPosH.Width = 72;
			// 
			// columnPosV
			// 
			this.columnPosV.Text = "V [º]";
			// 
			// columnAdcValue
			// 
			this.columnAdcValue.Text = "ADC";
			// 
			// columnVolts
			// 
			this.columnVolts.Text = "Volts";
			// 
			// columnDistanceMm
			// 
			this.columnDistanceMm.Text = "mm";
			// 
			// picBox
			// 
			this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picBox.Location = new System.Drawing.Point(0, 0);
			this.picBox.Name = "picBox";
			this.picBox.Size = new System.Drawing.Size(403, 281);
			this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBox.TabIndex = 5;
			this.picBox.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.numAdcMax, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblAdcMax, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblVRef, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblDateTitle, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblDateValue, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblBaseLoc, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblBaseRot, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.numBaseRot, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.numVRef, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 86);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// numAdcMax
			// 
			this.numAdcMax.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numAdcMax.Location = new System.Drawing.Point(68, 58);
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
			this.numAdcMax.Size = new System.Drawing.Size(199, 20);
			this.numAdcMax.TabIndex = 10;
			this.numAdcMax.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
			// 
			// lblAdcMax
			// 
			this.lblAdcMax.AutoSize = true;
			this.lblAdcMax.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblAdcMax.Location = new System.Drawing.Point(3, 55);
			this.lblAdcMax.Name = "lblAdcMax";
			this.lblAdcMax.Size = new System.Drawing.Size(59, 31);
			this.lblAdcMax.TabIndex = 10;
			this.lblAdcMax.Text = "ADC Max.:";
			this.lblAdcMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblVRef
			// 
			this.lblVRef.AutoSize = true;
			this.lblVRef.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblVRef.Location = new System.Drawing.Point(3, 26);
			this.lblVRef.Name = "lblVRef";
			this.lblVRef.Size = new System.Drawing.Size(59, 29);
			this.lblVRef.TabIndex = 6;
			this.lblVRef.Text = "V. Ref.:";
			this.lblVRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 6;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Controls.Add(this.numBaseLocZ, 5, 0);
			this.tableLayoutPanel2.Controls.Add(this.numBaseLocY, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.numBaseLocX, 1, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(378, 29);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(378, 23);
			this.tableLayoutPanel2.TabIndex = 4;
			// 
			// numBaseLocZ
			// 
			this.numBaseLocZ.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numBaseLocZ.Location = new System.Drawing.Point(278, 3);
			this.numBaseLocZ.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numBaseLocZ.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
			this.numBaseLocZ.Name = "numBaseLocZ";
			this.numBaseLocZ.Size = new System.Drawing.Size(97, 20);
			this.numBaseLocZ.TabIndex = 7;
			// 
			// numBaseLocY
			// 
			this.numBaseLocY.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numBaseLocY.Location = new System.Drawing.Point(152, 3);
			this.numBaseLocY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numBaseLocY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
			this.numBaseLocY.Name = "numBaseLocY";
			this.numBaseLocY.Size = new System.Drawing.Size(97, 20);
			this.numBaseLocY.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(255, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(17, 26);
			this.label5.TabIndex = 5;
			this.label5.Text = "Z:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 26);
			this.label3.TabIndex = 0;
			this.label3.Text = "X:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(129, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 26);
			this.label4.TabIndex = 1;
			this.label4.Text = "Y:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numBaseLocX
			// 
			this.numBaseLocX.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numBaseLocX.Location = new System.Drawing.Point(26, 3);
			this.numBaseLocX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numBaseLocX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
			this.numBaseLocX.Name = "numBaseLocX";
			this.numBaseLocX.Size = new System.Drawing.Size(97, 20);
			this.numBaseLocX.TabIndex = 6;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblName.Location = new System.Drawing.Point(3, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(59, 26);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "NS (Name)";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtName
			// 
			this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtName.Location = new System.Drawing.Point(68, 3);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(199, 20);
			this.txtName.TabIndex = 1;
			// 
			// lblDateTitle
			// 
			this.lblDateTitle.AutoSize = true;
			this.lblDateTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDateTitle.Location = new System.Drawing.Point(273, 0);
			this.lblDateTitle.Name = "lblDateTitle";
			this.lblDateTitle.Size = new System.Drawing.Size(99, 26);
			this.lblDateTitle.TabIndex = 2;
			this.lblDateTitle.Text = "NS (Date)";
			this.lblDateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDateValue
			// 
			this.lblDateValue.AutoSize = true;
			this.lblDateValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDateValue.Location = new System.Drawing.Point(378, 0);
			this.lblDateValue.Name = "lblDateValue";
			this.lblDateValue.Size = new System.Drawing.Size(378, 26);
			this.lblDateValue.TabIndex = 3;
			this.lblDateValue.Text = "NOT SET";
			this.lblDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblBaseLoc
			// 
			this.lblBaseLoc.AutoSize = true;
			this.lblBaseLoc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblBaseLoc.Location = new System.Drawing.Point(273, 26);
			this.lblBaseLoc.Name = "lblBaseLoc";
			this.lblBaseLoc.Size = new System.Drawing.Size(99, 29);
			this.lblBaseLoc.TabIndex = 5;
			this.lblBaseLoc.Text = "NS (Base Location)";
			this.lblBaseLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblBaseRot
			// 
			this.lblBaseRot.AutoSize = true;
			this.lblBaseRot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblBaseRot.Location = new System.Drawing.Point(273, 55);
			this.lblBaseRot.Name = "lblBaseRot";
			this.lblBaseRot.Size = new System.Drawing.Size(99, 31);
			this.lblBaseRot.TabIndex = 7;
			this.lblBaseRot.Text = "NS (Base Rotation)";
			this.lblBaseRot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numBaseRot
			// 
			this.numBaseRot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numBaseRot.Location = new System.Drawing.Point(378, 58);
			this.numBaseRot.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.numBaseRot.Name = "numBaseRot";
			this.numBaseRot.Size = new System.Drawing.Size(378, 20);
			this.numBaseRot.TabIndex = 8;
			// 
			// numVRef
			// 
			this.numVRef.DecimalPlaces = 2;
			this.numVRef.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numVRef.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numVRef.Location = new System.Drawing.Point(68, 29);
			this.numVRef.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
			this.numVRef.Minimum = new decimal(new int[] {
            34,
            0,
            0,
            65536});
			this.numVRef.Name = "numVRef";
			this.numVRef.Size = new System.Drawing.Size(199, 20);
			this.numVRef.TabIndex = 9;
			this.numVRef.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// FrmRawMsms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(927, 426);
			this.Controls.Add(this.splitMain);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnOpen);
			this.MinimumSize = new System.Drawing.Size(919, 286);
			this.Name = "FrmRawMsms";
			this.Text = "NS (Raw Measurements)";
			this.Load += new System.EventHandler(this.FrmRawMsms_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRawMsms_FormClosing);
			this.splitMain.Panel1.ResumeLayout(false);
			this.splitMain.Panel2.ResumeLayout(false);
			this.splitMain.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAdcMax)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numBaseLocZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numBaseLocY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numBaseLocX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numBaseRot)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numVRef)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.SplitContainer splitMain;
		private System.Windows.Forms.ListView lstMsms;
		private System.Windows.Forms.ColumnHeader columnName;
		private System.Windows.Forms.ListView lstPoints;
		private System.Windows.Forms.ColumnHeader columnPosH;
		private System.Windows.Forms.ColumnHeader columnPosV;
		private System.Windows.Forms.ColumnHeader columnAdcValue;
		private System.Windows.Forms.ColumnHeader columnVolts;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblDateTitle;
		private System.Windows.Forms.Label lblDateValue;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.NumericUpDown numBaseLocZ;
		private System.Windows.Forms.NumericUpDown numBaseLocY;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numBaseLocX;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblVRef;
		private System.Windows.Forms.Label lblBaseLoc;
		private System.Windows.Forms.Label lblBaseRot;
		private System.Windows.Forms.NumericUpDown numBaseRot;
		private System.Windows.Forms.Label lblAdcMax;
		private System.Windows.Forms.NumericUpDown numVRef;
		private System.Windows.Forms.NumericUpDown numAdcMax;
		private System.Windows.Forms.ColumnHeader columnDistanceMm;
		private System.Windows.Forms.ColumnHeader columnId;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.PictureBox picBox;
	}
}