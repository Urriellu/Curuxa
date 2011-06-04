using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization;
using _3DScannerPC.Properties;

namespace _3DScannerPC {
	/// <summary>
	/// Collection of raw measured points
	/// </summary>
	[DataContract]
	public class RawMeasurement {
		[DataMember]
		public string Name = "NO NAME";

		/// <summary>
		/// Voltage reference (usually 5V)
		/// </summary>
		[DataMember]
		public float VRef = 5;

		/// <summary>
		/// Maximum ADC value (for a 10-bit ADC it would be 1023)
		/// </summary>
		[DataMember]
		public UInt16 AdcMax = 1023;

		/// <summary>
		/// Location of the 3D Scanner
		/// </summary>
		[DataMember]
		public Vector3 BaseLocation = new Vector3(0, 0, 0);

		/// <summary>
		/// Rotation of the 3D Scanner. Degrees
		/// </summary>
		[DataMember]
		public float BaseRotation = 0f;

		[DataMember]
		public DateTime Date;

		[DataMember]
		List<RawMeasuredPoint> points = new List<RawMeasuredPoint>();

		private RawMeasurement() {
		}

		public RawMeasurement(string name, float VRef, UInt16 AdcMax)
			: this(name, VRef, AdcMax, new Vector3(0, 0, 0)) {
		}

		public RawMeasurement(string name, float VRef, UInt16 AdcMax, Vector3 baseLocation)
			: this(name, VRef, AdcMax, baseLocation, DateTime.Now) {
		}

		public RawMeasurement(string name, float VRef, UInt16 AdcMax, Vector3 baseLocation, DateTime date) {
			this.Name = name;
			this.VRef = VRef;
			this.AdcMax = AdcMax;
			this.BaseLocation = baseLocation;
			this.Date = date;
		}

		public void Add(float Hpos, float Vpos, UInt16 AdcValue) {
			Add(new RawMeasuredPoint(this, Hpos, Vpos, AdcValue));
		}

		public void Add(RawMeasuredPoint p) {
			points.Add(p);
		}

		public void Save(string file) {
			try {
				XmlWriterSettings xws = new XmlWriterSettings();
				xws.Indent = true;
				xws.NewLineHandling = NewLineHandling.Entitize;
				DataContractSerializer dcs = new DataContractSerializer(typeof(RawMeasurement));
				XmlWriter xw = XmlWriter.Create(file, xws);
				dcs.WriteObject(xw, this);
				xw.Close();
				Globals.Log(LogType.Success, i18n.str("SaveRawMsm", Name, file));
			} catch(Exception ex) {
				Globals.Log(LogType.Error, i18n.str("UnableSaveFile", file, ex.Message));
			}
		}

		public RawMeasuredPoint this[int i] {
			get {
				return points[i];
			}
		}

		public int Count {
			get {
				return points.Count;
			}
		}

		/// <summary>
		/// The last measured point
		/// </summary>
		public RawMeasuredPoint Last {
			get {
				return this[Count - 1];
			}
		}

		/// <summary>
		/// The closes measured point
		/// </summary>
		public RawMeasuredPoint Closest {
			get {
				RawMeasuredPoint closest = null;
				foreach(var p in points) {
					if(closest == null || p.DistanceAdcValue > closest.DistanceAdcValue) closest = p;
				}
				return closest;
			}
		}

		/// <summary>
		/// The fasthest measured point
		/// </summary>
		public RawMeasuredPoint Farthest {
			get {
				RawMeasuredPoint farthest = null;
				foreach(var p in points) {
					if(farthest == null || p.DistanceAdcValue < farthest.DistanceAdcValue) farthest = p;
				}
				return farthest;
			}
		}

		/// <summary>
		/// The point measured furthest to the left
		/// </summary>
		public RawMeasuredPoint LeftMost {
			get {
				RawMeasuredPoint leftMost = null;
				foreach(var p in points) {
					if(leftMost == null || p.ServoHdeg > leftMost.ServoHdeg) leftMost = p;
				}
				return leftMost;
			}
		}

		/// <summary>
		/// The point measured furthest to the right
		/// </summary>
		public RawMeasuredPoint RightMost {
			get {
				RawMeasuredPoint righttmost = null;
				foreach(var p in points) {
					if(righttmost == null || p.ServoHdeg < righttmost.ServoHdeg) righttmost = p;
				}
				return righttmost;
			}
		}

		/// <summary>
		/// The highest point measured
		/// </summary>
		public RawMeasuredPoint Highest {
			get {
				RawMeasuredPoint highest = null;
				foreach(var p in points) {
					if(highest == null || p.ServoVdeg < highest.ServoVdeg) highest = p;
				}
				return highest;
			}
		}

		/// <summary>
		/// Horizontal range of measurement
		/// </summary>
		public float HRangeDeg {
			get {
				return LeftMost.ServoHdeg - RightMost.ServoHdeg;
			}
		}

