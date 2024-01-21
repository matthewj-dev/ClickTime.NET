// <auto-generated/>
using ClickTime.NET.Models.ResponseBodyListGet;
using ClickTime.NET.Reports.TimeSummary.Daily;
using ClickTime.NET.Reports.TimeSummary.Jobs;
using ClickTime.NET.Reports.TimeSummary.Payroll;
using ClickTime.NET.Reports.TimeSummary.Weekly;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.Reports.TimeSummary {
    /// <summary>
    /// Builds and executes requests for operations under \Reports\TimeSummary
    /// </summary>
    public class TimeSummaryRequestBuilder : BaseRequestBuilder {
        /// <summary>The Daily property</summary>
        public DailyRequestBuilder Daily { get =>
            new DailyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Jobs property</summary>
        public JobsRequestBuilder Jobs { get =>
            new JobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Payroll property</summary>
        public PayrollRequestBuilder Payroll { get =>
            new PayrollRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Weekly property</summary>
        public WeeklyRequestBuilder Weekly { get =>
            new WeeklyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new TimeSummaryRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TimeSummaryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Reports/TimeSummary{?GroupBy*,JobID*,UserID*,TaskID*,TimesheetStatus*,StartDate*,EndDate*,JobIsActive*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new TimeSummaryRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TimeSummaryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Reports/TimeSummary{?GroupBy*,JobID*,UserID*,TaskID*,TimesheetStatus*,StartDate*,EndDate*,JobIsActive*}", rawUrl) {
        }
        /// <summary>
        ///   User requirements:User must be a Manager or an Admin.---# Sort Order:1. Key.JobName1. Key.TaskName1. Key.UserName1. Key.Month
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<SummaryModel_Root?> GetAsync(Action<RequestConfiguration<TimeSummaryRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<SummaryModel_Root> GetAsync(Action<RequestConfiguration<TimeSummaryRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<SummaryModel_Root>(requestInfo, SummaryModel_Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   User requirements:User must be a Manager or an Admin.---# Sort Order:1. Key.JobName1. Key.TaskName1. Key.UserName1. Key.Month
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TimeSummaryRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TimeSummaryRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public TimeSummaryRequestBuilder WithUrl(string rawUrl) {
            return new TimeSummaryRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        ///   User requirements:User must be a Manager or an Admin.---# Sort Order:1. Key.JobName1. Key.TaskName1. Key.UserName1. Key.Month
        /// </summary>
        public class TimeSummaryRequestBuilderGetQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? EndDate { get; set; }
#nullable restore
#else
            public string EndDate { get; set; }
#endif
            /// <summary>Supported groupings: Job, Task, User, Month, Date, Task and User, Job and Task, Job and Month.    Required</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? GroupBy { get; set; }
#nullable restore
#else
            public string[] GroupBy { get; set; }
#endif
            /// <summary>Required if UserID is not provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? JobID { get; set; }
#nullable restore
#else
            public string[] JobID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public bool?[]? JobIsActive { get; set; }
#nullable restore
#else
            public bool?[] JobIsActive { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? StartDate { get; set; }
#nullable restore
#else
            public string StartDate { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? TaskID { get; set; }
#nullable restore
#else
            public string[] TaskID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? TimesheetStatus { get; set; }
#nullable restore
#else
            public string[] TimesheetStatus { get; set; }
#endif
            /// <summary>Required if JobID is not provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? UserID { get; set; }
#nullable restore
#else
            public string[] UserID { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class TimeSummaryRequestBuilderGetRequestConfiguration : RequestConfiguration<TimeSummaryRequestBuilderGetQueryParameters> {
        }
    }
}