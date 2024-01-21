// <auto-generated/>
using ClickTime.NET.Divisions.CustomFieldDefinitions.Item;
using ClickTime.NET.Models.ResponseBodyListGet;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.Divisions.CustomFieldDefinitions {
    /// <summary>
    /// Builds and executes requests for operations under \Divisions\CustomFieldDefinitions
    /// </summary>
    public class CustomFieldDefinitionsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the ClickTime.NET.Divisions.CustomFieldDefinitions.item collection</summary>
        /// <param name="position">    Required</param>
        public WithCustomFieldDefinitionItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("customFieldDefinitionID", position);
            return new WithCustomFieldDefinitionItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new CustomFieldDefinitionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomFieldDefinitionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Divisions/CustomFieldDefinitions{?limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CustomFieldDefinitionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomFieldDefinitionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Divisions/CustomFieldDefinitions{?limit*,offset*}", rawUrl) {
        }
        /// <summary>
        ///   User requirements:Admin, or Manager with permissions to View Divisions.  Company requirements:Company must have one of the following optional modules: Corporate, Enterprise.---# Sort Order:1. DisplayName
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CustomFieldDefinitionModel_Root?> GetAsync(Action<RequestConfiguration<CustomFieldDefinitionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CustomFieldDefinitionModel_Root> GetAsync(Action<RequestConfiguration<CustomFieldDefinitionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<CustomFieldDefinitionModel_Root>(requestInfo, CustomFieldDefinitionModel_Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   User requirements:Admin, or Manager with permissions to View Divisions.  Company requirements:Company must have one of the following optional modules: Corporate, Enterprise.---# Sort Order:1. DisplayName
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CustomFieldDefinitionsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CustomFieldDefinitionsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public CustomFieldDefinitionsRequestBuilder WithUrl(string rawUrl) {
            return new CustomFieldDefinitionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        ///   User requirements:Admin, or Manager with permissions to View Divisions.  Company requirements:Company must have one of the following optional modules: Corporate, Enterprise.---# Sort Order:1. DisplayName
        /// </summary>
        public class CustomFieldDefinitionsRequestBuilderGetQueryParameters {
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            [QueryParameter("offset")]
            public int? Offset { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class CustomFieldDefinitionsRequestBuilderGetRequestConfiguration : RequestConfiguration<CustomFieldDefinitionsRequestBuilderGetQueryParameters> {
        }
    }
}