		/// <summary>
		/// Vertical range of measurement
		/// </summary>
		public float VRangeDeg {
			get {
				return Lowest.ServoVdeg - Highest.ServoVdeg;
			}
		}

		/// <summary>
		/// The lowest point measured
		/// </summary>
		public RawMeasuredPoint Lowest {
			get {
				RawMeasuredPoint lowest = null;
				foreach(var p in points) {
					if(lowest == null || p.ServoVdeg > lowest.ServoVdeg) lowest = p;
				}
				return lowest;
			}
		}

		/// <summary>
		/// Return the average of last N points
		/// </summary>
		/// <param name="n">Amount of points to average</param>
		/// <returns>New point that represents the average of last N points</returns>
		public RawMeasuredPoint AvgLastPoints(int n) {
			if(n <= 0) throw new ArgumentException();
			if(Count < n) n = Count;
			float Hpos = 0;
			float Vpos = 0;
			float AdcValue = 0;
			for(int i = Count - 1; i > Count - 1 - n; i--) {
				Hpos += this[i].ServoHdeg / n;
				Vpos += this[i].ServoVdeg / n;
				AdcValue += this[i].DistanceAdcValue / (float)n;
			}
			return new RawMeasuredPoint(this, Hpos, Vpos, (UInt16)AdcValue);
		}

		public RawMeasuredPoint AvgPoints(RawMeasuredPoint[] points) {
			int n = points.Length;
			float Hpos = 0;
			float Vpos = 0;
			float AdcValue = 0;
			foreach(RawMeasuredPoint p in points) {
				Hpos += p.ServoHdeg / n;
				Vpos += p.ServoVdeg / n;
				AdcValue += p.DistanceAdcValue / (float)n;
			}
			return new RawMeasuredPoint(this, Hpos, Vpos, (UInt16)AdcValue);
		}

		#region STATIC
		/// <summary>
		/// Initilize static stuff
		/// </summary>
		static RawMeasurement() {
			KnownRMs = new Dictionary<string, RawMeasurement>();
			foreach(string fileRawMsm in Settings.Default.OpenRawMsms) {
				RawMeasurement.OpenRawMsm(fileRawMsm, false);
			}
		}

		/// <summary>
		/// Collection of RAW Measurements.
		/// Key: file where it's stored.
		/// Value: RawMeasurement object
		/// </summary>
		public static Dictionary<string, RawMeasurement> KnownRMs;

		/// <summary>
		/// Open a new RAW Measurement from a file and puts it in the list of all known RAW Measurements
		/// </summary>
		/// <param name="fileRawMsm">RAW Measurement file</param>
		public static RawMeasurement OpenRawMsm(string fileRawMsm) {
			return OpenRawMsm(fileRawMsm, true);
		}

		/// <summary>
		/// Open a new RAW Measurement from a file and puts it in the list of all known RAW Measurements
		/// </summary>
		/// <param name="fileRawMsm">RAW Measurement file</param>
		/// <param name="updateWindows">Indicate if windows should be updated. This is to avoid that the static constructors updates the windows when starting the app</param>
		public static RawMeasurement OpenRawMsm(string fileRawMsm, bool updateWindows) {
			RawMeasurement newRM = null;
			if(!KnownRMs.ContainsKey(fileRawMsm)) {
				newRM = Load(fileRawMsm);
				if(newRM != null) {
					KnownRMs.Add(fileRawMsm, newRM);
					if(updateWindows) Globals.MainWindow.UpdateListOpenRawMsms();
				}
			}
			return newRM;
		}

		public static void CloseRawMwm(string fileRawMsm) {
			KnownRMs.Remove(fileRawMsm);
			Globals.MainWindow.UpdateListOpenRawMsms();
		}

		/// <summary>
		/// Load a new RAW Measurement from a file
		/// </summary>
		/// <param name="file"></param>
		/// <returns>Read object from file. Null if unable to read</returns>
		public static RawMeasurement Load(string file) {
			try {
				XmlReaderSettings xws = new XmlReaderSettings();
				DataContractSerializer dcs = new DataContractSerializer(typeof(RawMeasurement));
				XmlReader xw = XmlReader.Create(file, xws);
				RawMeasurement readRawMsm = (RawMeasurement)dcs.ReadObject(xw);
				xw.Close();

				//restore pointer to parent RawMeasurement (not stored in file)
				for(int i = 0; i < readRawMsm.Count; i++) {
					readRawMsm[i].ParentMeasurement = readRawMsm;
				}

				Globals.Log(LogType.Success, i18n.str("ReadRawMsm", readRawMsm.Name, file));
				return readRawMsm;
			} catch(Exception ex) {
				Globals.Log(LogType.Error, i18n.str("UnableLoadFile", file, ex.Message));
				return null;
			}
		}
		#endregion
	}
}
