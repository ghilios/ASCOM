﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TA.NexDome.Server.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("COM1")]
        public string CommPortName {
            get {
                return ((string)(this["CommPortName"]));
            }
            set {
                this["CommPortName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("COM1:9600")]
        public string ConnectionString {
            get {
                return ((string)(this["ConnectionString"]));
            }
            set {
                this["ConnectionString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100, 100")]
        public global::System.Drawing.Point SetupDialogLocation {
            get {
                return ((global::System.Drawing.Point)(this["SetupDialogLocation"]));
            }
            set {
                this["SetupDialogLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point MainFormLocation {
            get {
                return ((global::System.Drawing.Point)(this["MainFormLocation"]));
            }
            set {
                this["MainFormLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public decimal FullRotationTimeSeconds {
            get {
                return ((decimal)(this["FullRotationTimeSeconds"]));
            }
            set {
                this["FullRotationTimeSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("120")]
        public decimal ShutterOpenCloseTimeSeconds {
            get {
                return ((decimal)(this["ShutterOpenCloseTimeSeconds"]));
            }
            set {
                this["ShutterOpenCloseTimeSeconds"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:02")]
        public global::System.TimeSpan ShutterTickTimeout {
            get {
                return ((global::System.TimeSpan)(this["ShutterTickTimeout"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SerialAssertDTR {
            get {
                return ((bool)(this["SerialAssertDTR"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SerialAssertRTS {
            get {
                return ((bool)(this["SerialAssertRTS"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("115200")]
        public uint SerialBaudRate {
            get {
                return ((uint)(this["SerialBaudRate"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("None")]
        public global::System.IO.Ports.Parity SerialParity {
            get {
                return ((global::System.IO.Ports.Parity)(this["SerialParity"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public uint SerialDataBits {
            get {
                return ((uint)(this["SerialDataBits"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("One")]
        public global::System.IO.Ports.StopBits SerialStopBits {
            get {
                return ((global::System.IO.Ports.StopBits)(this["SerialStopBits"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("RequestToSend")]
        public global::System.IO.Ports.Handshake SerialHandshake {
            get {
                return ((global::System.IO.Ports.Handshake)(this["SerialHandshake"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal HomeSensorAzimuth {
            get {
                return ((decimal)(this["HomeSensorAzimuth"]));
            }
            set {
                this["HomeSensorAzimuth"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:02")]
        public global::System.TimeSpan RotatorTickTimeout {
            get {
                return ((global::System.TimeSpan)(this["RotatorTickTimeout"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ParkAzimuth {
            get {
                return ((decimal)(this["ParkAzimuth"]));
            }
            set {
                this["ParkAzimuth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("600")]
        public int RotatorMaximumSpeed {
            get {
                return ((int)(this["RotatorMaximumSpeed"]));
            }
            set {
                this["RotatorMaximumSpeed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1500")]
        public int RotatorRampTimeMilliseconds {
            get {
                return ((int)(this["RotatorRampTimeMilliseconds"]));
            }
            set {
                this["RotatorRampTimeMilliseconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("800")]
        public int ShutterMaximumSpeed {
            get {
                return ((int)(this["ShutterMaximumSpeed"]));
            }
            set {
                this["ShutterMaximumSpeed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1500")]
        public int ShutterAccelerationRampTimeMilliseconds {
            get {
                return ((int)(this["ShutterAccelerationRampTimeMilliseconds"]));
            }
            set {
                this["ShutterAccelerationRampTimeMilliseconds"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://tigra-astronomy.com")]
        public string TigraLogoWebDestination {
            get {
                return ((string)(this["TigraLogoWebDestination"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://ascom-standards.org")]
        public string AscomLogoWebDestination {
            get {
                return ((string)(this["AscomLogoWebDestination"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://nexdome.com")]
        public string NexDomeWebDestination {
            get {
                return ((string)(this["NexDomeWebDestination"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:02:00")]
        public global::System.TimeSpan OnConnectWaitForShutterOnline {
            get {
                return ((global::System.TimeSpan)(this["OnConnectWaitForShutterOnline"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\NexDome-Firmware")]
        public string FirmwareImageDirectory {
            get {
                return ((string)(this["FirmwareImageDirectory"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TA.NexDome.FirmwareUpdater.exe")]
        public string FirmwareUploaderExecutable {
            get {
                return ((string)(this["FirmwareUploaderExecutable"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FirmwareUploadVerboseOutput {
            get {
                return ((bool)(this["FirmwareUploadVerboseOutput"]));
            }
            set {
                this["FirmwareUploadVerboseOutput"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShutterIsInstalled {
            get {
                return ((bool)(this["ShutterIsInstalled"]));
            }
            set {
                this["ShutterIsInstalled"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/nexdome/ASCOM/wiki")]
        public string OnlineHelpWebDestination {
            get {
                return ((string)(this["OnlineHelpWebDestination"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool KeepStatusWindowOnScreen {
            get {
                return ((bool)(this["KeepStatusWindowOnScreen"]));
            }
            set {
                this["KeepStatusWindowOnScreen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DowngradeWarningAcknowledged {
            get {
                return ((bool)(this["DowngradeWarningAcknowledged"]));
            }
            set {
                this["DowngradeWarningAcknowledged"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/nexdome/ASCOM/wiki")]
        public string FaqWebDestination {
            get {
                return ((string)(this["FaqWebDestination"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.facebook.com/groups/477732789267400")]
        public string FacebookWebDestination {
            get {
                return ((string)(this["FacebookWebDestination"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("11.5")]
        public decimal ShutterLowVoltsThreshold {
            get {
                return ((decimal)(this["ShutterLowVoltsThreshold"]));
            }
            set {
                this["ShutterLowVoltsThreshold"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:01:00")]
        public global::System.TimeSpan ShutterLowVoltsNotificationTimeToLive {
            get {
                return ((global::System.TimeSpan)(this["ShutterLowVoltsNotificationTimeToLive"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShutterAutoCloseOnLowBattery {
            get {
                return ((bool)(this["ShutterAutoCloseOnLowBattery"]));
            }
            set {
                this["ShutterAutoCloseOnLowBattery"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShutterWaitUntilReady {
            get {
                return ((bool)(this["ShutterWaitUntilReady"]));
            }
            set {
                this["ShutterWaitUntilReady"] = value;
            }
        }
    }
}
