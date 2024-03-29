// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Get {
    public class BillingRate_UserJobModel_Root : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The BillingRate property</summary>
        public double? BillingRate { get; set; }
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Models.Get.BasicJobModel_Job_Get.BillingRate_UserJobModel_Root? Job { get; set; }
#nullable restore
#else
        public ClickTime.NET.Models.Get.BasicJobModel_Job_Get.BillingRate_UserJobModel_Root Job { get; set; }
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
        public BillingRate_UserJobModel_Root_SecondaryBillingRateMode? SecondaryBillingRateMode { get; set; }
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Models.Get.BasicUserModel_User_Get.BillingRate_UserJobModel_Root? User { get; set; }
#nullable restore
#else
        public ClickTime.NET.Models.Get.BasicUserModel_User_Get.BillingRate_UserJobModel_Root User { get; set; }
#endif
        /// <summary>The UserDefaultBillingRate property</summary>
        public double? UserDefaultBillingRate { get; set; }
        /// <summary>The UserID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserID { get; set; }
#nullable restore
#else
        public string UserID { get; set; }
#endif
        /// <summary>
        /// Instantiates a new BillingRate_UserJobModel_Root and sets the default values.
        /// </summary>
        public BillingRate_UserJobModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BillingRate_UserJobModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BillingRate_UserJobModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"BillingRate", n => { BillingRate = n.GetDoubleValue(); } },
                {"Job", n => { Job = n.GetObjectValue<ClickTime.NET.Models.Get.BasicJobModel_Job_Get.BillingRate_UserJobModel_Root>(ClickTime.NET.Models.Get.BasicJobModel_Job_Get.BillingRate_UserJobModel_Root.CreateFromDiscriminatorValue); } },
                {"JobID", n => { JobID = n.GetStringValue(); } },
                {"SecondaryBillingRateMode", n => { SecondaryBillingRateMode = n.GetEnumValue<BillingRate_UserJobModel_Root_SecondaryBillingRateMode>(); } },
                {"User", n => { User = n.GetObjectValue<ClickTime.NET.Models.Get.BasicUserModel_User_Get.BillingRate_UserJobModel_Root>(ClickTime.NET.Models.Get.BasicUserModel_User_Get.BillingRate_UserJobModel_Root.CreateFromDiscriminatorValue); } },
                {"UserDefaultBillingRate", n => { UserDefaultBillingRate = n.GetDoubleValue(); } },
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
            writer.WriteObjectValue<ClickTime.NET.Models.Get.BasicJobModel_Job_Get.BillingRate_UserJobModel_Root>("Job", Job);
            writer.WriteStringValue("JobID", JobID);
            writer.WriteEnumValue<BillingRate_UserJobModel_Root_SecondaryBillingRateMode>("SecondaryBillingRateMode", SecondaryBillingRateMode);
            writer.WriteObjectValue<ClickTime.NET.Models.Get.BasicUserModel_User_Get.BillingRate_UserJobModel_Root>("User", User);
            writer.WriteDoubleValue("UserDefaultBillingRate", UserDefaultBillingRate);
            writer.WriteStringValue("UserID", UserID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
