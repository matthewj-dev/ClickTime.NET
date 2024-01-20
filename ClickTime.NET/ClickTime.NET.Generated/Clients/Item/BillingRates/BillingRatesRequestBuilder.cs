// <auto-generated/>
using ClickTime.NET.Generated.Clients.Item.BillingRates.Item;
using ClickTime.NET.Generated.Models.ResponseBodyListGet;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.Generated.Clients.Item.BillingRates {
    /// <summary>
    /// Builds and executes requests for operations under \Clients\{clientID}\BillingRates
    /// </summary>
    public class BillingRatesRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the ClickTime.NET.Generated.Clients.item.BillingRates.item collection</summary>
        /// <param name="position">    Required</param>
        public WithBillingRateItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("billingRateID", position);
            return new WithBillingRateItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new BillingRatesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BillingRatesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Clients/{clientID}/BillingRates{?ID*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new BillingRatesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BillingRatesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Clients/{clientID}/BillingRates{?ID*}", rawUrl) {
        }
        /// <summary>
        ///   User requirements:Admin, or Manager with permissions to View Billingrates.---# Sort Order:1. Name
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BillingRateModel_Root?> GetAsync(Action<RequestConfiguration<BillingRatesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<BillingRateModel_Root> GetAsync(Action<RequestConfiguration<BillingRatesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<BillingRateModel_Root>(requestInfo, BillingRateModel_Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   User requirements:Admin, or Manager with permissions to View Billingrates.---# Sort Order:1. Name
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<BillingRatesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<BillingRatesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public BillingRatesRequestBuilder WithUrl(string rawUrl) {
            return new BillingRatesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        ///   User requirements:Admin, or Manager with permissions to View Billingrates.---# Sort Order:1. Name
        /// </summary>
        public class BillingRatesRequestBuilderGetQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? ID { get; set; }
#nullable restore
#else
            public string[] ID { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class BillingRatesRequestBuilderGetRequestConfiguration : RequestConfiguration<BillingRatesRequestBuilderGetQueryParameters> {
        }
    }
}
