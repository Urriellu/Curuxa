﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3DScannerPC.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool PrintDebugLogs {
            get {
                return ((bool)(this["PrintDebugLogs"]));
            }
            set {
                this["PrintDebugLogs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("41535")]
        public ushort T1preload {
            get {
                return ((ushort)(this["T1preload"]));
            }
            set {
                this["T1preload"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int SendDelayThreshold {
            get {
                return ((int)(this["SendDelayThreshold"]));
            }
            set {
                this["SendDelayThreshold"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool RequireAuthentication {
            get {
                return ((bool)(this["RequireAuthentication"]));
            }
            set {
                this["RequireAuthentication"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("97")]
        public byte ScannerID {
            get {
                return ((byte)(this["ScannerID"]));
            }
            set {
                this["ScannerID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("700")]
        public ushort ServoHduty0Deg {
            get {
                return ((ushort)(this["ServoHduty0Deg"]));
            }
            set {
                this["ServoHduty0Deg"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2100")]
        public ushort ServoHduty180Deg {
            get {
                return ((ushort)(this["ServoHduty180Deg"]));
            }
            set {
                this["ServoHduty180Deg"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("700")]
        public ushort ServoVduty0Deg {
            get {
                return ((ushort)(this["ServoVduty0Deg"]));
            }
            set {
                this["ServoVduty0Deg"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2100")]
        public ushort ServoVduty180Deg {
            get {
                return ((ushort)(this["ServoVduty180Deg"]));
            }
            set {
                this["ServoVduty180Deg"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3draw")]
        public string RawMsmExtension {
            get {
                return ((string)(this["RawMsmExtension"]));
            }
            set {
                this["RawMsmExtension"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3D Scanner Raw Measurement (*.3draw)|*.3draw")]
        public string RawMsmFileFilter {
            get {
                return ((string)(this["RawMsmFileFilter"]));
            }
            set {
                this["RawMsmFileFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Setting {
            get {
                return ((string)(this["Setting"]));
            }
            set {
                this["Setting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>C:\\throw_error_test.3draw</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection OpenRawMsms {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["OpenRawMsms"]));
            }
            set {
                this["OpenRawMsms"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>C:\\this scanned model doesnt exist.3dmodel</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection OpenScanModels {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["OpenScanModels"]));
            }
            set {
                this["OpenScanModels"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3dmodel")]
        public string ModelExtension {
            get {
                return ((string)(this["ModelExtension"]));
            }
            set {
                this["ModelExtension"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3D Scanned Model (*.3dmodel)|*.3dmodel")]
        public string ModelFileFilter {
            get {
                return ((string)(this["ModelFileFilter"]));
            }
            set {
                this["ModelFileFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>C:\\throw_error_test.3draw</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection OpenModels {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["OpenModels"]));
            }
            set {
                this["OpenModels"] = value;
            }
        }
    }
}
