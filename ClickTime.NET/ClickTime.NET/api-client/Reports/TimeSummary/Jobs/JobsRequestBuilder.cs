// <auto-generated/>
using ClickTime.NET.Models.ResponseBodyListGet;
using ClickTime.NET.Reports.TimeSummary.Jobs.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.Reports.TimeSummary.Jobs {
    /// <summary>
    /// Builds and executes requests for operations under \Reports\TimeSummary\Jobs
    /// </summary>
    public class JobsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the ClickTime.NET.Reports.TimeSummary.Jobs.item collection</summary>
        /// <param name="position">    Required</param>
        public WithJobItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("jobID", position);
            return new WithJobItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new JobsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JobsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Reports/TimeSummary/Jobs{?JobIsActive*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new JobsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JobsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Reports/TimeSummary/Jobs{?JobIsActive*}", rawUrl) {
        }
        /// <summary>
        ///   User requirements:User must be a Manager or an Admin.---# Sort Order:1. ClientName1. JobName
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<JobTimeSummaryModel_Root?> GetAsync(Action<RequestConfiguration<JobsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<JobTimeSummaryModel_Root> GetAsync(Action<RequestConfiguration<JobsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<JobTimeSummaryModel_Root>(requestInfo, JobTimeSummaryModel_Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   User requirements:User must be a Manager or an Admin.---# Sort Order:1. ClientName1. JobName
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<JobsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<JobsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public JobsRequestBuilder WithUrl(string rawUrl) {
            return new JobsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        ///   User requirements:User must be a Manager or an Admin.---# Sort Order:1. ClientName1. JobName
        /// </summary>
        public class JobsRequestBuilderGetQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public bool?[]? JobIsActive { get; set; }
#nullable restore
#else
            public bool?[] JobIsActive { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class JobsRequestBuilderGetRequestConfiguration : RequestConfiguration<JobsRequestBuilderGetQueryParameters> {
        }
    }
}
