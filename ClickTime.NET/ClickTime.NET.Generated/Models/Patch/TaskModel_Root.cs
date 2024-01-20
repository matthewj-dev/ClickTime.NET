// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Generated.Models.Patch {
    public class TaskModel_Root : IAdditionalDataHolder, IParsable {
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
        /// <summary>  User requirements:Security Level(s): Admin, Manager (Add/Edit Billingrates)  Company requirements:Billing rate model(s): Task, Task x User, Task x Job</summary>
        public double? BillingRate { get; set; }
        /// <summary>  Company requirements:Custom Fields must be configured for Tasks.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TaskModel_Root_CustomFields? CustomFields { get; set; }
#nullable restore
#else
        public TaskModel_Root_CustomFields CustomFields { get; set; }
#endif
        /// <summary>The IsActive property</summary>
        public bool? IsActive { get; set; }
        /// <summary>  Company requirements:Billability by: Task</summary>
        public bool? IsBillable { get; set; }
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
        /// <summary>The TaskCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaskCode { get; set; }
#nullable restore
#else
        public string TaskCode { get; set; }
#endif
        /// <summary>  User requirements:Security Level(s): Admin, Manager (Add/Edit Billingrates)  Company requirements:Billing rate model(s): Task, Task x User, Task x Job</summary>
        public bool? UseCompanyBillingRate { get; set; }
        /// <summary>
        /// Instantiates a new TaskModel_Root and sets the default values.
        /// </summary>
        public TaskModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TaskModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TaskModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AccountingPackageID", n => { AccountingPackageID = n.GetStringValue(); } },
                {"BillingRate", n => { BillingRate = n.GetDoubleValue(); } },
                {"CustomFields", n => { CustomFields = n.GetObjectValue<TaskModel_Root_CustomFields>(TaskModel_Root_CustomFields.CreateFromDiscriminatorValue); } },
                {"IsActive", n => { IsActive = n.GetBoolValue(); } },
                {"IsBillable", n => { IsBillable = n.GetBoolValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"Notes", n => { Notes = n.GetStringValue(); } },
                {"TaskCode", n => { TaskCode = n.GetStringValue(); } },
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
            writer.WriteDoubleValue("BillingRate", BillingRate);
            writer.WriteObjectValue<TaskModel_Root_CustomFields>("CustomFields", CustomFields);
            writer.WriteBoolValue("IsActive", IsActive);
            writer.WriteBoolValue("IsBillable", IsBillable);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("Notes", Notes);
            writer.WriteStringValue("TaskCode", TaskCode);
            writer.WriteBoolValue("UseCompanyBillingRate", UseCompanyBillingRate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
