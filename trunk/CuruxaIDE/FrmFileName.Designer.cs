namespace CuruxaIDE {
	partial class FrmFileName {
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
			this.BtnOk = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.LblFileName = new System.Windows.Forms.Label();
			this.TxtFileName = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnOk
			// 
			this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOk.Location = new System.Drawing.Point(241, 50);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(75, 23);
			this.BtnOk.TabIndex = 1;
			this.BtnOk.Text = "NS (OK)";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.LblFileName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.TxtFileName, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 25);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// LblFileName
			// 
			this.LblFileName.AutoSize = true;
			this.LblFileName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblFileName.Location = new System.Drawing.Point(3, 0);
			this.LblFileName.Name = "LblFileName";
			this.LblFileName.Size = new System.Drawing.Size(78, 25);
			this.LblFileName.TabIndex = 0;
			this.LblFileName.Text = "NS (File Name)";
			this.LblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TxtFileName
			// 
			this.TxtFileName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtFileName.Location = new System.Drawing.Point(87, 3);
			this.TxtFileName.Name = "TxtFileName";
			this.TxtFileName.Size = new System.Drawing.Size(213, 20);
			this.TxtFileName.TabIndex = 1;
			// 
			// FrmFileName
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 85);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.BtnOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmFileName";
			this.Text = "NS (File Name)";
			this.Load += new System.EventHandler(this.FrmFileName_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnOk;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label LblFileName;
		public System.Windows.Forms.TextBox TxtFileName;

	}
}