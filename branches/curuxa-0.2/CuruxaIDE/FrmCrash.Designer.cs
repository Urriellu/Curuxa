namespace CuruxaIDE {
	partial class FrmCrash {
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
			this.TxtError = new System.Windows.Forms.TextBox();
			this.BtnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TxtError
			// 
			this.TxtError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TxtError.BackColor = System.Drawing.SystemColors.Window;
			this.TxtError.Location = new System.Drawing.Point(12, 12);
			this.TxtError.Multiline = true;
			this.TxtError.Name = "TxtError";
			this.TxtError.ReadOnly = true;
			this.TxtError.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TxtError.Size = new System.Drawing.Size(742, 220);
			this.TxtError.TabIndex = 0;
			// 
			// BtnClose
			// 
			this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnClose.Location = new System.Drawing.Point(678, 238);
			this.BtnClose.Name = "BtnClose";
			this.BtnClose.Size = new System.Drawing.Size(75, 23);
			this.BtnClose.TabIndex = 1;
			this.BtnClose.Text = "Close";
			this.BtnClose.UseVisualStyleBackColor = true;
			this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// FrmCrash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(766, 273);
			this.Controls.Add(this.BtnClose);
			this.Controls.Add(this.TxtError);
			this.Name = "FrmCrash";
			this.Text = "Application crash";
			this.Load += new System.EventHandler(this.FrmCrash_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtError;
		private System.Windows.Forms.Button BtnClose;
	}
}