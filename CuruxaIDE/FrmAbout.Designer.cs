namespace CuruxaIDE {
	partial class FrmAbout {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.Logo = new System.Windows.Forms.PictureBox();
			this.labelProductName = new System.Windows.Forms.Label();
			this.LblVersion = new System.Windows.Forms.Label();
			this.TxtDescription = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.LblLicense = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.81275F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.18725F));
			this.tableLayoutPanel.Controls.Add(this.Logo, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.LblVersion, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.TxtDescription, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
			this.tableLayoutPanel.Controls.Add(this.LblLicense, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.linkLabel1, 1, 3);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 6;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(502, 265);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// Logo
			// 
			this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Logo.Location = new System.Drawing.Point(3, 3);
			this.Logo.Name = "Logo";
			this.tableLayoutPanel.SetRowSpan(this.Logo, 6);
			this.Logo.Size = new System.Drawing.Size(229, 259);
			this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Logo.TabIndex = 12;
			this.Logo.TabStop = false;
			// 
			// labelProductName
			// 
			this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelProductName.Location = new System.Drawing.Point(241, 0);
			this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(258, 17);
			this.labelProductName.TabIndex = 19;
			this.labelProductName.Text = "Curuxa IDE";
			this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblVersion
			// 
			this.LblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblVersion.Location = new System.Drawing.Point(241, 26);
			this.LblVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LblVersion.MaximumSize = new System.Drawing.Size(0, 17);
			this.LblVersion.Name = "LblVersion";
			this.LblVersion.Size = new System.Drawing.Size(258, 17);
			this.LblVersion.TabIndex = 0;
			this.LblVersion.Text = "NS (Version)";
			this.LblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtDescription
			// 
			this.TxtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtDescription.Location = new System.Drawing.Point(241, 107);
			this.TxtDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
			this.TxtDescription.Multiline = true;
			this.TxtDescription.Name = "TxtDescription";
			this.TxtDescription.ReadOnly = true;
			this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TxtDescription.Size = new System.Drawing.Size(258, 126);
			this.TxtDescription.TabIndex = 23;
			this.TxtDescription.TabStop = false;
			this.TxtDescription.Text = "NS (Description)";
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.Location = new System.Drawing.Point(424, 239);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 24;
			this.okButton.Text = "&OK";
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// LblLicense
			// 
			this.LblLicense.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblLicense.Location = new System.Drawing.Point(241, 52);
			this.LblLicense.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LblLicense.MaximumSize = new System.Drawing.Size(0, 17);
			this.LblLicense.Name = "LblLicense";
			this.LblLicense.Size = new System.Drawing.Size(258, 17);
			this.LblLicense.TabIndex = 21;
			this.LblLicense.Text = "GNU General Public License v3.0";
			this.LblLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(238, 78);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(88, 13);
			this.linkLabel1.TabIndex = 25;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "http://curuxa.org";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// FrmAbout
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 283);
			this.Controls.Add(this.tableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmAbout";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "NS (About Curuxa IDE)";
			this.Load += new System.EventHandler(this.FrmAbout_Load);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.PictureBox Logo;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Label LblVersion;
		private System.Windows.Forms.Label LblLicense;
		private System.Windows.Forms.TextBox TxtDescription;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}
