// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.ResponseBodyListGet {
    /// <summary>
    /// Standardized API response structure.
    /// </summary>
    public class PermissionNameModel_Root : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClickTime.NET.Models.Get.PermissionNameModel_Root>? Data { get; set; }
#nullable restore
#else
        public List<ClickTime.NET.Models.Get.PermissionNameModel_Root> Data { get; set; }
#endif
        /// <summary>The errors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClickTime.NET.Models.APIError>? Errors { get; set; }
#nullable restore
#else
        public List<ClickTime.NET.Models.APIError> Errors { get; set; }
#endif
        /// <summary>The jsonapi property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PermissionNameModel_Root_jsonapi? Jsonapi { get; set; }
#nullable restore
#else
        public PermissionNameModel_Root_jsonapi Jsonapi { get; set; }
#endif
        /// <summary>The meta property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PermissionNameModel_Root_meta? Meta { get; set; }
#nullable restore
#else
        public PermissionNameModel_Root_meta Meta { get; set; }
#endif
        /// <summary>Paging data for an API response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Models.Page? Page { get; set; }
#nullable restore
#else
        public ClickTime.NET.Models.Page Page { get; set; }
#endif
        /// <summary>
        /// Instantiates a new PermissionNameModel_Root and sets the default values.
        /// </summary>
        public PermissionNameModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PermissionNameModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PermissionNameModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"data", n => { Data = n.GetCollectionOfObjectValues<ClickTime.NET.Models.Get.PermissionNameModel_Root>(ClickTime.NET.Models.Get.PermissionNameModel_Root.CreateFromDiscriminatorValue)?.ToList(); } },
                {"errors", n => { Errors = n.GetCollectionOfObjectValues<ClickTime.NET.Models.APIError>(ClickTime.NET.Models.APIError.CreateFromDiscriminatorValue)?.ToList(); } },
                {"jsonapi", n => { Jsonapi = n.GetObjectValue<PermissionNameModel_Root_jsonapi>(PermissionNameModel_Root_jsonapi.CreateFromDiscriminatorValue); } },
                {"meta", n => { Meta = n.GetObjectValue<PermissionNameModel_Root_meta>(PermissionNameModel_Root_meta.CreateFromDiscriminatorValue); } },
                {"page", n => { Page = n.GetObjectValue<ClickTime.NET.Models.Page>(ClickTime.NET.Models.Page.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ClickTime.NET.Models.Get.PermissionNameModel_Root>("data", Data);
            writer.WriteCollectionOfObjectValues<ClickTime.NET.Models.APIError>("errors", Errors);
            writer.WriteObjectValue<PermissionNameModel_Root_jsonapi>("jsonapi", Jsonapi);
            writer.WriteObjectValue<PermissionNameModel_Root_meta>("meta", Meta);
            writer.WriteObjectValue<ClickTime.NET.Models.Page>("page", Page);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
