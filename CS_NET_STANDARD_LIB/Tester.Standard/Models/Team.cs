// <copyright file="Team.cs" company="APIMatic">
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
    /// Team.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Team
    {
        /// <summary>
        /// CODEGEN.
        /// </summary>
        [EnumMember(Value = "codegen")]
        CODEGEN,

        /// <summary>
        /// CGAAS.
        /// </summary>
        [EnumMember(Value = "cgaas")]
        CGAAS,

        /// <summary>
        /// UX.
        /// </summary>
        [EnumMember(Value = "ux")]
        UX,

        /// <summary>
        /// QA.
        /// </summary>
        [EnumMember(Value = "qa")]
        QA,
    }
}