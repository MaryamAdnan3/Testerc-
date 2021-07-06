// <copyright file="Styling.cs" company="APIMatic">
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
    /// Styling.
    /// </summary>
    public class Styling : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Styling"/> class.
        /// </summary>
        public Styling()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Styling"/> class.
        /// </summary>
        /// <param name="colorTheme">colorTheme.</param>
        /// <param name="spinner">spinner.</param>
        public Styling(
            string colorTheme,
            string spinner)
        {
            this.ColorTheme = colorTheme;
            this.Spinner = spinner;
        }

        /// <summary>
        /// Gets or sets ColorTheme.
        /// </summary>
        [JsonProperty("colorTheme")]
        public string ColorTheme { get; set; }

        /// <summary>
        /// Gets or sets Spinner.
        /// </summary>
        [JsonProperty("spinner")]
        public string Spinner { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Styling : ({string.Join(", ", toStringOutput)})";
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

            return obj is Styling other &&
                ((this.ColorTheme == null && other.ColorTheme == null) || (this.ColorTheme?.Equals(other.ColorTheme) == true)) &&
                ((this.Spinner == null && other.Spinner == null) || (this.Spinner?.Equals(other.Spinner) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1098317225;

            if (this.ColorTheme != null)
            {
               hashCode += this.ColorTheme.GetHashCode();
            }

            if (this.Spinner != null)
            {
               hashCode += this.Spinner.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColorTheme = {(this.ColorTheme == null ? "null" : this.ColorTheme == string.Empty ? "" : this.ColorTheme)}");
            toStringOutput.Add($"this.Spinner = {(this.Spinner == null ? "null" : this.Spinner == string.Empty ? "" : this.Spinner)}");

            base.ToString(toStringOutput);
        }
    }
}