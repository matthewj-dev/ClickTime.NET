// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Generated.Models.Get {
    public class JobPhaseModel_Root : IAdditionalDataHolder, IParsable {
        /// <summary>The AccountingPackageID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountingPackageID { get; set; }
#nullable restore
#else
        public string AccountingPackageID { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The DisplayOrder property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayOrder { get; set; }
#nullable restore
#else
        public string DisplayOrder { get; set; }
#endif
        /// <summary>The ID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ID { get; set; }
#nullable restore
#else
        public string ID { get; set; }
#endif
        /// <summary>The IsOpen property</summary>
        public bool? IsOpen { get; set; }
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ClickTime.NET.Generated.Models.Get.BasicJobModel_Job_Get.JobPhaseModel_Root? Job { get; set; }
#nullable restore
#else
        public ClickTime.NET.Generated.Models.Get.BasicJobModel_Job_Get.JobPhaseModel_Root Job { get; set; }
#endif
        /// <summary>The JobID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobID { get; set; }
#nullable restore
#else
        public string JobID { get; set; }
#endif
        /// <summary>The JobPhaseLabel property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobPhaseLabel { get; set; }
#nullable restore
#else
        public string JobPhaseLabel { get; set; }
#endif
        /// <summary>The JobPhaseName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobPhaseName { get; set; }
#nullable restore
#else
        public string JobPhaseName { get; set; }
#endif
        /// <summary>  Request requirements:CTLegacyScramble=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LegacyID { get; set; }
#nullable restore
#else
        public string LegacyID { get; set; }
#endif
        /// <summary>The ListDisplayText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ListDisplayText { get; set; }
#nullable restore
#else
        public string ListDisplayText { get; set; }
#endif
        /// <summary>The Notes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes { get; set; }
#nullable restore
#else
        public string Notes { get; set; }
#endif
        /// <summary>The PhaseID property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhaseID { get; set; }
#nullable restore
#else
        public string PhaseID { get; set; }
#endif
        /// <summary>
        /// Instantiates a new JobPhaseModel_Root and sets the default values.
        /// </summary>
        public JobPhaseModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static JobPhaseModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JobPhaseModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AccountingPackageID", n => { AccountingPackageID = n.GetStringValue(); } },
                {"DisplayOrder", n => { DisplayOrder = n.GetStringValue(); } },
                {"ID", n => { ID = n.GetStringValue(); } },
                {"IsOpen", n => { IsOpen = n.GetBoolValue(); } },
                {"Job", n => { Job = n.GetObjectValue<ClickTime.NET.Generated.Models.Get.BasicJobModel_Job_Get.JobPhaseModel_Root>(ClickTime.NET.Generated.Models.Get.BasicJobModel_Job_Get.JobPhaseModel_Root.CreateFromDiscriminatorValue); } },
                {"JobID", n => { JobID = n.GetStringValue(); } },
                {"JobPhaseLabel", n => { JobPhaseLabel = n.GetStringValue(); } },
                {"JobPhaseName", n => { JobPhaseName = n.GetStringValue(); } },
                {"LegacyID", n => { LegacyID = n.GetStringValue(); } },
                {"ListDisplayText", n => { ListDisplayText = n.GetStringValue(); } },
                {"Notes", n => { Notes = n.GetStringValue(); } },
                {"PhaseID", n => { PhaseID = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("AccountingPackageID", AccountingPackageID);
            writer.WriteStringValue("DisplayOrder", DisplayOrder);
            writer.WriteStringValue("ID", ID);
            writer.WriteBoolValue("IsOpen", IsOpen);
            writer.WriteObjectValue<ClickTime.NET.Generated.Models.Get.BasicJobModel_Job_Get.JobPhaseModel_Root>("Job", Job);
            writer.WriteStringValue("JobID", JobID);
            writer.WriteStringValue("JobPhaseLabel", JobPhaseLabel);
            writer.WriteStringValue("JobPhaseName", JobPhaseName);
            writer.WriteStringValue("LegacyID", LegacyID);
            writer.WriteStringValue("ListDisplayText", ListDisplayText);
            writer.WriteStringValue("Notes", Notes);
            writer.WriteStringValue("PhaseID", PhaseID);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
