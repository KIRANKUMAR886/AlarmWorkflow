﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlarmWorkflow.Windows.UIContracts.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AlarmWorkflow.Windows.UIContracts.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Die Daten wurden in die Zwischenablage kopiert..
        /// </summary>
        internal static string CopyToClipboardDoneMessage {
            get {
                return ResourceManager.GetString("CopyToClipboardDoneMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Konnte nicht auf die Zwischenablage zugreifen. Möglicherweise greift aktuell ein anderes Programm darauf zu. Bitte versuchen Sie es in ein paar Sekunden erneut..
        /// </summary>
        internal static string CopyToClipboardFailedMessage {
            get {
                return ResourceManager.GetString("CopyToClipboardFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination location is unknown! Cannot download route plan!.
        /// </summary>
        internal static string DestinationLocationIsUnknown {
            get {
                return ResourceManager.GetString("DestinationLocationIsUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading route plan to destination &apos;{0}&apos;....
        /// </summary>
        internal static string DownloadRoutePlanBegin {
            get {
                return ResourceManager.GetString("DownloadRoutePlanBegin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while trying to download the route plan! The image will not be available..
        /// </summary>
        internal static string DownloadRoutePlanError {
            get {
                return ResourceManager.GetString("DownloadRoutePlanError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The download of the route plan did not succeed. Please check the log for information!.
        /// </summary>
        internal static string DownloadRoutePlanFailed {
            get {
                return ResourceManager.GetString("DownloadRoutePlanFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloaded route plan in &apos;{0}&apos; milliseconds..
        /// </summary>
        internal static string DownloadRoutePlanSuccess {
            get {
                return ResourceManager.GetString("DownloadRoutePlanSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot download route plan because the location information for this fire department is not meaningful enough: &apos;{0}&apos;. Please fill in the correct address!.
        /// </summary>
        internal static string RoutePlanningSourceLocationNotMeaningful {
            get {
                return ResourceManager.GetString("RoutePlanningSourceLocationNotMeaningful", resourceCulture);
            }
        }
    }
}