﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DowntownBoiseAssociation.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection RecentLegalEntities {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["RecentLegalEntities"]));
            }
            set {
                this["RecentLegalEntities"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection RecentTenants {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["RecentTenants"]));
            }
            set {
                this["RecentTenants"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://CH-DBWEB:80/ReportServer/ReportService2005.asmx")]
        public string DowntownBoiseAssociation_Reports_ReportServer_ReportingService2005 {
            get {
                return ((string)(this["DowntownBoiseAssociation_Reports_ReportServer_ReportingService2005"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ch-dbweb;Initial Catalog=ReportServer;Persist Security Info=True;User" +
            " ID=DBAProduction;Password=COB2DBAData1")]
        public string ReportServerConnectionString {
            get {
                return ((string)(this["ReportServerConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ch-dbweb;Initial Catalog=DBAProduction_Test;Persist Security Info=Tru" +
            "e;User ID=DBAProduction;Password=COB2DBAData1")]
        public string DBADevConnectionString {
            get {
                return ((string)(this["DBADevConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ch-dbweb;Initial Catalog=DBAProduction;Persist Security Info=True;Use" +
            "r ID=DBAProduction;Password=COB2DBAData1")]
        public string DBAProductionConnectionString {
            get {
                return ((string)(this["DBAProductionConnectionString"]));
            }
        }
    }
}
