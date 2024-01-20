// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Post.BasicRuleDefinitionModel_RuleDefinition_Post {
    public class OvertimeRuleModel_Root : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Multiplier property</summary>
        public double? Multiplier { get; set; }
        /// <summary>The PayCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PayCode { get; set; }
#nullable restore
#else
        public string PayCode { get; set; }
#endif
        /// <summary>The RuleType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RuleType { get; set; }
#nullable restore
#else
        public string RuleType { get; set; }
#endif
        /// <summary>The Threshold property</summary>
        public double? Threshold { get; set; }
        /// <summary>The TimeSpan property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeSpan { get; set; }
#nullable restore
#else
        public string TimeSpan { get; set; }
#endif
        /// <summary>
        /// Instantiates a new OvertimeRuleModel_Root and sets the default values.
        /// </summary>
        public OvertimeRuleModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OvertimeRuleModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OvertimeRuleModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Multiplier", n => { Multiplier = n.GetDoubleValue(); } },
                {"PayCode", n => { PayCode = n.GetStringValue(); } },
                {"RuleType", n => { RuleType = n.GetStringValue(); } },
                {"Threshold", n => { Threshold = n.GetDoubleValue(); } },
                {"TimeSpan", n => { TimeSpan = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("Multiplier", Multiplier);
            writer.WriteStringValue("PayCode", PayCode);
            writer.WriteStringValue("RuleType", RuleType);
            writer.WriteDoubleValue("Threshold", Threshold);
            writer.WriteStringValue("TimeSpan", TimeSpan);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}