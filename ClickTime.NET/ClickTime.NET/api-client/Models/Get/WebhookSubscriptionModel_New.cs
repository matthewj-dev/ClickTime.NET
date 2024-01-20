// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Get {
    public class WebhookSubscriptionModel_New : IAdditionalDataHolder, IParsable {
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
        /// <summary>The IsActive property</summary>
        public bool? IsActive { get; set; }
        /// <summary>The Secret property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Secret { get; set; }
#nullable restore
#else
        public string Secret { get; set; }
#endif
        /// <summary>The URL property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? URL { get; set; }
#nullable restore
#else
        public string URL { get; set; }
#endif
        /// <summary>The WebHookEventTypeIDs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? WebHookEventTypeIDs { get; set; }
#nullable restore
#else
        public List<string> WebHookEventTypeIDs { get; set; }
#endif
        /// <summary>  Request requirements:Verbose=true</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClickTime.NET.Models.Get.WebHookEventTypeModel_WebHookEventTypes_Get.WebhookSubscriptionModel_New>? WebHookEventTypes { get; set; }
#nullable restore
#else
        public List<ClickTime.NET.Models.Get.WebHookEventTypeModel_WebHookEventTypes_Get.WebhookSubscriptionModel_New> WebHookEventTypes { get; set; }
#endif
        /// <summary>
        /// Instantiates a new WebhookSubscriptionModel_New and sets the default values.
        /// </summary>
        public WebhookSubscriptionModel_New() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WebhookSubscriptionModel_New CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WebhookSubscriptionModel_New();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ID", n => { ID = n.GetStringValue(); } },
                {"IsActive", n => { IsActive = n.GetBoolValue(); } },
                {"Secret", n => { Secret = n.GetStringValue(); } },
                {"URL", n => { URL = n.GetStringValue(); } },
                {"WebHookEventTypeIDs", n => { WebHookEventTypeIDs = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"WebHookEventTypes", n => { WebHookEventTypes = n.GetCollectionOfObjectValues<ClickTime.NET.Models.Get.WebHookEventTypeModel_WebHookEventTypes_Get.WebhookSubscriptionModel_New>(ClickTime.NET.Models.Get.WebHookEventTypeModel_WebHookEventTypes_Get.WebhookSubscriptionModel_New.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ID", ID);
            writer.WriteBoolValue("IsActive", IsActive);
            writer.WriteStringValue("Secret", Secret);
            writer.WriteStringValue("URL", URL);
            writer.WriteCollectionOfPrimitiveValues<string>("WebHookEventTypeIDs", WebHookEventTypeIDs);
            writer.WriteCollectionOfObjectValues<ClickTime.NET.Models.Get.WebHookEventTypeModel_WebHookEventTypes_Get.WebhookSubscriptionModel_New>("WebHookEventTypes", WebHookEventTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
