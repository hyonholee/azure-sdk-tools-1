﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Management.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.WindowsAzure.Management.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Windows Azure Powershell\.
        /// </summary>
        internal static string AzureDirectory {
            get {
                return ResourceManager.GetString("AzureDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windows Azure Powershell.
        /// </summary>
        internal static string AzureDirectoryName {
            get {
                return ResourceManager.GetString("AzureDirectoryName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Azure service management error
        ///{0}.
        /// </summary>
        internal static string AzureServiceManagementException_WrapExistingError_DetailedErrorFormat {
            get {
                return ResourceManager.GetString("AzureServiceManagementException_WrapExistingError_DetailedErrorFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot locate deploymentSettings.json in parent folders.
        /// </summary>
        internal static string CannotFindServiceRoot {
            get {
                return ResourceManager.GetString("CannotFindServiceRoot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No certificate was found in the certificate store with thumbprint {0}.
        /// </summary>
        internal static string CertificateNotFoundInStore {
            get {
                return ResourceManager.GetString("CertificateNotFoundInStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Communication could not be established. This could be due to an invalid subscription ID. Note that subscription IDs are case sensitive..
        /// </summary>
        internal static string CommunicationCouldNotBeEstablished {
            get {
                return ResourceManager.GetString("CommunicationCouldNotBeEstablished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to config.json.
        /// </summary>
        internal static string ConfigurationFileName {
            get {
                return ResourceManager.GetString("ConfigurationFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting: {0} as the default and current subscription. To view other subscriptions use Get-AzureSubscription.
        /// </summary>
        internal static string DefaultAndCurrentSubscription {
            get {
                return ResourceManager.GetString("DefaultAndCurrentSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find publish settings. Please run Import-AzurePublishSettingsFile..
        /// </summary>
        internal static string GlobalComponents_Load_PublishSettingsNotFound {
            get {
                return ResourceManager.GetString("GlobalComponents_Load_PublishSettingsNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Illegal characters in path..
        /// </summary>
        internal static string IllegalPath {
            get {
                return ResourceManager.GetString("IllegalPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid certificate format. Publish settings may be corrupted. Use Get-AzurePublishSettingsFile to download updated settings.
        /// </summary>
        internal static string InvalidCertificate {
            get {
                return ResourceManager.GetString("InvalidCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid certificate format..
        /// </summary>
        internal static string InvalidCertificateSingle {
            get {
                return ResourceManager.GetString("InvalidCertificateSingle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Call Set-AzureSubscription and Select-AzureSubscription first..
        /// </summary>
        internal static string InvalidCurrentSubscription {
            get {
                return ResourceManager.GetString("InvalidCurrentSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You MUST specify a subscription Id. Call Set-AzureSubscription and Select-AzureSubscription first..
        /// </summary>
        internal static string InvalidCurrentSubscriptionId {
            get {
                return ResourceManager.GetString("InvalidCurrentSubscriptionId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You MUST specify a certificate. Call Set-AzureSubscription and Select-AzureSubscription first..
        /// </summary>
        internal static string InvalidCurrentSuscriptionCertificate {
            get {
                return ResourceManager.GetString("InvalidCurrentSuscriptionCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No default subscription has been designated. Use Set-AzureSubscription &lt;subscriptionName&gt; -DefaultSubscription to set the default subscription..
        /// </summary>
        internal static string InvalidDefaultSubscription {
            get {
                return ResourceManager.GetString("InvalidDefaultSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; is an invalid DNS name for {1}.
        /// </summary>
        internal static string InvalidDnsName {
            get {
                return ResourceManager.GetString("InvalidDnsName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid service endpoint..
        /// </summary>
        internal static string InvalidEndpoint {
            get {
                return ResourceManager.GetString("InvalidEndpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided file in {0} must be have {1} extension.
        /// </summary>
        internal static string InvalidFileExtension {
            get {
                return ResourceManager.GetString("InvalidFileExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be null. Parameter name: &apos;{0}&apos;.
        /// </summary>
        internal static string InvalidNullArgument {
            get {
                return ResourceManager.GetString("InvalidNullArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is invalid or empty.
        /// </summary>
        internal static string InvalidOrEmptyArgumentMessage {
            get {
                return ResourceManager.GetString("InvalidOrEmptyArgumentMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided publish settings file {0} has invalid content. Please get valid by running cmdlet Get-AzurePublishSettingsFile.
        /// </summary>
        internal static string InvalidPublishSettingsSchema {
            get {
                return ResourceManager.GetString("InvalidPublishSettingsSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No subscription is currently selected. Use Select-Subscription to activate a subscription..
        /// </summary>
        internal static string InvalidSelectedSubscription {
            get {
                return ResourceManager.GetString("InvalidSelectedSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must provide valid value for {0}.
        /// </summary>
        internal static string InvalidServiceSettingElement {
            get {
                return ResourceManager.GetString("InvalidServiceSettingElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;The subscription named &apos;{0}&apos; cannot be found. Use Set-AzureSubscription to initialize the subscription data.&quot;.
        /// </summary>
        internal static string InvalidSubscription {
            get {
                return ResourceManager.GetString("InvalidSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must specify a non-null subscription name..
        /// </summary>
        internal static string InvalidSubscriptionName {
            get {
                return ResourceManager.GetString("InvalidSubscriptionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided subscriptions file {0} has invalid content..
        /// </summary>
        internal static string InvalidSubscriptionsDataSchema {
            get {
                return ResourceManager.GetString("InvalidSubscriptionsDataSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to managementCertificate.pem.
        /// </summary>
        internal static string ManagementCertificateFileName {
            get {
                return ResourceManager.GetString("ManagementCertificateFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please connect to internet before executing this cmdlet.
        /// </summary>
        internal static string NoInternetConnection {
            get {
                return ResourceManager.GetString("NoInternetConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path {0} doesn&apos;t exist..
        /// </summary>
        internal static string PathDoesNotExist {
            get {
                return ResourceManager.GetString("PathDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path for {0} doesn&apos;t exist in {1}..
        /// </summary>
        internal static string PathDoesNotExistForElement {
            get {
                return ResourceManager.GetString("PathDoesNotExistForElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to publish settings.
        /// </summary>
        internal static string PublishSettings {
            get {
                return ResourceManager.GetString("PublishSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .PublishSettings.
        /// </summary>
        internal static string PublishSettingsFileExtention {
            get {
                return ResourceManager.GetString("PublishSettingsFileExtention", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to publishSettings.xml.
        /// </summary>
        internal static string PublishSettingsFileName {
            get {
                return ResourceManager.GetString("PublishSettingsFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://windows.azure.com/download/publishprofile.aspx?client=nodejs&amp;lang=en.
        /// </summary>
        internal static string PublishSettingsUrl {
            get {
                return ResourceManager.GetString("PublishSettingsUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current subscription is being removed. Use Select-Subscription &lt;subscriptionName&gt; to select a new current subscription..
        /// </summary>
        internal static string RemoveCurrentSubscription {
            get {
                return ResourceManager.GetString("RemoveCurrentSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current subscription is being removed. Use Select-Subscription &lt;subscriptionName&gt; to select a new current subscription..
        /// </summary>
        internal static string RemoveDefaultSubscription {
            get {
                return ResourceManager.GetString("RemoveDefaultSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided service name {0} already exists, please pick another name.
        /// </summary>
        internal static string ServiceNameExists {
            get {
                return ResourceManager.GetString("ServiceNameExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to service settings.
        /// </summary>
        internal static string ServiceSettings {
            get {
                return ResourceManager.GetString("ServiceSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The storage account name &apos;{0}&apos; is invalid.  Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only..
        /// </summary>
        internal static string ServiceSettings_ValidateStorageAccountName_InvalidName {
            get {
                return ResourceManager.GetString("ServiceSettings_ValidateStorageAccountName_InvalidName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to deploymentSettings.json.
        /// </summary>
        internal static string SettingsFileName {
            get {
                return ResourceManager.GetString("SettingsFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DefaultSubscriptionData.xml.
        /// </summary>
        internal static string SubscriptionDataFileName {
            get {
                return ResourceManager.GetString("SubscriptionDataFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided subscription name doesn&apos;t exist in the imported publish profile. If subscriptions have changed for the hosted service, retrieve an updated profile by using Get-AzurePublishSettingsFile then import the profile using Import-AzurePublishSettingsFile.
        /// </summary>
        internal static string SubscriptionIdNotFoundMessage {
            get {
                return ResourceManager.GetString("SubscriptionIdNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updated settings for subscription &apos;{0}&apos;. Current subscription is &apos;{1}&apos;..
        /// </summary>
        internal static string UpdatedSettings {
            get {
                return ResourceManager.GetString("UpdatedSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  (x86).
        /// </summary>
        internal static string x86InProgramFiles {
            get {
                return ResourceManager.GetString("x86InProgramFiles", resourceCulture);
            }
        }
    }
}
