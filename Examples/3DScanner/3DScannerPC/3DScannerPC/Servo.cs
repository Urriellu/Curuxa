using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DScannerPC {
	/// <summary>
	/// Servomotor-related operations
	/// </summary>
	/// <remarks>
	/// Hardcoded for Tosc=8MHz
	/// </remarks>
	public struct Servo {
		/// <summary>
		/// Duty cycle (microseconds) for 0º
		/// </summary>
		const UInt16 Deg0 = 900;

		/// <summary>
		/// Duty cycle (microseconds) for 180º
		/// </summary>
		const UInt16 Deg180 = 2100;

		/// <summary>
		/// Get the amount of microseconds of duty cycle based on desired servo position (degrees)
		/// </summary>
		/// <remarks>
		/// Accepted values: 0º - 180º
		/// </remarks>
		/// <param name="deg">Desired servo position (degrees)</param>
		/// <returns>Duty cycle (microseconds)</returns>
		public static float DegToDutyUs(float deg) {
			while(deg < -180) deg += 180;
			while(deg > 180) deg -= 180;
			if(deg < 0) deg = 180 - deg;
			return (Deg180 - Deg0) / 180f * deg + Deg0;
		}

		/// <summary>
		/// Get the required Timer 1 preload based on the desired doty (in microseconds)
		/// </summary>
		/// <param name="duty"></param>
		/// <returns></returns>
		public static UInt16 DutyToT1preload(float duty) {
			return (UInt16)(UInt16.MaxValue - (UInt16)(duty / 0.5));
		}

		/// <summary>
		/// Get the required Timer 1 preload based on the desired servo position (degrees)
		/// </summary>
		/// <param name="deg"></param>
		/// <returns></returns>
		public static UInt16 DegToT1preload(float deg) {
			return DutyToT1preload(DegToDutyUs(deg));
		}
	}
}
