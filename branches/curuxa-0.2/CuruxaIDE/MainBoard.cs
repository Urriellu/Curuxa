using System;
using System.ComponentModel;
using System.Reflection;

namespace CuruxaIDE {
	/// <summary>
	/// List of available Curuxa Main Boards
	/// </summary>
	public enum MainBoard {
		[Description("PIC12F683")]
		MBP8,

		[Description("PIC16F688")]
		MBP14,

		[Description("PIC16F88")]
		MBP18,

		[Description("PIC16F887")]
		MBP40
	}

	public static class MainBoardsExtensions {
		/// <summary>
		/// Gets the Microcontroller used in this Main Board
		/// </summary>
		public static Microcontroller GetMCU(this MainBoard MainBoard) {
			FieldInfo fi = MainBoard.GetType().GetField(MainBoard.ToString());

			DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

			if(attributes != null && attributes.Length > 0)
				return (Microcontroller)Enum.Parse(typeof(Microcontroller), attributes[0].Description);
			else
				throw new NotImplementedException("No Microcontroller assigned to this Main board");
		}
	}
}
