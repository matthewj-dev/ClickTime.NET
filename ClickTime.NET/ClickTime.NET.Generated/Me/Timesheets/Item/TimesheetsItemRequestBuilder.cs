// <auto-generated/>
using ClickTime.NET.Generated.Me.Timesheets.Item.Actions;
using ClickTime.NET.Generated.Me.Timesheets.Item.History;
using ClickTime.NET.Generated.Models.ResponseBodyGet;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.Generated.Me.Timesheets.Item {
    /// <summary>
    /// Builds and executes requests for operations under \Me\Timesheets\{Timesheets-id}
    /// </summary>
    public class TimesheetsItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The Actions property</summary>
        public ActionsRequestBuilder Actions { get =>
            new ActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The History property</summary>
        public HistoryRequestBuilder History { get =>
            new HistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new TimesheetsItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TimesheetsItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Me/Timesheets/{Timesheets%2Did}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new TimesheetsItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TimesheetsItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Me/Timesheets/{Timesheets%2Did}", rawUrl) {
        }
        /// <summary>
        /// Get my Timesheet by date.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<TimesheetModel_Me?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<TimesheetModel_Me> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<TimesheetModel_Me>(requestInfo, TimesheetModel_Me.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get my Timesheet by date.
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
        public TimesheetsItemRequestBuilder WithUrl(string rawUrl) {
            return new TimesheetsItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class TimesheetsItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
