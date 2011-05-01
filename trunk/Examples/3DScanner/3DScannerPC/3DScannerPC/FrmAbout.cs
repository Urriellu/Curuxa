using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace _3DScannerPC {
	partial class FrmAbout:Form {
		public FrmAbout() {
			InitializeComponent();
		}

		private void FrmAbout_Load(object sender, EventArgs e) {
			UpdateLang();
		}

		private void UpdateLang() {
			
		}

		private void okButton_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
