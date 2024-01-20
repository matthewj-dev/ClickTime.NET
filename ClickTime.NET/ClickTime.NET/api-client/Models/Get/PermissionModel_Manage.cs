// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Get {
    /// <summary>
    /// The permission type and level for a user.
    /// </summary>
    public class PermissionModel_Manage : IAdditionalDataHolder, IParsable {
        /// <summary>The availability of this permission (e.g. All, or restricted by Division).</summary>
        public PermissionModel_Manage_AccessLevel? AccessLevel { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name of the permission.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Instantiates a new PermissionModel_Manage and sets the default values.
        /// </summary>
        public PermissionModel_Manage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PermissionModel_Manage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PermissionModel_Manage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AccessLevel", n => { AccessLevel = n.GetEnumValue<PermissionModel_Manage_AccessLevel>(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<PermissionModel_Manage_AccessLevel>("AccessLevel", AccessLevel);
            writer.WriteStringValue("Name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
