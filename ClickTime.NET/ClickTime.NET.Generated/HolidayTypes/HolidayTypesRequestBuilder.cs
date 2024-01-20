// <auto-generated/>
using ClickTime.NET.Generated.HolidayTypes.Item;
using ClickTime.NET.Generated.HolidayTypes.New;
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
namespace ClickTime.NET.Generated.HolidayTypes {
    /// <summary>
    /// Builds and executes requests for operations under \HolidayTypes
    /// </summary>
    public class HolidayTypesRequestBuilder : BaseRequestBuilder {
        /// <summary>The new property</summary>
        public NewRequestBuilder New { get =>
            new NewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the ClickTime.NET.Generated.HolidayTypes.item collection</summary>
        /// <param name="position">    Required</param>
        public WithHolidayTypeItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("holidayTypeID", position);
            return new WithHolidayTypeItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new HolidayTypesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HolidayTypesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/HolidayTypes{?ID*,IsActive*,Name*,Types*,limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new HolidayTypesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HolidayTypesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/HolidayTypes{?ID*,IsActive*,Name*,Types*,limit*,offset*}", rawUrl) {
        }
        /// <summary>
        /// # Sort Order:1. Name
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ClickTime.NET.Generated.Models.ResponseBodyListGet.HolidayTypeModel_Root?> GetAsync(Action<RequestConfiguration<HolidayTypesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ClickTime.NET.Generated.Models.ResponseBodyListGet.HolidayTypeModel_Root> GetAsync(Action<RequestConfiguration<HolidayTypesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<ClickTime.NET.Generated.Models.ResponseBodyListGet.HolidayTypeModel_Root>(requestInfo, ClickTime.NET.Generated.Models.ResponseBodyListGet.HolidayTypeModel_Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   Company requirements:DCAA must be disabled.Company must have the Time Off Management optional module.  User requirements:User must be an Admin.
        /// </summary>
        /// <param name="body">Holiday Type model for POST requests.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ClickTime.NET.Generated.Models.ResponseBodyGet.HolidayTypeModel_Root?> PostAsync(ClickTime.NET.Generated.Models.Post.HolidayTypeModel_Root body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ClickTime.NET.Generated.Models.ResponseBodyGet.HolidayTypeModel_Root> PostAsync(ClickTime.NET.Generated.Models.Post.HolidayTypeModel_Root body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<ClickTime.NET.Generated.Models.ResponseBodyGet.HolidayTypeModel_Root>(requestInfo, ClickTime.NET.Generated.Models.ResponseBodyGet.HolidayTypeModel_Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// # Sort Order:1. Name
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<HolidayTypesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<HolidayTypesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        ///   Company requirements:DCAA must be disabled.Company must have the Time Off Management optional module.  User requirements:User must be an Admin.
        /// </summary>
        /// <param name="body">Holiday Type model for POST requests.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ClickTime.NET.Generated.Models.Post.HolidayTypeModel_Root body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ClickTime.NET.Generated.Models.Post.HolidayTypeModel_Root body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        public HolidayTypesRequestBuilder WithUrl(string rawUrl) {
            return new HolidayTypesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// # Sort Order:1. Name
        /// </summary>
        public class HolidayTypesRequestBuilderGetQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? ID { get; set; }
#nullable restore
#else
            public string[] ID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public bool?[]? IsActive { get; set; }
#nullable restore
#else
            public bool?[] IsActive { get; set; }
#endif
            [QueryParameter("limit")]
            public int? Limit { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? Name { get; set; }
#nullable restore
#else
            public string[] Name { get; set; }
#endif
            [QueryParameter("offset")]
            public int? Offset { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? Types { get; set; }
#nullable restore
#else
            public string[] Types { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class HolidayTypesRequestBuilderGetRequestConfiguration : RequestConfiguration<HolidayTypesRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class HolidayTypesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
