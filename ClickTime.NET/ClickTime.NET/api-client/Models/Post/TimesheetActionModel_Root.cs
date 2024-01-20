// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Post {
    public class TimesheetActionModel_Root : IAdditionalDataHolder, IParsable {
        /// <summary>The Action property</summary>
        public TimesheetActionModel_Root_Action? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CCNotifications property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CCNotifications { get; set; }
#nullable restore
#else
        public List<string> CCNotifications { get; set; }
#endif
        /// <summary>The Comment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>The HasAttestation property</summary>
        public bool? HasAttestation { get; set; }
        /// <summary>
        /// Instantiates a new TimesheetActionModel_Root and sets the default values.
        /// </summary>
        public TimesheetActionModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimesheetActionModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimesheetActionModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Action", n => { Action = n.GetEnumValue<TimesheetActionModel_Root_Action>(); } },
                {"CCNotifications", n => { CCNotifications = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"Comment", n => { Comment = n.GetStringValue(); } },
                {"HasAttestation", n => { HasAttestation = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<TimesheetActionModel_Root_Action>("Action", Action);
            writer.WriteCollectionOfPrimitiveValues<string>("CCNotifications", CCNotifications);
            writer.WriteStringValue("Comment", Comment);
            writer.WriteBoolValue("HasAttestation", HasAttestation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}