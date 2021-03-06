﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;

namespace CuruxaIDE {
	/// <summary>
	/// Contains all the variables and methods required for showing internationalized strings. Before using any of it you must set CurrentLanguage
	/// </summary>
	/// <remarks>
	/// Only one language will be loaded at a time. All the strings are loaded automatically by this class. All the strings are stored in flat files, called "CurrentLanguage.lang"
	/// </remarks>
	public class i18n {
		/// <summary>
		/// Gets or sets the current language
		/// </summary>
		public static string CurrentLanguage {
			get {
				if(_CurrentLanguage == null) _CurrentLanguage = DefaultLang;
				return _CurrentLanguage;
			}
			set {
				Globals.Debug("Switching to language: {0}", value);
				if(AvailableLanguages.Contains(value)) {
					_CurrentLanguage = value;
					LangStrings.Clear();
				} else throw new Exception("Unknown language: " + value);
			}
		}
		private static string _CurrentLanguage;

		/// <summary>
		/// Gets the default language for the application
		/// </summary>
		public static string DefaultLang {
			get {
				string MyLang = System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
				if(AvailableLanguages.Contains(MyLang)) return MyLang;
				else return "en";
			}
		}

		public static List<string> AvailableLanguages {
			get {
				if(_AvailableLanguages == null) {
					Globals.Debug("Retrieving the list of available languages");
					_AvailableLanguages = new List<string>();
					_AvailableLanguages.Clear();
					DirectoryInfo dir = new DirectoryInfo(Settings.LanguageFilesDir);
					FileInfo[] files = dir.GetFiles("*.lang");
					if(files.Length == 0) throw new Exception(string.Format("No language files found in {0}", Settings.LanguageFilesDir));
					foreach(FileInfo fi in files) {
						_AvailableLanguages.Add(fi.Name.Replace(".lang", ""));
					}
					Globals.Debug("Available languages: {0}", _AvailableLanguages.CommaSeparatedList());
				}
				return _AvailableLanguages;
			}
		}
		protected static List<string> _AvailableLanguages;

		/// <summary>
		/// List of language strings not yet translated
		/// </summary>
		public static List<string> LangStrNotTranslated = new List<string>();

		/// <summary>
		/// Given the native name of a natural language "English", "Español"... it get its two-letter ISO language ID (i.e: "en", "es"...)
		/// </summary>
		/// <param name="NativeName">Native name of the given natural language ("English", "Español"...)</param>
		/// <returns>Two-letter ISO language name ("en", "es"...)</returns>
		public static string GetLangFromNativeName(string NativeName) {
			string TwoLetterName = "";
			foreach(CultureInfo culture in CultureInfo.GetCultures(CultureTypes.AllCultures)) {
				if(culture.NativeName == NativeName) TwoLetterName = culture.TwoLetterISOLanguageName;
			}
			return TwoLetterName;
		}

		public static string GetNativeName(string LangID) {
			foreach(CultureInfo culture in CultureInfo.GetCultures(CultureTypes.AllCultures)) {
				if(culture.TwoLetterISOLanguageName == LangID) return culture.NativeName;
			}
			throw new ArgumentException("Unknown LangID");
		}

		protected static Dictionary<string, string> LangStrings = new Dictionary<string, string>();

		/// <summary>
		/// Gets a string written in the current configured language. If it hasn't been translated yet it will be returned in english
		/// </summary>
		/// <param name="ID">The identification</param>
		/// <param name="replacements">Strings that replace {0}, {1}, {2}... in the original string</param>
		public static string str(UInt32 ID, params object[] replacements) {
			return str(ID.ToString(), replacements);
		}

		/// <summary>
		/// Gets a string written in the current configured language. If it hasn't been translated yet it will be returned in english
		/// </summary>
		/// <param name="ID">The identification</param>
		/// <param name="replacements">Strings that replace {0}, {1}, {2}... in the original string</param>
		public static string str(string ID, params object[] replacements) {
			if(LangStrings.Keys.Count == 0) LoadLangStrings();
			string str = "";
			if(LangStrings.ContainsKey(ID)) {
				try {
					str = string.Format(LangStrings[ID], replacements);
				} catch(FormatException fe) {
					throw new FormatException("Passed " + replacements.Length + " replacements. String [" + ID.ToString() + "]=" + LangStrings[ID], fe);
				}
			} else {
				string msg = "Unknown i18n ID: \"" + ID + "\". Known IDs: " + LangStrings.Keys.CommaSeparatedList();
				Console.Error.WriteLine(msg);
				throw new Exception(msg);
			}
			if(string.IsNullOrEmpty(str)) throw new Exception(string.Format("Language string \"{0}\" is empty", ID));
			return str;
		}

		/// <summary>
		/// Gets a bulk language string (without formatting, just the string as it is written in the language file
		/// </summary>
		public static string StrBulk(string ID) {
			Globals.Debug("Retrieving bulk language string, ID={0}", ID);
			if(LangStrings.Keys.Count == 0) LoadLangStrings();
			string str = "";
			if(LangStrings.ContainsKey(ID)) str = LangStrings[ID];
			else throw new Exception("Unknown i18n ID: " + ID);
			return str;
		}

		/// <summary>
		/// Loads the language strings from a file, based on the configured CurrentLanguage
		/// </summary>
		/// <remarks>
		/// It usually doesn't need to be called explicitly, language strings are loaded automatically when the first internatinalized string is used
		/// </remarks>
		public static void LoadLangStrings() {
			Globals.Debug("Loading language strings");

			LangStrings.Clear();
			string ID = "", text = "", file = Settings.LanguageFilesDir + "/" + "en.lang";

			//first load english strings
			TextReader tr = new StreamReader(file);
			while(true) {
				string NewLine = tr.ReadLine();
				if(NewLine != null) {
					if(NewLine != "") {
						ParseLine(NewLine, out ID, out text);
						if(LangStrings.ContainsKey(ID)) throw new Exception("Duplicated ID: " + ID);
						LangStrings.Add(ID, text);
						LangStrNotTranslated.Add(ID);
					} else Globals.Debug("WARNING: empty line found in {0}", file);
				} else break;
			}
			tr.Close();

			file = Settings.LanguageFilesDir + "/" + CurrentLanguage + ".lang";

			//replace some of them with the configured language strings
			tr = new StreamReader(file);
			while(true) {
				string NewLine = tr.ReadLine();
				if(!string.IsNullOrEmpty(NewLine)) {
					if(!string.IsNullOrEmpty(NewLine)) ParseLine(NewLine, out ID, out text);
					if(!LangStrings.ContainsKey(ID)) throw new Exception(string.Format("The language {0} has an incorrect string ID: {1} (it doesn't exist in the English language file)", CurrentLanguage, ID));
					LangStrings[ID] = text;
					LangStrNotTranslated.Remove(ID);
				} else break;
			}
			tr.Close();

			Globals.Debug("Loaded {0} language strings", LangStrings.Count);
		}

		/// <summary>
		/// Parse a line from a language file
		/// </summary>
		/// <param name="LineText">The entire text of the line</param>
		/// <param name="ID">Outputs the ID of the line</param>
		/// <param name="text">Outputs the associated text with that ID</param>
		protected static void ParseLine(string LineText, out string ID, out string text) {
			ID = LineText.Remove(LineText.IndexOf('='));
			text = LineText.Substring(ID.Length + 1);
		}
	}
}
