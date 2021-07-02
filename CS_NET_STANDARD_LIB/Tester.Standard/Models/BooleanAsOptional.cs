// <copyright file="BooleanAsOptional.cs" company="APIMatic">
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
    /// BooleanAsOptional.
    /// </summary>
    public class BooleanAsOptional : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanAsOptional"/> class.
        /// </summary>
        public BooleanAsOptional()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanAsOptional"/> class.
        /// </summary>
        /// <param name="boolean">boolean.</param>
        public BooleanAsOptional(
            bool? boolean = null)
        {
            this.Boolean = boolean;
        }

        /// <summary>
        /// Gets or sets Boolean.
        /// </summary>
        [JsonProperty("boolean", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Boolean { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BooleanAsOptional : ({string.Join(", ", toStringOutput)})";
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

            return obj is BooleanAsOptional other &&
                ((this.Boolean == null && other.Boolean == null) || (this.Boolean?.Equals(other.Boolean) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1411335933;

            if (this.Boolean != null)
            {
               hashCode += this.Boolean.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Boolean = {(this.Boolean == null ? "null" : this.Boolean.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}