using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization;

namespace _3DScannerPC {
	/// <summary>
	/// Collection of raw measured points
	/// </summary>
	[DataContract]
	public class RawMeasurement/*:List<RawMeasuredPoint>*/ {
		[DataMember]
		public string Name;

		/// <summary>
		/// Voltage reference (usually 5V)
		/// </summary>
		[DataMember]
		public float VRef;

		/// <summary>
		/// Maximum ADC value (for a 10-bit ADC it would be 1023)
		/// </summary>
		[DataMember]
		public UInt16 AdcMax;

		/// <summary>
		/// Location of the 3D Scanner
		/// </summary>
		[DataMember]
		public Vector3 BaseLocation = new Vector3(0, 0, 0);

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

		public RawMeasuredPoint Last {
			get {
				return this[Count - 1];
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
