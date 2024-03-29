// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Get.BasicJobModel_Job_Get {
    /// <summary>
    ///   Request requirements:Verbose=true
    /// </summary>
    public class TimeEntryModel_Me : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ClientID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientID { get; set; }
#nullable restore
#else
        public string ClientID { get; set; }
#endif
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
        /// <summary>The ListDisplayText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ListDisplayText { get; set; }
#nullable restore
#else
        public string ListDisplayText { get; set; }
#endif
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Instantiates a new TimeEntryModel_Me and sets the default values.
        /// </summary>
        public TimeEntryModel_Me() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimeEntryModel_Me CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeEntryModel_Me();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ClientID", n => { ClientID = n.GetStringValue(); } },
                {"ID", n => { ID = n.GetStringValue(); } },
                {"IsActive", n => { IsActive = n.GetBoolValue(); } },
                {"LegacyID", n => { LegacyID = n.GetStringValue(); } },
                {"ListDisplayText", n => { ListDisplayText = n.GetStringValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ClientID", ClientID);
            writer.WriteStringValue("ID", ID);
            writer.WriteBoolValue("IsActive", IsActive);
            writer.WriteStringValue("LegacyID", LegacyID);
            writer.WriteStringValue("ListDisplayText", ListDisplayText);
            writer.WriteStringValue("Name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
