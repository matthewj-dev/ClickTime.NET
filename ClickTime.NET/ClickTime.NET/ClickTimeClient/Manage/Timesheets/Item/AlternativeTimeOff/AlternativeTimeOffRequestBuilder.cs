// <auto-generated/>
using ClickTime.NET.Manage.Timesheets.Item.AlternativeTimeOff.Item;
using ClickTime.NET.Models.ResponseBodyListGet;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.Manage.Timesheets.Item.AlternativeTimeOff {
    /// <summary>
    /// Builds and executes requests for operations under \Manage\Timesheets\{Timesheets-id}\AlternativeTimeOff
    /// </summary>
    public class AlternativeTimeOffRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the ClickTime.NET.Manage.Timesheets.item.AlternativeTimeOff.item collection</summary>
        /// <param name="position">    Required</param>
        public WithAlternativeTimeOffItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("alternativeTimeOffID", position);
            return new WithAlternativeTimeOffItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new AlternativeTimeOffRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AlternativeTimeOffRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Manage/Timesheets/{Timesheets%2Did}/AlternativeTimeOff{?ID*,AlternativeTimeOffTypeID*,HolidayID*,limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AlternativeTimeOffRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AlternativeTimeOffRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Manage/Timesheets/{Timesheets%2Did}/AlternativeTimeOff{?ID*,AlternativeTimeOffTypeID*,HolidayID*,limit*,offset*}", rawUrl) {
        }
        /// <summary>
        ///   Company requirements:DCAA must be disabled.Company must have the TimesheetApprovals optional module.  User requirements:Admin, or Manager with permissions to Lock timesheets.---# Sort Order:1. Date (Desc)1. ID
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AlternativeTimeOffEntryModel_Manage?> GetAsync(Action<RequestConfiguration<AlternativeTimeOffRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<AlternativeTimeOffEntryModel_Manage> GetAsync(Action<RequestConfiguration<AlternativeTimeOffRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<AlternativeTimeOffEntryModel_Manage>(requestInfo, AlternativeTimeOffEntryModel_Manage.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   Company requirements:DCAA must be disabled.Company must have the TimesheetApprovals optional module.  User requirements:Admin, or Manager with permissions to Lock timesheets.---# Sort Order:1. Date (Desc)1. ID
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AlternativeTimeOffRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AlternativeTimeOffRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public AlternativeTimeOffRequestBuilder WithUrl(string rawUrl) {
            return new AlternativeTimeOffRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        ///   Company requirements:DCAA must be disabled.Company must have the TimesheetApprovals optional module.  User requirements:Admin, or Manager with permissions to Lock timesheets.---# Sort Order:1. Date (Desc)1. ID
        /// </summary>
        public class AlternativeTimeOffRequestBuilderGetQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? AlternativeTimeOffTypeID { get; set; }
#nullable restore
#else
            public string[] AlternativeTimeOffTypeID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? HolidayID { get; set; }
#nullable restore
#else
            public string[] HolidayID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? ID { get; set; }
#nullable restore
#else
            public string[] ID { get; set; }
#endif
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            [QueryParameter("offset")]
            public int? Offset { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class AlternativeTimeOffRequestBuilderGetRequestConfiguration : RequestConfiguration<AlternativeTimeOffRequestBuilderGetQueryParameters> {
        }
    }
}