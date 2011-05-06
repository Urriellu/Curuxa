using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3DScannerPC {
	public class FormChild:Form {
		protected List<Control> ignoreUsableControls = new List<Control>();

		public virtual void UpdateLang() {
		}

		public bool Usable {
			set {
				foreach(Control c in Controls) {
					if(!ignoreUsableControls.Contains(c)) c.Enabled = value;
				}
			}
		}
	}
}
