// <copyright file="AdditionalModelParameters.cs" company="APIMatic">
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
    /// AdditionalModelParameters.
    /// </summary>
    public class AdditionalModelParameters : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalModelParameters"/> class.
        /// </summary>
        public AdditionalModelParameters()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalModelParameters"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="field">field.</param>
        /// <param name="address">address.</param>
        /// <param name="job">Job.</param>
        public AdditionalModelParameters(
            string name,
            string field,
            string address,
            Models.Job job)
        {
            this.Name = name;
            this.Field = field;
            this.Address = address;
            this.Job = job;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Field.
        /// </summary>
        [JsonProperty("field")]
        public string Field { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets Job.
        /// </summary>
        [JsonProperty("Job")]
        public Models.Job Job { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalModelParameters : ({string.Join(", ", toStringOutput)})";
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

            return obj is AdditionalModelParameters other &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Field == null && other.Field == null) || (this.Field?.Equals(other.Field) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Job == null && other.Job == null) || (this.Job?.Equals(other.Job) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -690999044;

            if (this.Name != null)
            {
               hashCode += this.Name.GetHashCode();
            }

            if (this.Field != null)
            {
               hashCode += this.Field.GetHashCode();
            }

            if (this.Address != null)
            {
               hashCode += this.Address.GetHashCode();
            }

            if (this.Job != null)
            {
               hashCode += this.Job.GetHashCode();
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
            toStringOutput.Add($"this.Field = {(this.Field == null ? "null" : this.Field == string.Empty ? "" : this.Field)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address == string.Empty ? "" : this.Address)}");
            toStringOutput.Add($"this.Job = {(this.Job == null ? "null" : this.Job.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}