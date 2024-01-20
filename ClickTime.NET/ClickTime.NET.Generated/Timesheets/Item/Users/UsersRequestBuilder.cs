// <auto-generated/>
using ClickTime.NET.Generated.Timesheets.Item.Users.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace ClickTime.NET.Generated.Timesheets.Item.Users {
    /// <summary>
    /// Builds and executes requests for operations under \Timesheets\{Timesheets-id}\Users
    /// </summary>
    public class UsersRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the ClickTime.NET.Generated.Timesheets.item.Users.item collection</summary>
        /// <param name="position">    Required</param>
        public WithUserItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("userID", position);
            return new WithUserItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new UsersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Timesheets/{Timesheets%2Did}/Users", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UsersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Timesheets/{Timesheets%2Did}/Users", rawUrl) {
        }
    }
}
