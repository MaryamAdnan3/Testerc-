// <copyright file="AddUnixTimeStampInGlobalException.cs" company="APIMatic">
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
    /// AddUnixTimeStampInGlobalException.
    /// </summary>
    public class AddUnixTimeStampInGlobalException : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddUnixTimeStampInGlobalException"/> class.
        /// </summary>
        public AddUnixTimeStampInGlobalException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddUnixTimeStampInGlobalException"/> class.
        /// </summary>
        /// <param name="dateTime">dateTime.</param>
        /// <param name="dateTime1">dateTime1.</param>
        public AddUnixTimeStampInGlobalException(
            DateTime dateTime,
            DateTime? dateTime1 = null)
        {
            this.DateTime = dateTime;
            this.DateTime1 = dateTime1;
        }

        /// <summary>
        /// Gets or sets DateTime.
        /// </summary>
        [JsonConverter(typeof(Tester.Standard.Utilities.UnixDateTimeConverter))]
        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets DateTime1.
        /// </summary>
        [JsonConverter(typeof(Tester.Standard.Utilities.UnixDateTimeConverter))]
        [JsonProperty("dateTime1", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateTime1 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AddUnixTimeStampInGlobalException : ({string.Join(", ", toStringOutput)})";
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

            return obj is AddUnixTimeStampInGlobalException other &&
                this.DateTime.Equals(other.DateTime) &&
                ((this.DateTime1 == null && other.DateTime1 == null) || (this.DateTime1?.Equals(other.DateTime1) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -36063008;
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