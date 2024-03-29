// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Put {
    public class TimerModel_Root : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ID { get; set; }
#nullable restore
#else
        public string ID { get; set; }
#endif
        /// <summary>The Intervals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClickTime.NET.Models.Post.TimerIntervalModel_Intervals_Put.TimerModel_Root>? Intervals { get; set; }
#nullable restore
#else
        public List<ClickTime.NET.Models.Post.TimerIntervalModel_Intervals_Put.TimerModel_Root> Intervals { get; set; }
#endif
        /// <summary>The TimeEntryID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeEntryID { get; set; }
#nullable restore
#else
        public string TimeEntryID { get; set; }
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
        /// Instantiates a new TimerModel_Root and sets the default values.
        /// </summary>
        public TimerModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimerModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimerModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ID", n => { ID = n.GetStringValue(); } },
                {"Intervals", n => { Intervals = n.GetCollectionOfObjectValues<ClickTime.NET.Models.Post.TimerIntervalModel_Intervals_Put.TimerModel_Root>(ClickTime.NET.Models.Post.TimerIntervalModel_Intervals_Put.TimerModel_Root.CreateFromDiscriminatorValue)?.ToList(); } },
                {"TimeEntryID", n => { TimeEntryID = n.GetStringValue(); } },
                {"UserID", n => { UserID = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ID", ID);
            writer.WriteCollectionOfObjectValues<ClickTime.NET.Models.Post.TimerIntervalModel_Intervals_Put.TimerModel_Root>("Intervals", Intervals);
            writer.WriteStringValue("TimeEntryID", TimeEntryID);
            writer.WriteStringValue("UserID", UserID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
