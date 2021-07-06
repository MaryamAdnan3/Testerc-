// <copyright file="Job.cs" company="APIMatic">
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
    /// Job.
    /// </summary>
    public class Job : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Job"/> class.
        /// </summary>
        public Job()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Job"/> class.
        /// </summary>
        /// <param name="company">company.</param>
        public Job(
            string company)
        {
            this.Company = company;
        }

        /// <summary>
        /// Gets or sets Company.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Job : ({string.Join(", ", toStringOutput)})";
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

            return obj is Job other &&
                ((this.Company == null && other.Company == null) || (this.Company?.Equals(other.Company) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 796679077;

            if (this.Company != null)
            {
               hashCode += this.Company.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Company = {(this.Company == null ? "null" : this.Company == string.Empty ? "" : this.Company)}");

            base.ToString(toStringOutput);
        }
    }
}