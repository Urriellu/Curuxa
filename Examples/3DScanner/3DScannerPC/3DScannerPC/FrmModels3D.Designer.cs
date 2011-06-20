namespace _3DScannerPC {
	partial class FrmModels3D {
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
			this.lstModels = new System.Windows.Forms.ListView();
			this.columnName = new System.Windows.Forms.ColumnHeader();
			this.btnOpenModel = new System.Windows.Forms.Button();
			this.btnRemoveModel = new System.Windows.Forms.Button();
			this.lstPoints = new System.Windows.Forms.ListView();
			this.columnId = new System.Windows.Forms.ColumnHeader();
			this.columnX = new System.Windows.Forms.ColumnHeader();
			this.columnY = new System.Windows.Forms.ColumnHeader();
			this.columnZ = new System.Windows.Forms.ColumnHeader();
			this.btnImport = new System.Windows.Forms.Button();
			this.btnExportComma = new System.Windows.Forms.Button();
			this.lblExport = new System.Windows.Forms.Label();
			this.btnExportTabbed = new System.Windows.Forms.Button();
			this.btnNewModel = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblDate = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstModels
			// 
			this.lstModels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.lstModels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName});
			this.lstModels.HideSelection = false;
			this.lstModels.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
			this.lstModels.Location = new System.Drawing.Point(12, 12);
			this.lstModels.MultiSelect = false;
			this.lstModels.Name = "lstModels";
			this.lstModels.Size = new System.Drawing.Size(162, 381);
			this.lstModels.TabIndex = 2;
			this.lstModels.UseCompatibleStateImageBehavior = false;
			this.lstModels.View = System.Windows.Forms.View.List;
			this.lstModels.SelectedIndexChanged += new System.EventHandler(this.lstModels_SelectedIndexChanged);
			// 
			// columnName
			// 
			this.columnName.Text = "NS (Name)";
			this.columnName.Width = 300;
			// 
			// btnOpenModel
			// 
			this.btnOpenModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnOpenModel.Location = new System.Drawing.Point(12, 399);
			this.btnOpenModel.Name = "btnOpenModel";
			this.btnOpenModel.Size = new System.Drawing.Size(75, 23);
			this.btnOpenModel.TabIndex = 3;
			this.btnOpenModel.Text = "NS (Open)";
			this.btnOpenModel.UseVisualStyleBackColor = true;
			this.btnOpenModel.Click += new System.EventHandler(this.btnOpenModel_Click);
			// 
			// btnRemoveModel
			// 
			this.btnRemoveModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRemoveModel.Location = new System.Drawing.Point(93, 399);
			this.btnRemoveModel.Name = "btnRemoveModel";
			this.btnRemoveModel.Size = new System.Drawing.Size(81, 23);
			this.btnRemoveModel.TabIndex = 4;
			this.btnRemoveModel.Text = "NS (Remove)";
			this.btnRemoveModel.UseVisualStyleBackColor = true;
			this.btnRemoveModel.Click += new System.EventHandler(this.btnRemoveModel_Click);
			// 
			// lstPoints
			// 
			this.lstPoints.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.lstPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lstPoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnX,
            this.columnY,
            this.columnZ});
			this.lstPoints.HideSelection = false;
			listViewItem3.StateImageIndex = 0;
			this.lstPoints.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
			this.lstPoints.LabelEdit = true;
			this.lstPoints.Location = new System.Drawing.Point(180, 40);
			this.lstPoints.MultiSelect = false;
			this.lstPoints.Name = "lstPoints";
			this.lstPoints.Size = new System.Drawing.Size(619, 353);
			this.lstPoints.TabIndex = 5;
			this.lstPoints.UseCompatibleStateImageBehavior = false;
			this.lstPoints.View = System.Windows.Forms.View.Details;
			// 
			// columnId
			// 
			this.columnId.Text = "ID";
			this.columnId.Width = 124;
			// 
			// columnX
			// 
			this.columnX.Text = "X";
			this.columnX.Width = 147;
			// 
			// columnY
			// 
			this.columnY.Text = "Y";
			this.columnY.Width = 157;
			// 
			// columnZ
			// 
			this.columnZ.Text = "Z";
			this.columnZ.Width = 151;
			// 
			// btnImport
			// 
			this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnImport.Location = new System.Drawing.Point(281, 399);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(100, 23);
			this.btnImport.TabIndex = 6;
			this.btnImport.Text = "NS (Import Points)";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnExportComma
			// 
			this.btnExportComma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportComma.Location = new System.Drawing.Point(674, 399);
			this.btnExportComma.Name = "btnExportComma";
			this.btnExportComma.Size = new System.Drawing.Size(125, 23);
			this.btnExportComma.TabIndex = 7;
			this.btnExportComma.Text = "NS (comma separated)";
			this.btnExportComma.UseVisualStyleBackColor = true;
			this.btnExportComma.Click += new System.EventHandler(this.btnExportComma_Click);
			// 
			// lblExport
			// 
			this.lblExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblExport.Location = new System.Drawing.Point(475, 399);
			this.lblExport.Name = "lblExport";
			this.lblExport.Size = new System.Drawing.Size(100, 23);
			this.lblExport.TabIndex = 8;
			this.lblExport.Text = "NS (Export:)";
			this.lblExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnExportTabbed
			// 
			this.btnExportTabbed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportTabbed.Location = new System.Drawing.Point(581, 399);
			this.btnExportTabbed.Name = "btnExportTabbed";
			this.btnExportTabbed.Size = new System.Drawing.Size(87, 23);
			this.btnExportTabbed.TabIndex = 9;
			this.btnExportTabbed.Text = "NS (tabbed)";
			this.btnExportTabbed.UseVisualStyleBackColor = true;
			this.btnExportTabbed.Click += new System.EventHandler(this.btnExportTabbed_Click);
			// 
			// btnNewModel
			// 
			this.btnNewModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNewModel.Location = new System.Drawing.Point(180, 399);
			this.btnNewModel.Name = "btnNewModel";
			this.btnNewModel.Size = new System.Drawing.Size(95, 23);
			this.btnNewModel.TabIndex = 10;
			this.btnNewModel.Text = "NS New Model";
			this.btnNewModel.UseVisualStyleBackColor = true;
			this.btnNewModel.Click += new System.EventHandler(this.btnNewModel_Click);
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(180, 12);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(84, 23);
			this.lblName.TabIndex = 11;
			this.lblName.Text = "NS (Name)";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.Location = new System.Drawing.Point(270, 14);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(219, 20);
			this.txtName.TabIndex = 12;
			// 
			// lblDate
			// 
			this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDate.Location = new System.Drawing.Point(516, 9);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(283, 23);
			this.lblDate.TabIndex = 13;
			this.lblDate.Text = "NS (Date: NOT SET)";
			this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSave.Location = new System.Drawing.Point(387, 399);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(82, 23);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "NS (Save)";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// FrmModels3D
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(811, 434);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.btnNewModel);
			this.Controls.Add(this.btnExportTabbed);
			this.Controls.Add(this.lblExport);
			this.Controls.Add(this.btnExportComma);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.lstPoints);
			this.Controls.Add(this.btnRemoveModel);
			this.Controls.Add(this.btnOpenModel);
			this.Controls.Add(this.lstModels);
			this.Name = "FrmModels3D";
			this.Text = "NS (Model)";
			this.Load += new System.EventHandler(this.FrmModels3D_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmModels3D_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lstModels;
		private System.Windows.Forms.ColumnHeader columnName;
		private System.Windows.Forms.Button btnOpenModel;
		private System.Windows.Forms.Button btnRemoveModel;
		private System.Windows.Forms.ListView lstPoints;
		private System.Windows.Forms.ColumnHeader columnId;
		private System.Windows.Forms.ColumnHeader columnX;
		private System.Windows.Forms.ColumnHeader columnY;
		private System.Windows.Forms.ColumnHeader columnZ;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.Button btnExportComma;
		private System.Windows.Forms.Label lblExport;
		private System.Windows.Forms.Button btnExportTabbed;
		private System.Windows.Forms.Button btnNewModel;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Button btnSave;
	}
}