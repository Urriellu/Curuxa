using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace CuruxaIDE {
	public static class HttpDownloader {
		public static string GetUrlContent(string URL) {
			try {
				HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(URL);
				req.Timeout = 15000;
				req.UserAgent = "CuruxaIDE, " + Environment.MachineName;
				WebResponse response = req.GetResponse();
				Stream stream = response.GetResponseStream();
				StreamReader sr = new StreamReader(stream);
				string content = sr.ReadToEnd();
				return content;
			} catch {
				return "";
			}
		}

		public static Dictionary<string, List<KeyValuePair<string, string>>> CuruxaWebsiteMenu {
			get {
				if(_CuruxaWebsiteMenu == null) _CuruxaWebsiteMenu = GetMediaWikiMenu("http://curuxa.org/en/", "http://curuxa.org/w/index.php?title=MediaWiki:Sidebar&action=edit");
				return _CuruxaWebsiteMenu;
			}
		}
		private static Dictionary<string, List<KeyValuePair<string, string>>> _CuruxaWebsiteMenu;

		public static Dictionary<string, List<KeyValuePair<string, string>>> CommunityWebsiteMenu {
			get {
				if(_CommunityWebsiteMenu == null) _CommunityWebsiteMenu = GetMediaWikiMenu("http://community.curuxa.org/en/", "http://community.curuxa.org/w_en/index.php?title=MediaWiki:Sidebar&action=edit");
				return _CommunityWebsiteMenu;
			}
		}
		private static Dictionary<string, List<KeyValuePair<string, string>>> _CommunityWebsiteMenu;

		static Dictionary<string, List<KeyValuePair<string, string>>> GetMediaWikiMenu(string linkBase, string menuEditUrl) {
			Dictionary<string, List<KeyValuePair<string, string>>> menu = new Dictionary<string, List<KeyValuePair<string, string>>>();
			string currentSectionName = "";
			List<KeyValuePair<string, string>> section = null;
			string originalMenu = GetUrlContent(menuEditUrl);
			if(!string.IsNullOrEmpty(originalMenu)) {
				originalMenu = originalMenu.Remove(0, originalMenu.IndexOf("<textarea id=\"wpTextbox1\"") + 1);
				originalMenu = originalMenu.Remove(0, originalMenu.IndexOf('>') + 1);
				originalMenu = originalMenu.Substring(0, originalMenu.IndexOf("</textarea>"));
				foreach(string L in originalMenu.Split('\r', '\n')) {
					string line = L.Trim('\r', '\n', ' ');
					if(!string.IsNullOrEmpty(line) && !line.Contains("TOOLBOX") && !line.Contains("SEARCH") && !line.Contains("LANGUAGES")) {
						if(line.StartsWith("**")) {
							//new link detected
							line = line.Trim('*', ' ');
							string[] lineParts = line.Split('|');
							string linkUrl = linkBase;
							if(lineParts[0].StartsWith("http://")) linkUrl = lineParts[0];
							else linkUrl += lineParts[0];
							string linkText = lineParts[1];
							section.Add(new KeyValuePair<string, string>(linkText, linkUrl));
						} else if(line.StartsWith("*")) {
							//NEW SECTION DETECTED
							if(section != null && section.Count > 0) menu.Add(currentSectionName, section);

							//start new section
							section = new List<KeyValuePair<string, string>>();
							currentSectionName = line.Trim('*', ' ');
						}
					}
				}
			}
			return menu;
		}
	}
}
