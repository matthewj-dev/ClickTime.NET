// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Get {
    public class BillingRate_TaskJobModel_Root : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The BillingRate property</summary>
        public double? BillingRate { get; set; }
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Models.Get.BasicJobModel_Job_Get.BillingRate_TaskJobModel_Root? Job { get; set; }
#nullable restore
#else
        public ClickTime.NET.Models.Get.BasicJobModel_Job_Get.BillingRate_TaskJobModel_Root Job { get; set; }
#endif
        /// <summary>The JobID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobID { get; set; }
#nullable restore
#else
        public string JobID { get; set; }
#endif
        /// <summary>The SecondaryBillingRateMode property</summary>
        public BillingRate_TaskJobModel_Root_SecondaryBillingRateMode? SecondaryBillingRateMode { get; set; }
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Models.Get.BasicTaskModel_Task_Get.BillingRate_TaskJobModel_Root? Task { get; set; }
#nullable restore
#else
        public ClickTime.NET.Models.Get.BasicTaskModel_Task_Get.BillingRate_TaskJobModel_Root Task { get; set; }
#endif
        /// <summary>The TaskDefaultBillingRate property</summary>
        public double? TaskDefaultBillingRate { get; set; }
        /// <summary>The TaskID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaskID { get; set; }
#nullable restore
#else
        public string TaskID { get; set; }
#endif
        /// <summary>
        /// Instantiates a new BillingRate_TaskJobModel_Root and sets the default values.
        /// </summary>
        public BillingRate_TaskJobModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BillingRate_TaskJobModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BillingRate_TaskJobModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"BillingRate", n => { BillingRate = n.GetDoubleValue(); } },
                {"Job", n => { Job = n.GetObjectValue<ClickTime.NET.Models.Get.BasicJobModel_Job_Get.BillingRate_TaskJobModel_Root>(ClickTime.NET.Models.Get.BasicJobModel_Job_Get.BillingRate_TaskJobModel_Root.CreateFromDiscriminatorValue); } },
                {"JobID", n => { JobID = n.GetStringValue(); } },
                {"SecondaryBillingRateMode", n => { SecondaryBillingRateMode = n.GetEnumValue<BillingRate_TaskJobModel_Root_SecondaryBillingRateMode>(); } },
                {"Task", n => { Task = n.GetObjectValue<ClickTime.NET.Models.Get.BasicTaskModel_Task_Get.BillingRate_TaskJobModel_Root>(ClickTime.NET.Models.Get.BasicTaskModel_Task_Get.BillingRate_TaskJobModel_Root.CreateFromDiscriminatorValue); } },
                {"TaskDefaultBillingRate", n => { TaskDefaultBillingRate = n.GetDoubleValue(); } },
                {"TaskID", n => { TaskID = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("BillingRate", BillingRate);
            writer.WriteObjectValue<ClickTime.NET.Models.Get.BasicJobModel_Job_Get.BillingRate_TaskJobModel_Root>("Job", Job);
            writer.WriteStringValue("JobID", JobID);
            writer.WriteEnumValue<BillingRate_TaskJobModel_Root_SecondaryBillingRateMode>("SecondaryBillingRateMode", SecondaryBillingRateMode);
            writer.WriteObjectValue<ClickTime.NET.Models.Get.BasicTaskModel_Task_Get.BillingRate_TaskJobModel_Root>("Task", Task);
            writer.WriteDoubleValue("TaskDefaultBillingRate", TaskDefaultBillingRate);
            writer.WriteStringValue("TaskID", TaskID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
