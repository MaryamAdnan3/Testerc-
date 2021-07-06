// <copyright file="UnixDateTime.cs" company="APIMatic">
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
    /// UnixDateTime.
    /// </summary>
    public class UnixDateTime : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnixDateTime"/> class.
        /// </summary>
        public UnixDateTime()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnixDateTime"/> class.
        /// </summary>
        /// <param name="dateTime">dateTime.</param>
        public UnixDateTime(
            DateTime? dateTime = null)
        {
            this.DateTime = dateTime;
        }

        /// <summary>
        /// Gets or sets DateTime.
        /// </summary>
        [JsonConverter(typeof(Tester.Standard.Utilities.UnixDateTimeConverter))]
        [JsonProperty("dateTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UnixDateTime : ({string.Join(", ", toStringOutput)})";
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

            return obj is UnixDateTime other &&
                ((this.DateTime == null && other.DateTime == null) || (this.DateTime?.Equals(other.DateTime) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 617118426;

            if (this.DateTime != null)
            {
               hashCode += this.DateTime.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DateTime = {(this.DateTime == null ? "null" : this.DateTime.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}