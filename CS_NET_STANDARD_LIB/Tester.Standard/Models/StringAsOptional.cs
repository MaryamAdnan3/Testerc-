// <copyright file="StringAsOptional.cs" company="APIMatic">
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
    /// StringAsOptional.
    /// </summary>
    public class StringAsOptional : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringAsOptional"/> class.
        /// </summary>
        public StringAsOptional()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringAsOptional"/> class.
        /// </summary>
        /// <param name="mString">string.</param>
        public StringAsOptional(
            string mString = null)
        {
            this.MString = mString;
        }

        /// <summary>
        /// Gets or sets MString.
        /// </summary>
        [JsonProperty("string", NullValueHandling = NullValueHandling.Ignore)]
        public string MString { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StringAsOptional : ({string.Join(", ", toStringOutput)})";
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

            return obj is StringAsOptional other &&
                ((this.MString == null && other.MString == null) || (this.MString?.Equals(other.MString) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1153502765;

            if (this.MString != null)
            {
               hashCode += this.MString.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MString = {(this.MString == null ? "null" : this.MString == string.Empty ? "" : this.MString)}");

            base.ToString(toStringOutput);
        }
    }
}