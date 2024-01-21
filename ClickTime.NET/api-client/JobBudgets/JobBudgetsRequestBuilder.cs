// <auto-generated/>
using ClickTime.NET.JobBudgets.ResourceManagement;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace ClickTime.NET.JobBudgets {
    /// <summary>
    /// Builds and executes requests for operations under \JobBudgets
    /// </summary>
    public class JobBudgetsRequestBuilder : BaseRequestBuilder {
        /// <summary>The ResourceManagement property</summary>
        public ResourceManagementRequestBuilder ResourceManagement { get =>
            new ResourceManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new JobBudgetsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JobBudgetsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/JobBudgets", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new JobBudgetsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JobBudgetsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/JobBudgets", rawUrl) {
        }
    }
}