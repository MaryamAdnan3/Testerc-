// <copyright file="Medication.cs" company="APIMatic">
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
    /// Medication.
    /// </summary>
    public class Medication : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Medication"/> class.
        /// </summary>
        public Medication()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Medication"/> class.
        /// </summary>
        /// <param name="aceInhibitors">aceInhibitors.</param>
        /// <param name="antianginal">antianginal.</param>
        /// <param name="anticoagulants">anticoagulants.</param>
        /// <param name="betaBlocker">betaBlocker.</param>
        /// <param name="diuretic">diuretic.</param>
        /// <param name="mineral">mineral.</param>
        public Medication(
            List<Models.AceInhibitor> aceInhibitors,
            List<Models.Antianginal> antianginal,
            List<Models.Anticoagulant> anticoagulants,
            List<Models.BetaBlocker> betaBlocker,
            List<Models.Diuretic> diuretic,
            List<Models.Mineral> mineral)
        {
            this.AceInhibitors = aceInhibitors;
            this.Antianginal = antianginal;
            this.Anticoagulants = anticoagulants;
            this.BetaBlocker = betaBlocker;
            this.Diuretic = diuretic;
            this.Mineral = mineral;
        }

        /// <summary>
        /// Gets or sets AceInhibitors.
        /// </summary>
        [JsonProperty("aceInhibitors")]
        public List<Models.AceInhibitor> AceInhibitors { get; set; }

        /// <summary>
        /// Gets or sets Antianginal.
        /// </summary>
        [JsonProperty("antianginal")]
        public List<Models.Antianginal> Antianginal { get; set; }

        /// <summary>
        /// Gets or sets Anticoagulants.
        /// </summary>
        [JsonProperty("anticoagulants")]
        public List<Models.Anticoagulant> Anticoagulants { get; set; }

        /// <summary>
        /// Gets or sets BetaBlocker.
        /// </summary>
        [JsonProperty("betaBlocker")]
        public List<Models.BetaBlocker> BetaBlocker { get; set; }

        /// <summary>
        /// Gets or sets Diuretic.
        /// </summary>
        [JsonProperty("diuretic")]
        public List<Models.Diuretic> Diuretic { get; set; }

        /// <summary>
        /// Gets or sets Mineral.
        /// </summary>
        [JsonProperty("mineral")]
        public List<Models.Mineral> Mineral { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Medication : ({string.Join(", ", toStringOutput)})";
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

            return obj is Medication other &&
                ((this.AceInhibitors == null && other.AceInhibitors == null) || (this.AceInhibitors?.Equals(other.AceInhibitors) == true)) &&
                ((this.Antianginal == null && other.Antianginal == null) || (this.Antianginal?.Equals(other.Antianginal) == true)) &&
                ((this.Anticoagulants == null && other.Anticoagulants == null) || (this.Anticoagulants?.Equals(other.Anticoagulants) == true)) &&
                ((this.BetaBlocker == null && other.BetaBlocker == null) || (this.BetaBlocker?.Equals(other.BetaBlocker) == true)) &&
                ((this.Diuretic == null && other.Diuretic == null) || (this.Diuretic?.Equals(other.Diuretic) == true)) &&
                ((this.Mineral == null && other.Mineral == null) || (this.Mineral?.Equals(other.Mineral) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -267253707;

            if (this.AceInhibitors != null)
            {
               hashCode += this.AceInhibitors.GetHashCode();
            }

            if (this.Antianginal != null)
            {
               hashCode += this.Antianginal.GetHashCode();
            }

            if (this.Anticoagulants != null)
            {
               hashCode += this.Anticoagulants.GetHashCode();
            }

            if (this.BetaBlocker != null)
            {
               hashCode += this.BetaBlocker.GetHashCode();
            }

            if (this.Diuretic != null)
            {
               hashCode += this.Diuretic.GetHashCode();
            }

            if (this.Mineral != null)
            {
               hashCode += this.Mineral.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AceInhibitors = {(this.AceInhibitors == null ? "null" : $"[{string.Join(", ", this.AceInhibitors)} ]")}");
            toStringOutput.Add($"this.Antianginal = {(this.Antianginal == null ? "null" : $"[{string.Join(", ", this.Antianginal)} ]")}");
            toStringOutput.Add($"this.Anticoagulants = {(this.Anticoagulants == null ? "null" : $"[{string.Join(", ", this.Anticoagulants)} ]")}");
            toStringOutput.Add($"this.BetaBlocker = {(this.BetaBlocker == null ? "null" : $"[{string.Join(", ", this.BetaBlocker)} ]")}");
            toStringOutput.Add($"this.Diuretic = {(this.Diuretic == null ? "null" : $"[{string.Join(", ", this.Diuretic)} ]")}");
            toStringOutput.Add($"this.Mineral = {(this.Mineral == null ? "null" : $"[{string.Join(", ", this.Mineral)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}