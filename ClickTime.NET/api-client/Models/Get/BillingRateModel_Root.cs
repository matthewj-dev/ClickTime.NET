// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Get {
    public class BillingRateModel_Root : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The BillingRate property</summary>
        public double? BillingRate { get; set; }
        /// <summary>The ID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ID { get; set; }
#nullable restore
#else
        public string ID { get; set; }
#endif
        /// <summary>  Company requirements:Billability by: TaskBilling rate model(s): Task x User, Task x Job</summary>
        public bool? IsBillable { get; set; }
        /// <summary>  Request requirements:CTLegacyScramble=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LegacyID { get; set; }
#nullable restore
#else
        public string LegacyID { get; set; }
#endif
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The Type property</summary>
        public BillingRateModel_Root_Type? Type { get; set; }
        /// <summary>
        /// Instantiates a new BillingRateModel_Root and sets the default values.
        /// </summary>
        public BillingRateModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BillingRateModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BillingRateModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"BillingRate", n => { BillingRate = n.GetDoubleValue(); } },
                {"ID", n => { ID = n.GetStringValue(); } },
                {"IsBillable", n => { IsBillable = n.GetBoolValue(); } },
                {"LegacyID", n => { LegacyID = n.GetStringValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"Type", n => { Type = n.GetEnumValue<BillingRateModel_Root_Type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("BillingRate", BillingRate);
            writer.WriteStringValue("ID", ID);
            writer.WriteBoolValue("IsBillable", IsBillable);
            writer.WriteStringValue("LegacyID", LegacyID);
            writer.WriteStringValue("Name", Name);
            writer.WriteEnumValue<BillingRateModel_Root_Type>("Type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}