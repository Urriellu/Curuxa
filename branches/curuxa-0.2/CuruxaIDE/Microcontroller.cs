using System;
using System.Reflection;

namespace CuruxaIDE {
	/// <summary>
	/// List of available microcontrollers
	/// </summary>
	public enum Microcontroller {
		PIC12F683,
		PIC16F688,
		PIC16F88,
		PIC16F887
	}

	public static class MicrocontrollerExtensions {
		/// <summary>
		/// Gets the Main Board which uses the given Microcontroller. Returns null if the microcontroller is not used in Curuxa
		/// </summary>
		public static MainBoard? GetMainBoard(this Microcontroller MCU) {
			foreach(MainBoard MB in Enum.GetValues(typeof(MainBoard))) {
				if(MB.GetMCU() == MCU) return MB;
			}
			return null;
		}
	}
}
