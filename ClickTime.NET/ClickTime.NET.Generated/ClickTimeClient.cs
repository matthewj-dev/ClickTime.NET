// <auto-generated/>
using ClickTime.NET.Generated.Allocations;
using ClickTime.NET.Generated.AlternativeTimeOff;
using ClickTime.NET.Generated.AlternativeTimeOffTypes;
using ClickTime.NET.Generated.BillingRates;
using ClickTime.NET.Generated.Clients;
using ClickTime.NET.Generated.Company;
using ClickTime.NET.Generated.Currencies;
using ClickTime.NET.Generated.CustomFieldDefinitions;
using ClickTime.NET.Generated.CustomMessages;
using ClickTime.NET.Generated.Divisions;
using ClickTime.NET.Generated.EmploymentTypes;
using ClickTime.NET.Generated.ExpenseItems;
using ClickTime.NET.Generated.ExpenseSheets;
using ClickTime.NET.Generated.ExpenseTypes;
using ClickTime.NET.Generated.HolidayEntries;
using ClickTime.NET.Generated.HolidayTypes;
using ClickTime.NET.Generated.Holidays;
using ClickTime.NET.Generated.Internal;
using ClickTime.NET.Generated.JobBudgets;
using ClickTime.NET.Generated.Jobs;
using ClickTime.NET.Generated.LabelEvents;
using ClickTime.NET.Generated.Labels;
using ClickTime.NET.Generated.Manage;
using ClickTime.NET.Generated.Me;
using ClickTime.NET.Generated.Notifications;
using ClickTime.NET.Generated.Overtime;
using ClickTime.NET.Generated.PaymentTypes;
using ClickTime.NET.Generated.Permissions;
using ClickTime.NET.Generated.Reports;
using ClickTime.NET.Generated.Tasks;
using ClickTime.NET.Generated.TimeEntries;
using ClickTime.NET.Generated.TimeOff;
using ClickTime.NET.Generated.TimeOffRequests;
using ClickTime.NET.Generated.TimeOffTypes;
using ClickTime.NET.Generated.Timers;
using ClickTime.NET.Generated.Timesheets;
using ClickTime.NET.Generated.Users;
using ClickTime.NET.Generated.WebhookEventTypes;
using ClickTime.NET.Generated.WebhookSubscriptions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace ClickTime.NET.Generated {
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    public class ClickTimeClient : BaseRequestBuilder {
        /// <summary>The Allocations property</summary>
        public AllocationsRequestBuilder Allocations { get =>
            new AllocationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The AlternativeTimeOff property</summary>
        public AlternativeTimeOffRequestBuilder AlternativeTimeOff { get =>
            new AlternativeTimeOffRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The AlternativeTimeOffTypes property</summary>
        public AlternativeTimeOffTypesRequestBuilder AlternativeTimeOffTypes { get =>
            new AlternativeTimeOffTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The BillingRates property</summary>
        public BillingRatesRequestBuilder BillingRates { get =>
            new BillingRatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Clients property</summary>
        public ClientsRequestBuilder Clients { get =>
            new ClientsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Company property</summary>
        public CompanyRequestBuilder Company { get =>
            new CompanyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Currencies property</summary>
        public CurrenciesRequestBuilder Currencies { get =>
            new CurrenciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CustomFieldDefinitions property</summary>
        public CustomFieldDefinitionsRequestBuilder CustomFieldDefinitions { get =>
            new CustomFieldDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CustomMessages property</summary>
        public CustomMessagesRequestBuilder CustomMessages { get =>
            new CustomMessagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Divisions property</summary>
        public DivisionsRequestBuilder Divisions { get =>
            new DivisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The EmploymentTypes property</summary>
        public EmploymentTypesRequestBuilder EmploymentTypes { get =>
            new EmploymentTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ExpenseItems property</summary>
        public ExpenseItemsRequestBuilder ExpenseItems { get =>
            new ExpenseItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ExpenseSheets property</summary>
        public ExpenseSheetsRequestBuilder ExpenseSheets { get =>
            new ExpenseSheetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ExpenseTypes property</summary>
        public ExpenseTypesRequestBuilder ExpenseTypes { get =>
            new ExpenseTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The HolidayEntries property</summary>
        public HolidayEntriesRequestBuilder HolidayEntries { get =>
            new HolidayEntriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Holidays property</summary>
        public HolidaysRequestBuilder Holidays { get =>
            new HolidaysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The HolidayTypes property</summary>
        public HolidayTypesRequestBuilder HolidayTypes { get =>
            new HolidayTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Internal property</summary>
        public InternalRequestBuilder Internal { get =>
            new InternalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The JobBudgets property</summary>
        public JobBudgetsRequestBuilder JobBudgets { get =>
            new JobBudgetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Jobs property</summary>
        public JobsRequestBuilder Jobs { get =>
            new JobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The LabelEvents property</summary>
        public LabelEventsRequestBuilder LabelEvents { get =>
            new LabelEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Labels property</summary>
        public LabelsRequestBuilder Labels { get =>
            new LabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Manage property</summary>
        public ManageRequestBuilder Manage { get =>
            new ManageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Me property</summary>
        public MeRequestBuilder Me { get =>
            new MeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Notifications property</summary>
        public NotificationsRequestBuilder Notifications { get =>
            new NotificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Overtime property</summary>
        public OvertimeRequestBuilder Overtime { get =>
            new OvertimeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The PaymentTypes property</summary>
        public PaymentTypesRequestBuilder PaymentTypes { get =>
            new PaymentTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Permissions property</summary>
        public PermissionsRequestBuilder Permissions { get =>
            new PermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Reports property</summary>
        public ReportsRequestBuilder Reports { get =>
            new ReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Tasks property</summary>
        public TasksRequestBuilder Tasks { get =>
            new TasksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The TimeEntries property</summary>
        public TimeEntriesRequestBuilder TimeEntries { get =>
            new TimeEntriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The TimeOff property</summary>
        public TimeOffRequestBuilder TimeOff { get =>
            new TimeOffRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The TimeOffRequests property</summary>
        public TimeOffRequestsRequestBuilder TimeOffRequests { get =>
            new TimeOffRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The TimeOffTypes property</summary>
        public TimeOffTypesRequestBuilder TimeOffTypes { get =>
            new TimeOffTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Timers property</summary>
        public TimersRequestBuilder Timers { get =>
            new TimersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Timesheets property</summary>
        public TimesheetsRequestBuilder Timesheets { get =>
            new TimesheetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Users property</summary>
        public UsersRequestBuilder Users { get =>
            new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The WebhookEventTypes property</summary>
        public WebhookEventTypesRequestBuilder WebhookEventTypes { get =>
            new WebhookEventTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The WebhookSubscriptions property</summary>
        public WebhookSubscriptionsRequestBuilder WebhookSubscriptions { get =>
            new WebhookSubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ClickTimeClient and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ClickTimeClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>()) {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<MultipartSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl)) {
                RequestAdapter.BaseUrl = "https://api.clicktime.com/v2";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
    }
}
