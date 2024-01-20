// <auto-generated/>
using ClickTime.NET.Models.Post;
using ClickTime.NET.Models.ResponseBodyGet;
using ClickTime.NET.Models.ResponseBodyListGet;
using ClickTime.NET.Overtime.Item.Rules.Item;
using ClickTime.NET.Overtime.Item.Rules.New;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.Overtime.Item.Rules {
    /// <summary>
    /// Builds and executes requests for operations under \Overtime\{overtimeDefinitionID}\Rules
    /// </summary>
    public class RulesRequestBuilder : BaseRequestBuilder {
        /// <summary>The new property</summary>
        public NewRequestBuilder New { get =>
            new NewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the ClickTime.NET.Overtime.item.Rules.item collection</summary>
        /// <param name="position">    Required</param>
        public WithOvertimeRuleItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("overtimeRuleID", position);
            return new WithOvertimeRuleItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new RulesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RulesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Overtime/{overtimeDefinitionID}/Rules{?limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new RulesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RulesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Overtime/{overtimeDefinitionID}/Rules{?limit*,offset*}", rawUrl) {
        }
        /// <summary>
        ///   User requirements:User must be an Admin.---# Sort Order:1. ID (Desc)
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ClickTime.NET.Models.ResponseBodyListGet.OvertimeRuleModel_Root?> GetAsync(Action<RequestConfiguration<RulesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ClickTime.NET.Models.ResponseBodyListGet.OvertimeRuleModel_Root> GetAsync(Action<RequestConfiguration<RulesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<ClickTime.NET.Models.ResponseBodyListGet.OvertimeRuleModel_Root>(requestInfo, ClickTime.NET.Models.ResponseBodyListGet.OvertimeRuleModel_Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   User requirements:User must be an Admin.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ClickTime.NET.Models.ResponseBodyGet.OvertimeRuleModel_Root?> PostAsync(ClickTime.NET.Models.Post.OvertimeRuleModel_Root body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ClickTime.NET.Models.ResponseBodyGet.OvertimeRuleModel_Root> PostAsync(ClickTime.NET.Models.Post.OvertimeRuleModel_Root body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<ClickTime.NET.Models.ResponseBodyGet.OvertimeRuleModel_Root>(requestInfo, ClickTime.NET.Models.ResponseBodyGet.OvertimeRuleModel_Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   User requirements:User must be an Admin.---# Sort Order:1. ID (Desc)
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RulesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RulesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public RequestInformation ToPostRequestInformation(ClickTime.NET.Models.Post.OvertimeRuleModel_Root body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ClickTime.NET.Models.Post.OvertimeRuleModel_Root body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        public RulesRequestBuilder WithUrl(string rawUrl) {
            return new RulesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        ///   User requirements:User must be an Admin.---# Sort Order:1. ID (Desc)
        /// </summary>
        public class RulesRequestBuilderGetQueryParameters {
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            [QueryParameter("offset")]
            public int? Offset { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class RulesRequestBuilderGetRequestConfiguration : RequestConfiguration<RulesRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class RulesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
