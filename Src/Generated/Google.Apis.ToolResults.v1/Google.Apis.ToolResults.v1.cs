// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.43.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Cloud Tool Results API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://firebase.google.com/docs/test-lab/'>Cloud Tool Results API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20200206 (1862)
 *      <tr><th>API Docs
 *          <td><a href='https://firebase.google.com/docs/test-lab/'>
 *              https://firebase.google.com/docs/test-lab/</a>
 *      <tr><th>Discovery Name<td>toolresults
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Cloud Tool Results API can be found at
 * <a href='https://firebase.google.com/docs/test-lab/'>https://firebase.google.com/docs/test-lab/</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.ToolResults.v1
{
    /// <summary>The ToolResults Service.</summary>
    public class ToolResultsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ToolResultsService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ToolResultsService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {

        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "toolresults"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            get { return BaseUriOverride ?? "https://toolresults.googleapis.com/"; }
        #else
            get { return "https://toolresults.googleapis.com/"; }
        #endif
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return ""; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://toolresults.googleapis.com/batch"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch"; }
        }
        #endif




    }

    ///<summary>A base abstract class for ToolResults requests.</summary>
    public abstract class ToolResultsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new ToolResultsBaseServiceRequest instance.</summary>
        protected ToolResultsBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes ToolResults parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }
}

namespace Google.Apis.ToolResults.v1.Data
{    

