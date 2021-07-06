// <copyright file="Complex2.cs" company="APIMatic">
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
    /// Complex2.
    /// </summary>
    public class Complex2 : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Complex2"/> class.
        /// </summary>
        public Complex2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Complex2"/> class.
        /// </summary>
        /// <param name="glossary">glossary.</param>
        public Complex2(
            Models.Glossary glossary)
        {
            this.Glossary = glossary;
        }

        /// <summary>
        /// Gets or sets Glossary.
        /// </summary>
        [JsonProperty("glossary")]
        public Models.Glossary Glossary { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Complex2 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Complex2 other &&
                ((this.Glossary == null && other.Glossary == null) || (this.Glossary?.Equals(other.Glossary) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -729603796;

            if (this.Glossary != null)
            {
               hashCode += this.Glossary.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Glossary = {(this.Glossary == null ? "null" : this.Glossary.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}