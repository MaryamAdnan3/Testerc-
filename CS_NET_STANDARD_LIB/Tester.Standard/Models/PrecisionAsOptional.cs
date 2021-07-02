// <copyright file="PrecisionAsOptional.cs" company="APIMatic">
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
    /// PrecisionAsOptional.
    /// </summary>
    public class PrecisionAsOptional : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrecisionAsOptional"/> class.
        /// </summary>
        public PrecisionAsOptional()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrecisionAsOptional"/> class.
        /// </summary>
        /// <param name="precision">precision.</param>
        public PrecisionAsOptional(
            double? precision = null)
        {
            this.Precision = precision;
        }

        /// <summary>
        /// Gets or sets Precision.
        /// </summary>
        [JsonProperty("precision", NullValueHandling = NullValueHandling.Ignore)]
        public double? Precision { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PrecisionAsOptional : ({string.Join(", ", toStringOutput)})";
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

            return obj is PrecisionAsOptional other &&
                ((this.Precision == null && other.Precision == null) || (this.Precision?.Equals(other.Precision) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1404359324;

            if (this.Precision != null)
            {
               hashCode += this.Precision.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Precision = {(this.Precision == null ? "null" : this.Precision.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}