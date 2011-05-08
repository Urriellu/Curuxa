using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DScannerPC {
	/// <summary>
	/// Measured value by distance sensor
	/// </summary>
	/// <remarks>
	/// 8-30cm - high resolution
	/// 30-50cm - medium resolution
	/// 50-80cm - low resolution
	/// </remarks>
	public struct Measure {
		/// <summary>
		/// List of known points of the voltage-distance graph for the GP2 sensor. Key: voltage. Value: distance in mm
		/// </summary>
		static List<KeyValuePair<float,float>> knownPoints;

		static Measure() {
			knownPoints = new List<KeyValuePair<float, float>>();
			knownPoints.Add(new KeyValuePair<float, float>(3.15f, 70f));
			knownPoints.Add(new KeyValuePair<float, float>(2.3f, 100f));
			knownPoints.Add(new KeyValuePair<float, float>(1.65f, 150f));
			knownPoints.Add(new KeyValuePair<float, float>(1.35f, 200f));
			knownPoints.Add(new KeyValuePair<float, float>(1.1f, 250f));
			knownPoints.Add(new KeyValuePair<float, float>(0.9f, 300f));
			knownPoints.Add(new KeyValuePair<float, float>(0.75f, 400f));
			knownPoints.Add(new KeyValuePair<float, float>(0.6f, 500f));
			knownPoints.Add(new KeyValuePair<float, float>(0.5f, 620f));
			knownPoints.Add(new KeyValuePair<float, float>(0.45f, 700f));
			knownPoints.Add(new KeyValuePair<float, float>(0.42f, 800f));
		}

		public static float AdcValueToVoltage(int value, int AdcMax, float VRef) {
			return value * VRef / AdcMax;
		}

		/// <summary>
		/// Get the real distance, in millimeters
		/// </summary>
		/// <param name="volt"></param>
		/// <returns></returns>
		public static float VoltageToDistance(float volt) {
			if(volt >= knownPoints[0].Key) return 0;
			else if(volt <= knownPoints[knownPoints.Count - 1].Key) return float.PositiveInfinity;
			else {
				//find range
				int indexLowerVolt = 0;
				while(volt < knownPoints[indexLowerVolt].Key) indexLowerVolt++;
				int indexHigherVol = indexLowerVolt - 1;

				//pin-point value
				return (volt - knownPoints[indexHigherVol].Key) * (knownPoints[indexLowerVolt].Value - knownPoints[indexHigherVol].Value) / (knownPoints[indexLowerVolt].Key - knownPoints[indexHigherVol].Key) + knownPoints[indexHigherVol].Value;
			}
		}
	}
}
