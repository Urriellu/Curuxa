using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Xml;
using _3DScannerPC.Properties;

namespace _3DScannerPC {
	[DataContract]
	public class Model3D {
		/// <summary>
		/// Collection of Model.
		/// Key: file where it's stored.
		/// Value: Model3D object
		/// </summary>
		public static Dictionary<string, Model3D> KnownModels;

		[DataMember]
		public string Name = "NO NAME";

		[DataMember]
		public DateTime Date;

		[DataMember]
		List<Vector3> points = new List<Vector3>();

		private Model3D() {
		}

		public Model3D(string name)
			: this(name, DateTime.Now) {
		}

		public Model3D(string name, DateTime date) {
			this.Name = name;
			this.Date = date;
		}

		public Vector3 this[int i] {
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
		/// Initilize static stuff
		/// </summary>
		static Model3D() {
			KnownModels = new Dictionary<string, Model3D>();
			foreach(string fileModel in Settings.Default.OpenModels) {
				Model3D.OpenModel(fileModel, false);
			}
		}

		/// <summary>
		/// Open a new Model from a file and puts it in the list of all known Models
		/// </summary>
		/// <param name="fileModel">RAW Measurement file</param>
		public static Model3D OpenModel(string fileModel) {
			return OpenModel(fileModel, true);
		}

		/// <summary>
		/// Open a new Model from a file and puts it in the list of all known Models
		/// </summary>
		/// <param name="fileModel">Model file</param>
		/// <param name="updateWindows">Indicate if windows should be updated. This is to avoid that the static constructors updates the windows when starting the app</param>
		public static Model3D OpenModel(string fileModel, bool updateWindows) {
			Model3D newModel = null;
			if(!KnownModels.ContainsKey(fileModel)) {
				newModel = Load(fileModel);
				if(newModel != null) {
					KnownModels.Add(fileModel, newModel);
					if(updateWindows) Globals.MainWindow.UpdateListOpenModels();
				}
			}
			return newModel;
		}

		public static void CloseModel(string fileModel) {
			KnownModels.Remove(fileModel);
			Globals.MainWindow.UpdateListOpenModels();
		}

		/// <summary>
		/// Load a new Model from a file
		/// </summary>
		/// <param name="file"></param>
		/// <returns>Read object from file. Null if unable to read</returns>
		public static Model3D Load(string file) {
			try {
				XmlReaderSettings xws = new XmlReaderSettings();
				DataContractSerializer dcs = new DataContractSerializer(typeof(Model3D));
				XmlReader xw = XmlReader.Create(file, xws);
				Model3D readModel = (Model3D)dcs.ReadObject(xw);
				xw.Close();

				/*//restore pointer to parent RawMeasurement (not stored in file)
				for(int i = 0; i < readRawMsm.Count; i++) {
					readRawMsm[i].ParentMeasurement = readRawMsm;
				}*/

				Globals.Log(LogType.Success, i18n.str("ReadModel", readModel.Name, file));
				return readModel;
			} catch(Exception ex) {
				Globals.Log(LogType.Error, i18n.str("UnableLoadFile", file, ex.Message));
				return null;
			}
		}

		public void Save(string file) {
			try {
				XmlWriterSettings xws = new XmlWriterSettings();
				xws.Indent = true;
				xws.NewLineHandling = NewLineHandling.Entitize;
				DataContractSerializer dcs = new DataContractSerializer(typeof(Model3D));
				XmlWriter xw = XmlWriter.Create(file, xws);
				dcs.WriteObject(xw, this);
				xw.Close();
				Globals.Log(LogType.Success, i18n.str("SaveModel", Name, file));
			} catch(Exception ex) {
				Globals.Log(LogType.Error, i18n.str("UnableSaveFile", file, ex.Message));
			}
		}

		Dictionary<string, List<Vector3>> ps;

		public void ImportRawPoints(RawMeasurement rawMsm) {
			ps = new Dictionary<string, List<Vector3>>();
			for(int i = 0; i < rawMsm.Count; i++) {
				AddPoint(rawMsm[i]);
			}
			foreach(var position in ps) {
				List<Vector3> valuesForPosition = position.Value;
				double avgX = 0;
				double avgY = 0;
				double avgZ = 0;
				foreach(var p in valuesForPosition) {
					avgX += p.X / valuesForPosition.Count;
					avgY += p.Y / valuesForPosition.Count;
					avgZ += p.Z / valuesForPosition.Count;
				}
				points.Add(new Vector3(avgX, avgY, avgZ));
			}
		}

		public void AddPoint(RawMeasuredPoint p) {
			Vector3 offset = new Vector3(2.2, 6.5, 4.7 - 1.2);

			if(!float.IsNaN(p.Distance_cm) && !float.IsInfinity(p.Distance_cm) && p.Distance_cm > 7 && p.Distance_cm < 80) {
				//calculate real coordinates in cm
				double aV = (p.ServoVdeg - 90) * (-1);
				double aH = p.ServoHdeg;
				double y = Math.Sin(aV * 2 * Math.PI) * p.Distance_cm + offset.Y;
				double distH = Math.Cos(aV * 2 * Math.PI) * p.Distance_cm;
				double x = Math.Cos(aH * 2 * Math.PI) * distH + offset.X;
				double z = -Math.Sin(aH * 2 * Math.PI) * distH + offset.Z;
				Vector3 np = new Vector3(x, y, z);
				//points.Add(np);

				//add points to a list relating the angles and the calculated points. After that, we'll calculate the average of all those points for each servo position
				string posStr = aV.ToString() + aH.ToString();
				if(!ps.ContainsKey(posStr)) ps.Add(posStr, new List<Vector3>());
				ps[posStr].Add(np);
			}
		}
	}
}
