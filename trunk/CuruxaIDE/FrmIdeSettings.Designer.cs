namespace CuruxaIDE {
	partial class FrmIdeSettings {
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblLang = new System.Windows.Forms.Label();
			this.cmbLang = new System.Windows.Forms.ComboBox();
			this.BtnOk = new System.Windows.Forms.Button();
			this.BtnRestart = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.cbEnbSynHgl = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.lblLang, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.cmbLang, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 26);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 28);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lblLang
			// 
			this.lblLang.AutoSize = true;
			this.lblLang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblLang.Location = new System.Drawing.Point(3, 0);
			this.lblLang.Name = "lblLang";
			this.lblLang.Size = new System.Drawing.Size(82, 28);
			this.lblLang.TabIndex = 0;
			this.lblLang.Text = "NS (Language:)";
			this.lblLang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbLang
			// 
			this.cmbLang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLang.FormattingEnabled = true;
			this.cmbLang.Location = new System.Drawing.Point(91, 3);
			this.cmbLang.Name = "cmbLang";
			this.cmbLang.Size = new System.Drawing.Size(231, 21);
			this.cmbLang.TabIndex = 1;
			// 
			// BtnOk
			// 
			this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOk.Location = new System.Drawing.Point(169, 148);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(75, 23);
			this.BtnOk.TabIndex = 1;
			this.BtnOk.Text = "NS (Ok)";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// BtnRestart
			// 
			this.BtnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnRestart.Location = new System.Drawing.Point(76, 148);
			this.BtnRestart.Name = "BtnRestart";
			this.BtnRestart.Size = new System.Drawing.Size(75, 23);
			this.BtnRestart.TabIndex = 2;
			this.BtnRestart.Text = "NS (Restart)";
			this.BtnRestart.UseVisualStyleBackColor = true;
			this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.Location = new System.Drawing.Point(262, 148);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(75, 23);
			this.BtnCancel.TabIndex = 3;
			this.BtnCancel.Text = "NS (Cancel)";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// cbEnbSynHgl
			// 
			this.cbEnbSynHgl.AutoSize = true;
			this.cbEnbSynHgl.Location = new System.Drawing.Point(18, 83);
			this.cbEnbSynHgl.Name = "cbEnbSynHgl";
			this.cbEnbSynHgl.Size = new System.Drawing.Size(158, 17);
			this.cbEnbSynHgl.TabIndex = 4;
			this.cbEnbSynHgl.Text = "NS (Enable syntax highlight)";
			this.cbEnbSynHgl.UseVisualStyleBackColor = true;
			// 
			// FrmIdeSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 183);
			this.Controls.Add(this.cbEnbSynHgl);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.BtnRestart);
			this.Controls.Add(this.BtnOk);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimumSize = new System.Drawing.Size(300, 192);
			this.Name = "FrmIdeSettings";
			this.Text = "FrmIdeSettings";
			this.Load += new System.EventHandler(this.FrmIdeSettings_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblLang;
		private System.Windows.Forms.Button BtnOk;
		private System.Windows.Forms.ComboBox cmbLang;
		private System.Windows.Forms.Button BtnRestart;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.CheckBox cbEnbSynHgl;
	}
}