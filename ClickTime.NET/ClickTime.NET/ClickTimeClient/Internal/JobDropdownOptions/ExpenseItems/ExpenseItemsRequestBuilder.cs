// <auto-generated/>
using ClickTime.NET.Internal.JobDropdownOptions.ExpenseItems.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace ClickTime.NET.Internal.JobDropdownOptions.ExpenseItems {
    /// <summary>
    /// Builds and executes requests for operations under \Internal\JobDropdownOptions\ExpenseItems
    /// </summary>
    public class ExpenseItemsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the ClickTime.NET.Internal.JobDropdownOptions.ExpenseItems.item collection</summary>
        /// <param name="position">    Required</param>
        public WithExpenseItemItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("expenseItemID", position);
            return new WithExpenseItemItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ExpenseItemsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ExpenseItemsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Internal/JobDropdownOptions/ExpenseItems", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ExpenseItemsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ExpenseItemsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Internal/JobDropdownOptions/ExpenseItems", rawUrl) {
        }
    }
}