// <copyright file="NestedModelException.cs" company="APIMatic">
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
    /// NestedModelException.
    /// </summary>
    public class NestedModelException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NestedModelException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public NestedModelException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets ServerMessage.
        /// </summary>
        [JsonProperty("ServerMessage")]
        public string ServerMessage { get; set; }

        /// <summary>
        /// Gets or sets ServerCode.
        /// </summary>
        [JsonProperty("ServerCode")]
        public string ServerCode { get; set; }

        /// <summary>
        /// Gets or sets Model.
        /// </summary>
        [JsonProperty("model")]
        public Models.Validate Model { get; set; }
    }
}