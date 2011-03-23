using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace CuruxaIDE {
	public static class HttpDownloader {
		public enum AsyncDownloadId {
			GetCuruxaWebsiteMenu,
			GetCommunityWebsiteMenu
		}

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

		/*public static string GetUrlContentAsync(string URL, AsyncDownloadId id) {
			try {
				HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(URL);
				req.Timeout = 15000;
				req.UserAgent = "CuruxaIDE, " + Environment.MachineName;
				WebResponse response = req.GetResponse();
				req.BeginGetResponse(new AsyncCallback(EndGetResponseCallback), id);
				Stream stream = response.GetResponseStream();
				StreamReader sr = new StreamReader(stream);
				string content = sr.ReadToEnd();
				return content;
			} catch {
				return "";
			}
		}

		static void EndGetResponseCallback(IAsyncResult ar) {
			AsyncDownloadId id = (AsyncDownloadId)ar.AsyncState;
			switch(id) {
				case AsyncDownloadId.GetCuruxaWebsiteMenu:
					ParseMediaWikiMenu(ar "http://curuxa.org/en/", "http://curuxa.org/w/index.php?title=MediaWiki:Sidebar&action=edit"
					break;
				default:
					Globals.Debug("Unknown Async HTTP response: " + id);
					break;
			}
		}*/

		private static void GetUrlContentAsync(string URL, AsyncDownloadId id) {
			try {
				WebClient webClient = new WebClient();
				webClient.DownloadDataCompleted += new DownloadDataCompletedEventHandler(AsyncDownloadCompleted);
				webClient.DownloadDataAsync(new Uri(URL), id);
			} catch(Exception ex) {
				Globals.DebugExceptionIgnored(ex);
			}
		}

		private static void AsyncDownloadCompleted(object sender, DownloadDataCompletedEventArgs e) {
			AsyncDownloadId id = (AsyncDownloadId)e.UserState;
			if(id == AsyncDownloadId.GetCuruxaWebsiteMenu || id == AsyncDownloadId.GetCommunityWebsiteMenu) {
				string originalMenu;
				try {
					originalMenu = System.Text.Encoding.UTF8.GetString(e.Result);
					ParseMediaWikiMenu(originalMenu, id);
				} catch(Exception ex) {
					Globals.DebugExceptionIgnored(ex);
				}
			} else throw new NotImplementedException("Unknown async HTTP download type");
		}

		public static Dictionary<string, List<KeyValuePair<string, string>>> CuruxaWebsiteMenu { get; private set; }
		public static Dictionary<string, List<KeyValuePair<string, string>>> CommunityWebsiteMenu { get; private set; }

		/*public static Dictionary<string, List<KeyValuePair<string, string>>> CuruxaWebsiteMenu {
			get {
				//if(_CuruxaWebsiteMenu == null) _CuruxaWebsiteMenu = GetMediaWikiMenu("http://curuxa.org/en/", "http://curuxa.org/w/index.php?title=MediaWiki:Sidebar&action=edit");
				return _CuruxaWebsiteMenu;
			}
		}
		private static Dictionary<string, List<KeyValuePair<string, string>>> _CuruxaWebsiteMenu;

		public static Dictionary<string, List<KeyValuePair<string, string>>> CommunityWebsiteMenu {
			get {
				//if(_CommunityWebsiteMenu == null) _CommunityWebsiteMenu = GetMediaWikiMenu("http://community.curuxa.org/en/", "http://community.curuxa.org/w_en/index.php?title=MediaWiki:Sidebar&action=edit");
				if(_CommunityWebsiteMenu == null) GetUrlContentAsync
				return _CommunityWebsiteMenu;
			}
		}
		private static Dictionary<string, List<KeyValuePair<string, string>>> _CommunityWebsiteMenu;*/

		/// <summary>
		/// Download a parse asynchronously the links on the Curuxa Website
		/// </summary>
		public static void DownloadCuruxaWebsiteMenu() {
			GetUrlContentAsync("http://curuxa.org/w/index.php?title=MediaWiki:Sidebar&action=edit", AsyncDownloadId.GetCuruxaWebsiteMenu);
		}

		/// <summary>
		/// Download a parse asynchronously the links on the Curuxa Community Website
		/// </summary>
		public static void DownloadCommunityWebsiteMenu() {
			GetUrlContentAsync("http://community.curuxa.org/w_en/index.php?title=MediaWiki:Sidebar&action=edit", AsyncDownloadId.GetCommunityWebsiteMenu);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="originalMenu"></param>
		/// <param name="linkBase"></param>
		/// <param name="menuEditUrl"></param>
		/// <param name="id"></param>
		static void ParseMediaWikiMenu(string originalMenu, AsyncDownloadId id) {
			string linkBase;
			switch(id) {
				case AsyncDownloadId.GetCuruxaWebsiteMenu:
					linkBase = "http://curuxa.org/en/";
					break;
				case AsyncDownloadId.GetCommunityWebsiteMenu:
					linkBase = "http://community.curuxa.org/en/";
					break;
				default:
					throw new NotImplementedException("Unkown website ID");
					break;
			}
			Dictionary<string, List<KeyValuePair<string, string>>> menu = new Dictionary<string, List<KeyValuePair<string, string>>>();
			string currentSectionName = "";
			List<KeyValuePair<string, string>> section = null;
			//string originalMenu = GetUrlContent(menuEditUrl);
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
			switch(id) {
				case AsyncDownloadId.GetCuruxaWebsiteMenu:
					CuruxaWebsiteMenu = menu;
					Globals.MainWindow.UpdateCuruxaWebsiteMenuLinks();
					break;
				case AsyncDownloadId.GetCommunityWebsiteMenu:
					CommunityWebsiteMenu = menu;
					Globals.MainWindow.UpdateCommunityWebsiteMenuLinks();
					break;
			}
		}
	}
}
