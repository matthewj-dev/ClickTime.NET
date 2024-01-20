// <auto-generated/>
using ClickTime.NET.Generated.Me.TimeOffRequests.Item;
using ClickTime.NET.Generated.Models.Post;
using ClickTime.NET.Generated.Models.ResponseBodyGet;
using ClickTime.NET.Generated.Models.ResponseBodyListGet;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.Generated.Me.TimeOffRequests {
    /// <summary>
    /// Builds and executes requests for operations under \Me\TimeOffRequests
    /// </summary>
    public class TimeOffRequestsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the ClickTime.NET.Generated.Me.TimeOffRequests.item collection</summary>
        /// <param name="position">    Required</param>
        public WithTimeOffRequestItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("timeOffRequestID", position);
            return new WithTimeOffRequestItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new TimeOffRequestsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TimeOffRequestsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Me/TimeOffRequests{?ID*,TimeOffTypeID*,TimeOffID*,Status*,FromDate*,ToDate*,limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new TimeOffRequestsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TimeOffRequestsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Me/TimeOffRequests{?ID*,TimeOffTypeID*,TimeOffID*,Status*,FromDate*,ToDate*,limit*,offset*}", rawUrl) {
        }
        /// <summary>
        ///   Company requirements:Company must have the Time Off Management optional module.---# Sort Order:1. CreatedDate (Desc)
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ClickTime.NET.Generated.Models.ResponseBodyListGet.TimeOffRequestModel_Me?> GetAsync(Action<RequestConfiguration<TimeOffRequestsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ClickTime.NET.Generated.Models.ResponseBodyListGet.TimeOffRequestModel_Me> GetAsync(Action<RequestConfiguration<TimeOffRequestsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<ClickTime.NET.Generated.Models.ResponseBodyListGet.TimeOffRequestModel_Me>(requestInfo, ClickTime.NET.Generated.Models.ResponseBodyListGet.TimeOffRequestModel_Me.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   Company requirements:Company must have the Time Off Management optional module.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ClickTime.NET.Generated.Models.ResponseBodyGet.TimeOffRequestModel_Me?> PostAsync(ClickTime.NET.Generated.Models.Post.TimeOffRequestModel_Me body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ClickTime.NET.Generated.Models.ResponseBodyGet.TimeOffRequestModel_Me> PostAsync(ClickTime.NET.Generated.Models.Post.TimeOffRequestModel_Me body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<ClickTime.NET.Generated.Models.ResponseBodyGet.TimeOffRequestModel_Me>(requestInfo, ClickTime.NET.Generated.Models.ResponseBodyGet.TimeOffRequestModel_Me.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   Company requirements:Company must have the Time Off Management optional module.---# Sort Order:1. CreatedDate (Desc)
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TimeOffRequestsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TimeOffRequestsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        ///   Company requirements:Company must have the Time Off Management optional module.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ClickTime.NET.Generated.Models.Post.TimeOffRequestModel_Me body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ClickTime.NET.Generated.Models.Post.TimeOffRequestModel_Me body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public TimeOffRequestsRequestBuilder WithUrl(string rawUrl) {
            return new TimeOffRequestsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        ///   Company requirements:Company must have the Time Off Management optional module.---# Sort Order:1. CreatedDate (Desc)
        /// </summary>
        public class TimeOffRequestsRequestBuilderGetQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? FromDate { get; set; }
#nullable restore
#else
            public string FromDate { get; set; }
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? Status { get; set; }
#nullable restore
#else
            public string[] Status { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? TimeOffID { get; set; }
#nullable restore
#else
            public string[] TimeOffID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? TimeOffTypeID { get; set; }
#nullable restore
#else
            public string[] TimeOffTypeID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? ToDate { get; set; }
#nullable restore
#else
            public string ToDate { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class TimeOffRequestsRequestBuilderGetRequestConfiguration : RequestConfiguration<TimeOffRequestsRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class TimeOffRequestsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
