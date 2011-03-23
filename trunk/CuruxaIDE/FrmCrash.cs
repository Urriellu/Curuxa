using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuruxaIDE {
	public partial class FrmCrash:Form {
		public readonly object Error;

		public FrmCrash(object Error) {
			this.Error = Error;
			InitializeComponent();
		}

		private void FrmCrash_Load(object sender, EventArgs e) {
			lblInfo.Text = i18n.str("CrashInfo1");
			if(Error is Exception) {
				Exception ex = (Exception)Error;
				TxtError.Text = ex.Message + Environment.NewLine + Environment.NewLine + ex.StackTrace;
			} else {
				TxtError.Text = Error.ToString();
			}
		}

		private void BtnClose_Click(object sender, EventArgs e) {
			Environment.Exit(1);
		}
	}
}
