// <copyright file="AddDateInGlobalException.cs" company="APIMatic">
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
    /// AddDateInGlobalException.
    /// </summary>
    public class AddDateInGlobalException : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddDateInGlobalException"/> class.
        /// </summary>
        public AddDateInGlobalException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDateInGlobalException"/> class.
        /// </summary>
        /// <param name="mValue">value.</param>
        /// <param name="value1">value1.</param>
        public AddDateInGlobalException(
            DateTime mValue,
            DateTime? value1 = null)
        {
            this.MValue = mValue;
            this.Value1 = value1;
        }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("value")]
        public DateTime MValue { get; set; }

        /// <summary>
        /// Gets or sets Value1.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("value1", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Value1 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AddDateInGlobalException : ({string.Join(", ", toStringOutput)})";
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

            return obj is AddDateInGlobalException other &&
                this.MValue.Equals(other.MValue) &&
                ((this.Value1 == null && other.Value1 == null) || (this.Value1?.Equals(other.Value1) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 65852044;
            hashCode += this.MValue.GetHashCode();

            if (this.Value1 != null)
            {
               hashCode += this.Value1.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MValue = {this.MValue}");
            toStringOutput.Add($"this.Value1 = {(this.Value1 == null ? "null" : this.Value1.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}