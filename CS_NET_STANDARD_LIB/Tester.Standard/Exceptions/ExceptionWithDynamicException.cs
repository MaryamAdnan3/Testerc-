// <copyright file="ExceptionWithDynamicException.cs" company="APIMatic">
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
    /// ExceptionWithDynamicException.
    /// </summary>
    public class ExceptionWithDynamicException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionWithDynamicException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public ExceptionWithDynamicException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value")]
        public object MValue { get; set; }

        /// <summary>
        /// Gets or sets Value1.
        /// </summary>
        [JsonProperty("value1", NullValueHandling = NullValueHandling.Ignore)]
        public object Value1 { get; set; }
    }
}