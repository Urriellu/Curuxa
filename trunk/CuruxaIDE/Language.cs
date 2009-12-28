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
		/// Microchip PIC Assembly Language
		/// </summary>
		PicAsm,

		/// <summary>
		/// C language
		/// </summary>
		C
	}

	public static class LanguageExtensions {
		/// <summary>
		/// Gets the default extension for the given programming language (just the extension, without point)
		/// </summary>
		public static string GetExtension(this Language lang) {
			switch(lang) {
				case Language.C:
					return "c";
				case Language.PicAsm:
					return "asm";
				default:
					throw new NotImplementedException();
			}
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
