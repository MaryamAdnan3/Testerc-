// <copyright file="DateAsOptional.cs" company="APIMatic">
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
    /// DateAsOptional.
    /// </summary>
    public class DateAsOptional : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateAsOptional"/> class.
        /// </summary>
        public DateAsOptional()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateAsOptional"/> class.
        /// </summary>
        /// <param name="date">date.</param>
        public DateAsOptional(
            DateTime? date = null)
        {
            this.Date = date;
        }

        /// <summary>
        /// Gets or sets Date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Date { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DateAsOptional : ({string.Join(", ", toStringOutput)})";
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

            return obj is DateAsOptional other &&
                ((this.Date == null && other.Date == null) || (this.Date?.Equals(other.Date) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1302469116;

            if (this.Date != null)
            {
               hashCode += this.Date.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Date = {(this.Date == null ? "null" : this.Date.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}