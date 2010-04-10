using System;

namespace CuruxaIDE {
	public static class StringExtensions {
		public static bool IsNumber(this string str) {
			foreach(char c in str) {
				if(!char.IsNumber(c)) return false;
			}
			return true;
		}

		/// <summary>
		/// Remove all text from the given value till the end
		/// </summary>
		public static string RemoveFrom(this string str, string value) {
			if(str.Contains(value)) return str.Remove(str.IndexOf(value));
			else return str;
		}
		
		/// <summary>
		/// Remove all text from the given value till the end
		/// </summary>
		public static string RemoveFrom(this string str, char value) {
			return RemoveFrom(str, value.ToString());
		}
	}
}
