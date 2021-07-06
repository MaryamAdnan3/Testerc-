// <copyright file="ModelWithOptionalRfc3339DateTime.cs" company="APIMatic">
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
    /// ModelWithOptionalRfc3339DateTime.
    /// </summary>
    public class ModelWithOptionalRfc3339DateTime : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelWithOptionalRfc3339DateTime"/> class.
        /// </summary>
        public ModelWithOptionalRfc3339DateTime()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelWithOptionalRfc3339DateTime"/> class.
        /// </summary>
        /// <param name="dateTime">dateTime.</param>
        public ModelWithOptionalRfc3339DateTime(
            DateTime? dateTime = null)
        {
            this.DateTime = dateTime;
        }

        /// <summary>
        /// Gets or sets DateTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("dateTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ModelWithOptionalRfc3339DateTime : ({string.Join(", ", toStringOutput)})";
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

            return obj is ModelWithOptionalRfc3339DateTime other &&
                ((this.DateTime == null && other.DateTime == null) || (this.DateTime?.Equals(other.DateTime) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1381114810;

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