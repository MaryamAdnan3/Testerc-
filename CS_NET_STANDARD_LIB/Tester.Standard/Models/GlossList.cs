// <copyright file="GlossList.cs" company="APIMatic">
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
    /// GlossList.
    /// </summary>
    public class GlossList : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlossList"/> class.
        /// </summary>
        public GlossList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlossList"/> class.
        /// </summary>
        /// <param name="glossEntry">GlossEntry.</param>
        public GlossList(
            Models.GlossEntry glossEntry)
        {
            this.GlossEntry = glossEntry;
        }

        /// <summary>
        /// Gets or sets GlossEntry.
        /// </summary>
        [JsonProperty("GlossEntry")]
        public Models.GlossEntry GlossEntry { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GlossList : ({string.Join(", ", toStringOutput)})";
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

            return obj is GlossList other &&
                ((this.GlossEntry == null && other.GlossEntry == null) || (this.GlossEntry?.Equals(other.GlossEntry) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -625939360;

            if (this.GlossEntry != null)
            {
               hashCode += this.GlossEntry.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GlossEntry = {(this.GlossEntry == null ? "null" : this.GlossEntry.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}