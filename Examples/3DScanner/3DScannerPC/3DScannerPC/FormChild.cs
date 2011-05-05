using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3DScannerPC {
	public class FormChild:Form {
		public virtual void UpdateLang() {
		}

		public bool Usable {
			set {
				foreach(Control c in Controls) {
					c.Enabled = value;
				}
			}
		}
	}
}
