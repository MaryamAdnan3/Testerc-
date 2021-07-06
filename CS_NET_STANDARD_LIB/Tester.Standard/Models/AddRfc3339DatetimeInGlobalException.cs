// <copyright file="AddRfc3339DatetimeInGlobalException.cs" company="APIMatic">
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
    /// AddRfc3339DatetimeInGlobalException.
    /// </summary>
    public class AddRfc3339DatetimeInGlobalException : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddRfc3339DatetimeInGlobalException"/> class.
        /// </summary>
        public AddRfc3339DatetimeInGlobalException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRfc3339DatetimeInGlobalException"/> class.
        /// </summary>
        /// <param name="dateTime">dateTime.</param>
        /// <param name="dateTime1">dateTime1.</param>
        public AddRfc3339DatetimeInGlobalException(
            DateTime dateTime,
            DateTime? dateTime1 = null)
        {
            this.DateTime = dateTime;
            this.DateTime1 = dateTime1;
        }

        /// <summary>
        /// Gets or sets DateTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets DateTime1.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("dateTime1", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateTime1 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AddRfc3339DatetimeInGlobalException : ({string.Join(", ", toStringOutput)})";
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

            return obj is AddRfc3339DatetimeInGlobalException other &&
                this.DateTime.Equals(other.DateTime) &&
                ((this.DateTime1 == null && other.DateTime1 == null) || (this.DateTime1?.Equals(other.DateTime1) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1632715938;
            hashCode += this.DateTime.GetHashCode();

            if (this.DateTime1 != null)
            {
               hashCode += this.DateTime1.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DateTime = {this.DateTime}");
            toStringOutput.Add($"this.DateTime1 = {(this.DateTime1 == null ? "null" : this.DateTime1.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}