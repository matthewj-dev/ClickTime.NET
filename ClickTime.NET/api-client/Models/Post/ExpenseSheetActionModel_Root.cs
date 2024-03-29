// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ClickTime.NET.Models.Post {
    public class ExpenseSheetActionModel_Root : IAdditionalDataHolder, IParsable {
        /// <summary>The Action property</summary>
        public ExpenseSheetActionModel_Root_Action? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>CC&apos;d recipients only receive an email if a notification is sent at all.We do not send notifications if, for example, you approve an Expense Sheetfor a user who is configured not to receive expense approval alerts.The API will return a warning in the &quot;meta&quot; object if a value forCCNotifications has been supplied but not used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CCNotifications { get; set; }
#nullable restore
#else
        public List<string> CCNotifications { get; set; }
#endif
        /// <summary>Check Number when marking the expense sheet as Paid</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Check { get; set; }
#nullable restore
#else
        public string Check { get; set; }
#endif
        /// <summary>Required when rejecting or undoing approval on your own Expense Sheet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ExpenseSheetActionModel_Root and sets the default values.
        /// </summary>
        public ExpenseSheetActionModel_Root() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExpenseSheetActionModel_Root CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExpenseSheetActionModel_Root();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Action", n => { Action = n.GetEnumValue<ExpenseSheetActionModel_Root_Action>(); } },
                {"CCNotifications", n => { CCNotifications = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"Check", n => { Check = n.GetStringValue(); } },
                {"Comment", n => { Comment = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ExpenseSheetActionModel_Root_Action>("Action", Action);
            writer.WriteCollectionOfPrimitiveValues<string>("CCNotifications", CCNotifications);
            writer.WriteStringValue("Check", Check);
            writer.WriteStringValue("Comment", Comment);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
