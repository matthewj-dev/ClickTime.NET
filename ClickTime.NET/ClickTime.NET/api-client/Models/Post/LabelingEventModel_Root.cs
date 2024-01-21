// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Post {
    /// <summary>
    /// Labeling Event model for POST requests.
    /// </summary>
    public class LabelingEventModel_Root : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The EndDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EndDate { get; set; }
#nullable restore
#else
        public string EndDate { get; set; }
#endif
        /// <summary>The EntityIDs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EntityIDs { get; set; }
#nullable restore
#else
        public string EntityIDs { get; set; }
#endif
        /// <summary>The EntityType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EntityType { get; set; }
#nullable restore
#else
        public string EntityType { get; set; }
#endif
        /// <summary>The LabelID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LabelID { get; set; }
#nullable restore
#else
        public string LabelID { get; set; }
#endif
        /// <summary>The StartDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartDate { get; set; }
#nullable restore
#else
        public string StartDate { get; set; }
#endif
        /// <summary>
        /// Instantiates a new LabelingEventModel_Root and sets the default values.
        /// </summary>
        public LabelingEventModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static LabelingEventModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LabelingEventModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"EndDate", n => { EndDate = n.GetStringValue(); } },
                {"EntityIDs", n => { EntityIDs = n.GetStringValue(); } },
                {"EntityType", n => { EntityType = n.GetStringValue(); } },
                {"LabelID", n => { LabelID = n.GetStringValue(); } },
                {"StartDate", n => { StartDate = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("EndDate", EndDate);
            writer.WriteStringValue("EntityIDs", EntityIDs);
            writer.WriteStringValue("EntityType", EntityType);
            writer.WriteStringValue("LabelID", LabelID);
            writer.WriteStringValue("StartDate", StartDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
