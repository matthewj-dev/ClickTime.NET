// <auto-generated/>
using ClickTime.NET.BillingRates.Users.Clients;
using ClickTime.NET.BillingRates.Users.Jobs;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace ClickTime.NET.BillingRates.Users {
    /// <summary>
    /// Builds and executes requests for operations under \BillingRates\Users
    /// </summary>
    public class UsersRequestBuilder : BaseRequestBuilder {
        /// <summary>The Clients property</summary>
        public ClientsRequestBuilder Clients { get =>
            new ClientsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Jobs property</summary>
        public JobsRequestBuilder Jobs { get =>
            new JobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new UsersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/BillingRates/Users", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UsersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/BillingRates/Users", rawUrl) {
        }
    }
}
