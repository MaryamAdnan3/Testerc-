// <copyright file="GlobalTestException.cs" company="APIMatic">
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
    /// GlobalTestException.
    /// </summary>
    public class GlobalTestException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalTestException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public GlobalTestException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Represents the server's exception message
        /// </summary>
        [JsonProperty("ServerMessage")]
        public string ServerMessage { get; set; }

        /// <summary>
        /// Represents the server's error code
        /// </summary>
        [JsonProperty("ServerCode")]
        public int ServerCode { get; set; }
    }
}