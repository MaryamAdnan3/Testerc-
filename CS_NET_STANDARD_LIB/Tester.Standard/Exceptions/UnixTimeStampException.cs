// <copyright file="UnixTimeStampException.cs" company="APIMatic">
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
    /// UnixTimeStampException.
    /// </summary>
    public class UnixTimeStampException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnixTimeStampException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public UnixTimeStampException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets DateTime.
        /// </summary>
        [JsonConverter(typeof(Tester.Standard.Utilities.UnixDateTimeConverter))]
        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets DateTime1.
        /// </summary>
        [JsonConverter(typeof(Tester.Standard.Utilities.UnixDateTimeConverter))]
        [JsonProperty("dateTime1", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateTime1 { get; set; }
    }
}