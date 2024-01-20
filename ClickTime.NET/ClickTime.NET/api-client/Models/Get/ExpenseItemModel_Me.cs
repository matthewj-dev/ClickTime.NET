// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Get {
    public class ExpenseItemModel_Me : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Amount property</summary>
        public double? Amount { get; set; }
        /// <summary>The AmountForeign property</summary>
        public double? AmountForeign { get; set; }
        /// <summary>The AmountForeignCurrency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AmountForeignCurrency { get; set; }
#nullable restore
#else
        public string AmountForeignCurrency { get; set; }
#endif
        /// <summary>The AmountForeignExchangeRate property</summary>
        public double? AmountForeignExchangeRate { get; set; }
        /// <summary>The Billable property</summary>
        public bool? Billable { get; set; }
        /// <summary>The Comment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>The Currency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency { get; set; }
#nullable restore
#else
        public string Currency { get; set; }
#endif
        /// <summary>The Description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The ExpenseDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExpenseDate { get; set; }
#nullable restore
#else
        public string ExpenseDate { get; set; }
#endif
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Models.Get.BasicExpenseSheetModel_ExpenseSheet_Get.ExpenseItemModel_Me? ExpenseSheet { get; set; }
#nullable restore
#else
        public ClickTime.NET.Models.Get.BasicExpenseSheetModel_ExpenseSheet_Get.ExpenseItemModel_Me ExpenseSheet { get; set; }
#endif
        /// <summary>The ExpenseSheetID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExpenseSheetID { get; set; }
#nullable restore
#else
        public string ExpenseSheetID { get; set; }
#endif
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Models.Get.BasicExpenseTypeModel_ExpenseType_Get.ExpenseItemModel_Me? ExpenseType { get; set; }
#nullable restore
#else
        public ClickTime.NET.Models.Get.BasicExpenseTypeModel_ExpenseType_Get.ExpenseItemModel_Me ExpenseType { get; set; }
#endif
        /// <summary>The ExpenseTypeID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExpenseTypeID { get; set; }
#nullable restore
#else
        public string ExpenseTypeID { get; set; }
#endif
        /// <summary>HasForeignCurrency is set to true when AmountForeignCurrency has a valid value.Otherwise, HasForeignCurrency is set to false.</summary>
        public bool? HasForeignCurrency { get; set; }
        /// <summary>The ID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ID { get; set; }
#nullable restore
#else
        public string ID { get; set; }
#endif
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Models.Get.BasicJobModel_Job_Get.ExpenseItemModel_Me? Job { get; set; }
#nullable restore
#else
        public ClickTime.NET.Models.Get.BasicJobModel_Job_Get.ExpenseItemModel_Me Job { get; set; }
#endif
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
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Models.Get.BasicPaymentTypeModel_PaymentType_Get.ExpenseItemModel_Me? PaymentType { get; set; }
#nullable restore
#else
        public ClickTime.NET.Models.Get.BasicPaymentTypeModel_PaymentType_Get.ExpenseItemModel_Me PaymentType { get; set; }
#endif
        /// <summary>The PaymentTypeID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaymentTypeID { get; set; }
#nullable restore
#else
        public string PaymentTypeID { get; set; }
#endif
        /// <summary>The Quantity property</summary>
        public double? Quantity { get; set; }
        /// <summary>The Rate property</summary>
        public double? Rate { get; set; }
        /// <summary>The ReceiptURL property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReceiptURL { get; set; }
#nullable restore
#else
        public string ReceiptURL { get; set; }
#endif
        /// <summary>The Reimbursable property</summary>
        public bool? Reimbursable { get; set; }
        /// <summary>  Request requirements:Verbose=true  Company requirements:Support Tasks on Expenses</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Models.Get.BasicTaskModel_Task_Get.ExpenseItemModel_Me? Task { get; set; }
#nullable restore
#else
        public ClickTime.NET.Models.Get.BasicTaskModel_Task_Get.ExpenseItemModel_Me Task { get; set; }
#endif
        /// <summary>  Company requirements:Support Tasks on Expenses</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaskID { get; set; }
