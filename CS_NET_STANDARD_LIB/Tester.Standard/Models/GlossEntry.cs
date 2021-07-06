// <copyright file="GlossEntry.cs" company="APIMatic">
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
    /// GlossEntry.
    /// </summary>
    public class GlossEntry : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlossEntry"/> class.
        /// </summary>
        public GlossEntry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlossEntry"/> class.
        /// </summary>
        /// <param name="iD">ID.</param>
        /// <param name="sortAs">SortAs.</param>
        /// <param name="glossTerm">GlossTerm.</param>
        /// <param name="acronym">Acronym.</param>
        /// <param name="abbrev">Abbrev.</param>
        /// <param name="glossDef">GlossDef.</param>
        /// <param name="glossSee">GlossSee.</param>
        public GlossEntry(
            string iD,
            string sortAs,
            string glossTerm,
            string acronym,
            string abbrev,
            Models.GlossDef glossDef,
            string glossSee)
        {
            this.ID = iD;
            this.SortAs = sortAs;
            this.GlossTerm = glossTerm;
            this.Acronym = acronym;
            this.Abbrev = abbrev;
            this.GlossDef = glossDef;
            this.GlossSee = glossSee;
        }

        /// <summary>
        /// Gets or sets ID.
        /// </summary>
        [JsonProperty("ID")]
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets SortAs.
        /// </summary>
        [JsonProperty("SortAs")]
        public string SortAs { get; set; }

        /// <summary>
        /// Gets or sets GlossTerm.
        /// </summary>
        [JsonProperty("GlossTerm")]
        public string GlossTerm { get; set; }

        /// <summary>
        /// Gets or sets Acronym.
        /// </summary>
        [JsonProperty("Acronym")]
        public string Acronym { get; set; }

        /// <summary>
        /// Gets or sets Abbrev.
        /// </summary>
        [JsonProperty("Abbrev")]
        public string Abbrev { get; set; }

        /// <summary>
        /// Gets or sets GlossDef.
        /// </summary>
        [JsonProperty("GlossDef")]
        public Models.GlossDef GlossDef { get; set; }

        /// <summary>
        /// Gets or sets GlossSee.
        /// </summary>
        [JsonProperty("GlossSee")]
        public string GlossSee { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GlossEntry : ({string.Join(", ", toStringOutput)})";
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

            return obj is GlossEntry other &&
                ((this.ID == null && other.ID == null) || (this.ID?.Equals(other.ID) == true)) &&
                ((this.SortAs == null && other.SortAs == null) || (this.SortAs?.Equals(other.SortAs) == true)) &&
                ((this.GlossTerm == null && other.GlossTerm == null) || (this.GlossTerm?.Equals(other.GlossTerm) == true)) &&
                ((this.Acronym == null && other.Acronym == null) || (this.Acronym?.Equals(other.Acronym) == true)) &&
                ((this.Abbrev == null && other.Abbrev == null) || (this.Abbrev?.Equals(other.Abbrev) == true)) &&
                ((this.GlossDef == null && other.GlossDef == null) || (this.GlossDef?.Equals(other.GlossDef) == true)) &&
                ((this.GlossSee == null && other.GlossSee == null) || (this.GlossSee?.Equals(other.GlossSee) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -396316361;

            if (this.ID != null)
            {
               hashCode += this.ID.GetHashCode();
            }

            if (this.SortAs != null)
            {
               hashCode += this.SortAs.GetHashCode();
            }

            if (this.GlossTerm != null)
            {
               hashCode += this.GlossTerm.GetHashCode();
            }

            if (this.Acronym != null)
            {
               hashCode += this.Acronym.GetHashCode();
            }

            if (this.Abbrev != null)
            {
               hashCode += this.Abbrev.GetHashCode();
            }

            if (this.GlossDef != null)
            {
               hashCode += this.GlossDef.GetHashCode();
            }

            if (this.GlossSee != null)
            {
               hashCode += this.GlossSee.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ID = {(this.ID == null ? "null" : this.ID == string.Empty ? "" : this.ID)}");
            toStringOutput.Add($"this.SortAs = {(this.SortAs == null ? "null" : this.SortAs == string.Empty ? "" : this.SortAs)}");
            toStringOutput.Add($"this.GlossTerm = {(this.GlossTerm == null ? "null" : this.GlossTerm == string.Empty ? "" : this.GlossTerm)}");
            toStringOutput.Add($"this.Acronym = {(this.Acronym == null ? "null" : this.Acronym == string.Empty ? "" : this.Acronym)}");
            toStringOutput.Add($"this.Abbrev = {(this.Abbrev == null ? "null" : this.Abbrev == string.Empty ? "" : this.Abbrev)}");
            toStringOutput.Add($"this.GlossDef = {(this.GlossDef == null ? "null" : this.GlossDef.ToString())}");
            toStringOutput.Add($"this.GlossSee = {(this.GlossSee == null ? "null" : this.GlossSee == string.Empty ? "" : this.GlossSee)}");

            base.ToString(toStringOutput);
        }
    }
}