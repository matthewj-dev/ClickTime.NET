// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.ResponseBodyListGet {
    /// <summary>
    /// Standardized API response structure.
    /// </summary>
    public class JobBudgetResourceManagementModel_JobBudgetLifetime : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClickTime.NET.Models.Get.JobBudgetResourceManagementModel_JobBudgetLifetime>? Data { get; set; }
#nullable restore
#else
        public List<ClickTime.NET.Models.Get.JobBudgetResourceManagementModel_JobBudgetLifetime> Data { get; set; }
#endif
        /// <summary>The errors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClickTime.NET.Models.APIError>? Errors { get; set; }
#nullable restore
#else
        public List<ClickTime.NET.Models.APIError> Errors { get; set; }
#endif
        /// <summary>The jsonapi property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public JobBudgetResourceManagementModel_JobBudgetLifetime_jsonapi? Jsonapi { get; set; }
#nullable restore
#else
        public JobBudgetResourceManagementModel_JobBudgetLifetime_jsonapi Jsonapi { get; set; }
#endif
        /// <summary>The meta property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public JobBudgetResourceManagementModel_JobBudgetLifetime_meta? Meta { get; set; }
#nullable restore
#else
        public JobBudgetResourceManagementModel_JobBudgetLifetime_meta Meta { get; set; }
#endif
        /// <summary>Paging data for an API response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Models.Page? Page { get; set; }
#nullable restore
#else
        public ClickTime.NET.Models.Page Page { get; set; }
#endif
        /// <summary>
        /// Instantiates a new JobBudgetResourceManagementModel_JobBudgetLifetime and sets the default values.
        /// </summary>
        public JobBudgetResourceManagementModel_JobBudgetLifetime() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static JobBudgetResourceManagementModel_JobBudgetLifetime CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JobBudgetResourceManagementModel_JobBudgetLifetime();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"data", n => { Data = n.GetCollectionOfObjectValues<ClickTime.NET.Models.Get.JobBudgetResourceManagementModel_JobBudgetLifetime>(ClickTime.NET.Models.Get.JobBudgetResourceManagementModel_JobBudgetLifetime.CreateFromDiscriminatorValue)?.ToList(); } },
                {"errors", n => { Errors = n.GetCollectionOfObjectValues<ClickTime.NET.Models.APIError>(ClickTime.NET.Models.APIError.CreateFromDiscriminatorValue)?.ToList(); } },
                {"jsonapi", n => { Jsonapi = n.GetObjectValue<JobBudgetResourceManagementModel_JobBudgetLifetime_jsonapi>(JobBudgetResourceManagementModel_JobBudgetLifetime_jsonapi.CreateFromDiscriminatorValue); } },
                {"meta", n => { Meta = n.GetObjectValue<JobBudgetResourceManagementModel_JobBudgetLifetime_meta>(JobBudgetResourceManagementModel_JobBudgetLifetime_meta.CreateFromDiscriminatorValue); } },
                {"page", n => { Page = n.GetObjectValue<ClickTime.NET.Models.Page>(ClickTime.NET.Models.Page.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ClickTime.NET.Models.Get.JobBudgetResourceManagementModel_JobBudgetLifetime>("data", Data);
            writer.WriteCollectionOfObjectValues<ClickTime.NET.Models.APIError>("errors", Errors);
            writer.WriteObjectValue<JobBudgetResourceManagementModel_JobBudgetLifetime_jsonapi>("jsonapi", Jsonapi);
            writer.WriteObjectValue<JobBudgetResourceManagementModel_JobBudgetLifetime_meta>("meta", Meta);
            writer.WriteObjectValue<ClickTime.NET.Models.Page>("page", Page);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
