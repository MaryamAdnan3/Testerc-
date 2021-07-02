// <copyright file="LongAsOptional.cs" company="APIMatic">
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
    /// LongAsOptional.
    /// </summary>
    public class LongAsOptional : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LongAsOptional"/> class.
        /// </summary>
        public LongAsOptional()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LongAsOptional"/> class.
        /// </summary>
        /// <param name="mLong">long.</param>
        public LongAsOptional(
            long? mLong = null)
        {
            this.MLong = mLong;
        }

        /// <summary>
        /// Gets or sets MLong.
        /// </summary>
        [JsonProperty("long", NullValueHandling = NullValueHandling.Ignore)]
        public long? MLong { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LongAsOptional : ({string.Join(", ", toStringOutput)})";
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

            return obj is LongAsOptional other &&
                ((this.MLong == null && other.MLong == null) || (this.MLong?.Equals(other.MLong) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1254215573;

            if (this.MLong != null)
            {
               hashCode += this.MLong.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MLong = {(this.MLong == null ? "null" : this.MLong.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}