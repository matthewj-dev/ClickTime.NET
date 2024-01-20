// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Get {
    /// <summary>
    /// Holiday Type model for GET requests.
    /// </summary>
    public class HolidayTypeModel_Root : IAdditionalDataHolder, IParsable {
        /// <summary>  User requirements:Security Level(s): Admin</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountingPackageID { get; set; }
#nullable restore
#else
        public string AccountingPackageID { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>  User requirements:Security Level(s): Admin  Company requirements:Custom Fields must be configured for HolidayType.Custom Fields on Leave Types</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public HolidayTypeModel_Root_CustomFields? CustomFields { get; set; }
#nullable restore
#else
        public HolidayTypeModel_Root_CustomFields CustomFields { get; set; }
#endif
        /// <summary>Dates property would only be applicable for holiday Types  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClickTime.NET.Models.Get.HolidayModel_Dates_Get.HolidayTypeModel_Root>? Dates { get; set; }
#nullable restore
#else
        public List<ClickTime.NET.Models.Get.HolidayModel_Dates_Get.HolidayTypeModel_Root> Dates { get; set; }
#endif
        /// <summary>  Company requirements:Leave Type Restrictions: By Employment Type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EmploymentTypeIDs { get; set; }
#nullable restore
#else
        public List<string> EmploymentTypeIDs { get; set; }
#endif
        /// <summary>The ID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ID { get; set; }
#nullable restore
#else
        public string ID { get; set; }
#endif
        /// <summary>The IsActive property</summary>
        public bool? IsActive { get; set; }
        /// <summary>  Request requirements:CTLegacyScramble=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LegacyID { get; set; }
#nullable restore
#else
        public string LegacyID { get; set; }
#endif
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>  User requirements:Security Level(s): Admin</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes { get; set; }
#nullable restore
#else
        public string Notes { get; set; }
#endif
        /// <summary>
        /// Instantiates a new HolidayTypeModel_Root and sets the default values.
        /// </summary>
        public HolidayTypeModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static HolidayTypeModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HolidayTypeModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AccountingPackageID", n => { AccountingPackageID = n.GetStringValue(); } },
                {"CustomFields", n => { CustomFields = n.GetObjectValue<HolidayTypeModel_Root_CustomFields>(HolidayTypeModel_Root_CustomFields.CreateFromDiscriminatorValue); } },
                {"Dates", n => { Dates = n.GetCollectionOfObjectValues<ClickTime.NET.Models.Get.HolidayModel_Dates_Get.HolidayTypeModel_Root>(ClickTime.NET.Models.Get.HolidayModel_Dates_Get.HolidayTypeModel_Root.CreateFromDiscriminatorValue)?.ToList(); } },
                {"EmploymentTypeIDs", n => { EmploymentTypeIDs = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"ID", n => { ID = n.GetStringValue(); } },
                {"IsActive", n => { IsActive = n.GetBoolValue(); } },
                {"LegacyID", n => { LegacyID = n.GetStringValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"Notes", n => { Notes = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("AccountingPackageID", AccountingPackageID);
            writer.WriteObjectValue<HolidayTypeModel_Root_CustomFields>("CustomFields", CustomFields);
            writer.WriteCollectionOfObjectValues<ClickTime.NET.Models.Get.HolidayModel_Dates_Get.HolidayTypeModel_Root>("Dates", Dates);
            writer.WriteCollectionOfPrimitiveValues<string>("EmploymentTypeIDs", EmploymentTypeIDs);
            writer.WriteStringValue("ID", ID);
            writer.WriteBoolValue("IsActive", IsActive);
            writer.WriteStringValue("LegacyID", LegacyID);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("Notes", Notes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
