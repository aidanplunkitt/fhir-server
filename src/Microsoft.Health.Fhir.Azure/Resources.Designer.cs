﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Health.Fhir.Azure {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Health.Fhir.Azure.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Anonymization configuration &apos;{0}&apos; not found. .
        /// </summary>
        internal static string AnonymizationConfigurationNotFound {
            get {
                return ResourceManager.GetString("AnonymizationConfigurationNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Anonymization configuration is too large &gt; 1MB..
        /// </summary>
        internal static string AnonymizationConfigurationTooLarge {
            get {
                return ResourceManager.GetString("AnonymizationConfigurationTooLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Anonymization container not found on the destination storage..
        /// </summary>
        internal static string AnonymizationContainerNotFound {
            get {
                return ResourceManager.GetString("AnonymizationContainerNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get access token for storage account for export..
        /// </summary>
        internal static string CannotGetAccessToken {
            get {
                return ResourceManager.GetString("CannotGetAccessToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get access token for Azure Container Registry. Please check your configuration..
        /// </summary>
        internal static string CannotGetAcrAccessToken {
            get {
                return ResourceManager.GetString("CannotGetAcrAccessToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get an authorized client to export destination..
        /// </summary>
        internal static string CannotGetAuthorizedClient {
            get {
                return ResourceManager.GetString("CannotGetAuthorizedClient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to access container registry &apos;{0}&apos;, please check your configuration..
        /// </summary>
        internal static string ContainerRegistryNotAuthorized {
            get {
                return ResourceManager.GetString("ContainerRegistryNotAuthorized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Container registry &apos;{0}&apos; not found..
        /// </summary>
        internal static string ContainerRegistryNotFound {
            get {
                return ResourceManager.GetString("ContainerRegistryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The destination client is not connected to the destination end point..
        /// </summary>
        internal static string DestinationClientNotConnected {
            get {
                return ResourceManager.GetString("DestinationClientNotConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given connection settings is not in proper format..
        /// </summary>
        internal static string InvalidConnectionSettings {
            get {
                return ResourceManager.GetString("InvalidConnectionSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given storage uri is invalid.
        /// </summary>
        internal static string InvalidStorageUri {
            get {
                return ResourceManager.GetString("InvalidStorageUri", resourceCulture);
            }
        }
    }
}
