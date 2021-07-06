// <copyright file="Type.cs" company="APIMatic">
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
    /// Type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type
    {
        /// <summary>
        /// MLong.
        /// </summary>
        [EnumMember(Value = "Long")]
        MLong,

        /// <summary>
        /// Number.
        /// </summary>
        [EnumMember(Value = "Number")]
        Number,

        /// <summary>
        /// Precision.
        /// </summary>
        [EnumMember(Value = "Precision")]
        Precision,

        /// <summary>
        /// Boolean.
        /// </summary>
        [EnumMember(Value = "Boolean")]
        Boolean,

        /// <summary>
        /// DateTime.
        /// </summary>
        [EnumMember(Value = "DateTime")]
        DateTime,

        /// <summary>
        /// Date.
        /// </summary>
        [EnumMember(Value = "Date")]
        Date,

        /// <summary>
        /// MString.
        /// </summary>
        [EnumMember(Value = "String")]
        MString,
    }
}