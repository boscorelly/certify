﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Certify.Locales {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class CoreSR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CoreSR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Certify.Locales.CoreSR", typeof(CoreSR).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate Request was aborted by PS script.
        /// </summary>
        public static string CertificateRequestWasAbortedByPSScript {
            get {
                return ResourceManager.GetString("CertificateRequestWasAbortedByPSScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performing Automated Certificate Binding.
        /// </summary>
        public static string CertifyManager_AutoBinding {
            get {
                return ResourceManager.GetString("CertifyManager_AutoBinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Automated configuration checks failed. Authorizations will not be able to complete.
        ///Check you have http bindings for your site and ensure you can browse to http://{0}/.well-known/acme-challenge/configcheck before proceeding..
        /// </summary>
        public static string CertifyManager_AutomateConfigurationCheckFailed_HTTP {
            get {
                return ResourceManager.GetString("CertifyManager_AutomateConfigurationCheckFailed_HTTP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Automated configuration checks failed. Authorizations will not be able to complete.
        ///Check you have https SNI bindings for your site
        ///(ex: &apos;0123456789ABCDEF0123456789ABCDEF.0123456789ABCDEF0123456789ABCDEF.acme.invalid&apos;) before proceeding..
        /// </summary>
        public static string CertifyManager_AutomateConfigurationCheckFailed_SNI {
            get {
                return ResourceManager.GetString("CertifyManager_AutomateConfigurationCheckFailed_SNI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate created ready for manual binding: {0}.
        /// </summary>
        public static string CertifyManager_CertificateCreatedForBinding {
            get {
                return ResourceManager.GetString("CertifyManager_CertificateCreatedForBinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate installed and SSL bindings updated for {0}.
        /// </summary>
        public static string CertifyManager_CertificateInstalledAndBindingUpdated {
            get {
                return ResourceManager.GetString("CertifyManager_CertificateInstalledAndBindingUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred installing the certificate. Certificate file may not be valid: {0}.
        /// </summary>
        public static string CertifyManager_CertificateInstallFailed {
            get {
                return ResourceManager.GetString("CertifyManager_CertificateInstallFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Completed Certificate Request..
        /// </summary>
        public static string CertifyManager_CompleteRequest {
            get {
                return ResourceManager.GetString("CertifyManager_CompleteRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Completed certificate request and automated bindings update (IIS).
        /// </summary>
        public static string CertifyManager_CompleteRequestAndUpdateBinding {
            get {
                return ResourceManager.GetString("CertifyManager_CompleteRequestAndUpdateBinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Domain validation completed: {0}.
        /// </summary>
        public static string CertifyManager_DomainValidationCompleted {
            get {
                return ResourceManager.GetString("CertifyManager_DomainValidationCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Domain validation failed: {0} 
        ///{1}.
        /// </summary>
        public static string CertifyManager_DomainValidationFailed {
            get {
                return ResourceManager.GetString("CertifyManager_DomainValidationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Domain already has current authorization, skipping verification: {0}.
        /// </summary>
        public static string CertifyManager_DomainValidationSkipVerifed {
            get {
                return ResourceManager.GetString("CertifyManager_DomainValidationSkipVerifed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed prerequisite configuration checks ({0}).
        /// </summary>
        public static string CertifyManager_FailedPrerequisiteCheck {
            get {
                return ResourceManager.GetString("CertifyManager_FailedPrerequisiteCheck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Let&apos;s Encrypt service did not issue a valid certificate in the time allowed. {0}.
        /// </summary>
        public static string CertifyManager_LetsEncryptServiceTimeout {
            get {
                return ResourceManager.GetString("CertifyManager_LetsEncryptServiceTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performing Challenge Response via IIS: {0} .
        /// </summary>
        public static string CertifyManager_PerformingChallengeResponseViaIISX0 {
            get {
                return ResourceManager.GetString("CertifyManager_PerformingChallengeResponseViaIISX0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performing Config Tests.
        /// </summary>
        public static string CertifyManager_PerformingConfigTests {
            get {
                return ResourceManager.GetString("CertifyManager_PerformingConfigTests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registering Domain Identifiers.
        /// </summary>
        public static string CertifyManager_RegisterDomainIdentity {
            get {
                return ResourceManager.GetString("CertifyManager_RegisterDomainIdentity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registering and Validating {0} .
        /// </summary>
        public static string CertifyManager_RegisteringAndValidatingX0 {
            get {
                return ResourceManager.GetString("CertifyManager_RegisteringAndValidatingX0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Previous renewals failed: {0}. Renewal will be attempted within 48hrs..
        /// </summary>
        public static string CertifyManager_RenewalOnHold {
            get {
                return ResourceManager.GetString("CertifyManager_RenewalOnHold", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Requesting Validation from Let&apos;s Encrypt: {0}.
        /// </summary>
        public static string CertifyManager_ReqestValidationFromCertificateAuthority {
            get {
                return ResourceManager.GetString("CertifyManager_ReqestValidationFromLetsEncrypt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Requesting Certificate via Lets Encrypt.
        /// </summary>
        public static string CertifyManager_RequestCertificate {
            get {
                return ResourceManager.GetString("CertifyManager_RequestCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Request failed - {1} {2}.
        /// </summary>
        public static string CertifyManager_RequestFailed {
            get {
                return ResourceManager.GetString("CertifyManager_RequestFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Site stopped (or not present), renewal skipped as domain validation cannot be performed. .
        /// </summary>
        public static string CertifyManager_SiteStopped {
            get {
                return ResourceManager.GetString("CertifyManager_SiteStopped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skipping Renewal, existing certificate still OK. .
        /// </summary>
        public static string CertifyManager_SkipRenewalOk {
            get {
                return ResourceManager.GetString("CertifyManager_SkipRenewalOk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Validation of the required challenges did not complete successfully. {0}.
        /// </summary>
        public static string CertifyManager_ValidationForChallengeNotSuccess {
            get {
                return ResourceManager.GetString("CertifyManager_ValidationForChallengeNotSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finish.
        /// </summary>
        public static string Finish {
            get {
                return ResourceManager.GetString("Finish", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Local IIS, SSL Certificate via Let&apos;s Encrypt.
        /// </summary>
        public static string ManagedCertificateType_LocalIIS {
            get {
                return ResourceManager.GetString("ManagedCertificateType_LocalIIS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manual SSL Certificate via Let&apos;s Encrypt.
        /// </summary>
        public static string ManagedCertificateType_Manual {
            get {
                return ResourceManager.GetString("ManagedCertificateType_Manual", resourceCulture);
            }
        }
    }
}
