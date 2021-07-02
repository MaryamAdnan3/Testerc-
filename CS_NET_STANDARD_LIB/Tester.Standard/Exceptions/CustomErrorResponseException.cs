// <copyright file="CustomErrorResponseException.cs" company="APIMatic">
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
    /// CustomErrorResponseException.
    /// </summary>
    public class CustomErrorResponseException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomErrorResponseException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public CustomErrorResponseException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets ErrorDescription.
        /// </summary>
        [JsonProperty("error description")]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Gets or sets Caught.
        /// </summary>
        [JsonProperty("caught")]
        public string Caught { get; set; }

        /// <summary>
        /// Gets or sets Exception.
        /// </summary>
        [JsonProperty("Exception")]
        public string Exception { get; set; }

        /// <summary>
        /// Gets or sets InnerException.
        /// </summary>
        [JsonProperty("Inner Exception")]
        public string InnerException { get; set; }
    }
}