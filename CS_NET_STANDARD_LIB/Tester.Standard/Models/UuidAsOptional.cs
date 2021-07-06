// <copyright file="UuidAsOptional.cs" company="APIMatic">
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
    /// UuidAsOptional.
    /// </summary>
    public class UuidAsOptional : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UuidAsOptional"/> class.
        /// </summary>
        public UuidAsOptional()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UuidAsOptional"/> class.
        /// </summary>
        /// <param name="uuid">uuid.</param>
        public UuidAsOptional(
            Guid? uuid = null)
        {
            this.Uuid = uuid;
        }

        /// <summary>
        /// Gets or sets Uuid.
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Uuid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UuidAsOptional : ({string.Join(", ", toStringOutput)})";
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

            return obj is UuidAsOptional other &&
                ((this.Uuid == null && other.Uuid == null) || (this.Uuid?.Equals(other.Uuid) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 396912040;

            if (this.Uuid != null)
            {
               hashCode += this.Uuid.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uuid = {(this.Uuid == null ? "null" : this.Uuid.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}