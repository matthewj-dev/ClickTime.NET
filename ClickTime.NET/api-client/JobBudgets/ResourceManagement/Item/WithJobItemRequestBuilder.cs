// <auto-generated/>
using ClickTime.NET.JobBudgets.ResourceManagement.Item.LifetimeBillings;
using ClickTime.NET.JobBudgets.ResourceManagement.Item.Monthly;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace ClickTime.NET.JobBudgets.ResourceManagement.Item {
    /// <summary>
    /// Builds and executes requests for operations under \JobBudgets\ResourceManagement\{jobID}
    /// </summary>
    public class WithJobItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The LifetimeBillings property</summary>
        public LifetimeBillingsRequestBuilder LifetimeBillings { get =>
            new LifetimeBillingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Monthly property</summary>
        public MonthlyRequestBuilder Monthly { get =>
            new MonthlyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithJobItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithJobItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/JobBudgets/ResourceManagement/{jobID}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithJobItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithJobItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/JobBudgets/ResourceManagement/{jobID}", rawUrl) {
        }
    }
}