// <copyright file="ResponseData.cs" company="APIMatic">
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
    /// ResponseData.
    /// </summary>
    public class ResponseData : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseData"/> class.
        /// </summary>
        public ResponseData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseData"/> class.
        /// </summary>
        /// <param name="feed">feed.</param>
        public ResponseData(
            Models.Feed feed)
        {
            this.Feed = feed;
        }

        /// <summary>
        /// Gets or sets Feed.
        /// </summary>
        [JsonProperty("feed")]
        public Models.Feed Feed { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseData : ({string.Join(", ", toStringOutput)})";
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

            return obj is ResponseData other &&
                ((this.Feed == null && other.Feed == null) || (this.Feed?.Equals(other.Feed) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -879768365;

            if (this.Feed != null)
            {
               hashCode += this.Feed.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Feed = {(this.Feed == null ? "null" : this.Feed.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}