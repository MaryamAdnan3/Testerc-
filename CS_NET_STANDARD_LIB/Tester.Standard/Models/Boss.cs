// <copyright file="Boss.cs" company="APIMatic">
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
    /// Boss.
    /// </summary>
    public class Boss : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Boss"/> class.
        /// </summary>
        public Boss()
        {
            this.PersonType = "Boss";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Boss"/> class.
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
        /// <param name="promotedAt">promotedAt.</param>
        /// <param name="personType">personType.</param>
        /// <param name="bossProp">boss.</param>
        /// <param name="assistant">assistant.</param>
        public Boss(
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
            DateTime promotedAt,
            string personType = "Boss",
            Models.Person bossProp = null,
            Models.Employee assistant = null)
            : base(
                address,
                age,
                birthday,
                birthtime,
                name,
                uid,
                department,
                dependents,
                hiredAt,
                joiningDay,
                salary,
                workingDays,
                personType,
                bossProp)
        {
            this.PromotedAt = promotedAt;
            this.Assistant = assistant;
        }

        /// <summary>
        /// Gets or sets PromotedAt.
        /// </summary>
        [JsonConverter(typeof(Tester.Standard.Utilities.UnixDateTimeConverter))]
        [JsonProperty("promotedAt")]
        public DateTime PromotedAt { get; set; }

        /// <summary>
        /// Gets or sets Assistant.
        /// </summary>
        [JsonProperty("assistant", NullValueHandling = NullValueHandling.Include)]
        public Models.Employee Assistant { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Boss : ({string.Join(", ", toStringOutput)})";
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

            return obj is Boss other &&
                this.PromotedAt.Equals(other.PromotedAt) &&
                ((this.Assistant == null && other.Assistant == null) || (this.Assistant?.Equals(other.Assistant) == true)) &&
                base.Equals(obj);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 218876869;
            hashCode += this.PromotedAt.GetHashCode();

            if (this.Assistant != null)
            {
               hashCode += this.Assistant.GetHashCode();
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
            toStringOutput.Add($"this.PromotedAt = {this.PromotedAt}");
            toStringOutput.Add($"this.Assistant = {(this.Assistant == null ? "null" : this.Assistant.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}