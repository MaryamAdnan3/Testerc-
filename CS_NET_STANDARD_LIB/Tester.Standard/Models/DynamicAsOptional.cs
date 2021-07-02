// <copyright file="DynamicAsOptional.cs" company="APIMatic">
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
    /// DynamicAsOptional.
    /// </summary>
    public class DynamicAsOptional : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicAsOptional"/> class.
        /// </summary>
        public DynamicAsOptional()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicAsOptional"/> class.
        /// </summary>
        /// <param name="mDynamic">dynamic.</param>
        public DynamicAsOptional(
            object mDynamic = null)
        {
            this.MDynamic = mDynamic;
        }

        /// <summary>
        /// Gets or sets MDynamic.
        /// </summary>
        [JsonProperty("dynamic", NullValueHandling = NullValueHandling.Ignore)]
        public object MDynamic { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DynamicAsOptional : ({string.Join(", ", toStringOutput)})";
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

            return obj is DynamicAsOptional other &&
                ((this.MDynamic == null && other.MDynamic == null) || (this.MDynamic?.Equals(other.MDynamic) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 51845577;

            if (this.MDynamic != null)
            {
               hashCode += this.MDynamic.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MDynamic = {(this.MDynamic == null ? "null" : this.MDynamic.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}