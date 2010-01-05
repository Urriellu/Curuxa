namespace CuruxaIDE {
	partial class FrmNewPrjFromExample {
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("test");
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("another test");
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("don\'t remove these tests!");
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("test");
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("another test");
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("don\'t remove these tests!");
			this.LstExamples = new System.Windows.Forms.ListBox();
			this.LblAvailEx = new System.Windows.Forms.Label();
			this.TxtDescription = new System.Windows.Forms.TextBox();
			this.LblDescription = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.LblSaveAs = new System.Windows.Forms.Label();
			this.TxtPrjFile = new System.Windows.Forms.TextBox();
			this.BtnSaveAs = new System.Windows.Forms.Button();
			this.BtnSave = new System.Windows.Forms.Button();
			this.LstFilterMB = new System.Windows.Forms.ListView();
			this.LblFilter = new System.Windows.Forms.Label();
			this.LblMainBoard = new System.Windows.Forms.Label();
			this.LblModules = new System.Windows.Forms.Label();
			this.LstFilterModules = new System.Windows.Forms.ListView();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// LstExamples
			// 
			this.LstExamples.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.LstExamples.FormattingEnabled = true;
			this.LstExamples.Location = new System.Drawing.Point(12, 25);
			this.LstExamples.Name = "LstExamples";
			this.LstExamples.Size = new System.Drawing.Size(186, 212);
			this.LstExamples.TabIndex = 0;
			this.LstExamples.SelectedValueChanged += new System.EventHandler(this.LstExamples_SelectedValueChanged);
			// 
			// LblAvailEx
			// 
			this.LblAvailEx.AutoSize = true;
			this.LblAvailEx.Location = new System.Drawing.Point(12, 9);
			this.LblAvailEx.Name = "LblAvailEx";
			this.LblAvailEx.Size = new System.Drawing.Size(86, 13);
			this.LblAvailEx.TabIndex = 1;
			this.LblAvailEx.Text = "NS (List avail prj)";
			// 
			// TxtDescription
			// 
			this.TxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TxtDescription.BackColor = System.Drawing.SystemColors.Window;
			this.TxtDescription.Location = new System.Drawing.Point(210, 25);
			this.TxtDescription.Multiline = true;
			this.TxtDescription.Name = "TxtDescription";
			this.TxtDescription.ReadOnly = true;
			this.TxtDescription.Size = new System.Drawing.Size(570, 497);
			this.TxtDescription.TabIndex = 0;
			// 
			// LblDescription
			// 
			this.LblDescription.AutoSize = true;
			this.LblDescription.Location = new System.Drawing.Point(207, 9);
			this.LblDescription.Name = "LblDescription";
			this.LblDescription.Size = new System.Drawing.Size(84, 13);
			this.LblDescription.TabIndex = 3;
			this.LblDescription.Text = "NS (Description)";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.tableLayoutPanel1.Controls.Add(this.LblSaveAs, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.TxtPrjFile, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.BtnSaveAs, 2, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(210, 528);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 35);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// LblSaveAs
			// 
			this.LblSaveAs.AutoSize = true;
			this.LblSaveAs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblSaveAs.Location = new System.Drawing.Point(3, 0);
			this.LblSaveAs.Name = "LblSaveAs";
			this.LblSaveAs.Size = new System.Drawing.Size(84, 35);
			this.LblSaveAs.TabIndex = 0;
			this.LblSaveAs.Text = "NS (Save prj as)";
			this.LblSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TxtPrjFile
			// 
			this.TxtPrjFile.BackColor = System.Drawing.SystemColors.Window;
			this.TxtPrjFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtPrjFile.Location = new System.Drawing.Point(93, 8);
			this.TxtPrjFile.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.TxtPrjFile.Name = "TxtPrjFile";
			this.TxtPrjFile.ReadOnly = true;
			this.TxtPrjFile.Size = new System.Drawing.Size(335, 20);
			this.TxtPrjFile.TabIndex = 1;
			// 
			// BtnSaveAs
			// 
			this.BtnSaveAs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnSaveAs.Location = new System.Drawing.Point(434, 3);
			this.BtnSaveAs.Name = "BtnSaveAs";
			this.BtnSaveAs.Size = new System.Drawing.Size(33, 29);
			this.BtnSaveAs.TabIndex = 2;
			this.BtnSaveAs.UseVisualStyleBackColor = true;
			this.BtnSaveAs.Click += new System.EventHandler(this.BtnSaveAs_Click);
			// 
			// BtnSave
			// 
			this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnSave.Location = new System.Drawing.Point(705, 534);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(75, 23);
			this.BtnSave.TabIndex = 5;
			this.BtnSave.Text = "NS (Save)";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// LstFilterMB
			// 
			this.LstFilterMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LstFilterMB.CheckBoxes = true;
			this.LstFilterMB.FullRowSelect = true;
			listViewItem1.StateImageIndex = 0;
			listViewItem2.StateImageIndex = 0;
			listViewItem3.StateImageIndex = 0;
			this.LstFilterMB.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
			this.LstFilterMB.Location = new System.Drawing.Point(12, 295);
			this.LstFilterMB.MultiSelect = false;
			this.LstFilterMB.Name = "LstFilterMB";
			this.LstFilterMB.Size = new System.Drawing.Size(186, 94);
			this.LstFilterMB.TabIndex = 6;
			this.LstFilterMB.UseCompatibleStateImageBehavior = false;
			this.LstFilterMB.View = System.Windows.Forms.View.List;
			this.LstFilterMB.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LstFilterMB_ItemChecked);
			// 
			// LblFilter
			// 
			this.LblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LblFilter.AutoSize = true;
			this.LblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblFilter.Location = new System.Drawing.Point(12, 252);
			this.LblFilter.Name = "LblFilter";
			this.LblFilter.Size = new System.Drawing.Size(83, 17);
			this.LblFilter.TabIndex = 7;
			this.LblFilter.Text = "NS (Filter)";
			// 
			// LblMainBoard
			// 
			this.LblMainBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LblMainBoard.AutoSize = true;
			this.LblMainBoard.Location = new System.Drawing.Point(12, 279);
			this.LblMainBoard.Name = "LblMainBoard";
			this.LblMainBoard.Size = new System.Drawing.Size(85, 13);
			this.LblMainBoard.TabIndex = 8;
			this.LblMainBoard.Text = "NS (Main Board)";
			// 
			// LblModules
			// 
			this.LblModules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LblModules.AutoSize = true;
			this.LblModules.Location = new System.Drawing.Point(12, 404);
			this.LblModules.Name = "LblModules";
			this.LblModules.Size = new System.Drawing.Size(71, 13);
			this.LblModules.TabIndex = 9;
			this.LblModules.Text = "NS (Modules)";
			// 
			// LstFilterModules
			// 
			this.LstFilterModules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LstFilterModules.CheckBoxes = true;
			this.LstFilterModules.FullRowSelect = true;
			listViewItem4.StateImageIndex = 0;
			listViewItem5.StateImageIndex = 0;
			listViewItem6.StateImageIndex = 0;
			this.LstFilterModules.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
			this.LstFilterModules.Location = new System.Drawing.Point(12, 420);
			this.LstFilterModules.MultiSelect = false;
			this.LstFilterModules.Name = "LstFilterModules";
			this.LstFilterModules.Size = new System.Drawing.Size(186, 143);
			this.LstFilterModules.TabIndex = 10;
			this.LstFilterModules.UseCompatibleStateImageBehavior = false;
			this.LstFilterModules.View = System.Windows.Forms.View.List;
			this.LstFilterModules.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LstFilterModules_ItemChecked);
			// 
			// FrmNewPrjFromExample
			// 
			this.AcceptButton = this.BtnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 573);
			this.Controls.Add(this.LstFilterModules);
			this.Controls.Add(this.LblModules);
			this.Controls.Add(this.LblMainBoard);
			this.Controls.Add(this.LblFilter);
			this.Controls.Add(this.LstFilterMB);
			this.Controls.Add(this.BtnSave);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.TxtDescription);
			this.Controls.Add(this.LblDescription);
			this.Controls.Add(this.LblAvailEx);
			this.Controls.Add(this.LstExamples);
			this.MinimumSize = new System.Drawing.Size(570, 500);
			this.Name = "FrmNewPrjFromExample";
			this.Text = "NS (New Project From Example)";
			this.Load += new System.EventHandler(this.NewPrjFromExample_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox LstExamples;
		private System.Windows.Forms.Label LblAvailEx;
		private System.Windows.Forms.TextBox TxtDescription;
		private System.Windows.Forms.Label LblDescription;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label LblSaveAs;
		public System.Windows.Forms.TextBox TxtPrjFile;
		private System.Windows.Forms.Button BtnSaveAs;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.ListView LstFilterMB;
		private System.Windows.Forms.Label LblFilter;
		private System.Windows.Forms.Label LblMainBoard;
		private System.Windows.Forms.Label LblModules;
		private System.Windows.Forms.ListView LstFilterModules;
	}
}