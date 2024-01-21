// <auto-generated/>
using ClickTime.NET.JobBudgets.ResourceManagement.Item.Monthly.Item;
using ClickTime.NET.Models.ResponseBodyListGet;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.JobBudgets.ResourceManagement.Item.Monthly {
    /// <summary>
    /// Builds and executes requests for operations under \JobBudgets\ResourceManagement\{jobID}\Monthly
    /// </summary>
    public class MonthlyRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the ClickTime.NET.JobBudgets.ResourceManagement.item.Monthly.item collection</summary>
        /// <param name="position">    Required</param>
        public WithMonthItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("month", position);
            return new WithMonthItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new MonthlyRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MonthlyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/JobBudgets/ResourceManagement/{jobID}/Monthly{?StartDate*,EndDate*,limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new MonthlyRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MonthlyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/JobBudgets/ResourceManagement/{jobID}/Monthly{?StartDate*,EndDate*,limit*,offset*}", rawUrl) {
        }
        /// <summary>
        ///   Company requirements:Company must have the Resource Management optional module.Estimation model: Resource Management  User requirements:Admin, or Manager with permissions to View Resource Management.---# Sort Order:1. Month
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<JobBudgetResourceManagementModel_JobBudgetMonthly?> GetAsync(Action<RequestConfiguration<MonthlyRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<JobBudgetResourceManagementModel_JobBudgetMonthly> GetAsync(Action<RequestConfiguration<MonthlyRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<JobBudgetResourceManagementModel_JobBudgetMonthly>(requestInfo, JobBudgetResourceManagementModel_JobBudgetMonthly.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   Company requirements:Company must have the Resource Management optional module.Estimation model: Resource Management  User requirements:Admin, or Manager with permissions to View Resource Management.---# Sort Order:1. Month
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MonthlyRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MonthlyRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public MonthlyRequestBuilder WithUrl(string rawUrl) {
            return new MonthlyRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        ///   Company requirements:Company must have the Resource Management optional module.Estimation model: Resource Management  User requirements:Admin, or Manager with permissions to View Resource Management.---# Sort Order:1. Month
        /// </summary>
        public class MonthlyRequestBuilderGetQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? EndDate { get; set; }
#nullable restore
#else
            public string EndDate { get; set; }
#endif
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            [QueryParameter("offset")]
            public int? Offset { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? StartDate { get; set; }
#nullable restore
#else
            public string StartDate { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class MonthlyRequestBuilderGetRequestConfiguration : RequestConfiguration<MonthlyRequestBuilderGetQueryParameters> {
        }
    }
}