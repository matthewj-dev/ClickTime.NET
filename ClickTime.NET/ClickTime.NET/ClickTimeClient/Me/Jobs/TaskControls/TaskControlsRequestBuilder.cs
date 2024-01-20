// <auto-generated/>
using ClickTime.NET.Models.ResponseBodyListGet;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.Me.Jobs.TaskControls {
    /// <summary>
    /// Builds and executes requests for operations under \Me\Jobs\TaskControls
    /// </summary>
    public class TaskControlsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new TaskControlsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TaskControlsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Me/Jobs/TaskControls{?JobID*,TaskID*,JobIsActive*,TaskIsActive*,limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new TaskControlsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TaskControlsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Me/Jobs/TaskControls{?JobID*,TaskID*,JobIsActive*,TaskIsActive*,limit*,offset*}", rawUrl) {
        }
        /// <summary>
        ///   Company requirements:Task List Control must be restricted by Job.---# Sort Order:1. JobID1. TaskID
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<JobTaskControlModel_Root?> GetAsync(Action<RequestConfiguration<TaskControlsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<JobTaskControlModel_Root> GetAsync(Action<RequestConfiguration<TaskControlsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<JobTaskControlModel_Root>(requestInfo, JobTaskControlModel_Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   Company requirements:Task List Control must be restricted by Job.---# Sort Order:1. JobID1. TaskID
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TaskControlsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TaskControlsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public TaskControlsRequestBuilder WithUrl(string rawUrl) {
            return new TaskControlsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        ///   Company requirements:Task List Control must be restricted by Job.---# Sort Order:1. JobID1. TaskID
        /// </summary>
        public class TaskControlsRequestBuilderGetQueryParameters {
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
            [QueryParameter("offset")]
            public int? Offset { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? TaskID { get; set; }
#nullable restore
#else
            public string[] TaskID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public bool?[]? TaskIsActive { get; set; }
#nullable restore
#else
            public bool?[] TaskIsActive { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class TaskControlsRequestBuilderGetRequestConfiguration : RequestConfiguration<TaskControlsRequestBuilderGetQueryParameters> {
        }
    }
}
