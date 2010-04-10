namespace CuruxaIDE {
	partial class FrmProjectSettings {
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
			this.BtnOK = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.CmbLanguage = new System.Windows.Forms.ComboBox();
			this.LblLanguage = new System.Windows.Forms.Label();
			this.Voltage = new System.Windows.Forms.NumericUpDown();
			this.LblVoltage = new System.Windows.Forms.Label();
			this.CmbMainBoard = new System.Windows.Forms.ComboBox();
			this.LblMainBoard = new System.Windows.Forms.Label();
			this.TxtName = new System.Windows.Forms.TextBox();
			this.LblName = new System.Windows.Forms.Label();
			this.LblDescription = new System.Windows.Forms.Label();
			this.TxtDescription = new System.Windows.Forms.TextBox();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Voltage)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnOK
			// 
			this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOK.Location = new System.Drawing.Point(155, 154);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new System.Drawing.Size(97, 28);
			this.BtnOK.TabIndex = 1;
			this.BtnOK.Text = "NS (OK)";
			this.BtnOK.UseVisualStyleBackColor = true;
			this.BtnOK.Click += new System.EventHandler(this.LblOK_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.MinimumSize = new System.Drawing.Size(370, 190);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel5);
			this.splitContainer1.Panel1MinSize = 168;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.LblDescription);
			this.splitContainer1.Panel2.Controls.Add(this.TxtDescription);
			this.splitContainer1.Panel2.Controls.Add(this.BtnOK);
			this.splitContainer1.Size = new System.Drawing.Size(466, 190);
			this.splitContainer1.SplitterDistance = 198;
			this.splitContainer1.TabIndex = 2;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel5.ColumnCount = 2;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Controls.Add(this.CmbLanguage, 1, 3);
			this.tableLayoutPanel5.Controls.Add(this.LblLanguage, 0, 3);
			this.tableLayoutPanel5.Controls.Add(this.Voltage, 1, 2);
			this.tableLayoutPanel5.Controls.Add(this.LblVoltage, 0, 2);
			this.tableLayoutPanel5.Controls.Add(this.CmbMainBoard, 1, 1);
			this.tableLayoutPanel5.Controls.Add(this.LblMainBoard, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.TxtName, 1, 0);
			this.tableLayoutPanel5.Controls.Add(this.LblName, 0, 0);
			this.tableLayoutPanel5.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 31);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 5;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(192, 115);
			this.tableLayoutPanel5.TabIndex = 5;
			// 
			// CmbLanguage
			// 
			this.CmbLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmbLanguage.FormattingEnabled = true;
			this.CmbLanguage.Location = new System.Drawing.Point(94, 82);
			this.CmbLanguage.Name = "CmbLanguage";
			this.CmbLanguage.Size = new System.Drawing.Size(95, 21);
			this.CmbLanguage.TabIndex = 9;
			// 
			// LblLanguage
			// 
			this.LblLanguage.AutoSize = true;
			this.LblLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblLanguage.Location = new System.Drawing.Point(3, 79);
			this.LblLanguage.Name = "LblLanguage";
			this.LblLanguage.Size = new System.Drawing.Size(85, 27);
			this.LblLanguage.TabIndex = 8;
			this.LblLanguage.Text = "NS (Language)";
			this.LblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Voltage
			// 
			this.Voltage.DecimalPlaces = 1;
			this.Voltage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Voltage.Location = new System.Drawing.Point(94, 56);
			this.Voltage.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.Voltage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.Voltage.Name = "Voltage";
			this.Voltage.Size = new System.Drawing.Size(95, 20);
			this.Voltage.TabIndex = 7;
			this.Voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Voltage.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// LblVoltage
			// 
			this.LblVoltage.AutoSize = true;
			this.LblVoltage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblVoltage.Location = new System.Drawing.Point(3, 53);
			this.LblVoltage.Name = "LblVoltage";
			this.LblVoltage.Size = new System.Drawing.Size(85, 26);
			this.LblVoltage.TabIndex = 6;
			this.LblVoltage.Text = "NS (Voltage)";
			this.LblVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CmbMainBoard
			// 
			this.CmbMainBoard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CmbMainBoard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmbMainBoard.FormattingEnabled = true;
			this.CmbMainBoard.Location = new System.Drawing.Point(94, 29);
			this.CmbMainBoard.Name = "CmbMainBoard";
			this.CmbMainBoard.Size = new System.Drawing.Size(95, 21);
			this.CmbMainBoard.TabIndex = 5;
			// 
			// LblMainBoard
			// 
			this.LblMainBoard.AutoSize = true;
			this.LblMainBoard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblMainBoard.Location = new System.Drawing.Point(3, 26);
			this.LblMainBoard.Name = "LblMainBoard";
			this.LblMainBoard.Size = new System.Drawing.Size(85, 27);
			this.LblMainBoard.TabIndex = 4;
			this.LblMainBoard.Text = "NS (Main Board)";
			this.LblMainBoard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TxtName
			// 
			this.TxtName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtName.Location = new System.Drawing.Point(94, 3);
			this.TxtName.Name = "TxtName";
			this.TxtName.ReadOnly = true;
			this.TxtName.Size = new System.Drawing.Size(95, 20);
			this.TxtName.TabIndex = 3;
			// 
			// LblName
			// 
			this.LblName.AutoSize = true;
			this.LblName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblName.Location = new System.Drawing.Point(3, 0);
			this.LblName.Name = "LblName";
			this.LblName.Size = new System.Drawing.Size(85, 26);
			this.LblName.TabIndex = 2;
			this.LblName.Text = "NS (name)";
			this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LblDescription
			// 
			this.LblDescription.AutoSize = true;
			this.LblDescription.Location = new System.Drawing.Point(13, 14);
			this.LblDescription.Name = "LblDescription";
			this.LblDescription.Size = new System.Drawing.Size(84, 13);
			this.LblDescription.TabIndex = 3;
			this.LblDescription.Text = "NS (Description)";
			// 
			// TxtDescription
			// 
			this.TxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TxtDescription.Location = new System.Drawing.Point(16, 33);
			this.TxtDescription.Multiline = true;
			this.TxtDescription.Name = "TxtDescription";
			this.TxtDescription.Size = new System.Drawing.Size(236, 115);
			this.TxtDescription.TabIndex = 2;
			// 
			// FrmProjectSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 186);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(390, 210);
			this.Name = "FrmProjectSettings";
			this.ShowIcon = false;
			this.Text = "NS (Project Settings)";
			this.Load += new System.EventHandler(this.ProjectSettings_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Voltage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnOK;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label LblDescription;
		private System.Windows.Forms.TextBox TxtDescription;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.ComboBox CmbLanguage;
		private System.Windows.Forms.Label LblLanguage;
		private System.Windows.Forms.NumericUpDown Voltage;
		private System.Windows.Forms.Label LblVoltage;
		private System.Windows.Forms.ComboBox CmbMainBoard;
		private System.Windows.Forms.Label LblMainBoard;
		private System.Windows.Forms.TextBox TxtName;
		private System.Windows.Forms.Label LblName;
	}
}