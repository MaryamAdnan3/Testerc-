// <copyright file="Attributes.cs" company="APIMatic">
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
    /// Attributes.
    /// </summary>
    public class Attributes : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes"/> class.
        /// </summary>
        public Attributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes"/> class.
        /// </summary>
        /// <param name="exclusiveMaximum">exclusiveMaximum.</param>
        /// <param name="exclusiveMinimum">exclusiveMinimum.</param>
        /// <param name="id">id.</param>
        public Attributes(
            bool exclusiveMaximum,
            bool exclusiveMinimum,
            string id)
        {
            this.ExclusiveMaximum = exclusiveMaximum;
            this.ExclusiveMinimum = exclusiveMinimum;
            this.Id = id;
        }

        /// <summary>
        /// Gets or sets ExclusiveMaximum.
        /// </summary>
        [JsonProperty("exclusiveMaximum")]
        public bool ExclusiveMaximum { get; set; }

        /// <summary>
        /// Gets or sets ExclusiveMinimum.
        /// </summary>
        [JsonProperty("exclusiveMinimum")]
        public bool ExclusiveMinimum { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes : ({string.Join(", ", toStringOutput)})";
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

            return obj is Attributes other &&
                this.ExclusiveMaximum.Equals(other.ExclusiveMaximum) &&
                this.ExclusiveMinimum.Equals(other.ExclusiveMinimum) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1934119611;
            hashCode += this.ExclusiveMaximum.GetHashCode();
            hashCode += this.ExclusiveMinimum.GetHashCode();

            if (this.Id != null)
            {
               hashCode += this.Id.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExclusiveMaximum = {this.ExclusiveMaximum}");
            toStringOutput.Add($"this.ExclusiveMinimum = {this.ExclusiveMinimum}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");

            base.ToString(toStringOutput);
        }
    }
}