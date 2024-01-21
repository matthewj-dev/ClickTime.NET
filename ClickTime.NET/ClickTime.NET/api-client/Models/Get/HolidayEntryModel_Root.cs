// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Get {
    public class HolidayEntryModel_Root : IAdditionalDataHolder, IParsable {
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
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Models.Get.BasicTimeOffTypeModel_HolidayType_Get.HolidayEntryModel_Root? HolidayType { get; set; }
#nullable restore
#else
        public ClickTime.NET.Models.Get.BasicTimeOffTypeModel_HolidayType_Get.HolidayEntryModel_Root HolidayType { get; set; }
#endif
        /// <summary>The HolidayTypeID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HolidayTypeID { get; set; }
#nullable restore
#else
        public string HolidayTypeID { get; set; }
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
        public ClickTime.NET.Models.Get.BasicUserModel_User_Get.HolidayEntryModel_Root? User { get; set; }
#nullable restore
#else
        public ClickTime.NET.Models.Get.BasicUserModel_User_Get.HolidayEntryModel_Root User { get; set; }
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
        /// Instantiates a new HolidayEntryModel_Root and sets the default values.
        /// </summary>
        public HolidayEntryModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static HolidayEntryModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HolidayEntryModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Date", n => { Date = n.GetStringValue(); } },
                {"HolidayType", n => { HolidayType = n.GetObjectValue<ClickTime.NET.Models.Get.BasicTimeOffTypeModel_HolidayType_Get.HolidayEntryModel_Root>(ClickTime.NET.Models.Get.BasicTimeOffTypeModel_HolidayType_Get.HolidayEntryModel_Root.CreateFromDiscriminatorValue); } },
                {"HolidayTypeID", n => { HolidayTypeID = n.GetStringValue(); } },
                {"Hours", n => { Hours = n.GetDoubleValue(); } },
                {"ID", n => { ID = n.GetStringValue(); } },
                {"LegacyID", n => { LegacyID = n.GetStringValue(); } },
                {"Notes", n => { Notes = n.GetStringValue(); } },
                {"User", n => { User = n.GetObjectValue<ClickTime.NET.Models.Get.BasicUserModel_User_Get.HolidayEntryModel_Root>(ClickTime.NET.Models.Get.BasicUserModel_User_Get.HolidayEntryModel_Root.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<ClickTime.NET.Models.Get.BasicTimeOffTypeModel_HolidayType_Get.HolidayEntryModel_Root>("HolidayType", HolidayType);
            writer.WriteStringValue("HolidayTypeID", HolidayTypeID);
            writer.WriteDoubleValue("Hours", Hours);
            writer.WriteStringValue("ID", ID);
            writer.WriteStringValue("LegacyID", LegacyID);
            writer.WriteStringValue("Notes", Notes);
            writer.WriteObjectValue<ClickTime.NET.Models.Get.BasicUserModel_User_Get.HolidayEntryModel_Root>("User", User);
            writer.WriteStringValue("UserID", UserID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
