// <auto-generated/>
using ClickTime.NET.Allocations.Jobs.Item.Users.Item.Month;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace ClickTime.NET.Allocations.Jobs.Item.Users.Item {
    /// <summary>
    /// Builds and executes requests for operations under \Allocations\Jobs\{jobID}\Users\{userID}
    /// </summary>
    public class WithUserItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The Month property</summary>
        public MonthRequestBuilder Month { get =>
            new MonthRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithUserItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUserItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Allocations/Jobs/{jobID}/Users/{userID}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithUserItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUserItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Allocations/Jobs/{jobID}/Users/{userID}", rawUrl) {
        }
    }
}
