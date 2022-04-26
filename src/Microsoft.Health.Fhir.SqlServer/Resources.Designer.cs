﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Health.Fhir.SqlServer {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Health.Fhir.SqlServer.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Cyclic include iterate queries are not supported..
        /// </summary>
        internal static string CyclicIncludeIterateNotSupported {
            get {
                return ResourceManager.GetString("CyclicIncludeIterateNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred when fetching resource changes from SQL database..
        /// </summary>
        internal static string ExceptionOccurredWhenFetchingResourceChanges {
            get {
                return ResourceManager.GetString("ExceptionOccurredWhenFetchingResourceChanges", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The execution timeout expired from SQL Server..
        /// </summary>
        internal static string ExecutionTimeoutExpired {
            get {
                return ResourceManager.GetString("ExecutionTimeoutExpired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to import resource with duplicated resource id {0}, line: {1}.
        /// </summary>
        internal static string FailedToImportForDuplicatedResource {
            get {
                return ResourceManager.GetString("FailedToImportForDuplicatedResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation to get resource changes has been canceled..
        /// </summary>
        internal static string GetRecordsAsyncOperationIsCanceled {
            get {
                return ResourceManager.GetString("GetRecordsAsyncOperationIsCanceled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided continuation token is not valid..
        /// </summary>
        internal static string InvalidContinuationToken {
            get {
                return ResourceManager.GetString("InvalidContinuationToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid resource type &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidResourceTypeValue {
            get {
                return ResourceManager.GetString("InvalidResourceTypeValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only &apos;_type&apos; and &apos;_lastUpdated&apos; can be used together as sorting parameters (and in that order)..
        /// </summary>
        internal static string OnlyTypeAndLastUpdatedSupportedForCompoundSort {
            get {
                return ResourceManager.GetString("OnlyTypeAndLastUpdatedSupportedForCompoundSort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot carry out the SQL datastore operation because the SQL schema needs to be upgraded..
        /// </summary>
        internal static string SchemaVersionNeedsToBeUpgraded {
            get {
                return ResourceManager.GetString("SchemaVersionNeedsToBeUpgraded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current schema version should not be null..
        /// </summary>
        internal static string SchemaVersionShouldNotBeNull {
            get {
                return ResourceManager.GetString("SchemaVersionShouldNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search parameter status information should not be null..
        /// </summary>
        internal static string SearchParameterStatusShouldNotBeNull {
            get {
                return ResourceManager.GetString("SearchParameterStatusShouldNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The SearchParameter with type {0} is not supported by SQL server..
        /// </summary>
        internal static string SearchParameterTypeNotSupportedBySQLServer {
            get {
                return ResourceManager.GetString("SearchParameterTypeNotSupportedBySQLServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A SQL exception occurred when fetching resource changes from SQL database. Error number is {0}..
        /// </summary>
        internal static string SqlExceptionOccurredWhenFetchingResourceChanges {
            get {
                return ResourceManager.GetString("SqlExceptionOccurredWhenFetchingResourceChanges", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an internal server error while processing the transaction..
        /// </summary>
        internal static string TransactionProcessingException {
            get {
                return ResourceManager.GetString("TransactionProcessingException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both _type and _lastUpdated must have the same sort direction (_sort=_type,_lastUpdated or _sort=-_type,-_lastUpdated).
        /// </summary>
        internal static string TypeAndLastUpdatedMustHaveSameSortDirection {
            get {
                return ResourceManager.GetString("TypeAndLastUpdatedMustHaveSameSortDirection", resourceCulture);
            }
        }
    }
}
