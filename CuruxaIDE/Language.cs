using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuruxaIDE {
	/// <summary>
	/// Programming Languages
	/// </summary>
	public enum Language {
		/// <summary>
		/// Plain text
		/// </summary>
		Text,

		/// <summary>
		/// Microchip PIC Assembly Language
		/// </summary>
		PicAsm,

		/// <summary>
		/// C language
		/// </summary>
		C
	}

	public static class LanguageExtensions {
		static Dictionary<Language, string> LangExtensions = new Dictionary<Language, string>();

		static LanguageExtensions() {
			LangExtensions.Add(Language.Text, "txt");
			LangExtensions.Add(Language.C, "c");
			LangExtensions.Add(Language.PicAsm, "asm");
		}

		/// <summary>
		/// Get the language, given a extension
		/// </summary>
		/// <param name="extension"></param>
		/// <returns></returns>
		public static Language GetFromExtension(string extension) {
			extension = extension.ToLowerInvariant();
			foreach(KeyValuePair<Language, string> pair in LangExtensions) {
				if(pair.Value == extension) return pair.Key;
			}
			return Language.Text;
		}

		/// <summary>
		/// Gets the default extension for the given programming language (just the extension, without point)
		/// </summary>
		public static string GetExtension(this Language lang) {
			return LangExtensions[lang];
		}

		/// <summary>
		/// Gets the toolsuite used for compiling the given programming language
		/// </summary>
		public static Toolsuite GetToolsuite(this Language lang) {
			switch(lang) {
				case Language.C:
					return Toolsuite.SDCC;
				default:
					throw new NotImplementedException();
			}
		}
	}
}
