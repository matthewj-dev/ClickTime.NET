// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Generated.Models.Get {
    public class TimeOffModel_New : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Date property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Date { get; set; }
#nullable restore
#else
        public string Date { get; set; }
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
        /// <summary>The Notes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes { get; set; }
#nullable restore
#else
        public string Notes { get; set; }
#endif
        /// <summary>The TimeOffRequestID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeOffRequestID { get; set; }
#nullable restore
#else
        public string TimeOffRequestID { get; set; }
#endif
        /// <summary>The TimeOffTypeID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeOffTypeID { get; set; }
#nullable restore
#else
        public string TimeOffTypeID { get; set; }
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
        /// Instantiates a new TimeOffModel_New and sets the default values.
        /// </summary>
        public TimeOffModel_New() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimeOffModel_New CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeOffModel_New();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Date", n => { Date = n.GetStringValue(); } },
                {"Hours", n => { Hours = n.GetDoubleValue(); } },
                {"ID", n => { ID = n.GetStringValue(); } },
                {"Notes", n => { Notes = n.GetStringValue(); } },
                {"TimeOffRequestID", n => { TimeOffRequestID = n.GetStringValue(); } },
                {"TimeOffTypeID", n => { TimeOffTypeID = n.GetStringValue(); } },
                {"UserID", n => { UserID = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Date", Date);
            writer.WriteDoubleValue("Hours", Hours);
            writer.WriteStringValue("ID", ID);
            writer.WriteStringValue("Notes", Notes);
            writer.WriteStringValue("TimeOffRequestID", TimeOffRequestID);
            writer.WriteStringValue("TimeOffTypeID", TimeOffTypeID);
            writer.WriteStringValue("UserID", UserID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