#nullable restore
#else
        public string TaskID { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ExpenseItemModel_Me and sets the default values.
        /// </summary>
        public ExpenseItemModel_Me() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExpenseItemModel_Me CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExpenseItemModel_Me();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Amount", n => { Amount = n.GetDoubleValue(); } },
                {"AmountForeign", n => { AmountForeign = n.GetDoubleValue(); } },
                {"AmountForeignCurrency", n => { AmountForeignCurrency = n.GetStringValue(); } },
                {"AmountForeignExchangeRate", n => { AmountForeignExchangeRate = n.GetDoubleValue(); } },
                {"Billable", n => { Billable = n.GetBoolValue(); } },
                {"Comment", n => { Comment = n.GetStringValue(); } },
                {"Currency", n => { Currency = n.GetStringValue(); } },
                {"Description", n => { Description = n.GetStringValue(); } },
                {"ExpenseDate", n => { ExpenseDate = n.GetStringValue(); } },
                {"ExpenseSheet", n => { ExpenseSheet = n.GetObjectValue<ClickTime.NET.Models.Get.BasicExpenseSheetModel_ExpenseSheet_Get.ExpenseItemModel_Me>(ClickTime.NET.Models.Get.BasicExpenseSheetModel_ExpenseSheet_Get.ExpenseItemModel_Me.CreateFromDiscriminatorValue); } },
                {"ExpenseSheetID", n => { ExpenseSheetID = n.GetStringValue(); } },
                {"ExpenseType", n => { ExpenseType = n.GetObjectValue<ClickTime.NET.Models.Get.BasicExpenseTypeModel_ExpenseType_Get.ExpenseItemModel_Me>(ClickTime.NET.Models.Get.BasicExpenseTypeModel_ExpenseType_Get.ExpenseItemModel_Me.CreateFromDiscriminatorValue); } },
                {"ExpenseTypeID", n => { ExpenseTypeID = n.GetStringValue(); } },
                {"HasForeignCurrency", n => { HasForeignCurrency = n.GetBoolValue(); } },
                {"ID", n => { ID = n.GetStringValue(); } },
                {"Job", n => { Job = n.GetObjectValue<ClickTime.NET.Models.Get.BasicJobModel_Job_Get.ExpenseItemModel_Me>(ClickTime.NET.Models.Get.BasicJobModel_Job_Get.ExpenseItemModel_Me.CreateFromDiscriminatorValue); } },
                {"JobID", n => { JobID = n.GetStringValue(); } },
                {"LegacyID", n => { LegacyID = n.GetStringValue(); } },
                {"PaymentType", n => { PaymentType = n.GetObjectValue<ClickTime.NET.Models.Get.BasicPaymentTypeModel_PaymentType_Get.ExpenseItemModel_Me>(ClickTime.NET.Models.Get.BasicPaymentTypeModel_PaymentType_Get.ExpenseItemModel_Me.CreateFromDiscriminatorValue); } },
                {"PaymentTypeID", n => { PaymentTypeID = n.GetStringValue(); } },
                {"Quantity", n => { Quantity = n.GetDoubleValue(); } },
                {"Rate", n => { Rate = n.GetDoubleValue(); } },
                {"ReceiptURL", n => { ReceiptURL = n.GetStringValue(); } },
                {"Reimbursable", n => { Reimbursable = n.GetBoolValue(); } },
                {"Task", n => { Task = n.GetObjectValue<ClickTime.NET.Models.Get.BasicTaskModel_Task_Get.ExpenseItemModel_Me>(ClickTime.NET.Models.Get.BasicTaskModel_Task_Get.ExpenseItemModel_Me.CreateFromDiscriminatorValue); } },
                {"TaskID", n => { TaskID = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("Amount", Amount);
            writer.WriteDoubleValue("AmountForeign", AmountForeign);
            writer.WriteStringValue("AmountForeignCurrency", AmountForeignCurrency);
            writer.WriteDoubleValue("AmountForeignExchangeRate", AmountForeignExchangeRate);
            writer.WriteBoolValue("Billable", Billable);
            writer.WriteStringValue("Comment", Comment);
            writer.WriteStringValue("Currency", Currency);
            writer.WriteStringValue("Description", Description);
            writer.WriteStringValue("ExpenseDate", ExpenseDate);
            writer.WriteObjectValue<ClickTime.NET.Models.Get.BasicExpenseSheetModel_ExpenseSheet_Get.ExpenseItemModel_Me>("ExpenseSheet", ExpenseSheet);
            writer.WriteStringValue("ExpenseSheetID", ExpenseSheetID);
            writer.WriteObjectValue<ClickTime.NET.Models.Get.BasicExpenseTypeModel_ExpenseType_Get.ExpenseItemModel_Me>("ExpenseType", ExpenseType);
            writer.WriteStringValue("ExpenseTypeID", ExpenseTypeID);
            writer.WriteBoolValue("HasForeignCurrency", HasForeignCurrency);
            writer.WriteStringValue("ID", ID);
            writer.WriteObjectValue<ClickTime.NET.Models.Get.BasicJobModel_Job_Get.ExpenseItemModel_Me>("Job", Job);
            writer.WriteStringValue("JobID", JobID);
            writer.WriteStringValue("LegacyID", LegacyID);
            writer.WriteObjectValue<ClickTime.NET.Models.Get.BasicPaymentTypeModel_PaymentType_Get.ExpenseItemModel_Me>("PaymentType", PaymentType);
            writer.WriteStringValue("PaymentTypeID", PaymentTypeID);
            writer.WriteDoubleValue("Quantity", Quantity);
            writer.WriteDoubleValue("Rate", Rate);
            writer.WriteStringValue("ReceiptURL", ReceiptURL);
            writer.WriteBoolValue("Reimbursable", Reimbursable);
            writer.WriteObjectValue<ClickTime.NET.Models.Get.BasicTaskModel_Task_Get.ExpenseItemModel_Me>("Task", Task);
            writer.WriteStringValue("TaskID", TaskID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
