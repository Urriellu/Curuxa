using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DScannerPC {
	public class ModelOLD {
		public string Name;
		
		/// <summary>
		/// All the data.
		/// Keys: the original RawMeasurement (they contain the points in low-level values given by the ADC and timer-overflow-value for controlling servos with PWM).
		/// Values: collections of points in real-world coordinates calculated from the RawMeasurement points
		/// </summary>
		public Dictionary<RawMeasurement, List<Vector3>> Data;
	}
}
