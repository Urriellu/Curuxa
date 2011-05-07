using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _3DScannerPC.Properties;

namespace _3DScannerPC {
	/// <summary>
	/// Servomotor-related operations
	/// </summary>
	/// <remarks>
	/// Hardcoded for Tosc=8MHz
	/// </remarks>
	public class Servo {
		public readonly ServoID ID;

		public Servo(ServoID id) {
			ID = id;
		}

		/// <summary>
		/// Duty time (in microseconds) for 0º
		/// </summary>
		public UInt16 Duty0deg {
			get {
				switch(ID) {
					case ServoID.H:
						return Settings.Default.ServoHduty0Deg;
					case ServoID.V:
						return Settings.Default.ServoVduty0Deg;
					default:
						throw new NotImplementedException();
				}
			}
		}

		/// <summary>
		/// Duty time (in microseconds) for 180º
		/// </summary>
		public UInt16 Duty180deg {
			get {
				switch(ID) {
					case ServoID.H:
						return Settings.Default.ServoHduty180Deg;
					case ServoID.V:
						return Settings.Default.ServoVduty180Deg;
					default:
						throw new NotImplementedException();
				}
			}
		}

		public UInt16 Ccp0deg {
			get {
				return DutyToCcp(Duty0deg);
			}
		}

		public UInt16 Ccp180deg {
			get {
				return DutyToCcp(Duty180deg);
			}
		}




		#region STATIC
		public static Servo H = new Servo(ServoID.H);
		public static Servo V = new Servo(ServoID.V);

		public static Dictionary<ServoID, Servo> All;

		static Servo() {
			All = new Dictionary<ServoID, Servo>();
			All.Add(ServoID.H, H);
			All.Add(ServoID.V, V);
		}

		public static UInt16 DutyToCcp(UInt16 duty) {
			int r = Settings.Default.T1preload + 2 * duty;
			if(r < Settings.Default.T1preload || r > UInt16.MaxValue) throw new Exception("Wrong implementation");
			return (UInt16)r;
		}

		public static float DutyToDeg(UInt16 duty, ServoID servo) {
			float val = duty - All[servo].Duty0deg;
			float val180 = All[servo].Duty180deg - All[servo].Duty0deg;
			return (float)val * 180f / val180;
		}
		#endregion
	}
}
