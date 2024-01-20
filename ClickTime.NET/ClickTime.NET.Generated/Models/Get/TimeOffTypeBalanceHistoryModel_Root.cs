// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Generated.Models.Get {
    public class TimeOffTypeBalanceHistoryModel_Root : IAdditionalDataHolder, IParsable {
        /// <summary>The Action property</summary>
        public TimeOffTypeBalanceHistoryModel_Root_Action? Action { get; set; }
        /// <summary>The ActionByUserID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActionByUserID { get; set; }
#nullable restore
#else
        public string ActionByUserID { get; set; }
#endif
        /// <summary>The ActionByUserName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActionByUserName { get; set; }
#nullable restore
#else
        public string ActionByUserName { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Balance property</summary>
        public double? Balance { get; set; }
        /// <summary>The Date property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Date { get; set; }
#nullable restore
#else
        public string Date { get; set; }
#endif
        /// <summary>The HoursDifference property</summary>
        public double? HoursDifference { get; set; }
        /// <summary>The Notes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes { get; set; }
#nullable restore
#else
        public string Notes { get; set; }
#endif
        /// <summary>
        /// Instantiates a new TimeOffTypeBalanceHistoryModel_Root and sets the default values.
        /// </summary>
        public TimeOffTypeBalanceHistoryModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimeOffTypeBalanceHistoryModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeOffTypeBalanceHistoryModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Action", n => { Action = n.GetEnumValue<TimeOffTypeBalanceHistoryModel_Root_Action>(); } },
                {"ActionByUserID", n => { ActionByUserID = n.GetStringValue(); } },
                {"ActionByUserName", n => { ActionByUserName = n.GetStringValue(); } },
                {"Balance", n => { Balance = n.GetDoubleValue(); } },
                {"Date", n => { Date = n.GetStringValue(); } },
                {"HoursDifference", n => { HoursDifference = n.GetDoubleValue(); } },
                {"Notes", n => { Notes = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<TimeOffTypeBalanceHistoryModel_Root_Action>("Action", Action);
            writer.WriteStringValue("ActionByUserID", ActionByUserID);
            writer.WriteStringValue("ActionByUserName", ActionByUserName);
            writer.WriteDoubleValue("Balance", Balance);
            writer.WriteStringValue("Date", Date);
            writer.WriteDoubleValue("HoursDifference", HoursDifference);
            writer.WriteStringValue("Notes", Notes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
