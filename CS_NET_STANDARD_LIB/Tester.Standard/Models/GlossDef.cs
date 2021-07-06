// <copyright file="GlossDef.cs" company="APIMatic">
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
    /// GlossDef.
    /// </summary>
    public class GlossDef : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlossDef"/> class.
        /// </summary>
        public GlossDef()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlossDef"/> class.
        /// </summary>
        /// <param name="para">para.</param>
        /// <param name="glossSeeAlso">GlossSeeAlso.</param>
        public GlossDef(
            string para,
            List<string> glossSeeAlso)
        {
            this.Para = para;
            this.GlossSeeAlso = glossSeeAlso;
        }

        /// <summary>
        /// Gets or sets Para.
        /// </summary>
        [JsonProperty("para")]
        public string Para { get; set; }

        /// <summary>
        /// Gets or sets GlossSeeAlso.
        /// </summary>
        [JsonProperty("GlossSeeAlso")]
        public List<string> GlossSeeAlso { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GlossDef : ({string.Join(", ", toStringOutput)})";
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

            return obj is GlossDef other &&
                ((this.Para == null && other.Para == null) || (this.Para?.Equals(other.Para) == true)) &&
                ((this.GlossSeeAlso == null && other.GlossSeeAlso == null) || (this.GlossSeeAlso?.Equals(other.GlossSeeAlso) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 820136119;

            if (this.Para != null)
            {
               hashCode += this.Para.GetHashCode();
            }

            if (this.GlossSeeAlso != null)
            {
               hashCode += this.GlossSeeAlso.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Para = {(this.Para == null ? "null" : this.Para == string.Empty ? "" : this.Para)}");
            toStringOutput.Add($"this.GlossSeeAlso = {(this.GlossSeeAlso == null ? "null" : $"[{string.Join(", ", this.GlossSeeAlso)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}