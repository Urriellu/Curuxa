using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Deployment.Application;
using System.Windows.Forms;

namespace CuruxaIDE {
	public static class InstallManager {
		/// <summary>
		/// Checks from the website which is the latest version of Curuxa IDE
		/// </summary>
		public static void CheckVersionWeb() {
			WebClient wc = new WebClient();
			wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(wc_DownloadStringCompleted);
			try {
				wc.DownloadStringAsync(new Uri("http://curuxa.org/curuxa_latest"));
			} catch(WebException we) {
				Globals.LogIDE(i18n.str("UnableGetLatestVersion", we.Message));
			}
		}

		static void wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e) {
			if(e.Cancelled == true) Globals.LogIDE(i18n.str("UnableGetLatestVersion", "Cancelled"));
			else if(e.Error != null) Globals.LogIDE(i18n.str("UnableGetLatestVersion", e.Error.Message));
			else {
				string[] LatestVersion = e.Result.RemoveFrom('-').Split('.');
				string[] CurrentVersion = Settings.Version.RemoveFrom('-').Split('.');
				for(int i = 0; i < LatestVersion.Length; i++) {
					UInt32 LatestVersionX = 0;
					UInt32.TryParse(LatestVersion[i], out LatestVersionX);
					UInt32 CurrentVersionX = 0;
					if(i < CurrentVersion.Length) UInt32.TryParse(CurrentVersion[i], out CurrentVersionX);
					if(LatestVersionX > CurrentVersionX) {
						Globals.LogIDE(i18n.str("ThereIsNewVersion", e.Result, Settings.Version));
						break;
					}
					if(LatestVersionX < CurrentVersionX) {
						Globals.Debug("You are using a more recent version that the latest official release. Wow! You must be God or something.");
					}
				}
			}
		}

		/// <summary>
		/// Checks for update and install it
		/// </summary>
		public static void CheckUpdates() {
			try {
				Globals.LogIDE(i18n.str("checkingUpdates"));
				if(ApplicationDeployment.IsNetworkDeployed) {
					if(ApplicationDeployment.CurrentDeployment.CheckForUpdate()) {
						//there is an update
						ApplicationDeployment.CurrentDeployment.UpdateCompleted += new System.ComponentModel.AsyncCompletedEventHandler(CurrentDeployment_UpdateCompleted);
						ApplicationDeployment.CurrentDeployment.UpdateAsync();
					} else Globals.LogIDE(i18n.str("noUpdates"));
				} else Globals.LogIDE(i18n.str("cantUpdateAuto"));
			} catch(Exception ex) {
				Globals.LogIDE(i18n.str("errorWhileUpdate", ex.Message));
			}
		}

		static void CurrentDeployment_UpdateCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
			Globals.LogIDE(i18n.str("updateCompleted"));
		}
	}
}
