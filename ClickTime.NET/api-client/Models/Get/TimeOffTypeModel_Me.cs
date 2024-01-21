// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Get {
    public class TimeOffTypeModel_Me : IAdditionalDataHolder, IParsable {
        /// <summary>  Company requirements:Optional module(s): Time Off Management</summary>
        public double? AccrualRate { get; set; }
        /// <summary>  Company requirements:Optional module(s): Time Off Management</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccrualStartDate { get; set; }
#nullable restore
#else
        public string AccrualStartDate { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>  Request requirements:Verbose=true  Company requirements:Optional module(s): Time Off Management</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Models.Get.BasicUserModel_Approver_Get.TimeOffTypeModel_Me? Approver { get; set; }
#nullable restore
#else
        public ClickTime.NET.Models.Get.BasicUserModel_Approver_Get.TimeOffTypeModel_Me Approver { get; set; }
#endif
        /// <summary>  Company requirements:Optional module(s): Time Off Management</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApproverID { get; set; }
#nullable restore
#else
        public string ApproverID { get; set; }
#endif
        /// <summary>The CurrentBalance property</summary>
        public double? CurrentBalance { get; set; }
        /// <summary>  User requirements:Security Level(s): Admin  Company requirements:Custom Fields must be configured for TimeOffType.Custom Fields on Leave Types</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TimeOffTypeModel_Me_CustomFields? CustomFields { get; set; }
#nullable restore
#else
        public TimeOffTypeModel_Me_CustomFields CustomFields { get; set; }
#endif
        /// <summary>  Company requirements:Optional module(s): Time Off ManagementCanViewWorkTypeBalanceDashboard</summary>
        public bool? DisplayOnTimeEntryPages { get; set; }
        /// <summary>The ID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ID { get; set; }
#nullable restore
#else
        public string ID { get; set; }
#endif
        /// <summary>The IsActive property</summary>
        public bool? IsActive { get; set; }
        /// <summary>  Request requirements:CTLegacyScramble=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LegacyID { get; set; }
#nullable restore
#else
        public string LegacyID { get; set; }
#endif
        /// <summary>  Company requirements:Optional module(s): Time Off Management</summary>
        public double? MaximumBalance { get; set; }
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The Notes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes { get; set; }
#nullable restore
#else
        public string Notes { get; set; }
#endif
        /// <summary>The RequiresApproval property</summary>
        public bool? RequiresApproval { get; set; }
        /// <summary>
        /// Instantiates a new TimeOffTypeModel_Me and sets the default values.
        /// </summary>
        public TimeOffTypeModel_Me() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimeOffTypeModel_Me CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeOffTypeModel_Me();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AccrualRate", n => { AccrualRate = n.GetDoubleValue(); } },
                {"AccrualStartDate", n => { AccrualStartDate = n.GetStringValue(); } },
                {"Approver", n => { Approver = n.GetObjectValue<ClickTime.NET.Models.Get.BasicUserModel_Approver_Get.TimeOffTypeModel_Me>(ClickTime.NET.Models.Get.BasicUserModel_Approver_Get.TimeOffTypeModel_Me.CreateFromDiscriminatorValue); } },
                {"ApproverID", n => { ApproverID = n.GetStringValue(); } },
                {"CurrentBalance", n => { CurrentBalance = n.GetDoubleValue(); } },
                {"CustomFields", n => { CustomFields = n.GetObjectValue<TimeOffTypeModel_Me_CustomFields>(TimeOffTypeModel_Me_CustomFields.CreateFromDiscriminatorValue); } },
                {"DisplayOnTimeEntryPages", n => { DisplayOnTimeEntryPages = n.GetBoolValue(); } },
                {"ID", n => { ID = n.GetStringValue(); } },
                {"IsActive", n => { IsActive = n.GetBoolValue(); } },
                {"LegacyID", n => { LegacyID = n.GetStringValue(); } },
                {"MaximumBalance", n => { MaximumBalance = n.GetDoubleValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"Notes", n => { Notes = n.GetStringValue(); } },
                {"RequiresApproval", n => { RequiresApproval = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("AccrualRate", AccrualRate);
            writer.WriteStringValue("AccrualStartDate", AccrualStartDate);
            writer.WriteObjectValue<ClickTime.NET.Models.Get.BasicUserModel_Approver_Get.TimeOffTypeModel_Me>("Approver", Approver);
            writer.WriteStringValue("ApproverID", ApproverID);
            writer.WriteDoubleValue("CurrentBalance", CurrentBalance);
            writer.WriteObjectValue<TimeOffTypeModel_Me_CustomFields>("CustomFields", CustomFields);
            writer.WriteBoolValue("DisplayOnTimeEntryPages", DisplayOnTimeEntryPages);
            writer.WriteStringValue("ID", ID);
            writer.WriteBoolValue("IsActive", IsActive);
            writer.WriteStringValue("LegacyID", LegacyID);
            writer.WriteDoubleValue("MaximumBalance", MaximumBalance);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("Notes", Notes);
            writer.WriteBoolValue("RequiresApproval", RequiresApproval);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}