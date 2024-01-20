// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Generated.Models.Get {
    public class BillingRate_TaskUserModel_Root : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The BillingRate property</summary>
        public double? BillingRate { get; set; }
        /// <summary>The SecondaryBillingRateMode property</summary>
        public BillingRate_TaskUserModel_Root_SecondaryBillingRateMode? SecondaryBillingRateMode { get; set; }
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Generated.Models.Get.BasicTaskModel_Task_Get.BillingRate_TaskUserModel_Root? Task { get; set; }
#nullable restore
#else
        public ClickTime.NET.Generated.Models.Get.BasicTaskModel_Task_Get.BillingRate_TaskUserModel_Root Task { get; set; }
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
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Generated.Models.Get.BasicUserModel_User_Get.BillingRate_TaskUserModel_Root? User { get; set; }
#nullable restore
#else
        public ClickTime.NET.Generated.Models.Get.BasicUserModel_User_Get.BillingRate_TaskUserModel_Root User { get; set; }
#endif
        /// <summary>The UserID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserID { get; set; }
#nullable restore
#else
        public string UserID { get; set; }
#endif
        /// <summary>
        /// Instantiates a new BillingRate_TaskUserModel_Root and sets the default values.
        /// </summary>
        public BillingRate_TaskUserModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BillingRate_TaskUserModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BillingRate_TaskUserModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"BillingRate", n => { BillingRate = n.GetDoubleValue(); } },
                {"SecondaryBillingRateMode", n => { SecondaryBillingRateMode = n.GetEnumValue<BillingRate_TaskUserModel_Root_SecondaryBillingRateMode>(); } },
                {"Task", n => { Task = n.GetObjectValue<ClickTime.NET.Generated.Models.Get.BasicTaskModel_Task_Get.BillingRate_TaskUserModel_Root>(ClickTime.NET.Generated.Models.Get.BasicTaskModel_Task_Get.BillingRate_TaskUserModel_Root.CreateFromDiscriminatorValue); } },
                {"TaskDefaultBillingRate", n => { TaskDefaultBillingRate = n.GetDoubleValue(); } },
                {"TaskID", n => { TaskID = n.GetStringValue(); } },
                {"User", n => { User = n.GetObjectValue<ClickTime.NET.Generated.Models.Get.BasicUserModel_User_Get.BillingRate_TaskUserModel_Root>(ClickTime.NET.Generated.Models.Get.BasicUserModel_User_Get.BillingRate_TaskUserModel_Root.CreateFromDiscriminatorValue); } },
                {"UserID", n => { UserID = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("BillingRate", BillingRate);
            writer.WriteEnumValue<BillingRate_TaskUserModel_Root_SecondaryBillingRateMode>("SecondaryBillingRateMode", SecondaryBillingRateMode);
            writer.WriteObjectValue<ClickTime.NET.Generated.Models.Get.BasicTaskModel_Task_Get.BillingRate_TaskUserModel_Root>("Task", Task);
            writer.WriteDoubleValue("TaskDefaultBillingRate", TaskDefaultBillingRate);
            writer.WriteStringValue("TaskID", TaskID);
            writer.WriteObjectValue<ClickTime.NET.Generated.Models.Get.BasicUserModel_User_Get.BillingRate_TaskUserModel_Root>("User", User);
            writer.WriteStringValue("UserID", UserID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
