// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ClickTime.NET.Models.Get {
    /// <summary>  User requirements:Security Level(s): Admin, Manager (View Billingrates)Security Level(s): Admin, Manager (Add/Edit Jobs)  Company requirements:Billing rate model(s): Task x Job, User x Job</summary>
    public enum JobModel_New_SecondaryBillingRateMode {
        [EnumMember(Value = "INHERIT")]
        INHERIT,
        [EnumMember(Value = "CUSTOM")]
        CUSTOM,
        [EnumMember(Value = "FLAT")]
        FLAT,
    }
}
