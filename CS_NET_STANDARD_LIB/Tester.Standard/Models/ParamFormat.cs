// <copyright file="ParamFormat.cs" company="APIMatic">
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
    /// ParamFormat.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ParamFormat
    {
        /// <summary>
        /// Template.
        /// </summary>
        [EnumMember(Value = "Template")]
        Template,

        /// <summary>
        /// Form.
        /// </summary>
        [EnumMember(Value = "Form")]
        Form,

        /// <summary>
        /// Body.
        /// </summary>
        [EnumMember(Value = "Body")]
        Body,

        /// <summary>
        /// Header.
        /// </summary>
        [EnumMember(Value = "Header")]
        Header,

        /// <summary>
        /// Query.
        /// </summary>
        [EnumMember(Value = "Query")]
        Query,
    }
}