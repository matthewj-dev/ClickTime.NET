// <auto-generated/>
using ClickTime.NET.Allocations.Jobs.Item.Users.Item.Month.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace ClickTime.NET.Allocations.Jobs.Item.Users.Item.Month {
    /// <summary>
    /// Builds and executes requests for operations under \Allocations\Jobs\{jobID}\Users\{userID}\Month
    /// </summary>
    public class MonthRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the ClickTime.NET.Allocations.Jobs.item.Users.item.Month.item collection</summary>
        /// <param name="position">    Required</param>
        public WithMonthItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("month", position);
            return new WithMonthItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new MonthRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MonthRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Allocations/Jobs/{jobID}/Users/{userID}/Month", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new MonthRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MonthRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Allocations/Jobs/{jobID}/Users/{userID}/Month", rawUrl) {
        }
    }
}
