using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DScannerPC {
	public static class i18n {
		static Dictionary<string, Dictionary<string, string>> langs = new Dictionary<string, Dictionary<string, string>>();

		public static string CurrLang {
			get {
				if(string.IsNullOrEmpty(_currLang)) {
					//get default language
					string MyLang = System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
					if(langs.ContainsKey(MyLang)) _currLang = MyLang;
					else {
						if(langs.Count == 0 || !langs.ContainsKey("en")) throw new Exception("Wrongly programmed");
						_currLang = "en";
					}
				}
				return _currLang;
			}
			set {
				if(langs.ContainsKey(value)) _currLang = value;
			}
		}
		static string _currLang;

		static i18n() {
			LoadLanguages();
		}

		private static void LoadLanguages() {
			//English
			Dictionary<string, string> langEn = new Dictionary<string, string>();
			langEn.Add("File", "File");
			langEn.Add("Exit", "Exit");
			langEn.Add("About", "About...");
			langEn.Add("init", "Initializing application...");
			langEn.Add("Connected", "Connected");
			langEn.Add("Disconnected", "Disconnected");
			langEn.Add("Mode", "Mode");
			langEn.Add("Mode" + ScannerMode.Inactive, "Inactive");
			langEn.Add("Mode" + ScannerMode.Manual, "Manual");
			langEn.Add("Mode" + ScannerMode.Scan, "Scanning");
			langEn.Add("ManualControl", "Manual Control");
			langEn.Add("Scan", "Scan");
			langEn.Add("recManualTitle", "Latest Received Value:");
			langEn.Add("recManualValue", "Value: {0}      (0V = 0, {1}V = {2})");
			langEn.Add("recManualVoltage", "Voltage: {0}V   (3.15V=70mm, 1.65V=150mmm 0.4V=800mm, non-linear)");
			langEn.Add("recManualDistance", "Distance: {0}mm");
			langEn.Add("Connection", "Connection");
			langEn.Add("UpdateList", "Update List");
			langEn.Add("bauds", "bauds");
			langEn.Add("Connect", "Connect");
			langEn.Add("Disconnect", "Disconnect");
			langEn.Add("Edit", "Edit");
			langEn.Add("View", "View");
			langEn.Add("Language", "Language");
			langEn.Add("Help", "Help");
			langEn.Add("MenuModeInactiveReadyScan", "Inactive: Ready to Scan");
			langEn.Add("ManualControlHtitle", "Horizontal movement (duty cycle and degrees):");
			langEn.Add("ManualControlVtitle", "Vertical:");
			langEn.Add("DegreesN", "Degrees: {0}º");
			langEn.Add("ConnectedNotAuth", "Connected - Not Authenticated");
			langEn.Add("SaveRawMsm", "Saved raw measurement \"{0}\" in {1}");
			langEn.Add("UnableSaveFile", "Unable to save file \"{0}\". {1}");
			langEn.Add("ReadRawMsm", "Raw measurement \"{0}\" read from {1}");
			langEn.Add("UnableLoadFile", "Unable to load file \"{0}\". {1}");
			langEn.Add("Open", "Open");
			langEn.Add("Remove", "Remove");
			langEn.Add("SavingSettings", "Saving settings");
			langEn.Add("Setup", "Setup");
			langEn.Add("AvgEvery", "Average every");
			langEn.Add("points", "points");
			langEn.Add("Activate", "Activate");
			langEn.Add("Deactivate", "Deactivate");
			langEn.Add("Auth", "Auth");
			langEn.Add("ClosestObject", "Closest Object");
			langEn.Add("MeasuredPoints", "Measured Points");
			langEn.Add("StartNewSeries", "Start New Series");
			langEn.Add("SaveInstantSeries", "Save Instant Series");
			langEn.Add("SaveAvgSeries", "Save Average Series");
			langEn.Add("RawMsms", "Raw Measurements");
			langEn.Add("Name", "Name");
			langEn.Add("Date", "Date");
			langEn.Add("BaseLocation", "Base Location");
			langEn.Add("BaseRotation", "Base Rotation");
			langEn.Add("Tools", "Tools");
			langEn.Add("Settings", "Settings");
			langEn.Add("ReqAuth", "Require Authentication");
			langEn.Add("PrintDebugLogs", "Print Debug Logs");
			langEn.Add("ScannerID", "Scanner ID");
			langEn.Add("ManualCtrlChangesEvery", "On manual control, update every (sec)");
			langEn.Add("T1preload", "Timer 1 preload");
			langEn.Add("Duty0H", "Duty for 0º, horizontal servo");
			langEn.Add("Duty180H", "Duty for 180º, horizontal servo");
			langEn.Add("Duty0V", "Duty for 0º, vertical servo");
			langEn.Add("Duty180V", "Duty for 180º, vertical servo");
			langEn.Add("Ok", "Ok");
			langEn.Add("OK", "OK");
			langEn.Add("NewAutoMsm", "New Automatic Measurement");
			langEn.Add("AutoScanResolutionSummaryH", "Will measure {0} points between {1}º and {2}º for each row, {3} times each point");
			langEn.Add("AutoScanResolutionSummaryV", "Will measure {0} rows between {1}º and {2}º");
			langEn.Add("ElapsedTime", "Elapsed Time: ");
			langEn.Add("RemainingTime", "Remaining Time: ");
			langEn.Add("ReceivedXpointsOfY", "Received {0} points out of {1}");
			langEn.Add("StartNewAutoMsm", "New Automatic Measurement");
			langEn.Add("ForceStop", "Force Stop");
			langEn.Add("MustSaveMsm", "You must save the automatic measurement that has just finished");
			//langEn.Add("", "");
			langs.Add("en", langEn);


			//Spanish
			Dictionary<string, string> langEs = new Dictionary<string, string>();
			langEs.Add("File", "Archivo");
			langEs.Add("Exit", "Salir");
			langEs.Add("About", "Acerca de...");
			langs.Add("es", langEs);


			//French
			Dictionary<string, string> langFr = new Dictionary<string, string>();
			langFr.Add("File", "Fichier");
			langFr.Add("Exit", "Sortir");
			langFr.Add("About", "À propos de...");
			langFr.Add("init", "Debut du programme...");
			langFr.Add("Connected", "Connecté");
			langFr.Add("Disconnected", "Déconnecté");
			langFr.Add("Mode", "Mode");
			langFr.Add("Mode" + ScannerMode.Inactive, "Inactif");
			langFr.Add("Mode" + ScannerMode.Manual, "Manuel");
			langFr.Add("Mode" + ScannerMode.Scan, "Numérisation");
			langFr.Add("ManualControl", "Contrôle Manuel");
			langFr.Add("Scan", "Scan");
			langFr.Add("recManualTitle", "Dernière Valeur Reçu :");
			langFr.Add("recManualValue", "Valeur: {0} (0-{1})");
			langFr.Add("recManualVoltage", "Tension: {0}V (0V=0, {1}V={2})");
			langFr.Add("recManualDistance", "Distance: {0}mm (3.15V=70mm, 1.65V=150mmm 0.4V=800mm, non-linéaire)");
			langFr.Add("Connection", "Connexion");
			langFr.Add("UpdateList", "Mise à jour");
			langFr.Add("bauds", "bauds");
			langFr.Add("Connect", "Connecter");
			langFr.Add("Disconnect", "Déconnecter");
			langFr.Add("Edit", "Modifier");
			langFr.Add("View", "Affichage");
			langFr.Add("Language", "Langage");
			langs.Add("fr", langFr);
		}

		public static string str(string id, params object[] p) {
			if(langs[CurrLang].ContainsKey(id)) return string.Format(langs[CurrLang][id], p);
			else if(langs["en"].ContainsKey(id)) return string.Format(langs["en"][id], p);
			else throw new Exception(string.Format("Language string not found. Lang: {0}, ID: {1}", CurrLang, id));
		}
	}
}
