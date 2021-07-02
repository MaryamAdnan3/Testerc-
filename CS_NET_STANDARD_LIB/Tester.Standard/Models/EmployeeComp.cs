// <copyright file="EmployeeComp.cs" company="APIMatic">
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
    /// EmployeeComp.
    /// </summary>
    public class EmployeeComp : Company
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeComp"/> class.
        /// </summary>
        public EmployeeComp()
        {
            this.CompanyProp = "empl_comp";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeComp"/> class.
        /// </summary>
        /// <param name="companyName">company name.</param>
        /// <param name="address">address.</param>
        /// <param name="cellNumber">cell number.</param>
        /// <param name="firstName">first name.</param>
        /// <param name="lastName">last name.</param>
        /// <param name="id">id.</param>
        /// <param name="companyProp">company.</param>
        public EmployeeComp(
            string companyName,
            string address,
            string cellNumber,
            string firstName,
            string lastName,
            string id,
            string companyProp = "empl_comp")
            : base(
                companyName,
                address,
                cellNumber,
                companyProp)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        /// <summary>
        /// Gets or sets FirstName.
        /// </summary>
        [JsonProperty("first name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets LastName.
        /// </summary>
        [JsonProperty("last name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EmployeeComp : ({string.Join(", ", toStringOutput)})";
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

            return obj is EmployeeComp other &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                base.Equals(obj);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1719472147;

            if (this.FirstName != null)
            {
               hashCode += this.FirstName.GetHashCode();
            }

            if (this.LastName != null)
            {
               hashCode += this.LastName.GetHashCode();
            }

            if (this.Id != null)
            {
               hashCode += this.Id.GetHashCode();
            }

            hashCode += base.GetHashCode();

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName == string.Empty ? "" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName == string.Empty ? "" : this.LastName)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");

            base.ToString(toStringOutput);
        }
    }
}