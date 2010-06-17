using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCBot_PCApp {
	public partial class FrmAbout:Form {
		public FrmAbout() {
			InitializeComponent();
		}

		private void textBox1_Enter(object sender, EventArgs e) {
			textBox1.Select(0, 0);
			this.Focus();
		}
	}
}
