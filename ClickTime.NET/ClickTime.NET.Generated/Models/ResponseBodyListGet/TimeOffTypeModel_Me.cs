// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Generated.Models.ResponseBodyListGet {
    /// <summary>
    /// Standardized API response structure.
    /// </summary>
    public class TimeOffTypeModel_Me : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClickTime.NET.Generated.Models.Get.TimeOffTypeModel_Me>? Data { get; set; }
#nullable restore
#else
        public List<ClickTime.NET.Generated.Models.Get.TimeOffTypeModel_Me> Data { get; set; }
#endif
        /// <summary>The errors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClickTime.NET.Generated.Models.APIError>? Errors { get; set; }
#nullable restore
#else
        public List<ClickTime.NET.Generated.Models.APIError> Errors { get; set; }
#endif
        /// <summary>The jsonapi property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TimeOffTypeModel_Me_jsonapi? Jsonapi { get; set; }
#nullable restore
#else
        public TimeOffTypeModel_Me_jsonapi Jsonapi { get; set; }
#endif
        /// <summary>The meta property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TimeOffTypeModel_Me_meta? Meta { get; set; }
#nullable restore
#else
        public TimeOffTypeModel_Me_meta Meta { get; set; }
#endif
        /// <summary>Paging data for an API response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Generated.Models.Page? Page { get; set; }
#nullable restore
#else
        public ClickTime.NET.Generated.Models.Page Page { get; set; }
#endif
        /// <summary>
        /// Instantiates a new TimeOffTypeModel_Me and sets the default values.
        /// </summary>
        public TimeOffTypeModel_Me() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimeOffTypeModel_Me CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeOffTypeModel_Me();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"data", n => { Data = n.GetCollectionOfObjectValues<ClickTime.NET.Generated.Models.Get.TimeOffTypeModel_Me>(ClickTime.NET.Generated.Models.Get.TimeOffTypeModel_Me.CreateFromDiscriminatorValue)?.ToList(); } },
                {"errors", n => { Errors = n.GetCollectionOfObjectValues<ClickTime.NET.Generated.Models.APIError>(ClickTime.NET.Generated.Models.APIError.CreateFromDiscriminatorValue)?.ToList(); } },
                {"jsonapi", n => { Jsonapi = n.GetObjectValue<TimeOffTypeModel_Me_jsonapi>(TimeOffTypeModel_Me_jsonapi.CreateFromDiscriminatorValue); } },
                {"meta", n => { Meta = n.GetObjectValue<TimeOffTypeModel_Me_meta>(TimeOffTypeModel_Me_meta.CreateFromDiscriminatorValue); } },
                {"page", n => { Page = n.GetObjectValue<ClickTime.NET.Generated.Models.Page>(ClickTime.NET.Generated.Models.Page.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ClickTime.NET.Generated.Models.Get.TimeOffTypeModel_Me>("data", Data);
            writer.WriteCollectionOfObjectValues<ClickTime.NET.Generated.Models.APIError>("errors", Errors);
            writer.WriteObjectValue<TimeOffTypeModel_Me_jsonapi>("jsonapi", Jsonapi);
            writer.WriteObjectValue<TimeOffTypeModel_Me_meta>("meta", Meta);
            writer.WriteObjectValue<ClickTime.NET.Generated.Models.Page>("page", Page);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
