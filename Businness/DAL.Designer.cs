﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Businness {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class DAL : global::System.Configuration.ApplicationSettingsBase {
        
        private static DAL defaultInstance = ((DAL)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DAL())));
        
        public static DAL Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("server=.  ;database=TurStok;MultipleActiveResultSets=true;Trusted_connection=yes;" +
            "")]
        public string localcon {
            get {
                return ((string)(this["localcon"]));
            }
        }
    }
}
