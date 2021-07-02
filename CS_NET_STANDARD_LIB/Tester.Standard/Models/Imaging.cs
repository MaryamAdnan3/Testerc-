// <copyright file="Imaging.cs" company="APIMatic">
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
    /// Imaging.
    /// </summary>
    public class Imaging : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Imaging"/> class.
        /// </summary>
        public Imaging()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Imaging"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="time">time.</param>
        /// <param name="location">location.</param>
        public Imaging(
            string name,
            string time,
            string location)
        {
            this.Name = name;
            this.Time = time;
            this.Location = location;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Time.
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }

        /// <summary>
        /// Gets or sets Location.
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Imaging : ({string.Join(", ", toStringOutput)})";
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

            return obj is Imaging other &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Time == null && other.Time == null) || (this.Time?.Equals(other.Time) == true)) &&
                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -291730050;

            if (this.Name != null)
            {
               hashCode += this.Name.GetHashCode();
            }

            if (this.Time != null)
            {
               hashCode += this.Time.GetHashCode();
            }

            if (this.Location != null)
            {
               hashCode += this.Location.GetHashCode();
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
            toStringOutput.Add($"this.Time = {(this.Time == null ? "null" : this.Time == string.Empty ? "" : this.Time)}");
            toStringOutput.Add($"this.Location = {(this.Location == null ? "null" : this.Location == string.Empty ? "" : this.Location)}");

            base.ToString(toStringOutput);
        }
    }
}