﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Krypton.Toolkit.Suite.Extended.Settings.Settings.Palette_Explorer.General {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
    internal sealed partial class PaletteExplorerBooleanSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static PaletteExplorerBooleanSettings defaultInstance = ((PaletteExplorerBooleanSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new PaletteExplorerBooleanSettings())));
        
        public static PaletteExplorerBooleanSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowAdvancedColourToolTips {
            get {
                return ((bool)(this["ShowAdvancedColourToolTips"]));
            }
            set {
                this["ShowAdvancedColourToolTips"] = value;
            }
        }
    }
}
