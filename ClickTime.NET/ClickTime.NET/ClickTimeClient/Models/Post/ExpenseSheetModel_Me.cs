// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Post {
    public class ExpenseSheetModel_Me : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The EnableForeignCurrency property</summary>
        public bool? EnableForeignCurrency { get; set; }
        /// <summary>The ExpenseSheetDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExpenseSheetDate { get; set; }
#nullable restore
#else
        public string ExpenseSheetDate { get; set; }
#endif
        /// <summary>The Title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The TrackingID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TrackingID { get; set; }
#nullable restore
#else
        public string TrackingID { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ExpenseSheetModel_Me and sets the default values.
        /// </summary>
        public ExpenseSheetModel_Me() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExpenseSheetModel_Me CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExpenseSheetModel_Me();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Description", n => { Description = n.GetStringValue(); } },
                {"EnableForeignCurrency", n => { EnableForeignCurrency = n.GetBoolValue(); } },
                {"ExpenseSheetDate", n => { ExpenseSheetDate = n.GetStringValue(); } },
                {"Title", n => { Title = n.GetStringValue(); } },
                {"TrackingID", n => { TrackingID = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Description", Description);
            writer.WriteBoolValue("EnableForeignCurrency", EnableForeignCurrency);
            writer.WriteStringValue("ExpenseSheetDate", ExpenseSheetDate);
            writer.WriteStringValue("Title", Title);
            writer.WriteStringValue("TrackingID", TrackingID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
