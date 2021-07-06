// <copyright file="LocalTestException.cs" company="APIMatic">
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
    /// LocalTestException.
    /// </summary>
    public class LocalTestException : GlobalTestException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalTestException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public LocalTestException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Represents the specific endpoint info
        /// </summary>
        [JsonProperty("SecretMessageForEndpoint")]
        public string SecretMessageForEndpoint { get; set; }
    }
}