// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Post {
    public class UserModel_Manage : IAdditionalDataHolder, IParsable {
        /// <summary>The AccountingPackageID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountingPackageID { get; set; }
#nullable restore
#else
        public string AccountingPackageID { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>  Company requirements:Timesheet Approval Permission</summary>
        public bool? AllowIncompleteTimesheetSubmission { get; set; }
        /// <summary>  User requirements:Security Level(s): Admin, Manager (Add/Edit Billingrates)  Company requirements:Billing rate model(s): User, User x Job, User x Client</summary>
        public double? BillingRate { get; set; }
        /// <summary>  User requirements:Security Level(s): Admin, Manager (Add/Edit Costs)  Company requirements:Salaried Costs</summary>
        public UserModel_Manage_CostModel? CostModel { get; set; }
        /// <summary>CostModel must be set to &quot;Salary&quot; in order to set CostPerTimesheet.  User requirements:Security Level(s): Admin, Manager (Add/Edit Costs)  Company requirements:Salaried Costs</summary>
        public double? CostPerTimesheet { get; set; }
        /// <summary>  User requirements:Security Level(s): Admin, Manager (Add/Edit Costs)</summary>
        public double? CostRate { get; set; }
        /// <summary>  Company requirements:Custom Fields must be configured for Users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserModel_Manage_CustomFields? CustomFields { get; set; }
#nullable restore
#else
        public UserModel_Manage_CustomFields CustomFields { get; set; }
#endif
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
        /// <summary>The DivisionID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DivisionID { get; set; }
#nullable restore
#else
        public string DivisionID { get; set; }
#endif
        /// <summary>The Email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The EmployeeNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmployeeNumber { get; set; }
#nullable restore
#else
        public string EmployeeNumber { get; set; }
#endif
        /// <summary>The EmploymentTypeID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmploymentTypeID { get; set; }
#nullable restore
#else
        public string EmploymentTypeID { get; set; }
#endif
        /// <summary>The EnableBreakTime property</summary>
        public bool? EnableBreakTime { get; set; }
        /// <summary>The EndDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EndDate { get; set; }
#nullable restore
#else
        public string EndDate { get; set; }
#endif
        /// <summary>SubjectToExpenseApproval must be true in order to set ExpenseApproverID.  Company requirements:Expense Permission</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExpenseApproverID { get; set; }
#nullable restore
#else
        public string ExpenseApproverID { get; set; }
#endif
        /// <summary>The GDPRConsentStatus property</summary>
        public UserModel_Manage_GDPRConsentStatus? GDPRConsentStatus { get; set; }
        /// <summary>  Company requirements:Optional module(s): Resource Management</summary>
        public bool? IncludeInRM { get; set; }
        /// <summary>The IsActive property</summary>
        public bool? IsActive { get; set; }
        /// <summary>The MinimumTimeHours property</summary>
        public double? MinimumTimeHours { get; set; }
        /// <summary>The MinimumTimePeriod property</summary>
        public UserModel_Manage_MinimumTimePeriod? MinimumTimePeriod { get; set; }
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
        /// <summary>The PayrollType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PayrollType { get; set; }
#nullable restore
#else
        public string PayrollType { get; set; }
#endif
        /// <summary>The PreferredTimeEntryView property</summary>
        public UserModel_Manage_PreferredTimeEntryView? PreferredTimeEntryView { get; set; }
        /// <summary>The PreferredTimeFormat property</summary>
        public UserModel_Manage_PreferredTimeFormat? PreferredTimeFormat { get; set; }
        /// <summary>The RequireComments property</summary>
        public bool? RequireComments { get; set; }
        /// <summary>The RequireStartEndTime property</summary>
        public bool? RequireStartEndTime { get; set; }
        /// <summary>The RequireStopwatch property</summary>
        public bool? RequireStopwatch { get; set; }
        /// <summary>The Role property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Role { get; set; }
#nullable restore
#else
        public string Role { get; set; }
#endif
        /// <summary>The SkipWeekend property</summary>
        public bool? SkipWeekend { get; set; }
        /// <summary>The StartDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartDate { get; set; }
#nullable restore
#else
        public string StartDate { get; set; }
#endif
        /// <summary>  Company requirements:Expense Permission</summary>
        public bool? SubjectToExpenseApproval { get; set; }
        /// <summary>  Company requirements:Timesheet Approval Permission</summary>
        public bool? SubjectToTimesheetApproval { get; set; }
        /// <summary>The SubjectToTimesheetCompletion property</summary>
        public bool? SubjectToTimesheetCompletion { get; set; }
        /// <summary>  Company requirements:Time Off Management Permission</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeOffApproverID { get; set; }
#nullable restore
#else
        public string TimeOffApproverID { get; set; }
#endif
        /// <summary>SubjectToTimesheetApproval must be true in order to set TimesheetApproverID.  Company requirements:Timesheet Approval Permission</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimesheetApproverID { get; set; }
#nullable restore
#else
        public string TimesheetApproverID { get; set; }
#endif
        /// <summary>  User requirements:Security Level(s): Admin, Manager (Add/Edit Billingrates)  Company requirements:Billing rate model(s): User, User x Job, User x Client</summary>
        public bool? UseCompanyBillingRate { get; set; }
        /// <summary>
        /// Instantiates a new UserModel_Manage and sets the default values.
        /// </summary>
        public UserModel_Manage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserModel_Manage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserModel_Manage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AccountingPackageID", n => { AccountingPackageID = n.GetStringValue(); } },
                {"AllowIncompleteTimesheetSubmission", n => { AllowIncompleteTimesheetSubmission = n.GetBoolValue(); } },
                {"BillingRate", n => { BillingRate = n.GetDoubleValue(); } },
                {"CostModel", n => { CostModel = n.GetEnumValue<UserModel_Manage_CostModel>(); } },
                {"CostPerTimesheet", n => { CostPerTimesheet = n.GetDoubleValue(); } },
                {"CostRate", n => { CostRate = n.GetDoubleValue(); } },
                {"CustomFields", n => { CustomFields = n.GetObjectValue<UserModel_Manage_CustomFields>(UserModel_Manage_CustomFields.CreateFromDiscriminatorValue); } },
                {"DefaultExpenseTypeID", n => { DefaultExpenseTypeID = n.GetStringValue(); } },
                {"DefaultPaymentTypeID", n => { DefaultPaymentTypeID = n.GetStringValue(); } },
                {"DefaultTaskID", n => { DefaultTaskID = n.GetStringValue(); } },
                {"DivisionID", n => { DivisionID = n.GetStringValue(); } },
                {"Email", n => { Email = n.GetStringValue(); } },
                {"EmployeeNumber", n => { EmployeeNumber = n.GetStringValue(); } },
                {"EmploymentTypeID", n => { EmploymentTypeID = n.GetStringValue(); } },
                {"EnableBreakTime", n => { EnableBreakTime = n.GetBoolValue(); } },
                {"EndDate", n => { EndDate = n.GetStringValue(); } },
                {"ExpenseApproverID", n => { ExpenseApproverID = n.GetStringValue(); } },
                {"GDPRConsentStatus", n => { GDPRConsentStatus = n.GetEnumValue<UserModel_Manage_GDPRConsentStatus>(); } },
                {"IncludeInRM", n => { IncludeInRM = n.GetBoolValue(); } },
                {"IsActive", n => { IsActive = n.GetBoolValue(); } },
                {"MinimumTimeHours", n => { MinimumTimeHours = n.GetDoubleValue(); } },
                {"MinimumTimePeriod", n => { MinimumTimePeriod = n.GetEnumValue<UserModel_Manage_MinimumTimePeriod>(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"Notes", n => { Notes = n.GetStringValue(); } },
                {"PayrollType", n => { PayrollType = n.GetStringValue(); } },
                {"PreferredTimeEntryView", n => { PreferredTimeEntryView = n.GetEnumValue<UserModel_Manage_PreferredTimeEntryView>(); } },
                {"PreferredTimeFormat", n => { PreferredTimeFormat = n.GetEnumValue<UserModel_Manage_PreferredTimeFormat>(); } },
                {"RequireComments", n => { RequireComments = n.GetBoolValue(); } },
                {"RequireStartEndTime", n => { RequireStartEndTime = n.GetBoolValue(); } },
                {"RequireStopwatch", n => { RequireStopwatch = n.GetBoolValue(); } },
                {"Role", n => { Role = n.GetStringValue(); } },
                {"SkipWeekend", n => { SkipWeekend = n.GetBoolValue(); } },
                {"StartDate", n => { StartDate = n.GetStringValue(); } },
                {"SubjectToExpenseApproval", n => { SubjectToExpenseApproval = n.GetBoolValue(); } },
                {"SubjectToTimesheetApproval", n => { SubjectToTimesheetApproval = n.GetBoolValue(); } },
                {"SubjectToTimesheetCompletion", n => { SubjectToTimesheetCompletion = n.GetBoolValue(); } },
                {"TimeOffApproverID", n => { TimeOffApproverID = n.GetStringValue(); } },
                {"TimesheetApproverID", n => { TimesheetApproverID = n.GetStringValue(); } },
                {"UseCompanyBillingRate", n => { UseCompanyBillingRate = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("AccountingPackageID", AccountingPackageID);
            writer.WriteBoolValue("AllowIncompleteTimesheetSubmission", AllowIncompleteTimesheetSubmission);
            writer.WriteDoubleValue("BillingRate", BillingRate);
            writer.WriteEnumValue<UserModel_Manage_CostModel>("CostModel", CostModel);
            writer.WriteDoubleValue("CostPerTimesheet", CostPerTimesheet);
            writer.WriteDoubleValue("CostRate", CostRate);
            writer.WriteObjectValue<UserModel_Manage_CustomFields>("CustomFields", CustomFields);
            writer.WriteStringValue("DefaultExpenseTypeID", DefaultExpenseTypeID);
            writer.WriteStringValue("DefaultPaymentTypeID", DefaultPaymentTypeID);
            writer.WriteStringValue("DefaultTaskID", DefaultTaskID);
            writer.WriteStringValue("DivisionID", DivisionID);
            writer.WriteStringValue("Email", Email);
            writer.WriteStringValue("EmployeeNumber", EmployeeNumber);
            writer.WriteStringValue("EmploymentTypeID", EmploymentTypeID);
            writer.WriteBoolValue("EnableBreakTime", EnableBreakTime);
            writer.WriteStringValue("EndDate", EndDate);
            writer.WriteStringValue("ExpenseApproverID", ExpenseApproverID);
            writer.WriteEnumValue<UserModel_Manage_GDPRConsentStatus>("GDPRConsentStatus", GDPRConsentStatus);
            writer.WriteBoolValue("IncludeInRM", IncludeInRM);
            writer.WriteBoolValue("IsActive", IsActive);
            writer.WriteDoubleValue("MinimumTimeHours", MinimumTimeHours);
            writer.WriteEnumValue<UserModel_Manage_MinimumTimePeriod>("MinimumTimePeriod", MinimumTimePeriod);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("Notes", Notes);
            writer.WriteStringValue("PayrollType", PayrollType);
            writer.WriteEnumValue<UserModel_Manage_PreferredTimeEntryView>("PreferredTimeEntryView", PreferredTimeEntryView);
            writer.WriteEnumValue<UserModel_Manage_PreferredTimeFormat>("PreferredTimeFormat", PreferredTimeFormat);
            writer.WriteBoolValue("RequireComments", RequireComments);
            writer.WriteBoolValue("RequireStartEndTime", RequireStartEndTime);
            writer.WriteBoolValue("RequireStopwatch", RequireStopwatch);
            writer.WriteStringValue("Role", Role);
            writer.WriteBoolValue("SkipWeekend", SkipWeekend);
            writer.WriteStringValue("StartDate", StartDate);
            writer.WriteBoolValue("SubjectToExpenseApproval", SubjectToExpenseApproval);
            writer.WriteBoolValue("SubjectToTimesheetApproval", SubjectToTimesheetApproval);
            writer.WriteBoolValue("SubjectToTimesheetCompletion", SubjectToTimesheetCompletion);
            writer.WriteStringValue("TimeOffApproverID", TimeOffApproverID);
            writer.WriteStringValue("TimesheetApproverID", TimesheetApproverID);
            writer.WriteBoolValue("UseCompanyBillingRate", UseCompanyBillingRate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}