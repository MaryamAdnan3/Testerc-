// <copyright file="AddBooleanInGlobalException.cs" company="APIMatic">
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
    /// AddBooleanInGlobalException.
    /// </summary>
    public class AddBooleanInGlobalException : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddBooleanInGlobalException"/> class.
        /// </summary>
        public AddBooleanInGlobalException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBooleanInGlobalException"/> class.
        /// </summary>
        /// <param name="mValue">value.</param>
        /// <param name="value1">value1.</param>
        public AddBooleanInGlobalException(
            bool mValue,
            bool? value1 = null)
        {
            this.MValue = mValue;
            this.Value1 = value1;
        }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value")]
        public bool MValue { get; set; }

        /// <summary>
        /// Gets or sets Value1.
        /// </summary>
        [JsonProperty("value1", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Value1 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AddBooleanInGlobalException : ({string.Join(", ", toStringOutput)})";
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

            return obj is AddBooleanInGlobalException other &&
                this.MValue.Equals(other.MValue) &&
                ((this.Value1 == null && other.Value1 == null) || (this.Value1?.Equals(other.Value1) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -913987412;
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