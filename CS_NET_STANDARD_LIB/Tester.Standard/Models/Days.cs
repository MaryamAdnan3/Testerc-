// <copyright file="Days.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Tester.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Tester.Standard;
    using Tester.Standard.Utilities;

    /// <summary>
    /// Days.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Days
    {
        /// <summary>
        /// Sunday.
        /// </summary>
        [EnumMember(Value = "Sunday")]
        Sunday,

        /// <summary>
        /// Monday.
        /// </summary>
        [EnumMember(Value = "Monday")]
        Monday,

        /// <summary>
        /// Tuesday.
        /// </summary>
        [EnumMember(Value = "Tuesday")]
        Tuesday,

        /// <summary>
        /// Wednesday.
        /// </summary>
        [EnumMember(Value = "Wednesday")]
        Wednesday,

        /// <summary>
        /// Thursday.
        /// </summary>
        [EnumMember(Value = "Thursday")]
        Thursday,

        /// <summary>
        /// FriDay.
        /// </summary>
        [EnumMember(Value = "Friday")]
        FriDay,

        /// <summary>
        /// Saturday.
        /// </summary>
        [EnumMember(Value = "Saturday")]
        Saturday,
    }
}