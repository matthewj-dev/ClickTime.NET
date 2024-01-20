// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Generated.Models.Get {
    public class AlternativeTimeOffEntryModel_Manage : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Generated.Models.Get.BasicAlternativeTimeOffTypeModel_AlternativeTimeOffType_Get.AlternativeTimeOffEntryModel_Manage? AlternativeTimeOffType { get; set; }
#nullable restore
#else
        public ClickTime.NET.Generated.Models.Get.BasicAlternativeTimeOffTypeModel_AlternativeTimeOffType_Get.AlternativeTimeOffEntryModel_Manage AlternativeTimeOffType { get; set; }
#endif
        /// <summary>The AlternativeTimeOffTypeID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlternativeTimeOffTypeID { get; set; }
#nullable restore
#else
        public string AlternativeTimeOffTypeID { get; set; }
#endif
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
        /// <summary>  Request requirements:CTLegacyScramble=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LegacyID { get; set; }
#nullable restore
#else
        public string LegacyID { get; set; }
#endif
        /// <summary>The Notes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes { get; set; }
#nullable restore
#else
        public string Notes { get; set; }
#endif
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Generated.Models.Get.BasicUserModel_User_Get.AlternativeTimeOffEntryModel_Manage? User { get; set; }
#nullable restore
#else
        public ClickTime.NET.Generated.Models.Get.BasicUserModel_User_Get.AlternativeTimeOffEntryModel_Manage User { get; set; }
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
        /// Instantiates a new AlternativeTimeOffEntryModel_Manage and sets the default values.
        /// </summary>
        public AlternativeTimeOffEntryModel_Manage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AlternativeTimeOffEntryModel_Manage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AlternativeTimeOffEntryModel_Manage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AlternativeTimeOffType", n => { AlternativeTimeOffType = n.GetObjectValue<ClickTime.NET.Generated.Models.Get.BasicAlternativeTimeOffTypeModel_AlternativeTimeOffType_Get.AlternativeTimeOffEntryModel_Manage>(ClickTime.NET.Generated.Models.Get.BasicAlternativeTimeOffTypeModel_AlternativeTimeOffType_Get.AlternativeTimeOffEntryModel_Manage.CreateFromDiscriminatorValue); } },
                {"AlternativeTimeOffTypeID", n => { AlternativeTimeOffTypeID = n.GetStringValue(); } },
                {"Date", n => { Date = n.GetStringValue(); } },
                {"Hours", n => { Hours = n.GetDoubleValue(); } },
                {"ID", n => { ID = n.GetStringValue(); } },
                {"LegacyID", n => { LegacyID = n.GetStringValue(); } },
                {"Notes", n => { Notes = n.GetStringValue(); } },
                {"User", n => { User = n.GetObjectValue<ClickTime.NET.Generated.Models.Get.BasicUserModel_User_Get.AlternativeTimeOffEntryModel_Manage>(ClickTime.NET.Generated.Models.Get.BasicUserModel_User_Get.AlternativeTimeOffEntryModel_Manage.CreateFromDiscriminatorValue); } },
                {"UserID", n => { UserID = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ClickTime.NET.Generated.Models.Get.BasicAlternativeTimeOffTypeModel_AlternativeTimeOffType_Get.AlternativeTimeOffEntryModel_Manage>("AlternativeTimeOffType", AlternativeTimeOffType);
            writer.WriteStringValue("AlternativeTimeOffTypeID", AlternativeTimeOffTypeID);
            writer.WriteStringValue("Date", Date);
            writer.WriteDoubleValue("Hours", Hours);
            writer.WriteStringValue("ID", ID);
            writer.WriteStringValue("LegacyID", LegacyID);
            writer.WriteStringValue("Notes", Notes);
            writer.WriteObjectValue<ClickTime.NET.Generated.Models.Get.BasicUserModel_User_Get.AlternativeTimeOffEntryModel_Manage>("User", User);
            writer.WriteStringValue("UserID", UserID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
