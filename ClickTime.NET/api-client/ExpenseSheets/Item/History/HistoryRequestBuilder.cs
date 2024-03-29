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
namespace ClickTime.NET.ExpenseSheets.Item.History {
    /// <summary>
    /// Builds and executes requests for operations under \ExpenseSheets\{expenseSheetID}\History
    /// </summary>
    public class HistoryRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new HistoryRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HistoryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/ExpenseSheets/{expenseSheetID}/History{?limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new HistoryRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HistoryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/ExpenseSheets/{expenseSheetID}/History{?limit*,offset*}", rawUrl) {
        }
        /// <summary>
        ///   Company requirements:Company must have the Expenses optional module.  User requirements:Admin, or Manager with permissions to Review Expenses.---# Sort Order:1. ChangeDate (Desc)
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ExpenseSheetHistoryModel_Root?> GetAsync(Action<RequestConfiguration<HistoryRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ExpenseSheetHistoryModel_Root> GetAsync(Action<RequestConfiguration<HistoryRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<ExpenseSheetHistoryModel_Root>(requestInfo, ExpenseSheetHistoryModel_Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   Company requirements:Company must have the Expenses optional module.  User requirements:Admin, or Manager with permissions to Review Expenses.---# Sort Order:1. ChangeDate (Desc)
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<HistoryRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<HistoryRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public HistoryRequestBuilder WithUrl(string rawUrl) {
            return new HistoryRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        ///   Company requirements:Company must have the Expenses optional module.  User requirements:Admin, or Manager with permissions to Review Expenses.---# Sort Order:1. ChangeDate (Desc)
        /// </summary>
        public class HistoryRequestBuilderGetQueryParameters {
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            [QueryParameter("offset")]
            public int? Offset { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class HistoryRequestBuilderGetRequestConfiguration : RequestConfiguration<HistoryRequestBuilderGetQueryParameters> {
        }
    }
}
