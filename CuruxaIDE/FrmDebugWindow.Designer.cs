namespace CuruxaIDE {
	partial class FrmDebugWindow {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDebugWindow));
			this.txtDebug = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtDebug
			// 
			this.txtDebug.BackColor = System.Drawing.SystemColors.Window;
			this.txtDebug.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDebug.Location = new System.Drawing.Point(0, 0);
			this.txtDebug.Multiline = true;
			this.txtDebug.Name = "txtDebug";
			this.txtDebug.ReadOnly = true;
			this.txtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtDebug.Size = new System.Drawing.Size(523, 253);
			this.txtDebug.TabIndex = 0;
			this.txtDebug.WordWrap = false;
			// 
			// FrmDebugWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 253);
			this.Controls.Add(this.txtDebug);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmDebugWindow";
			this.Text = "Curuxa IDE Debug Window";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmDebugWindow_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDebugWindow_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtDebug;
	}
}