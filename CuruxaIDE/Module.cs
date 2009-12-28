using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;

namespace CuruxaIDE {
	/// <summary>
	/// List of available Curuxa Modules
	/// </summary>
	public enum Module {
		[Description("SISW-SPST")]
		SISW_SPST,

		[Description("LTIND-A")]
		LTIND_A,

		[Description("LTIL-A")]
		LTIL_A,

		[Description("AO-PZ")]
		AO_PZ,

		[Description("CMIR-RC")]
		CMIR_RC
	}

	public static class ModuleExtensions {
		/// <summary>
		/// Gets the real name of this Curuxa Module
		/// </summary>
		public static string GetRealName(this Module M) {
			FieldInfo fi = M.GetType().GetField(M.ToString());

			DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

			if(attributes != null && attributes.Length > 0) return attributes[0].Description;
			else return M.ToString();
		}

		/// <summary>
		/// Get a Module given its real name
		/// </summary>
		public static Module GetModuleFromRealName(string M) {
			foreach(string Mod in Enum.GetNames(typeof(Module))) {
				Module m = (Module)Enum.Parse(typeof(Module), Mod);
				if(M == m.GetRealName()) return m;
			}
			throw new ArgumentException(string.Format("\"" + M + "\" is not the real name of any known Module"));
		}
	}
}
