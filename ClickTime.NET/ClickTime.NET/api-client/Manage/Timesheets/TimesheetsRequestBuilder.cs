// <auto-generated/>
using ClickTime.NET.Manage.Timesheets.AlternativeTimeOff;
using ClickTime.NET.Manage.Timesheets.HolidayEntries;
using ClickTime.NET.Manage.Timesheets.Item;
using ClickTime.NET.Manage.Timesheets.TimeEntries;
using ClickTime.NET.Manage.Timesheets.TimeOff;
using ClickTime.NET.Models.ResponseBodyListGet;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.Manage.Timesheets {
    /// <summary>
    /// Builds and executes requests for operations under \Manage\Timesheets
    /// </summary>
    public class TimesheetsRequestBuilder : BaseRequestBuilder {
        /// <summary>The AlternativeTimeOff property</summary>
        public AlternativeTimeOffRequestBuilder AlternativeTimeOff { get =>
            new AlternativeTimeOffRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The HolidayEntries property</summary>
        public HolidayEntriesRequestBuilder HolidayEntries { get =>
            new HolidayEntriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The TimeEntries property</summary>
        public TimeEntriesRequestBuilder TimeEntries { get =>
            new TimeEntriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The TimeOff property</summary>
        public TimeOffRequestBuilder TimeOff { get =>
            new TimeOffRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the ClickTime.NET.Manage.Timesheets.item collection</summary>
        /// <param name="position">    Required</param>
        public TimesheetsItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("Timesheets%2Did", position);
            return new TimesheetsItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new TimesheetsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TimesheetsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Manage/Timesheets{?Status*,UserID*,DivisionID*,EmploymentTypeID*,FromDate*,ToDate*,limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new TimesheetsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TimesheetsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Manage/Timesheets{?Status*,UserID*,DivisionID*,EmploymentTypeID*,FromDate*,ToDate*,limit*,offset*}", rawUrl) {
        }
        /// <summary>
        ///   Company requirements:Company must have the TimesheetApprovals optional module.  User requirements:Admin, or Manager with permissions to Lock timesheets.---# Sort Order:1. StartDate (Desc)1. User.Name
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<TimesheetModel_Manage?> GetAsync(Action<RequestConfiguration<TimesheetsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<TimesheetModel_Manage> GetAsync(Action<RequestConfiguration<TimesheetsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<TimesheetModel_Manage>(requestInfo, TimesheetModel_Manage.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   Company requirements:Company must have the TimesheetApprovals optional module.  User requirements:Admin, or Manager with permissions to Lock timesheets.---# Sort Order:1. StartDate (Desc)1. User.Name
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TimesheetsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TimesheetsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public TimesheetsRequestBuilder WithUrl(string rawUrl) {
            return new TimesheetsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        ///   Company requirements:Company must have the TimesheetApprovals optional module.  User requirements:Admin, or Manager with permissions to Lock timesheets.---# Sort Order:1. StartDate (Desc)1. User.Name
        /// </summary>
        public class TimesheetsRequestBuilderGetQueryParameters {
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? FromDate { get; set; }
#nullable restore
#else
            public string FromDate { get; set; }
#endif
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            [QueryParameter("offset")]
            public int? Offset { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? Status { get; set; }
#nullable restore
#else
            public string[] Status { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? ToDate { get; set; }
#nullable restore
#else
            public string ToDate { get; set; }
#endif
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
        public class TimesheetsRequestBuilderGetRequestConfiguration : RequestConfiguration<TimesheetsRequestBuilderGetQueryParameters> {
        }
    }
}
