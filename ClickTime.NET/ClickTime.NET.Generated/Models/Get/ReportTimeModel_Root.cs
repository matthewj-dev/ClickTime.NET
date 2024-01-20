// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Generated.Models.Get {
    public class ReportTimeModel_Root : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>  User requirements:Security Level(s): Admin, Manager (View Billingrates)</summary>
        public double? BillingRate { get; set; }
        /// <summary>The BreakTime property</summary>
        public double? BreakTime { get; set; }
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>  User requirements:Security Level(s): Admin, Manager (View Costs)</summary>
        public double? CostRate { get; set; }
        /// <summary>  Request requirements:Verbose=true  Company requirements:Custom Fields must be configured for Time Entries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ReportTimeModel_Root_CustomFields? CustomFields { get; set; }
#nullable restore
#else
        public ReportTimeModel_Root_CustomFields CustomFields { get; set; }
#endif
        /// <summary>The Date property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Date { get; set; }
#nullable restore
#else
        public string Date { get; set; }
#endif
        /// <summary>The EndTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EndTime { get; set; }
#nullable restore
#else
        public string EndTime { get; set; }
#endif
        /// <summary>The Hours property</summary>
        public double? Hours { get; set; }
        /// <summary>The ID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ID { get; set; }
#nullable restore
#else
        public string ID { get; set; }
#endif
        /// <summary>  User requirements:Security Level(s): Admin, Manager</summary>
        public bool? IsBillable { get; set; }
        /// <summary>The JobID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobID { get; set; }
#nullable restore
#else
        public string JobID { get; set; }
#endif
        /// <summary>  Request requirements:CTLegacyScramble=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LegacyID { get; set; }
#nullable restore
#else
        public string LegacyID { get; set; }
#endif
        /// <summary>The StartTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartTime { get; set; }
#nullable restore
#else
        public string StartTime { get; set; }
#endif
        /// <summary>The TaskID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaskID { get; set; }
#nullable restore
#else
        public string TaskID { get; set; }
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
        /// Instantiates a new ReportTimeModel_Root and sets the default values.
        /// </summary>
        public ReportTimeModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ReportTimeModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReportTimeModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"BillingRate", n => { BillingRate = n.GetDoubleValue(); } },
                {"BreakTime", n => { BreakTime = n.GetDoubleValue(); } },
                {"Comment", n => { Comment = n.GetStringValue(); } },
                {"CostRate", n => { CostRate = n.GetDoubleValue(); } },
                {"CustomFields", n => { CustomFields = n.GetObjectValue<ReportTimeModel_Root_CustomFields>(ReportTimeModel_Root_CustomFields.CreateFromDiscriminatorValue); } },
                {"Date", n => { Date = n.GetStringValue(); } },
                {"EndTime", n => { EndTime = n.GetStringValue(); } },
                {"Hours", n => { Hours = n.GetDoubleValue(); } },
                {"ID", n => { ID = n.GetStringValue(); } },
                {"IsBillable", n => { IsBillable = n.GetBoolValue(); } },
                {"JobID", n => { JobID = n.GetStringValue(); } },
                {"LegacyID", n => { LegacyID = n.GetStringValue(); } },
                {"StartTime", n => { StartTime = n.GetStringValue(); } },
                {"TaskID", n => { TaskID = n.GetStringValue(); } },
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
            writer.WriteDoubleValue("BreakTime", BreakTime);
            writer.WriteStringValue("Comment", Comment);
            writer.WriteDoubleValue("CostRate", CostRate);
            writer.WriteObjectValue<ReportTimeModel_Root_CustomFields>("CustomFields", CustomFields);
            writer.WriteStringValue("Date", Date);
            writer.WriteStringValue("EndTime", EndTime);
            writer.WriteDoubleValue("Hours", Hours);
            writer.WriteStringValue("ID", ID);
            writer.WriteBoolValue("IsBillable", IsBillable);
            writer.WriteStringValue("JobID", JobID);
            writer.WriteStringValue("LegacyID", LegacyID);
            writer.WriteStringValue("StartTime", StartTime);
            writer.WriteStringValue("TaskID", TaskID);
            writer.WriteStringValue("UserID", UserID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
