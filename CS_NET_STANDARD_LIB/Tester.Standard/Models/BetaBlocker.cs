// <copyright file="BetaBlocker.cs" company="APIMatic">
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
    /// BetaBlocker.
    /// </summary>
    public class BetaBlocker : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBlocker"/> class.
        /// </summary>
        public BetaBlocker()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBlocker"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="strength">strength.</param>
        /// <param name="dose">dose.</param>
        /// <param name="route">route.</param>
        /// <param name="sig">sig.</param>
        /// <param name="pillCount">pillCount.</param>
        /// <param name="refills">refills.</param>
        public BetaBlocker(
            string name,
            string strength,
            string dose,
            string route,
            string sig,
            string pillCount,
            string refills)
        {
            this.Name = name;
            this.Strength = strength;
            this.Dose = dose;
            this.Route = route;
            this.Sig = sig;
            this.PillCount = pillCount;
            this.Refills = refills;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Strength.
        /// </summary>
        [JsonProperty("strength")]
        public string Strength { get; set; }

        /// <summary>
        /// Gets or sets Dose.
        /// </summary>
        [JsonProperty("dose")]
        public string Dose { get; set; }

        /// <summary>
        /// Gets or sets Route.
        /// </summary>
        [JsonProperty("route")]
        public string Route { get; set; }

        /// <summary>
        /// Gets or sets Sig.
        /// </summary>
        [JsonProperty("sig")]
        public string Sig { get; set; }

        /// <summary>
        /// Gets or sets PillCount.
        /// </summary>
        [JsonProperty("pillCount")]
        public string PillCount { get; set; }

        /// <summary>
        /// Gets or sets Refills.
        /// </summary>
        [JsonProperty("refills")]
        public string Refills { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BetaBlocker : ({string.Join(", ", toStringOutput)})";
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

            return obj is BetaBlocker other &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Strength == null && other.Strength == null) || (this.Strength?.Equals(other.Strength) == true)) &&
                ((this.Dose == null && other.Dose == null) || (this.Dose?.Equals(other.Dose) == true)) &&
                ((this.Route == null && other.Route == null) || (this.Route?.Equals(other.Route) == true)) &&
                ((this.Sig == null && other.Sig == null) || (this.Sig?.Equals(other.Sig) == true)) &&
                ((this.PillCount == null && other.PillCount == null) || (this.PillCount?.Equals(other.PillCount) == true)) &&
                ((this.Refills == null && other.Refills == null) || (this.Refills?.Equals(other.Refills) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1242164897;

            if (this.Name != null)
            {
               hashCode += this.Name.GetHashCode();
            }

            if (this.Strength != null)
            {
               hashCode += this.Strength.GetHashCode();
            }

            if (this.Dose != null)
            {
               hashCode += this.Dose.GetHashCode();
            }

            if (this.Route != null)
            {
               hashCode += this.Route.GetHashCode();
            }

            if (this.Sig != null)
            {
               hashCode += this.Sig.GetHashCode();
            }

            if (this.PillCount != null)
            {
               hashCode += this.PillCount.GetHashCode();
            }

            if (this.Refills != null)
            {
               hashCode += this.Refills.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Strength = {(this.Strength == null ? "null" : this.Strength == string.Empty ? "" : this.Strength)}");
            toStringOutput.Add($"this.Dose = {(this.Dose == null ? "null" : this.Dose == string.Empty ? "" : this.Dose)}");
            toStringOutput.Add($"this.Route = {(this.Route == null ? "null" : this.Route == string.Empty ? "" : this.Route)}");
            toStringOutput.Add($"this.Sig = {(this.Sig == null ? "null" : this.Sig == string.Empty ? "" : this.Sig)}");
            toStringOutput.Add($"this.PillCount = {(this.PillCount == null ? "null" : this.PillCount == string.Empty ? "" : this.PillCount)}");
            toStringOutput.Add($"this.Refills = {(this.Refills == null ? "null" : this.Refills == string.Empty ? "" : this.Refills)}");

            base.ToString(toStringOutput);
        }
    }
}