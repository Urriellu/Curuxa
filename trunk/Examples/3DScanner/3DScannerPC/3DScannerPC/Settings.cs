using System.IO;
namespace _3DScannerPC.Properties {
    
    
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    internal sealed partial class Settings {
        
        public Settings() {
            // // To add event handlers for saving and changing settings, uncomment the lines below:
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Add code to handle the SettingChangingEvent event here.
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
			SaveAllSettings();
        }

		public static void SaveAllSettings() {
			Globals.Log(LogType.Information, i18n.str("SavingSettings"));

			Settings.Default.OpenRawMsms.Clear();
			foreach(var rm in RawMeasurement.KnownRMs) {
				Settings.Default.OpenRawMsms.Add(rm.Key);
			}

			Settings.Default.Save();
		}

		/// <summary>
		/// Full path to the running executable file
		/// </summary>
		public static string ExePath {
			get {
				if(_ExePath == null) _ExePath = System.Reflection.Assembly.GetEntryAssembly().Location;
				return _ExePath;
			}
		}
		private static string _ExePath;

		/// <summary>
		/// Full path to the directory that contains the running executable file. The last character is NOT a slash ('/')
		/// </summary>
		public static string ExeLocation {
			get {
				if(_ExeLocation == null) _ExeLocation = System.IO.Path.GetDirectoryName(ExePath);
				return _ExeLocation;
			}
		}
		private static string _ExeLocation;
    }
}
