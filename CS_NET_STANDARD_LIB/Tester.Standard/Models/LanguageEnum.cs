// <copyright file="LanguageEnum.cs" company="APIMatic">
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
    /// LanguageEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LanguageEnum
    {
        /// <summary>
        /// EN.
        /// </summary>
        [EnumMember(Value = "EN")]
        EN,

        /// <summary>
        /// DZ.
        /// </summary>
        [EnumMember(Value = "DZ")]
        DZ,

        /// <summary>
        /// NL.
        /// </summary>
        [EnumMember(Value = "NL")]
        NL,
    }
}