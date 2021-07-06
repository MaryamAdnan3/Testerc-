// <copyright file="Company.cs" company="APIMatic">
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
    /// Company.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "company")]
    [JsonSubtypes.KnownSubType(typeof(BossCompany), "boss_comp")]
    [JsonSubtypes.KnownSubType(typeof(EmployeeComp), "empl_comp")]
    [JsonSubtypes.KnownSubType(typeof(SoftwareTester), "Software_Tester")]
    [JsonSubtypes.KnownSubType(typeof(Developer), "developer")]
    public class Company : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        public Company()
        {
            this.CompanyProp = "comp";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        /// <param name="companyName">company name.</param>
        /// <param name="address">address.</param>
        /// <param name="cellNumber">cell number.</param>
        /// <param name="companyProp">company.</param>
        public Company(
            string companyName,
            string address,
            string cellNumber,
            string companyProp = "comp")
        {
            this.CompanyName = companyName;
            this.Address = address;
            this.CellNumber = cellNumber;
            this.CompanyProp = companyProp;
        }

        /// <summary>
        /// Gets or sets CompanyName.
        /// </summary>
        [JsonProperty("company name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets CellNumber.
        /// </summary>
        [JsonProperty("cell number")]
        public string CellNumber { get; set; }

        /// <summary>
        /// Gets or sets CompanyProp.
        /// </summary>
        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyProp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Company : ({string.Join(", ", toStringOutput)})";
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

            return obj is Company other &&
                ((this.CompanyName == null && other.CompanyName == null) || (this.CompanyName?.Equals(other.CompanyName) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.CellNumber == null && other.CellNumber == null) || (this.CellNumber?.Equals(other.CellNumber) == true)) &&
                ((this.CompanyProp == null && other.CompanyProp == null) || (this.CompanyProp?.Equals(other.CompanyProp) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1858542675;

            if (this.CompanyName != null)
            {
               hashCode += this.CompanyName.GetHashCode();
            }

            if (this.Address != null)
            {
               hashCode += this.Address.GetHashCode();
            }

            if (this.CellNumber != null)
            {
               hashCode += this.CellNumber.GetHashCode();
            }

            if (this.CompanyProp != null)
            {
               hashCode += this.CompanyProp.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CompanyName = {(this.CompanyName == null ? "null" : this.CompanyName == string.Empty ? "" : this.CompanyName)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address == string.Empty ? "" : this.Address)}");
            toStringOutput.Add($"this.CellNumber = {(this.CellNumber == null ? "null" : this.CellNumber == string.Empty ? "" : this.CellNumber)}");
            toStringOutput.Add($"this.CompanyProp = {(this.CompanyProp == null ? "null" : this.CompanyProp == string.Empty ? "" : this.CompanyProp)}");

            base.ToString(toStringOutput);
        }
    }
}