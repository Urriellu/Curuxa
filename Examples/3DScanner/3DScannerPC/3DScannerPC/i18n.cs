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
			langFr.Add("About", "About...");
			langs.Add("fr", langFr);
		}

		public static string str(string id, params object[] p) {
			if(langs[CurrLang].ContainsKey(id)) return string.Format(langs[CurrLang][id], p);
			else if(langs["en"].ContainsKey(id)) return string.Format(langs["en"][id], p);
			else throw new Exception(string.Format("Language string not found. Lang: {0}, ID: {1}", CurrLang, id));
		}
	}
}
