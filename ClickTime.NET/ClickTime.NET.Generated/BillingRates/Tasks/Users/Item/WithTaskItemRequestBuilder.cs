// <auto-generated/>
using ClickTime.NET.Generated.BillingRates.Tasks.Users.Item.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace ClickTime.NET.Generated.BillingRates.Tasks.Users.Item {
    /// <summary>
    /// Builds and executes requests for operations under \BillingRates\Tasks\Users\{taskID}
    /// </summary>
    public class WithTaskItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the ClickTime.NET.Generated.BillingRates.Tasks.Users.item.item collection</summary>
        /// <param name="position">    Required</param>
        public WithUserItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("userID", position);
            return new WithUserItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new WithTaskItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTaskItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/BillingRates/Tasks/Users/{taskID}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithTaskItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTaskItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/BillingRates/Tasks/Users/{taskID}", rawUrl) {
        }
    }
}
