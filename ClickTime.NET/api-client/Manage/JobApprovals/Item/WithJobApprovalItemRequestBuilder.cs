// <auto-generated/>
using ClickTime.NET.Manage.JobApprovals.Item.TimeEntries;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace ClickTime.NET.Manage.JobApprovals.Item {
    /// <summary>
    /// Builds and executes requests for operations under \Manage\JobApprovals\{jobApprovalID}
    /// </summary>
    public class WithJobApprovalItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The TimeEntries property</summary>
        public TimeEntriesRequestBuilder TimeEntries { get =>
            new TimeEntriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithJobApprovalItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithJobApprovalItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Manage/JobApprovals/{jobApprovalID}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithJobApprovalItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithJobApprovalItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Manage/JobApprovals/{jobApprovalID}", rawUrl) {
        }
    }
}
