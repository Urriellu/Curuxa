using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace _3DScannerPC {
	[DataContract]
	public class RawMeasuredPoint {
		/// <summary>
		/// The RawMeasurement this point belongs to
		/// </summary>
		public RawMeasurement ParentMeasurement;

		/// <summary>
		/// Horizontal position when this point was measured. Degrees
		/// </summary>
		[DataMember]
		public float ServoHdeg;

		/// <summary>
		/// Horizontal position when this point was measured. Degrees
		/// </summary>
		[DataMember]
		public float ServoVdeg;

		/// <summary>
		/// Measured distance, as ADC result value
		/// </summary>
		/// <remarks>
		/// The real distance can be calculated using VRef and AdcMax from ParentMeasurement
		/// </remarks>
		[DataMember]
		public UInt16 DistanceAdcValue;

		/// <summary>
		/// Measured output voltage from sensor
		/// </summary>
		public float DistanceVolts {
			get {
				return Measure.AdcValueToVoltage(DistanceAdcValue, ParentMeasurement.AdcMax, ParentMeasurement.VRef);
			}
		}

		/// <summary>
		/// Real measured distance, in millimeters
		/// </summary>
		public float Distance_mm {
			get {
				return Measure.VoltageToDistance(DistanceVolts);
			}
		}

		/// <summary>
		/// Real measured distance, in centimeters
		/// </summary>
		public float Distance_cm {
			get {
				return Distance_mm / 10;
			}
		}

		/// <summary>
		/// Real measured distance, in centimeters, rouded to 2 decimal positions
		/// </summary>
		public float Distance_cm_2dec {
			get {
				return (float)Math.Round(Distance_cm, 2);
			}
		}

		protected RawMeasuredPoint() {
		}

		public RawMeasuredPoint(RawMeasurement parent, float Hpos, float Vpos, UInt16 AdcValue) {
			this.ParentMeasurement = parent;
			this.ServoHdeg = Hpos;
			this.ServoVdeg = Vpos;
			this.DistanceAdcValue = AdcValue;
		}
	}
}
