// <copyright file="Glossary.cs" company="APIMatic">
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
    /// Glossary.
    /// </summary>
    public class Glossary : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Glossary"/> class.
        /// </summary>
        public Glossary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Glossary"/> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="glossDiv">GlossDiv.</param>
        public Glossary(
            string title,
            Models.GlossDiv glossDiv)
        {
            this.Title = title;
            this.GlossDiv = glossDiv;
        }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets GlossDiv.
        /// </summary>
        [JsonProperty("GlossDiv")]
        public Models.GlossDiv GlossDiv { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Glossary : ({string.Join(", ", toStringOutput)})";
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

            return obj is Glossary other &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.GlossDiv == null && other.GlossDiv == null) || (this.GlossDiv?.Equals(other.GlossDiv) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1492683545;

            if (this.Title != null)
            {
               hashCode += this.Title.GetHashCode();
            }

            if (this.GlossDiv != null)
            {
               hashCode += this.GlossDiv.GetHashCode();
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
            toStringOutput.Add($"this.GlossDiv = {(this.GlossDiv == null ? "null" : this.GlossDiv.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}