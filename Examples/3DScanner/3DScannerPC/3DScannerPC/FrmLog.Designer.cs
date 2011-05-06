namespace _3DScannerPC {
	partial class FrmLog {
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
			this.txtLog = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// txtLog
			// 
			this.txtLog.BackColor = System.Drawing.SystemColors.Window;
			this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtLog.Location = new System.Drawing.Point(0, 0);
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.Size = new System.Drawing.Size(629, 188);
			this.txtLog.TabIndex = 0;
			this.txtLog.Text = "";
			this.txtLog.WordWrap = false;
			// 
			// FrmLog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 188);
			this.Controls.Add(this.txtLog);
			this.Name = "FrmLog";
			this.ShowIcon = false;
			this.Text = "Log";
			this.Load += new System.EventHandler(this.FrmLog_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLog_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.RichTextBox txtLog;

	}
}