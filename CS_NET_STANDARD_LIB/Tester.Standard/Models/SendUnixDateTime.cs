// <copyright file="SendUnixDateTime.cs" company="APIMatic">
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
    /// SendUnixDateTime.
    /// </summary>
    public class SendUnixDateTime : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendUnixDateTime"/> class.
        /// </summary>
        public SendUnixDateTime()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendUnixDateTime"/> class.
        /// </summary>
        /// <param name="dateTime">dateTime.</param>
        public SendUnixDateTime(
            Models.UnixDateTime dateTime = null)
        {
            this.DateTime = dateTime;
        }

        /// <summary>
        /// Gets or sets DateTime.
        /// </summary>
        [JsonProperty("dateTime", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UnixDateTime DateTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SendUnixDateTime : ({string.Join(", ", toStringOutput)})";
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

            return obj is SendUnixDateTime other &&
                ((this.DateTime == null && other.DateTime == null) || (this.DateTime?.Equals(other.DateTime) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 688964359;

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