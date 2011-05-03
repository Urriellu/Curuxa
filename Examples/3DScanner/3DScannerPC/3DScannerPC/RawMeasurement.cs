using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DScannerPC {
	public class RawMeasurement {
		/// <summary>
		/// Voltage reference
		/// </summary>
		public float VRef;

		public float ServoHOffset;
		public float ServoVOffset;

		public byte ServoH_0deg;
		public byte ServoH_180deg;
		public byte ServoV_0deg;
		public byte ServoV_180deg;

		/// <summary>
		/// Location of the 3D Scanner
		/// </summary>
		public Vector3 BaseLocation = new Vector3(0, 0, 0);

		/// <summary>
		/// Measured points
		/// </summary>
		public List<RawMeasuredPoint> Points;

		public DateTime Date = DateTime.Now;
	}
}
