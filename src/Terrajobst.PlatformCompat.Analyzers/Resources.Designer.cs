﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Terrajobst.PlatformCompat.Analyzers {
    using System;
    using System.Reflection;
    
    
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Terrajobst.PlatformCompat.Analyzers.Resources", typeof(Resources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to {0} isn&apos;t supported on {1}.
        /// </summary>
        internal static string ExceptionAnalyzerMessageFormat {
            get {
                return ResourceManager.GetString("ExceptionAnalyzerMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to API not supported on all platforms.
        /// </summary>
        internal static string ExceptionAnalyzerTitle {
            get {
                return ResourceManager.GetString("ExceptionAnalyzerTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DocId,Namespace,Type,Member,linux,osx,win
        ///&quot;M:System.Security.AccessControl.RegistryAccessRule.#ctor(System.Security.Principal.IdentityReference,System.Security.AccessControl.RegistryRights,System.Security.AccessControl.AccessControlType)&quot;,System.Security.AccessControl,RegistryAccessRule,&quot;.ctor(IdentityReference, RegistryRights, AccessControlType)&quot;,X,X,
        ///&quot;M:System.Security.AccessControl.RegistryAccessRule.#ctor(System.String,System.Security.AccessControl.RegistryRights,System.Security.AccessControl.AccessCo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Exceptions {
            get {
                return ResourceManager.GetString("Exceptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DocId,Namespace,Type,Member
        ///M:System.AppContext.GetData(System.String),System,AppContext,GetData(String)
        ///P:System.AppContext.TargetFrameworkName,System,AppContext,TargetFrameworkName
        ///T:System.StringNormalizationExtensions,System,StringNormalizationExtensions,
        ///T:System.Data.Common.DbColumn,System.Data.Common,DbColumn,
        ///T:System.Data.Common.DbDataReaderExtensions,System.Data.Common,DbDataReaderExtensions,
        ///T:System.Data.Common.IDbColumnSchemaGenerator,System.Data.Common,IDbColumnSchemaGenerator,
        ///T:System [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Net461 {
            get {
                return ResourceManager.GetString("Net461", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} isn&apos;t available in .NET Framework 4.6.1.
        /// </summary>
        internal static string Net461AnalyzerMessageFormat {
            get {
                return ResourceManager.GetString("Net461AnalyzerMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to API not available in .NET Framework 4.6.1.
        /// </summary>
        internal static string Net461AnalyzerTitle {
            get {
                return ResourceManager.GetString("Net461AnalyzerTitle", resourceCulture);
            }
        }
    }
}
