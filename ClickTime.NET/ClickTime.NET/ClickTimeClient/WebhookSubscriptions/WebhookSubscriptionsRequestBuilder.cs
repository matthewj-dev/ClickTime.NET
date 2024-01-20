// <auto-generated/>
using ClickTime.NET.Models.Get;
using ClickTime.NET.Models.ResponseBodyGet;
using ClickTime.NET.Models.ResponseBodyListGet;
using ClickTime.NET.WebhookSubscriptions.Item;
using ClickTime.NET.WebhookSubscriptions.New;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.WebhookSubscriptions {
    /// <summary>
    /// Builds and executes requests for operations under \WebhookSubscriptions
    /// </summary>
    public class WebhookSubscriptionsRequestBuilder : BaseRequestBuilder {
        /// <summary>The new property</summary>
        public NewRequestBuilder New { get =>
            new NewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the ClickTime.NET.WebhookSubscriptions.item collection</summary>
        /// <param name="position">    Required</param>
        public WithWebhookSubscriptionItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("webhookSubscriptionID", position);
            return new WithWebhookSubscriptionItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new WebhookSubscriptionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WebhookSubscriptionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/WebhookSubscriptions{?ID*,WebhookEventTypeID*,limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WebhookSubscriptionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WebhookSubscriptionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/WebhookSubscriptions{?ID*,WebhookEventTypeID*,limit*,offset*}", rawUrl) {
        }
        /// <summary>
        ///   User requirements:User must be an Admin.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ClickTime.NET.Models.ResponseBodyListGet.WebhookSubscriptionModel_Root?> GetAsync(Action<RequestConfiguration<WebhookSubscriptionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ClickTime.NET.Models.ResponseBodyListGet.WebhookSubscriptionModel_Root> GetAsync(Action<RequestConfiguration<WebhookSubscriptionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<ClickTime.NET.Models.ResponseBodyListGet.WebhookSubscriptionModel_Root>(requestInfo, ClickTime.NET.Models.ResponseBodyListGet.WebhookSubscriptionModel_Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   User requirements:User must be an Admin.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ClickTime.NET.Models.ResponseBodyGet.WebhookSubscriptionModel_Root?> PostAsync(ClickTime.NET.Models.Get.WebhookSubscriptionModel_Root body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ClickTime.NET.Models.ResponseBodyGet.WebhookSubscriptionModel_Root> PostAsync(ClickTime.NET.Models.Get.WebhookSubscriptionModel_Root body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<ClickTime.NET.Models.ResponseBodyGet.WebhookSubscriptionModel_Root>(requestInfo, ClickTime.NET.Models.ResponseBodyGet.WebhookSubscriptionModel_Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   User requirements:User must be an Admin.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WebhookSubscriptionsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WebhookSubscriptionsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        ///   User requirements:User must be an Admin.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ClickTime.NET.Models.Get.WebhookSubscriptionModel_Root body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ClickTime.NET.Models.Get.WebhookSubscriptionModel_Root body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        public WebhookSubscriptionsRequestBuilder WithUrl(string rawUrl) {
            return new WebhookSubscriptionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        ///   User requirements:User must be an Admin.
        /// </summary>
        public class WebhookSubscriptionsRequestBuilderGetQueryParameters {
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
            public string[]? WebhookEventTypeID { get; set; }
#nullable restore
#else
            public string[] WebhookEventTypeID { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WebhookSubscriptionsRequestBuilderGetRequestConfiguration : RequestConfiguration<WebhookSubscriptionsRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WebhookSubscriptionsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
