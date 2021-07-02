// <copyright file="RedirectSettings.cs" company="APIMatic">
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
    /// RedirectSettings.
    /// </summary>
    public class RedirectSettings : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectSettings"/> class.
        /// </summary>
        public RedirectSettings()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectSettings"/> class.
        /// </summary>
        /// <param name="redirectMode">redirectMode.</param>
        public RedirectSettings(
            string redirectMode)
        {
            this.RedirectMode = redirectMode;
        }

        /// <summary>
        /// Gets or sets RedirectMode.
        /// </summary>
        [JsonProperty("redirectMode")]
        public string RedirectMode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RedirectSettings : ({string.Join(", ", toStringOutput)})";
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

            return obj is RedirectSettings other &&
                ((this.RedirectMode == null && other.RedirectMode == null) || (this.RedirectMode?.Equals(other.RedirectMode) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -577140065;

            if (this.RedirectMode != null)
            {
               hashCode += this.RedirectMode.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RedirectMode = {(this.RedirectMode == null ? "null" : this.RedirectMode == string.Empty ? "" : this.RedirectMode)}");

            base.ToString(toStringOutput);
        }
    }
}