    /// <summary>Additional details for an ANR crash.</summary>
    public class ANR : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The stack trace of the ANR crash. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackTrace")]
        public virtual StackTrace StackTrace { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A suggestion to use deep links for a Robo run.</summary>
    public class AvailableDeepLinks : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A warning that Robo encountered a screen that was mostly blank; this may indicate a problem with the
    /// app.</summary>
    public class BlankScreen : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The screen id of the element</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenId")]
        public virtual string ScreenId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Crash dialog was detected during the test execution</summary>
    public class CrashDialogError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the package that caused the dialog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crashPackage")]
        public virtual string CrashPackage { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details about encountered login screens.</summary>
    public class EncounteredLoginScreen : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of encountered distinct login screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distinctScreens")]
        public virtual System.Nullable<int> DistinctScreens { get; set; } 

        /// <summary>Subset of login screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenIds")]
        public virtual System.Collections.Generic.IList<string> ScreenIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details about encountered screens with elements that are not Android UI widgets.</summary>
    public class EncounteredNonAndroidUiWidgetScreen : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of encountered distinct screens with non Android UI widgets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distinctScreens")]
        public virtual System.Nullable<int> DistinctScreens { get; set; } 

        /// <summary>Subset of screens which contain non Android UI widgets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenIds")]
        public virtual System.Collections.Generic.IList<string> ScreenIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Failed to install the APK.</summary>
    public class FailedToInstall : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details for a fatal exception.</summary>
    public class FatalException : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The stack trace of the fatal exception. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackTrace")]
        public virtual StackTrace StackTrace { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details of in-app purchases encountered during the crawl.</summary>
    public class InAppPurchasesFound : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total number of in-app purchases flows explored: how many times the robo tries to buy a
        /// SKU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inAppPurchasesFlowsExplored")]
        public virtual System.Nullable<int> InAppPurchasesFlowsExplored { get; set; } 

        /// <summary>The total number of in-app purchases flows started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inAppPurchasesFlowsStarted")]
        public virtual System.Nullable<int> InAppPurchasesFlowsStarted { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A warning that Robo did not crawl potentially important parts of the app.</summary>
    public class InsufficientCoverage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details for an iOS app crash.</summary>
    public class IosAppCrashed : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The stack trace, if one is available. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackTrace")]
        public virtual StackTrace StackTrace { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Failed to find the launcher activity of an app.</summary>
    public class LauncherActivityNotFound : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details for a native crash.</summary>
    public class NativeCrash : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The stack trace of the native crash. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackTrace")]
        public virtual StackTrace StackTrace { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A non-sdk API and examples of it being called along with other metadata See
    /// https://developer.android.com/distribute/best-practices/develop/restrictions-non-sdk-interfaces</summary>
    public class NonSdkApi : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The signature of the Non-SDK API</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiSignature")]
        public virtual string ApiSignature { get; set; } 

        /// <summary>Example stack traces of this API being called.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleStackTraces")]
        public virtual System.Collections.Generic.IList<string> ExampleStackTraces { get; set; } 

        /// <summary>Optional debugging insights for non-SDK API violations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insights")]
        public virtual System.Collections.Generic.IList<NonSdkApiInsight> Insights { get; set; } 

        /// <summary>The total number of times this API was observed to have been called.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invocationCount")]
        public virtual System.Nullable<int> InvocationCount { get; set; } 

        /// <summary>Which list this API appears on</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("list")]
        public virtual string List { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Non-SDK API insights (to address debugging solutions).</summary>
    public class NonSdkApiInsight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional sample stack traces, for which this insight applies (there should be at least
        /// one).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleTraceMessages")]
        public virtual System.Collections.Generic.IList<string> ExampleTraceMessages { get; set; } 

        /// <summary>A unique ID, to be used for determining the effectiveness of this particular insight in the context
        /// of a matcher. (required)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matcherId")]
        public virtual string MatcherId { get; set; } 

        /// <summary>An insight indicating that the hidden API usage originates from a Google-provided
        /// library.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingGoogleUpdateInsight")]
        public virtual PendingGoogleUpdateInsight PendingGoogleUpdateInsight { get; set; } 

        /// <summary>An insight indicating that the hidden API usage originates from the use of a library that needs to
        /// be upgraded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeInsight")]
        public virtual UpgradeInsight UpgradeInsight { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details for a non-sdk API usage violation.</summary>
    public class NonSdkApiUsageViolation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Signatures of a subset of those hidden API's.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiSignatures")]
        public virtual System.Collections.Generic.IList<string> ApiSignatures { get; set; } 

        /// <summary>Total number of unique hidden API's accessed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniqueApis")]
        public virtual System.Nullable<int> UniqueApis { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Contains a summary and examples of non-sdk API usage violations.</summary>
    public class NonSdkApiUsageViolationReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Examples of the detected API usages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleApis")]
        public virtual System.Collections.Generic.IList<NonSdkApi> ExampleApis { get; set; } 

        /// <summary>Minimum API level required for the application to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minSdkVersion")]
        public virtual System.Nullable<int> MinSdkVersion { get; set; } 

        /// <summary>Specifies the API Level on which the application is designed to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSdkVersion")]
        public virtual System.Nullable<int> TargetSdkVersion { get; set; } 

        /// <summary>Total number of unique Non-SDK API's accessed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniqueApis")]
        public virtual System.Nullable<int> UniqueApis { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A warning that Robo encountered a screen that has overlapping clickable elements; this may indicate a
    /// potential UI issue.</summary>
    public class OverlappingUIElements : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource names of the overlapping screen elements</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual System.Collections.Generic.IList<string> ResourceName { get; set; } 

        /// <summary>The screen id of the elements</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenId")]
        public virtual string ScreenId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This insight indicates that the hidden API usage originates from a Google-provided library. Users need
    /// not take any action.</summary>
    public class PendingGoogleUpdateInsight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the Google-provided library with the non-SDK API dependency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameOfGoogleLibrary")]
        public virtual string NameOfGoogleLibrary { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A notification that Robo signed in with Google.</summary>
    public class PerformedGoogleLogin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A notification that Robo performed some monkey actions.</summary>
    public class PerformedMonkeyActions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total number of monkey actions performed during the crawl.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalActions")]
        public virtual System.Nullable<int> TotalActions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Execution stats for a user-provided Robo script.</summary>
    public class RoboScriptExecution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of Robo script actions executed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successfulActions")]
        public virtual System.Nullable<int> SuccessfulActions { get; set; } 

        /// <summary>The total number of actions in the Robo script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalActions")]
        public virtual System.Nullable<int> TotalActions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A stacktrace.</summary>
    public class StackTrace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The stack trace message.
        ///
        /// Required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exception")]
        public virtual string Exception { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>User provided intent failed to resolve to an activity.</summary>
    public class StartActivityNotFound : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A warning that the screen hierarchy is deeper than the recommended threshold.</summary>
    public class UIElementTooDeep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The depth of the screen element</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("depth")]
        public virtual System.Nullable<int> Depth { get; set; } 

        /// <summary>The screen id of the element</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenId")]
        public virtual string ScreenId { get; set; } 

        /// <summary>The screen state id of the element</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenStateId")]
        public virtual string ScreenStateId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Default unspecified warning.</summary>
    public class UnspecifiedWarning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details of an unused robodirective.</summary>
    public class UnusedRoboDirective : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the resource that was unused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This insight is a recommendation to upgrade a given library to the specified version, in order to avoid
    /// dependencies on non-SDK APIs.</summary>
    public class UpgradeInsight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the package to be upgraded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; } 

        /// <summary>The suggested version to upgrade to. Optional: In case we are not sure which version solves this
        /// problem</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeToVersion")]
        public virtual string UpgradeToVersion { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details of a used Robo directive.</summary>
    public class UsedRoboDirective : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the resource that was used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details of a used Robo directive with an ignore action. Note: This is a different scenario
    /// than unused directive.</summary>
    public class UsedRoboIgnoreDirective : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the resource that was ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
