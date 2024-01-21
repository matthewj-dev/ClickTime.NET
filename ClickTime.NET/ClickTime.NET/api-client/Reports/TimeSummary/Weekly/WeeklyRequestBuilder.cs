// <auto-generated/>
using ClickTime.NET.Models.ResponseBodyListGet;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.Reports.TimeSummary.Weekly {
    /// <summary>
    /// Builds and executes requests for operations under \Reports\TimeSummary\Weekly
    /// </summary>
    public class WeeklyRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new WeeklyRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WeeklyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Reports/TimeSummary/Weekly{?StartDate*,EndDate*,UserID*,DivisionID*,EmploymentTypeID*,UserIsActive*,SubjectToTimesheetCompletionWeekly*,TimesheetApproverID*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WeeklyRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WeeklyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Reports/TimeSummary/Weekly{?StartDate*,EndDate*,UserID*,DivisionID*,EmploymentTypeID*,UserIsActive*,SubjectToTimesheetCompletionWeekly*,TimesheetApproverID*}", rawUrl) {
        }
        /// <summary>
        ///   User requirements:Admin, or Manager with permissions to Review timesheets, or Run Company Reports (all Jobs).---# Sort Order:1. Name1. StartDate
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<TimeSummaryWeeklyModel_Root?> GetAsync(Action<RequestConfiguration<WeeklyRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<TimeSummaryWeeklyModel_Root> GetAsync(Action<RequestConfiguration<WeeklyRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<TimeSummaryWeeklyModel_Root>(requestInfo, TimeSummaryWeeklyModel_Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   User requirements:Admin, or Manager with permissions to Review timesheets, or Run Company Reports (all Jobs).---# Sort Order:1. Name1. StartDate
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WeeklyRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WeeklyRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public WeeklyRequestBuilder WithUrl(string rawUrl) {
            return new WeeklyRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        ///   User requirements:Admin, or Manager with permissions to Review timesheets, or Run Company Reports (all Jobs).---# Sort Order:1. Name1. StartDate
        /// </summary>
        public class WeeklyRequestBuilderGetQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? DivisionID { get; set; }
#nullable restore
#else
            public string[] DivisionID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? EmploymentTypeID { get; set; }
#nullable restore
#else
            public string[] EmploymentTypeID { get; set; }
#endif
            /// <summary>    Required</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? EndDate { get; set; }
#nullable restore
#else
            public string EndDate { get; set; }
#endif
            /// <summary>    Required</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? StartDate { get; set; }
#nullable restore
#else
            public string StartDate { get; set; }
#endif
            public bool? SubjectToTimesheetCompletionWeekly { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? TimesheetApproverID { get; set; }
#nullable restore
#else
            public string[] TimesheetApproverID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? UserID { get; set; }
#nullable restore
#else
            public string[] UserID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public bool?[]? UserIsActive { get; set; }
#nullable restore
#else
            public bool?[] UserIsActive { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WeeklyRequestBuilderGetRequestConfiguration : RequestConfiguration<WeeklyRequestBuilderGetQueryParameters> {
        }
    }
}
