// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Generated.Models.Get {
    public class TimerModel_Root : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ElapsedSeconds property</summary>
        public int? ElapsedSeconds { get; set; }
        /// <summary>The ID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ID { get; set; }
#nullable restore
#else
        public string ID { get; set; }
#endif
        /// <summary>The InitialTimeInSeconds property</summary>
        public int? InitialTimeInSeconds { get; set; }
        /// <summary>The Intervals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClickTime.NET.Generated.Models.Get.TimerIntervalModel_Intervals_Get.TimerModel_Root>? Intervals { get; set; }
#nullable restore
#else
        public List<ClickTime.NET.Generated.Models.Get.TimerIntervalModel_Intervals_Get.TimerModel_Root> Intervals { get; set; }
#endif
        /// <summary>  Request requirements:CTLegacyScramble=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LegacyID { get; set; }
#nullable restore
#else
        public string LegacyID { get; set; }
#endif
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Generated.Models.Get.ExtendedBasicTimeEntryModel_TimeEntry_Get.TimerModel_Root? TimeEntry { get; set; }
#nullable restore
#else
        public ClickTime.NET.Generated.Models.Get.ExtendedBasicTimeEntryModel_TimeEntry_Get.TimerModel_Root TimeEntry { get; set; }
#endif
        /// <summary>The TimeEntryDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeEntryDate { get; set; }
#nullable restore
#else
        public string TimeEntryDate { get; set; }
#endif
        /// <summary>The TimeEntryID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeEntryID { get; set; }
#nullable restore
#else
        public string TimeEntryID { get; set; }
#endif
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Generated.Models.Get.BasicUserModel_User_Get.TimerModel_Root? User { get; set; }
#nullable restore
#else
        public ClickTime.NET.Generated.Models.Get.BasicUserModel_User_Get.TimerModel_Root User { get; set; }
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
                {"ElapsedSeconds", n => { ElapsedSeconds = n.GetIntValue(); } },
                {"ID", n => { ID = n.GetStringValue(); } },
                {"InitialTimeInSeconds", n => { InitialTimeInSeconds = n.GetIntValue(); } },
                {"Intervals", n => { Intervals = n.GetCollectionOfObjectValues<ClickTime.NET.Generated.Models.Get.TimerIntervalModel_Intervals_Get.TimerModel_Root>(ClickTime.NET.Generated.Models.Get.TimerIntervalModel_Intervals_Get.TimerModel_Root.CreateFromDiscriminatorValue)?.ToList(); } },
                {"LegacyID", n => { LegacyID = n.GetStringValue(); } },
                {"TimeEntry", n => { TimeEntry = n.GetObjectValue<ClickTime.NET.Generated.Models.Get.ExtendedBasicTimeEntryModel_TimeEntry_Get.TimerModel_Root>(ClickTime.NET.Generated.Models.Get.ExtendedBasicTimeEntryModel_TimeEntry_Get.TimerModel_Root.CreateFromDiscriminatorValue); } },
                {"TimeEntryDate", n => { TimeEntryDate = n.GetStringValue(); } },
                {"TimeEntryID", n => { TimeEntryID = n.GetStringValue(); } },
                {"User", n => { User = n.GetObjectValue<ClickTime.NET.Generated.Models.Get.BasicUserModel_User_Get.TimerModel_Root>(ClickTime.NET.Generated.Models.Get.BasicUserModel_User_Get.TimerModel_Root.CreateFromDiscriminatorValue); } },
                {"UserID", n => { UserID = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("ElapsedSeconds", ElapsedSeconds);
            writer.WriteStringValue("ID", ID);
            writer.WriteIntValue("InitialTimeInSeconds", InitialTimeInSeconds);
            writer.WriteCollectionOfObjectValues<ClickTime.NET.Generated.Models.Get.TimerIntervalModel_Intervals_Get.TimerModel_Root>("Intervals", Intervals);
            writer.WriteStringValue("LegacyID", LegacyID);
            writer.WriteObjectValue<ClickTime.NET.Generated.Models.Get.ExtendedBasicTimeEntryModel_TimeEntry_Get.TimerModel_Root>("TimeEntry", TimeEntry);
            writer.WriteStringValue("TimeEntryDate", TimeEntryDate);
            writer.WriteStringValue("TimeEntryID", TimeEntryID);
            writer.WriteObjectValue<ClickTime.NET.Generated.Models.Get.BasicUserModel_User_Get.TimerModel_Root>("User", User);
            writer.WriteStringValue("UserID", UserID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
