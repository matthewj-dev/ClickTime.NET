// <auto-generated/>
using ClickTime.NET.Models.Put;
using ClickTime.NET.Models.ResponseBodyListGet;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.JobBudgets.ResourceManagement.Item.LifetimeBillings {
    /// <summary>
    /// Builds and executes requests for operations under \JobBudgets\ResourceManagement\{jobID}\LifetimeBillings
    /// </summary>
    public class LifetimeBillingsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new LifetimeBillingsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LifetimeBillingsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/JobBudgets/ResourceManagement/{jobID}/LifetimeBillings", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new LifetimeBillingsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LifetimeBillingsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/JobBudgets/ResourceManagement/{jobID}/LifetimeBillings", rawUrl) {
        }
        /// <summary>
        ///   Company requirements:Company must have the Resource Management optional module.Estimation model: Resource Management  User requirements:Admin, or Manager with permissions to Add/Edit Resource Management.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   Company requirements:Company must have the Resource Management optional module.Estimation model: Resource Management  User requirements:Admin, or Manager with permissions to View Resource Management.---# Sort Order:1. Month
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ClickTime.NET.Models.ResponseBodyListGet.JobBudgetResourceManagementModel_JobBudgetLifetime?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ClickTime.NET.Models.ResponseBodyListGet.JobBudgetResourceManagementModel_JobBudgetLifetime> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<ClickTime.NET.Models.ResponseBodyListGet.JobBudgetResourceManagementModel_JobBudgetLifetime>(requestInfo, ClickTime.NET.Models.ResponseBodyListGet.JobBudgetResourceManagementModel_JobBudgetLifetime.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   Company requirements:Company must have the Resource Management optional module.Estimation model: Resource Management  User requirements:Admin, or Manager with permissions to Add/Edit Resource Management.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ClickTime.NET.Models.ResponseBodyListGet.JobBudgetResourceManagementModel_JobBudgetLifetime?> PutAsync(ClickTime.NET.Models.Put.JobBudgetResourceManagementModel_JobBudgetLifetime body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ClickTime.NET.Models.ResponseBodyListGet.JobBudgetResourceManagementModel_JobBudgetLifetime> PutAsync(ClickTime.NET.Models.Put.JobBudgetResourceManagementModel_JobBudgetLifetime body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<ClickTime.NET.Models.ResponseBodyListGet.JobBudgetResourceManagementModel_JobBudgetLifetime>(requestInfo, ClickTime.NET.Models.ResponseBodyListGet.JobBudgetResourceManagementModel_JobBudgetLifetime.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   Company requirements:Company must have the Resource Management optional module.Estimation model: Resource Management  User requirements:Admin, or Manager with permissions to Add/Edit Resource Management.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        ///   Company requirements:Company must have the Resource Management optional module.Estimation model: Resource Management  User requirements:Admin, or Manager with permissions to View Resource Management.---# Sort Order:1. Month
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
        ///   Company requirements:Company must have the Resource Management optional module.Estimation model: Resource Management  User requirements:Admin, or Manager with permissions to Add/Edit Resource Management.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(ClickTime.NET.Models.Put.JobBudgetResourceManagementModel_JobBudgetLifetime body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(ClickTime.NET.Models.Put.JobBudgetResourceManagementModel_JobBudgetLifetime body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public LifetimeBillingsRequestBuilder WithUrl(string rawUrl) {
            return new LifetimeBillingsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class LifetimeBillingsRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class LifetimeBillingsRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class LifetimeBillingsRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
