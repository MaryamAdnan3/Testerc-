// <copyright file="NumberAsOptional.cs" company="APIMatic">
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
    /// NumberAsOptional.
    /// </summary>
    public class NumberAsOptional : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberAsOptional"/> class.
        /// </summary>
        public NumberAsOptional()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberAsOptional"/> class.
        /// </summary>
        /// <param name="number">number.</param>
        public NumberAsOptional(
            int? number = null)
        {
            this.Number = number;
        }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public int? Number { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NumberAsOptional : ({string.Join(", ", toStringOutput)})";
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

            return obj is NumberAsOptional other &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -728348144;

            if (this.Number != null)
            {
               hashCode += this.Number.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}