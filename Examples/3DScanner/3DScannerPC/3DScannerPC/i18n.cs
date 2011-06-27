using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DScannerPC {
	public static class i18n {
		static Dictionary<string, Dictionary<string, string>> langs = new Dictionary<string, Dictionary<string, string>>();

		public static string CurrLang {
			get {
				if(string.IsNullOrEmpty(_currLang)) {
					//get default language
					string MyLang = System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
					if(langs.ContainsKey(MyLang)) _currLang = MyLang;
					else {
						if(langs.Count == 0 || !langs.ContainsKey("en")) throw new Exception("Wrongly programmed");
						_currLang = "en";
					}
				}
				return _currLang;
			}
			set {
				if(langs.ContainsKey(value)) _currLang = value;
			}
		}
		static string _currLang;

		static i18n() {
			LoadLanguages();
		}

		private static void LoadLanguages() {
			//English
			Dictionary<string, string> langEn = new Dictionary<string, string>();
			langEn.Add("File", "File");
			langEn.Add("Exit", "Exit");
			langEn.Add("About", "About...");
			langEn.Add("init", "Initializing application...");
			langEn.Add("Connected", "Connected");
			langEn.Add("Disconnected", "Disconnected");
			langEn.Add("Mode", "Mode");
			langEn.Add("Mode" + ScannerMode.Inactive, "Inactive");
			langEn.Add("Mode" + ScannerMode.Manual, "Manual");
			langEn.Add("Mode" + ScannerMode.Scan, "Scanning");
			langEn.Add("ManualControl", "Manual Control");
			langEn.Add("Scan", "Scan");
			langEn.Add("recManualTitle", "Latest Received Value:");
			langEn.Add("recManualValue", "Value: {0}      (0V = 0, {1}V = {2})");
			langEn.Add("recManualVoltage", "Voltage: {0}V   (3.15V=70mm, 1.65V=150mmm 0.4V=800mm, non-linear)");
			langEn.Add("recManualDistance", "Distance: {0}mm");
			langEn.Add("Connection", "Connection");
			langEn.Add("UpdateList", "Update List");
			langEn.Add("bauds", "bauds");
			langEn.Add("Connect", "Connect");
			langEn.Add("Disconnect", "Disconnect");
			langEn.Add("Edit", "Edit");
			langEn.Add("View", "View");
			langEn.Add("Language", "Language");
			langEn.Add("Help", "Help");
			langEn.Add("MenuModeInactiveReadyScan", "Inactive: Ready to Scan");
			langEn.Add("ManualControlHtitle", "Horizontal movement (duty cycle and degrees):");
			langEn.Add("ManualControlVtitle", "Vertical:");
			langEn.Add("DegreesN", "Degrees: {0}º");
			langEn.Add("ConnectedNotAuth", "Connected - Not Authenticated");
			langEn.Add("SaveRawMsm", "Saved raw measurement \"{0}\" in {1}");
			langEn.Add("UnableSaveFile", "Unable to save file \"{0}\". {1}");
			langEn.Add("ReadRawMsm", "Raw measurement \"{0}\" read from {1}");
			langEn.Add("UnableLoadFile", "Unable to load file \"{0}\". {1}");
			langEn.Add("Open", "Open");
			langEn.Add("Remove", "Remove");
			langEn.Add("SavingSettings", "Saving settings");
			langEn.Add("Setup", "Setup");
			langEn.Add("AvgEvery", "Average every");
			langEn.Add("points", "points");
			langEn.Add("Activate", "Activate");
			langEn.Add("Deactivate", "Deactivate");
			langEn.Add("Auth", "Auth");
			langEn.Add("ClosestObject", "Closest Object");
			langEn.Add("MeasuredPoints", "Measured Points");
			langEn.Add("StartNewSeries", "Start New Series");
			langEn.Add("SaveInstantSeries", "Save Instant Series");
			langEn.Add("SaveAvgSeries", "Save Average Series");
			langEn.Add("RawMsms", "Raw Measurements");
			langEn.Add("Name", "Name");
			langEn.Add("Date", "Date");
			langEn.Add("BaseLocation", "Base Location");
			langEn.Add("BaseRotation", "Base Rotation");
			langEn.Add("Tools", "Tools");
			langEn.Add("Settings", "Settings");
			langEn.Add("ReqAuth", "Require Authentication");
			langEn.Add("PrintDebugLogs", "Print Debug Logs");
			langEn.Add("ScannerID", "Scanner ID");
			langEn.Add("ManualCtrlChangesEvery", "On manual control, update every (sec)");
			langEn.Add("T1preload", "Timer 1 preload");
			langEn.Add("Duty0H", "Duty for 0º, horizontal servo");
			langEn.Add("Duty180H", "Duty for 180º, horizontal servo");
			langEn.Add("Duty0V", "Duty for 0º, vertical servo");
			langEn.Add("Duty180V", "Duty for 180º, vertical servo");
			langEn.Add("Ok", "Ok");
			langEn.Add("OK", "OK");
			langEn.Add("NewAutoMsm", "New Automatic Measurement");
			langEn.Add("AutoScanResolutionSummaryH", "Will measure {0} points between {1}º and {2}º for each row, {3} times each point");
			langEn.Add("AutoScanResolutionSummaryV", "Will measure {0} rows between {1}º and {2}º");
			langEn.Add("ElapsedTime", "Elapsed Time: ");
			langEn.Add("RemainingTime", "Remaining Time: ");
			langEn.Add("ReceivedXpointsOfY", "Received {0} points out of {1}");
			langEn.Add("StartNewAutoMsm", "New Automatic Measurement");
			langEn.Add("ForceStop", "Force Stop");
			langEn.Add("SaveMsm", "Automatic measurement scan has just finished. We'll save the data now");
			langEn.Add("Default", "Default");
			langEn.Add("and", "and");
			langEn.Add("TakeMeasuresBetween", "Take measures between");
			langEn.Add("WithIntervalsOf", "with intervals of");
			langEn.Add("MsBetweenMeas", "milliseconds between measures");
			langEn.Add("MeasPerPoint", "measures per point");
			langEn.Add("Results", "Results");
			langEn.Add("HorizontalResolution", "Horizontal Resolution");
			langEn.Add("VerticalResolution", "Vertical Resolution");
			langEn.Add("StatusBar", "Status Bar");
			langEn.Add("Log", "Log");
			langEn.Add("Show", "Show");
			langEn.Add("Hide", "Hide");
			langEn.Add("ClearAll", "Clear All");
			langEn.Add("ShowHideDebug", "Show/Hide Debug");
			langEn.Add("SaveLogAs", "Save log as...");
			langEn.Add("ReadModel", "3D Model \"{0}\" read from {1}");
			langEn.Add("SaveModel", "Saved 3D Model \"{0}\" in {1}");
			langEn.Add("Models", "Models");
			langEn.Add("NewModel", "New Model");
			langEn.Add("ImportPoints", "Import Points");
			langEn.Add("Export", "Export");
			langEn.Add("tabbed", "tabbed");
			langEn.Add("comma-separated", "comma-separated");
			langEn.Add("Save", "Save");
			langEn.Add("Cancel", "Cancel");
			//langEn.Add("", "");
			langs.Add("en", langEn);


			//Spanish
			Dictionary<string, string> langEs = new Dictionary<string, string>();
			langEs.Add("File", "Archivo");
			langEs.Add("Exit", "Salir");
			langEs.Add("About", "Acerca de...");
			langEs.Add("init", "Iniciando aplicación...");
			langEs.Add("Connected", "Conectado");
			langEs.Add("Disconnected", "Desconectado");
			langEs.Add("Mode", "Modo");
			langEs.Add("Mode" + ScannerMode.Inactive, "Inactivo");
			langEs.Add("Mode" + ScannerMode.Manual, "Manual");
			langEs.Add("Mode" + ScannerMode.Scan, "Escaneando");
			langEs.Add("ManualControl", "Control Manual");
			langEs.Add("Scan", "Escanear");
			langEs.Add("recManualTitle", "Último Valor Recibido:");
			langEs.Add("recManualValue", "Valor: {0}      (0V = 0, {1}V = {2})");
			langEs.Add("recManualVoltage", "Tensión: {0}V   (3.15V=70mm, 1.65V=150mmm 0.4V=800mm, non-linear)");
			langEs.Add("recManualDistance", "Distancia: {0}mm");
			langEs.Add("Connection", "Connexión");
			langEs.Add("UpdateList", "Actualizar Lista");
			langEs.Add("bauds", "baudios");
			langEs.Add("Connect", "Conectar");
			langEs.Add("Disconnect", "Desconectar");
			langEs.Add("Edit", "Editar");
			langEs.Add("View", "Ver");
			langEs.Add("Language", "Idioma");
			langEs.Add("Help", "Ayuda");
			langEs.Add("MenuModeInactiveReadyScan", "Inactivo: listo para escanear");
			langEs.Add("ManualControlHtitle", "Movimiento horizontal (ciclo duty y grados):");
			langEs.Add("ManualControlVtitle", "Vertical:");
			langEs.Add("DegreesN", "Grados: {0}º");
			langEs.Add("ConnectedNotAuth", "Conectado - No Autenticado");
			langEs.Add("SaveRawMsm", "Medición en bruto \"{0}\" guardada en {1}");
			langEs.Add("UnableSaveFile", "Imposible guardar \"{0}\". {1}");
			langEs.Add("ReadRawMsm", "Medición en bruto \"{0}\" leída desde {1}");
			langEs.Add("UnableLoadFile", "Imposible cargar archivo \"{0}\". {1}");
			langEs.Add("Open", "Abrir");
			langEs.Add("Remove", "Eliminar");
			langEs.Add("SavingSettings", "Guardando opciones");
			langEs.Add("Setup", "Configuración");
			langEs.Add("AvgEvery", "Media cada");
			langEs.Add("points", "puntos");
			langEs.Add("Activate", "Activar");
			langEs.Add("Deactivate", "Desactivar");
			langEs.Add("Auth", "Autent.");
			langEs.Add("ClosestObject", "Objeto Más Próximo");
			langEs.Add("MeasuredPoints", "Puntos Medidos");
			langEs.Add("StartNewSeries", "Iniciar Nueva Serie");
			langEs.Add("SaveInstantSeries", "Guardar Serie Instantánea");
			langEs.Add("SaveAvgSeries", "Guardar Serie Media");
			langEs.Add("RawMsms", "Mediciones en Bruto");
			langEs.Add("Name", "Nombre");
			langEs.Add("Date", "Fecha");
			langEs.Add("BaseLocation", "Posición de Base");
			langEs.Add("BaseRotation", "Rotación de Base");
			langEs.Add("Tools", "Herramientas");
			langEs.Add("Settings", "Opciones");
			langEs.Add("ReqAuth", "Requerir Autenticación");
			langEs.Add("PrintDebugLogs", "Mostrar Info Depuración");
			langEs.Add("ScannerID", "ID Escáner");
			langEs.Add("ManualCtrlChangesEvery", "En control manual, actualizar cada (seg)");
			langEs.Add("T1preload", "Precarga Timer 1");
			langEs.Add("Duty0H", "Duty para 0º, servo horizontal");
			langEs.Add("Duty180H", "Duty para 180º, servo horizontal");
			langEs.Add("Duty0V", "Duty para 0º, servo vertical");
			langEs.Add("Duty180V", "Duty para 180º, servo vertical");
			langEs.Add("Ok", "Ok");
			langEs.Add("OK", "OK");
			langEs.Add("NewAutoMsm", "Nueva Medición Automática");
			langEs.Add("AutoScanResolutionSummaryH", "Se tomarán {0} muestras entre {1}º y {2}º para cada fila, {3} veces cada posición");
			langEs.Add("AutoScanResolutionSummaryV", "Se tomarán {0} filas entre {1}º y {2}º");
			langEs.Add("ElapsedTime", "Transcurrido: ");
			langEs.Add("RemainingTime", "Restante: ");
			langEs.Add("ReceivedXpointsOfY", "Recibidos {0} puntos de {1}");
			langEs.Add("StartNewAutoMsm", "Iniciar Medición Automática");
			langEs.Add("ForceStop", "Forzar Parada");
			langEs.Add("SaveMsm", "Medición automática terminada. Ahora guardaremos los datos");
			langEs.Add("Default", "Por defecto");
			langEs.Add("and", "y");
			langEs.Add("TakeMeasuresBetween", "Tomar medidas entre");
			langEs.Add("WithIntervalsOf", "a intervalos de");
			langEs.Add("MsBetweenMeas", "milisegundos entre medidas");
			langEs.Add("MeasPerPoint", "muestras por punto");
			langEs.Add("Results", "Resultados");
			langEs.Add("HorizontalResolution", "Resolución Horizontal");
			langEs.Add("VerticalResolution", "Resolución Vertical");
			langEs.Add("StatusBar", "Barra de Estado");
			langEs.Add("Log", "Log");
			langEs.Add("Show", "Mostrar");
			langEs.Add("Hide", "Ocultar");
			langEs.Add("ClearAll", "Limpiar Todo");
			langEs.Add("ShowHideDebug", "Mostrar/Ocultar Depuración");
			langEs.Add("SaveLogAs", "Guardar log como...");
			langEs.Add("ReadModel", "Modelo 3D \"{0}\" leído de {1}");
			langEs.Add("SaveModel", "Guardado Modelo 3D \"{0}\" en {1}");
			langEs.Add("Models", "Modelos");
			langEs.Add("NewModel", "Nuevo Modelo");
			langEs.Add("ImportPoints", "Importar Puntos");
			langEs.Add("Export", "Exportar");
			langEs.Add("tabbed", "tabulado");
			langEs.Add("comma-separated", "sep. comas");
			langEs.Add("Save", "Guardar");
			langEs.Add("Cancel", "Cancelar");
			langs.Add("es", langEs);


			//French
			Dictionary<string, string> langFr = new Dictionary<string, string>();
			langFr.Add("File", "Fichier");
			langFr.Add("Exit", "Sortir");
			langFr.Add("About", "À propos de...");
			langFr.Add("init", "Debut du programme...");
			langFr.Add("Connected", "Connecté");
			langFr.Add("Disconnected", "Déconnecté");
			langFr.Add("Mode", "Mode");
			langFr.Add("Mode" + ScannerMode.Inactive, "Inactif");
			langFr.Add("Mode" + ScannerMode.Manual, "Manuel");
			langFr.Add("Mode" + ScannerMode.Scan, "Numérisation");
			langFr.Add("ManualControl", "Contrôle Manuel");
			langFr.Add("Scan", "Scan");
			langFr.Add("recManualTitle", "Dernière valeur reçu:");
			langFr.Add("recManualValue", "Valeur: {0}      (0V = 0, {1}V = {2})");
			langFr.Add("recManualVoltage", "Tension: {0}V   (3.15V=70mm, 1.65V=150mmm 0.4V=800mm, pas lineal)");
			langFr.Add("recManualDistance", "Distance: {0}mm");
			langFr.Add("Connection", "Connexion");
			langFr.Add("UpdateList", "Mise à jour");
			langFr.Add("bauds", "bauds");
			langFr.Add("Connect", "Connecter");
			langFr.Add("Disconnect", "Déconnecter");
			langFr.Add("Edit", "Modifier");
			langFr.Add("View", "Affichage");
			langFr.Add("Language", "Langage");
			langFr.Add("Help", "Aide");
			langFr.Add("MenuModeInactiveReadyScan", "Inactif: disponible pour scan");
			langFr.Add("ManualControlHtitle", "Mouvement horizontal (duty et degrés):");
			langFr.Add("ManualControlVtitle", "Vertical:");
			langFr.Add("DegreesN", "Degrés: {0}º");
			langFr.Add("ConnectedNotAuth", "Conecté - Non authentifié");
			langFr.Add("SaveRawMsm", "Mesure brut \"{0}\" sauvé dans {1}");
			langFr.Add("UnableSaveFile", "Impossible d'enregistrer \"{0}\". {1}");
			langFr.Add("ReadRawMsm", "Mesure brut \"{0}\" lire à partir de {1}");
			langFr.Add("UnableLoadFile", "Impossible de charger le fichier \"{0}\". {1}");
			langFr.Add("Open", "Ouvrir");
			langFr.Add("Remove", "Supprimer");
			langFr.Add("SavingSettings", "Enregistrement d'options");
			langFr.Add("Setup", "Options");
			langFr.Add("AvgEvery", "Moyenne chaque");
			langFr.Add("points", "points");
			langFr.Add("Activate", "Activer");
			langFr.Add("Deactivate", "Désactiver");
			langFr.Add("Auth", "Auth");
			langFr.Add("ClosestObject", "Objet Plus Proche");
			langFr.Add("MeasuredPoints", "Points Moyennes");
			langFr.Add("StartNewSeries", "Démarrer Nouvelle Série");
			langFr.Add("SaveInstantSeries", "Enregistrer Série Instantanée");
			langFr.Add("SaveAvgSeries", "Enregistrer Série Moyenne");
			langFr.Add("RawMsms", "Mesures Brut");
			langFr.Add("Name", "Nom");
			langFr.Add("Date", "Date");
			langs.Add("fr", langFr);
		}

		public static string str(string id, params object[] p) {
			if(langs[CurrLang].ContainsKey(id)) return string.Format(langs[CurrLang][id], p);
			else if(langs["en"].ContainsKey(id)) return string.Format(langs["en"][id], p);
			else throw new Exception(string.Format("Language string not found. Lang: {0}, ID: {1}", CurrLang, id));
		}
	}
}
