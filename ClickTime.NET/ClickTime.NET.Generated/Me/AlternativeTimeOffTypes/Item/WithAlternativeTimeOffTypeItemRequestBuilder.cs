// <auto-generated/>
using ClickTime.NET.Generated.Models.ResponseBodyGet;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.Generated.Me.AlternativeTimeOffTypes.Item {
    /// <summary>
    /// Builds and executes requests for operations under \Me\AlternativeTimeOffTypes\{alternativeTimeOffTypeID}
    /// </summary>
    public class WithAlternativeTimeOffTypeItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new WithAlternativeTimeOffTypeItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithAlternativeTimeOffTypeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Me/AlternativeTimeOffTypes/{alternativeTimeOffTypeID}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithAlternativeTimeOffTypeItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithAlternativeTimeOffTypeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Me/AlternativeTimeOffTypes/{alternativeTimeOffTypeID}", rawUrl) {
        }
        /// <summary>
        /// Get my Alternative Time Off Type.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AlternativeTimeOffTypeModel_Me?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<AlternativeTimeOffTypeModel_Me> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<AlternativeTimeOffTypeModel_Me>(requestInfo, AlternativeTimeOffTypeModel_Me.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get my Alternative Time Off Type.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        public WithAlternativeTimeOffTypeItemRequestBuilder WithUrl(string rawUrl) {
            return new WithAlternativeTimeOffTypeItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithAlternativeTimeOffTypeItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
