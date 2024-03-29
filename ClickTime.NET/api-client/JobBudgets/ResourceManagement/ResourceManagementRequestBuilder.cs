// <auto-generated/>
using ClickTime.NET.JobBudgets.ResourceManagement.Item;
using ClickTime.NET.Models.ResponseBodyListGet;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.JobBudgets.ResourceManagement {
    /// <summary>
    /// Builds and executes requests for operations under \JobBudgets\ResourceManagement
    /// </summary>
    public class ResourceManagementRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the ClickTime.NET.JobBudgets.ResourceManagement.item collection</summary>
        /// <param name="position">    Required</param>
        public WithJobItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("jobID", position);
            return new WithJobItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ResourceManagementRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ResourceManagementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/JobBudgets/ResourceManagement{?JobID*,ClientID*,JobIsActive*,ProjectManagerID*,Type*,MonthlyBudgetStartDate*,MonthlyBudgetEndDate*,limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ResourceManagementRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ResourceManagementRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/JobBudgets/ResourceManagement{?JobID*,ClientID*,JobIsActive*,ProjectManagerID*,Type*,MonthlyBudgetStartDate*,MonthlyBudgetEndDate*,limit*,offset*}", rawUrl) {
        }
        /// <summary>
        ///   Company requirements:Company must have the Resource Management optional module.Estimation model: Resource Management  User requirements:Admin, or Manager with permissions to View Resource Management.---# Sort Order:1. Type1. Month
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<JobBudgetResourceManagementModel_Root?> GetAsync(Action<RequestConfiguration<ResourceManagementRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<JobBudgetResourceManagementModel_Root> GetAsync(Action<RequestConfiguration<ResourceManagementRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<JobBudgetResourceManagementModel_Root>(requestInfo, JobBudgetResourceManagementModel_Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   Company requirements:Company must have the Resource Management optional module.Estimation model: Resource Management  User requirements:Admin, or Manager with permissions to View Resource Management.---# Sort Order:1. Type1. Month
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ResourceManagementRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ResourceManagementRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public ResourceManagementRequestBuilder WithUrl(string rawUrl) {
            return new ResourceManagementRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        ///   Company requirements:Company must have the Resource Management optional module.Estimation model: Resource Management  User requirements:Admin, or Manager with permissions to View Resource Management.---# Sort Order:1. Type1. Month
        /// </summary>
        public class ResourceManagementRequestBuilderGetQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? ClientID { get; set; }
#nullable restore
#else
            public string[] ClientID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? JobID { get; set; }
#nullable restore
#else
            public string[] JobID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public bool?[]? JobIsActive { get; set; }
#nullable restore
#else
            public bool?[] JobIsActive { get; set; }
#endif
            [QueryParameter("limit")]
            public int? Limit { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? MonthlyBudgetEndDate { get; set; }
#nullable restore
#else
            public string MonthlyBudgetEndDate { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? MonthlyBudgetStartDate { get; set; }
#nullable restore
#else
            public string MonthlyBudgetStartDate { get; set; }
#endif
            [QueryParameter("offset")]
            public int? Offset { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? ProjectManagerID { get; set; }
#nullable restore
#else
            public string[] ProjectManagerID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? Type { get; set; }
#nullable restore
#else
            public string[] Type { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ResourceManagementRequestBuilderGetRequestConfiguration : RequestConfiguration<ResourceManagementRequestBuilderGetQueryParameters> {
        }
    }
}
