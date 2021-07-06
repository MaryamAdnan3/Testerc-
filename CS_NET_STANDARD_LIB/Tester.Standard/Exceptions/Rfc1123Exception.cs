// <copyright file="Rfc1123Exception.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Tester.Standard.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Tester.Standard;
    using Tester.Standard.Http.Client;
    using Tester.Standard.Models;
    using Tester.Standard.Utilities;

    /// <summary>
    /// Rfc1123Exception.
    /// </summary>
    public class Rfc1123Exception : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rfc1123Exception"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public Rfc1123Exception(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets DateTime.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "r")]
        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets DateTime1.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "r")]
        [JsonProperty("dateTime1", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateTime1 { get; set; }
    }
}