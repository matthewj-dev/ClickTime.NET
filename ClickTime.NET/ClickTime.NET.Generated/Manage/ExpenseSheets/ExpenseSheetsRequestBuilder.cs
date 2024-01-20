// <auto-generated/>
using ClickTime.NET.Generated.Manage.ExpenseSheets.Item;
using ClickTime.NET.Generated.Models.Post;
using ClickTime.NET.Generated.Models.ResponseBodyGet;
using ClickTime.NET.Generated.Models.ResponseBodyListGet;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ClickTime.NET.Generated.Manage.ExpenseSheets {
    /// <summary>
    /// Builds and executes requests for operations under \Manage\ExpenseSheets
    /// </summary>
    public class ExpenseSheetsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the ClickTime.NET.Generated.Manage.ExpenseSheets.item collection</summary>
        /// <param name="position">    Required</param>
        public WithExpenseSheetItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("expenseSheetID", position);
            return new WithExpenseSheetItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ExpenseSheetsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ExpenseSheetsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Manage/ExpenseSheets{?ID*,FromExpenseSheetDate*,ToExpenseSheetDate*,Status*,Paid*,UserID*,UserIsActive*,DivisionID*,EmploymentTypeID*,ExpenseDate*,SortBy*,limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ExpenseSheetsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ExpenseSheetsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Manage/ExpenseSheets{?ID*,FromExpenseSheetDate*,ToExpenseSheetDate*,Status*,Paid*,UserID*,UserIsActive*,DivisionID*,EmploymentTypeID*,ExpenseDate*,SortBy*,limit*,offset*}", rawUrl) {
        }
        /// <summary>
        ///   Company requirements:Company must have the Expenses optional module.  User requirements:Admin, or Manager with permissions to Approve Expenses.---# Sort Order:1. ExpenseSheetDate1. ID
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ClickTime.NET.Generated.Models.ResponseBodyListGet.ExpenseSheetModel_Root?> GetAsync(Action<RequestConfiguration<ExpenseSheetsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ClickTime.NET.Generated.Models.ResponseBodyListGet.ExpenseSheetModel_Root> GetAsync(Action<RequestConfiguration<ExpenseSheetsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<ClickTime.NET.Generated.Models.ResponseBodyListGet.ExpenseSheetModel_Root>(requestInfo, ClickTime.NET.Generated.Models.ResponseBodyListGet.ExpenseSheetModel_Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   Company requirements:Company must have the Expenses optional module.  User requirements:Admin, or Manager with permissions to Approve Expenses, and Override Expenses.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ClickTime.NET.Generated.Models.ResponseBodyGet.ExpenseSheetModel_Root?> PostAsync(ClickTime.NET.Generated.Models.Post.ExpenseSheetModel_Root body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ClickTime.NET.Generated.Models.ResponseBodyGet.ExpenseSheetModel_Root> PostAsync(ClickTime.NET.Generated.Models.Post.ExpenseSheetModel_Root body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<ClickTime.NET.Generated.Models.ResponseBodyGet.ExpenseSheetModel_Root>(requestInfo, ClickTime.NET.Generated.Models.ResponseBodyGet.ExpenseSheetModel_Root.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        ///   Company requirements:Company must have the Expenses optional module.  User requirements:Admin, or Manager with permissions to Approve Expenses.---# Sort Order:1. ExpenseSheetDate1. ID
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ExpenseSheetsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ExpenseSheetsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        ///   Company requirements:Company must have the Expenses optional module.  User requirements:Admin, or Manager with permissions to Approve Expenses, and Override Expenses.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ClickTime.NET.Generated.Models.Post.ExpenseSheetModel_Root body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ClickTime.NET.Generated.Models.Post.ExpenseSheetModel_Root body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        public ExpenseSheetsRequestBuilder WithUrl(string rawUrl) {
            return new ExpenseSheetsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        ///   Company requirements:Company must have the Expenses optional module.  User requirements:Admin, or Manager with permissions to Approve Expenses.---# Sort Order:1. ExpenseSheetDate1. ID
        /// </summary>
        public class ExpenseSheetsRequestBuilderGetQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? DivisionID { get; set; }
#nullable restore
#else
            public string[] DivisionID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? EmploymentTypeID { get; set; }
#nullable restore
#else
            public string[] EmploymentTypeID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? ExpenseDate { get; set; }
#nullable restore
#else
            public string[] ExpenseDate { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? FromExpenseSheetDate { get; set; }
#nullable restore
#else
            public string FromExpenseSheetDate { get; set; }
#endif
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
            public bool?[]? Paid { get; set; }
#nullable restore
#else
            public bool?[] Paid { get; set; }
#endif
            /// <summary>Supported values: Date, ExpenseItemCount, ReimbursableAmount, Status, Title, TotalAmount, User. In order to specify to sort data in a “descending” order prepend the SortBy value with a hyphen such as “SortBy=-Date” or “SortBy=-TotalAmount”</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? SortBy { get; set; }
#nullable restore
#else
            public string SortBy { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? Status { get; set; }
#nullable restore
#else
            public string[] Status { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? ToExpenseSheetDate { get; set; }
#nullable restore
#else
            public string ToExpenseSheetDate { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string[]? UserID { get; set; }
#nullable restore
#else
            public string[] UserID { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public bool?[]? UserIsActive { get; set; }
#nullable restore
#else
            public bool?[] UserIsActive { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ExpenseSheetsRequestBuilderGetRequestConfiguration : RequestConfiguration<ExpenseSheetsRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ExpenseSheetsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
