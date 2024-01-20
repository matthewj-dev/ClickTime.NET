// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Patch {
    public class UserModel_Me : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>  User requirements:Security Level(s): Admin, Manager (Add/Edit Costs)  Company requirements:Salaried Costs</summary>
        public UserModel_Me_CostModel? CostModel { get; set; }
        /// <summary>  User requirements:Security Level(s): Admin, Manager (Add/Edit Costs)  Company requirements:Salaried Costs</summary>
        public double? CostPerTimesheet { get; set; }
        /// <summary>  Company requirements:Expense Permission</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultExpenseTypeID { get; set; }
#nullable restore
#else
        public string DefaultExpenseTypeID { get; set; }
#endif
        /// <summary>  Company requirements:Expense Permission</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultPaymentTypeID { get; set; }
#nullable restore
#else
        public string DefaultPaymentTypeID { get; set; }
#endif
        /// <summary>The DefaultTaskID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultTaskID { get; set; }
#nullable restore
#else
        public string DefaultTaskID { get; set; }
#endif
        /// <summary>The ExpenseSheetApprovedAlert property</summary>
        public bool? ExpenseSheetApprovedAlert { get; set; }
        /// <summary>The ExpenseSheetPaidAlert property</summary>
        public bool? ExpenseSheetPaidAlert { get; set; }
        /// <summary>The GDPRConsentStatus property</summary>
        public UserModel_Me_GDPRConsentStatus? GDPRConsentStatus { get; set; }
        /// <summary>  Company requirements:Optional module(s): Resource Management</summary>
        public bool? IncludeInRM { get; set; }
        /// <summary>The JobSelectionMethod property</summary>
        public UserModel_Me_JobSelectionMethod? JobSelectionMethod { get; set; }
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The NumEntries property</summary>
        public int? NumEntries { get; set; }
        /// <summary>The PreferredTimeEntryView property</summary>
        public UserModel_Me_PreferredTimeEntryView? PreferredTimeEntryView { get; set; }
        /// <summary>The PreferredTimeFormat property</summary>
        public UserModel_Me_PreferredTimeFormat? PreferredTimeFormat { get; set; }
        /// <summary>The SkipWeekend property</summary>
        public bool? SkipWeekend { get; set; }
        /// <summary>The TimesheetApprovedAlert property</summary>
        public bool? TimesheetApprovedAlert { get; set; }
        /// <summary>
        /// Instantiates a new UserModel_Me and sets the default values.
        /// </summary>
        public UserModel_Me() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserModel_Me CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserModel_Me();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CostModel", n => { CostModel = n.GetEnumValue<UserModel_Me_CostModel>(); } },
                {"CostPerTimesheet", n => { CostPerTimesheet = n.GetDoubleValue(); } },
                {"DefaultExpenseTypeID", n => { DefaultExpenseTypeID = n.GetStringValue(); } },
                {"DefaultPaymentTypeID", n => { DefaultPaymentTypeID = n.GetStringValue(); } },
                {"DefaultTaskID", n => { DefaultTaskID = n.GetStringValue(); } },
                {"ExpenseSheetApprovedAlert", n => { ExpenseSheetApprovedAlert = n.GetBoolValue(); } },
                {"ExpenseSheetPaidAlert", n => { ExpenseSheetPaidAlert = n.GetBoolValue(); } },
                {"GDPRConsentStatus", n => { GDPRConsentStatus = n.GetEnumValue<UserModel_Me_GDPRConsentStatus>(); } },
                {"IncludeInRM", n => { IncludeInRM = n.GetBoolValue(); } },
                {"JobSelectionMethod", n => { JobSelectionMethod = n.GetEnumValue<UserModel_Me_JobSelectionMethod>(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"NumEntries", n => { NumEntries = n.GetIntValue(); } },
                {"PreferredTimeEntryView", n => { PreferredTimeEntryView = n.GetEnumValue<UserModel_Me_PreferredTimeEntryView>(); } },
                {"PreferredTimeFormat", n => { PreferredTimeFormat = n.GetEnumValue<UserModel_Me_PreferredTimeFormat>(); } },
                {"SkipWeekend", n => { SkipWeekend = n.GetBoolValue(); } },
                {"TimesheetApprovedAlert", n => { TimesheetApprovedAlert = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<UserModel_Me_CostModel>("CostModel", CostModel);
            writer.WriteDoubleValue("CostPerTimesheet", CostPerTimesheet);
            writer.WriteStringValue("DefaultExpenseTypeID", DefaultExpenseTypeID);
            writer.WriteStringValue("DefaultPaymentTypeID", DefaultPaymentTypeID);
            writer.WriteStringValue("DefaultTaskID", DefaultTaskID);
            writer.WriteBoolValue("ExpenseSheetApprovedAlert", ExpenseSheetApprovedAlert);
            writer.WriteBoolValue("ExpenseSheetPaidAlert", ExpenseSheetPaidAlert);
            writer.WriteEnumValue<UserModel_Me_GDPRConsentStatus>("GDPRConsentStatus", GDPRConsentStatus);
            writer.WriteBoolValue("IncludeInRM", IncludeInRM);
            writer.WriteEnumValue<UserModel_Me_JobSelectionMethod>("JobSelectionMethod", JobSelectionMethod);
            writer.WriteStringValue("Name", Name);
            writer.WriteIntValue("NumEntries", NumEntries);
            writer.WriteEnumValue<UserModel_Me_PreferredTimeEntryView>("PreferredTimeEntryView", PreferredTimeEntryView);
            writer.WriteEnumValue<UserModel_Me_PreferredTimeFormat>("PreferredTimeFormat", PreferredTimeFormat);
            writer.WriteBoolValue("SkipWeekend", SkipWeekend);
            writer.WriteBoolValue("TimesheetApprovedAlert", TimesheetApprovedAlert);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}