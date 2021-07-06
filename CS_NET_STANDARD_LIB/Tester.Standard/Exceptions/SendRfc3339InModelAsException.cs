// <copyright file="SendRfc3339InModelAsException.cs" company="APIMatic">
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
    /// SendRfc3339InModelAsException.
    /// </summary>
    public class SendRfc3339InModelAsException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendRfc3339InModelAsException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public SendRfc3339InModelAsException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Body.
        /// </summary>
        [JsonProperty("body")]
        public Models.AddRfc3339DatetimeInGlobalException Body { get; set; }
    }
}