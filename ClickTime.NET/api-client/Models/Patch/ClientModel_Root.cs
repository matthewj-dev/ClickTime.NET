// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Patch {
    public class ClientModel_Root : IAdditionalDataHolder, IParsable {
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
        /// <summary>  User requirements:Security Level(s): Admin, Manager (Add/Edit Billingrates)  Company requirements:Billing rate model(s): User x Client</summary>
        public double? BillingRate { get; set; }
        /// <summary>The ClientNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientNumber { get; set; }
#nullable restore
#else
        public string ClientNumber { get; set; }
#endif
        /// <summary>  Company requirements:Custom Fields must be configured for Clients.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClientModel_Root_CustomFields? CustomFields { get; set; }
#nullable restore
#else
        public ClientModel_Root_CustomFields CustomFields { get; set; }
#endif
        /// <summary>The IsActive property</summary>
        public bool? IsActive { get; set; }
        /// <summary>  Company requirements:Company must be nonprofit</summary>
        public bool? IsEligibleTimeOffAllocation { get; set; }
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
        /// <summary>  User requirements:Security Level(s): Admin, Manager (Add/Edit Billingrates)  Company requirements:Billing rate model(s): User x Client</summary>
        public ClientModel_Root_SecondaryBillingRateMode? SecondaryBillingRateMode { get; set; }
        /// <summary>The ShortName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShortName { get; set; }
#nullable restore
#else
        public string ShortName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ClientModel_Root and sets the default values.
        /// </summary>
        public ClientModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ClientModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClientModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AccountingPackageID", n => { AccountingPackageID = n.GetStringValue(); } },
                {"BillingRate", n => { BillingRate = n.GetDoubleValue(); } },
                {"ClientNumber", n => { ClientNumber = n.GetStringValue(); } },
                {"CustomFields", n => { CustomFields = n.GetObjectValue<ClientModel_Root_CustomFields>(ClientModel_Root_CustomFields.CreateFromDiscriminatorValue); } },
                {"IsActive", n => { IsActive = n.GetBoolValue(); } },
                {"IsEligibleTimeOffAllocation", n => { IsEligibleTimeOffAllocation = n.GetBoolValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"Notes", n => { Notes = n.GetStringValue(); } },
                {"SecondaryBillingRateMode", n => { SecondaryBillingRateMode = n.GetEnumValue<ClientModel_Root_SecondaryBillingRateMode>(); } },
                {"ShortName", n => { ShortName = n.GetStringValue(); } },
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
            writer.WriteStringValue("ClientNumber", ClientNumber);
            writer.WriteObjectValue<ClientModel_Root_CustomFields>("CustomFields", CustomFields);
            writer.WriteBoolValue("IsActive", IsActive);
            writer.WriteBoolValue("IsEligibleTimeOffAllocation", IsEligibleTimeOffAllocation);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("Notes", Notes);
            writer.WriteEnumValue<ClientModel_Root_SecondaryBillingRateMode>("SecondaryBillingRateMode", SecondaryBillingRateMode);
            writer.WriteStringValue("ShortName", ShortName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
