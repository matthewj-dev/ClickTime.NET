// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Post {
    public class TimeOffRequestModel_Me : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Dates property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClickTime.NET.Models.Post.TimeOffRequestDateModel_Dates_Post.TimeOffRequestModel_Me>? Dates { get; set; }
#nullable restore
#else
        public List<ClickTime.NET.Models.Post.TimeOffRequestDateModel_Dates_Post.TimeOffRequestModel_Me> Dates { get; set; }
#endif
        /// <summary>The Notes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes { get; set; }
#nullable restore
#else
        public string Notes { get; set; }
#endif
        /// <summary>The TimeOffTypeID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeOffTypeID { get; set; }
#nullable restore
#else
        public string TimeOffTypeID { get; set; }
#endif
        /// <summary>
        /// Instantiates a new TimeOffRequestModel_Me and sets the default values.
        /// </summary>
        public TimeOffRequestModel_Me() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimeOffRequestModel_Me CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeOffRequestModel_Me();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Dates", n => { Dates = n.GetCollectionOfObjectValues<ClickTime.NET.Models.Post.TimeOffRequestDateModel_Dates_Post.TimeOffRequestModel_Me>(ClickTime.NET.Models.Post.TimeOffRequestDateModel_Dates_Post.TimeOffRequestModel_Me.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Notes", n => { Notes = n.GetStringValue(); } },
                {"TimeOffTypeID", n => { TimeOffTypeID = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ClickTime.NET.Models.Post.TimeOffRequestDateModel_Dates_Post.TimeOffRequestModel_Me>("Dates", Dates);
            writer.WriteStringValue("Notes", Notes);
            writer.WriteStringValue("TimeOffTypeID", TimeOffTypeID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
