// <copyright file="Employee.cs" company="APIMatic">
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
    /// Employee.
    /// </summary>
    public class Employee : Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        public Employee()
        {
            this.PersonType = "Empl";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="age">age.</param>
        /// <param name="birthday">birthday.</param>
        /// <param name="birthtime">birthtime.</param>
        /// <param name="name">name.</param>
        /// <param name="uid">uid.</param>
        /// <param name="department">department.</param>
        /// <param name="dependents">dependents.</param>
        /// <param name="hiredAt">hiredAt.</param>
        /// <param name="joiningDay">joiningDay.</param>
        /// <param name="salary">salary.</param>
        /// <param name="workingDays">workingDays.</param>
        /// <param name="personType">personType.</param>
        /// <param name="boss">boss.</param>
        public Employee(
            string address,
            long age,
            DateTime birthday,
            DateTime birthtime,
            string name,
            string uid,
            string department,
            List<Models.Person> dependents,
            DateTime hiredAt,
            Models.Days joiningDay,
            int salary,
            List<Models.Days> workingDays,
            string personType = "Empl",
            Models.Person boss = null)
            : base(
                address,
                age,
                birthday,
                birthtime,
                name,
                uid,
                personType)
        {
            this.Department = department;
            this.Dependents = dependents;
            this.HiredAt = hiredAt;
            this.JoiningDay = joiningDay;
            this.Salary = salary;
            this.WorkingDays = workingDays;
            this.Boss = boss;
        }

        /// <summary>
        /// Gets or sets Department.
        /// </summary>
        [JsonProperty("department")]
        public string Department { get; set; }

        /// <summary>
        /// Gets or sets Dependents.
        /// </summary>
        [JsonProperty("dependents")]
        public List<Models.Person> Dependents { get; set; }

        /// <summary>
        /// Gets or sets HiredAt.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "r")]
        [JsonProperty("hiredAt")]
        public DateTime HiredAt { get; set; }

        /// <summary>
        /// Gets or sets JoiningDay.
        /// </summary>
        [JsonProperty("joiningDay", ItemConverterType = typeof(StringEnumConverter))]
        public Models.Days JoiningDay { get; set; }

        /// <summary>
        /// Gets or sets Salary.
        /// </summary>
        [JsonProperty("salary")]
        public int Salary { get; set; }

        /// <summary>
        /// Gets or sets WorkingDays.
        /// </summary>
        [JsonProperty("workingDays", ItemConverterType = typeof(StringEnumConverter))]
        public List<Models.Days> WorkingDays { get; set; }

        /// <summary>
        /// Gets or sets Boss.
        /// </summary>
        [JsonProperty("boss", NullValueHandling = NullValueHandling.Include)]
        public Models.Person Boss { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Employee : ({string.Join(", ", toStringOutput)})";
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

            return obj is Employee other &&
                ((this.Department == null && other.Department == null) || (this.Department?.Equals(other.Department) == true)) &&
                ((this.Dependents == null && other.Dependents == null) || (this.Dependents?.Equals(other.Dependents) == true)) &&
                this.HiredAt.Equals(other.HiredAt) &&
                this.JoiningDay.Equals(other.JoiningDay) &&
                this.Salary.Equals(other.Salary) &&
                ((this.WorkingDays == null && other.WorkingDays == null) || (this.WorkingDays?.Equals(other.WorkingDays) == true)) &&
                ((this.Boss == null && other.Boss == null) || (this.Boss?.Equals(other.Boss) == true)) &&
                base.Equals(obj);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -2114944770;

            if (this.Department != null)
            {
               hashCode += this.Department.GetHashCode();
            }

            if (this.Dependents != null)
            {
               hashCode += this.Dependents.GetHashCode();
            }

            hashCode += this.HiredAt.GetHashCode();
            hashCode += this.JoiningDay.GetHashCode();
            hashCode += this.Salary.GetHashCode();

            if (this.WorkingDays != null)
            {
               hashCode += this.WorkingDays.GetHashCode();
            }

            if (this.Boss != null)
            {
               hashCode += this.Boss.GetHashCode();
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
            toStringOutput.Add($"this.Department = {(this.Department == null ? "null" : this.Department == string.Empty ? "" : this.Department)}");
            toStringOutput.Add($"this.Dependents = {(this.Dependents == null ? "null" : $"[{string.Join(", ", this.Dependents)} ]")}");
            toStringOutput.Add($"this.HiredAt = {this.HiredAt}");
            toStringOutput.Add($"this.JoiningDay = {this.JoiningDay}");
            toStringOutput.Add($"this.Salary = {this.Salary}");
            toStringOutput.Add($"this.WorkingDays = {(this.WorkingDays == null ? "null" : $"[{string.Join(", ", this.WorkingDays)} ]")}");
            toStringOutput.Add($"this.Boss = {(this.Boss == null ? "null" : this.Boss.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}