// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Get {
    public class JobBudgetResourceManagementModel_JobBudgetLifetime : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Amount property</summary>
        public int? Amount { get; set; }
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Models.Get.BasicJobModel_Job_Get.JobBudgetResourceManagementModel_JobBudgetLifetime? Job { get; set; }
#nullable restore
#else
        public ClickTime.NET.Models.Get.BasicJobModel_Job_Get.JobBudgetResourceManagementModel_JobBudgetLifetime Job { get; set; }
#endif
        /// <summary>The JobID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobID { get; set; }
#nullable restore
#else
        public string JobID { get; set; }
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
                {"Amount", n => { Amount = n.GetIntValue(); } },
                {"Job", n => { Job = n.GetObjectValue<ClickTime.NET.Models.Get.BasicJobModel_Job_Get.JobBudgetResourceManagementModel_JobBudgetLifetime>(ClickTime.NET.Models.Get.BasicJobModel_Job_Get.JobBudgetResourceManagementModel_JobBudgetLifetime.CreateFromDiscriminatorValue); } },
                {"JobID", n => { JobID = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("Amount", Amount);
            writer.WriteObjectValue<ClickTime.NET.Models.Get.BasicJobModel_Job_Get.JobBudgetResourceManagementModel_JobBudgetLifetime>("Job", Job);
            writer.WriteStringValue("JobID", JobID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}