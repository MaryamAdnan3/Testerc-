// <copyright file="BossCompany.cs" company="APIMatic">
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
    /// BossCompany.
    /// </summary>
    public class BossCompany : Company
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BossCompany"/> class.
        /// </summary>
        public BossCompany()
        {
            this.CompanyProp = "boss_comp";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BossCompany"/> class.
        /// </summary>
        /// <param name="companyName">company name.</param>
        /// <param name="address">address.</param>
        /// <param name="cellNumber">cell number.</param>
        /// <param name="firstName">first name.</param>
        /// <param name="lastName">last name.</param>
        /// <param name="addressBoss">address_boss.</param>
        /// <param name="companyProp">company.</param>
        public BossCompany(
            string companyName,
            string address,
            string cellNumber,
            string firstName,
            string lastName,
            string addressBoss,
            string companyProp = "boss_comp")
            : base(
                companyName,
                address,
                cellNumber,
                companyProp)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AddressBoss = addressBoss;
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
        /// Gets or sets AddressBoss.
        /// </summary>
        [JsonProperty("address_boss")]
        public string AddressBoss { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BossCompany : ({string.Join(", ", toStringOutput)})";
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

            return obj is BossCompany other &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.AddressBoss == null && other.AddressBoss == null) || (this.AddressBoss?.Equals(other.AddressBoss) == true)) &&
                base.Equals(obj);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -341601651;

            if (this.FirstName != null)
            {
               hashCode += this.FirstName.GetHashCode();
            }

            if (this.LastName != null)
            {
               hashCode += this.LastName.GetHashCode();
            }

            if (this.AddressBoss != null)
            {
               hashCode += this.AddressBoss.GetHashCode();
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
            toStringOutput.Add($"this.AddressBoss = {(this.AddressBoss == null ? "null" : this.AddressBoss == string.Empty ? "" : this.AddressBoss)}");

            base.ToString(toStringOutput);
        }
    }
}