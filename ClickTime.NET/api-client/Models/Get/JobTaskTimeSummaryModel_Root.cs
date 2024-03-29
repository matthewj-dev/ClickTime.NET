// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Get {
    public class JobTaskTimeSummaryModel_Root : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Billings property</summary>
        public double? Billings { get; set; }
        /// <summary>  Company requirements:Optional module(s): ForecastingEstimation model: Project Insights</summary>
        public double? EstimateBillings { get; set; }
        /// <summary>  Company requirements:Optional module(s): ForecastingEstimation model: Project Insights</summary>
        public double? EstimateHours { get; set; }
        /// <summary>The Hours property</summary>
        public double? Hours { get; set; }
        /// <summary>The IsActive property</summary>
        public bool? IsActive { get; set; }
        /// <summary>The IsBillable property</summary>
        public bool? IsBillable { get; set; }
        /// <summary>The TaskID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaskID { get; set; }
#nullable restore
#else
        public string TaskID { get; set; }
#endif
        /// <summary>The TaskName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaskName { get; set; }
#nullable restore
#else
        public string TaskName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new JobTaskTimeSummaryModel_Root and sets the default values.
        /// </summary>
        public JobTaskTimeSummaryModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static JobTaskTimeSummaryModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JobTaskTimeSummaryModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Billings", n => { Billings = n.GetDoubleValue(); } },
                {"EstimateBillings", n => { EstimateBillings = n.GetDoubleValue(); } },
                {"EstimateHours", n => { EstimateHours = n.GetDoubleValue(); } },
                {"Hours", n => { Hours = n.GetDoubleValue(); } },
                {"IsActive", n => { IsActive = n.GetBoolValue(); } },
                {"IsBillable", n => { IsBillable = n.GetBoolValue(); } },
                {"TaskID", n => { TaskID = n.GetStringValue(); } },
                {"TaskName", n => { TaskName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("Billings", Billings);
            writer.WriteDoubleValue("EstimateBillings", EstimateBillings);
            writer.WriteDoubleValue("EstimateHours", EstimateHours);
            writer.WriteDoubleValue("Hours", Hours);
            writer.WriteBoolValue("IsActive", IsActive);
            writer.WriteBoolValue("IsBillable", IsBillable);
            writer.WriteStringValue("TaskID", TaskID);
            writer.WriteStringValue("TaskName", TaskName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
