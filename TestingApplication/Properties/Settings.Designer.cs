﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestingApplication.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("14")]
        public int msbuild_version {
            get {
                return ((int)(this["msbuild_version"]));
            }
            set {
                this["msbuild_version"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\BuildTools\\MSBuild\\15.0\\Bin\\M" +
            "SBuild.exe")]
        public string vs_msbuild_path {
            get {
                return ((string)(this["vs_msbuild_path"]));
            }
            set {
                this["vs_msbuild_path"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\Research\\projects\\GUI-Testing-Automation\\GUI_Testing_Automation_CL\\bin\\Debug\\G" +
            "UI_Testing_Automation.dll")]
        public string path_GUI_Testing_Automation_ref {
            get {
                return ((string)(this["path_GUI_Testing_Automation_ref"]));
            }
            set {
                this["path_GUI_Testing_Automation_ref"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\Research\\projects\\GUI-Testing-Automation\\VsGenerationTest\\Visual C#\\ProjectGen" +
            "Template\\MyTemplate.vstemplate")]
        public string path_to_vstemplate_output_proj {
            get {
                return ((string)(this["path_to_vstemplate_output_proj"]));
            }
            set {
                this["path_to_vstemplate_output_proj"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string time_mouse_hover {
            get {
                return ((string)(this["time_mouse_hover"]));
            }
            set {
                this["time_mouse_hover"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\apps\\nuget.exe")]
        public string nuget_path {
            get {
                return ((string)(this["nuget_path"]));
            }
            set {
                this["nuget_path"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.3")]
        public double divide1_per {
            get {
                return ((double)(this["divide1_per"]));
            }
            set {
                this["divide1_per"] = value;
            }
        }
    }
}