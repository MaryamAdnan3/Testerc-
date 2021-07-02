// <copyright file="EchoResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Tester.Standard.Models
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
    using Tester.Standard.Utilities;

    /// <summary>
    /// EchoResponse.
    /// </summary>
    public class EchoResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EchoResponse"/> class.
        /// </summary>
        public EchoResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EchoResponse"/> class.
        /// </summary>
        /// <param name="body">body.</param>
        /// <param name="headers">headers.</param>
        /// <param name="method">method.</param>
        /// <param name="path">path.</param>
        /// <param name="query">query.</param>
        /// <param name="uploadCount">uploadCount.</param>
        public EchoResponse(
            object body = null,
            Dictionary<string, string> headers = null,
            string method = null,
            string path = null,
            Dictionary<string, Models.QueryParameter> query = null,
            int? uploadCount = null)
        {
            this.Body = body;
            this.Headers = headers;
            this.Method = method;
            this.Path = path;
            this.Query = query;
            this.UploadCount = uploadCount;
        }

        /// <summary>
        /// Gets or sets Body.
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public object Body { get; set; }

        /// <summary>
        /// Gets or sets Headers.
        /// </summary>
        [JsonProperty("headers", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Gets or sets Method.
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public string Method { get; set; }

        /// <summary>
        /// relativePath
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets Query.
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.QueryParameter> Query { get; set; }

        /// <summary>
        /// Gets or sets UploadCount.
        /// </summary>
        [JsonProperty("uploadCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? UploadCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EchoResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is EchoResponse other &&
                ((this.Body == null && other.Body == null) || (this.Body?.Equals(other.Body) == true)) &&
                ((this.Headers == null && other.Headers == null) || (this.Headers?.Equals(other.Headers) == true)) &&
                ((this.Method == null && other.Method == null) || (this.Method?.Equals(other.Method) == true)) &&
                ((this.Path == null && other.Path == null) || (this.Path?.Equals(other.Path) == true)) &&
                ((this.Query == null && other.Query == null) || (this.Query?.Equals(other.Query) == true)) &&
                ((this.UploadCount == null && other.UploadCount == null) || (this.UploadCount?.Equals(other.UploadCount) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -544656015;

            if (this.Body != null)
            {
               hashCode += this.Body.GetHashCode();
            }

            if (this.Headers != null)
            {
               hashCode += this.Headers.GetHashCode();
            }

            if (this.Method != null)
            {
               hashCode += this.Method.GetHashCode();
            }

            if (this.Path != null)
            {
               hashCode += this.Path.GetHashCode();
            }

            if (this.Query != null)
            {
               hashCode += this.Query.GetHashCode();
            }

            if (this.UploadCount != null)
            {
               hashCode += this.UploadCount.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Body = {(this.Body == null ? "null" : this.Body.ToString())}");
            toStringOutput.Add($"Headers = {(this.Headers == null ? "null" : this.Headers.ToString())}");
            toStringOutput.Add($"this.Method = {(this.Method == null ? "null" : this.Method == string.Empty ? "" : this.Method)}");
            toStringOutput.Add($"this.Path = {(this.Path == null ? "null" : this.Path == string.Empty ? "" : this.Path)}");
            toStringOutput.Add($"Query = {(this.Query == null ? "null" : this.Query.ToString())}");
            toStringOutput.Add($"this.UploadCount = {(this.UploadCount == null ? "null" : this.UploadCount.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}