namespace _3DScannerPC {
	partial class FrmManualControl {
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
			this.manualNumControlV = new System.Windows.Forms.NumericUpDown();
			this.manualNumControlH = new System.Windows.Forms.NumericUpDown();
			this.manualControlV = new System.Windows.Forms.TrackBar();
			this.manualControlH = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.manualNumControlV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.manualNumControlH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.manualControlV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.manualControlH)).BeginInit();
			this.SuspendLayout();
			// 
			// manualNumControlV
			// 
			this.manualNumControlV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.manualNumControlV.Location = new System.Drawing.Point(379, 12);
			this.manualNumControlV.Name = "manualNumControlV";
			this.manualNumControlV.Size = new System.Drawing.Size(64, 20);
			this.manualNumControlV.TabIndex = 11;
			this.manualNumControlV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.manualNumControlV.ValueChanged += new System.EventHandler(this.manualNumControlV_ValueChanged);
			// 
			// manualNumControlH
			// 
			this.manualNumControlH.Location = new System.Drawing.Point(12, 94);
			this.manualNumControlH.Name = "manualNumControlH";
			this.manualNumControlH.Size = new System.Drawing.Size(68, 20);
			this.manualNumControlH.TabIndex = 10;
			this.manualNumControlH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.manualNumControlH.ValueChanged += new System.EventHandler(this.manualNumControlH_ValueChanged);
			// 
			// manualControlV
			// 
			this.manualControlV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.manualControlV.Location = new System.Drawing.Point(394, 38);
			this.manualControlV.Maximum = 100;
			this.manualControlV.Name = "manualControlV";
			this.manualControlV.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.manualControlV.Size = new System.Drawing.Size(42, 246);
			this.manualControlV.TabIndex = 9;
			this.manualControlV.Value = 50;
			this.manualControlV.Scroll += new System.EventHandler(this.manualControlV_Scroll);
			// 
			// manualControlH
			// 
			this.manualControlH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.manualControlH.Location = new System.Drawing.Point(92, 87);
			this.manualControlH.Maximum = 100;
			this.manualControlH.Name = "manualControlH";
			this.manualControlH.Size = new System.Drawing.Size(280, 42);
			this.manualControlH.TabIndex = 8;
			this.manualControlH.Value = 50;
			this.manualControlH.Scroll += new System.EventHandler(this.manualControlH_Scroll);
			// 
			// FrmManualControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 296);
			this.Controls.Add(this.manualNumControlV);
			this.Controls.Add(this.manualNumControlH);
			this.Controls.Add(this.manualControlV);
			this.Controls.Add(this.manualControlH);
			this.MinimumSize = new System.Drawing.Size(304, 213);
			this.Name = "FrmManualControl";
			this.ShowIcon = false;
			this.Text = "NOT SET (Manual Control)";
			this.Load += new System.EventHandler(this.FrmManualControl_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmManualControl_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.manualNumControlV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.manualNumControlH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.manualControlV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.manualControlH)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown manualNumControlV;
		private System.Windows.Forms.NumericUpDown manualNumControlH;
		private System.Windows.Forms.TrackBar manualControlV;
		private System.Windows.Forms.TrackBar manualControlH;
	}
}