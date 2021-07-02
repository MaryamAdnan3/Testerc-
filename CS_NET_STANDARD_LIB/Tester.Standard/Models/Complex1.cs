// <copyright file="Complex1.cs" company="APIMatic">
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
    /// Complex1.
    /// </summary>
    public class Complex1 : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Complex1"/> class.
        /// </summary>
        public Complex1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Complex1"/> class.
        /// </summary>
        /// <param name="medications">medications.</param>
        /// <param name="labs">labs.</param>
        /// <param name="imaging">imaging.</param>
        public Complex1(
            List<Models.Medication> medications,
            List<Models.Lab> labs,
            List<Models.Imaging> imaging)
        {
            this.Medications = medications;
            this.Labs = labs;
            this.Imaging = imaging;
        }

        /// <summary>
        /// Gets or sets Medications.
        /// </summary>
        [JsonProperty("medications")]
        public List<Models.Medication> Medications { get; set; }

        /// <summary>
        /// Gets or sets Labs.
        /// </summary>
        [JsonProperty("labs")]
        public List<Models.Lab> Labs { get; set; }

        /// <summary>
        /// Gets or sets Imaging.
        /// </summary>
        [JsonProperty("imaging")]
        public List<Models.Imaging> Imaging { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Complex1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Complex1 other &&
                ((this.Medications == null && other.Medications == null) || (this.Medications?.Equals(other.Medications) == true)) &&
                ((this.Labs == null && other.Labs == null) || (this.Labs?.Equals(other.Labs) == true)) &&
                ((this.Imaging == null && other.Imaging == null) || (this.Imaging?.Equals(other.Imaging) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1449938333;

            if (this.Medications != null)
            {
               hashCode += this.Medications.GetHashCode();
            }

            if (this.Labs != null)
            {
               hashCode += this.Labs.GetHashCode();
            }

            if (this.Imaging != null)
            {
               hashCode += this.Imaging.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Medications = {(this.Medications == null ? "null" : $"[{string.Join(", ", this.Medications)} ]")}");
            toStringOutput.Add($"this.Labs = {(this.Labs == null ? "null" : $"[{string.Join(", ", this.Labs)} ]")}");
            toStringOutput.Add($"this.Imaging = {(this.Imaging == null ? "null" : $"[{string.Join(", ", this.Imaging)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}