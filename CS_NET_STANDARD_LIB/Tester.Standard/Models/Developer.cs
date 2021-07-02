// <copyright file="Developer.cs" company="APIMatic">
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
    /// Developer.
    /// </summary>
    public class Developer : EmployeeComp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Developer"/> class.
        /// </summary>
        public Developer()
        {
            this.CompanyProp = "developer";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Developer"/> class.
        /// </summary>
        /// <param name="companyName">company name.</param>
        /// <param name="address">address.</param>
        /// <param name="cellNumber">cell number.</param>
        /// <param name="firstName">first name.</param>
        /// <param name="lastName">last name.</param>
        /// <param name="id">id.</param>
        /// <param name="team">team.</param>
        /// <param name="designation">designation.</param>
        /// <param name="role">role.</param>
        /// <param name="companyProp">company.</param>
        public Developer(
            string companyName,
            string address,
            string cellNumber,
            string firstName,
            string lastName,
            string id,
            string team,
            string designation,
            string role,
            string companyProp = "developer")
            : base(
                companyName,
                address,
                cellNumber,
                firstName,
                lastName,
                id,
                companyProp)
        {
            this.Team = team;
            this.Designation = designation;
            this.Role = role;
        }

        /// <summary>
        /// Gets or sets Team.
        /// </summary>
        [JsonProperty("team")]
        public string Team { get; set; }

        /// <summary>
        /// Gets or sets Designation.
        /// </summary>
        [JsonProperty("designation")]
        public string Designation { get; set; }

        /// <summary>
        /// Gets or sets Role.
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Developer : ({string.Join(", ", toStringOutput)})";
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

            return obj is Developer other &&
                ((this.Team == null && other.Team == null) || (this.Team?.Equals(other.Team) == true)) &&
                ((this.Designation == null && other.Designation == null) || (this.Designation?.Equals(other.Designation) == true)) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true)) &&
                base.Equals(obj);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 2114916169;

            if (this.Team != null)
            {
               hashCode += this.Team.GetHashCode();
            }

            if (this.Designation != null)
            {
               hashCode += this.Designation.GetHashCode();
            }

            if (this.Role != null)
            {
               hashCode += this.Role.GetHashCode();
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
            toStringOutput.Add($"this.Team = {(this.Team == null ? "null" : this.Team == string.Empty ? "" : this.Team)}");
            toStringOutput.Add($"this.Designation = {(this.Designation == null ? "null" : this.Designation == string.Empty ? "" : this.Designation)}");
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role == string.Empty ? "" : this.Role)}");

            base.ToString(toStringOutput);
        }
    }
}