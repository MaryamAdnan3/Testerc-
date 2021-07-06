// <copyright file="GlossDiv.cs" company="APIMatic">
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
    /// GlossDiv.
    /// </summary>
    public class GlossDiv : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlossDiv"/> class.
        /// </summary>
        public GlossDiv()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlossDiv"/> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="glossList">GlossList.</param>
        public GlossDiv(
            string title,
            Models.GlossList glossList)
        {
            this.Title = title;
            this.GlossList = glossList;
        }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets GlossList.
        /// </summary>
        [JsonProperty("GlossList")]
        public Models.GlossList GlossList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GlossDiv : ({string.Join(", ", toStringOutput)})";
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

            return obj is GlossDiv other &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.GlossList == null && other.GlossList == null) || (this.GlossList?.Equals(other.GlossList) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 351985330;

            if (this.Title != null)
            {
               hashCode += this.Title.GetHashCode();
            }

            if (this.GlossList != null)
            {
               hashCode += this.GlossList.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title == string.Empty ? "" : this.Title)}");
            toStringOutput.Add($"this.GlossList = {(this.GlossList == null ? "null" : this.GlossList.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}