// <copyright file="Person.cs" company="APIMatic">
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
    /// Person.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "personType")]
    [JsonSubtypes.KnownSubType(typeof(Employee), "Empl")]
    [JsonSubtypes.KnownSubType(typeof(Boss), "Boss")]
    public class Person : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {
            this.PersonType = "Per";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="age">age.</param>
        /// <param name="birthday">birthday.</param>
        /// <param name="birthtime">birthtime.</param>
        /// <param name="name">name.</param>
        /// <param name="uid">uid.</param>
        /// <param name="personType">personType.</param>
        public Person(
            string address,
            long age,
            DateTime birthday,
            DateTime birthtime,
            string name,
            string uid,
            string personType = "Per")
        {
            this.Address = address;
            this.Age = age;
            this.Birthday = birthday;
            this.Birthtime = birthtime;
            this.Name = name;
            this.Uid = uid;
            this.PersonType = personType;
        }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets Age.
        /// </summary>
        [JsonProperty("age")]
        public long Age { get; set; }

        /// <summary>
        /// Gets or sets Birthday.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Gets or sets Birthtime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("birthtime")]
        public DateTime Birthtime { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Uid.
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets PersonType.
        /// </summary>
        [JsonProperty("personType", NullValueHandling = NullValueHandling.Ignore)]
        public string PersonType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Person : ({string.Join(", ", toStringOutput)})";
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

            return obj is Person other &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                this.Age.Equals(other.Age) &&
                this.Birthday.Equals(other.Birthday) &&
                this.Birthtime.Equals(other.Birthtime) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.PersonType == null && other.PersonType == null) || (this.PersonType?.Equals(other.PersonType) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1043646439;

            if (this.Address != null)
            {
               hashCode += this.Address.GetHashCode();
            }

            hashCode += this.Age.GetHashCode();
            hashCode += this.Birthday.GetHashCode();
            hashCode += this.Birthtime.GetHashCode();

            if (this.Name != null)
            {
               hashCode += this.Name.GetHashCode();
            }

            if (this.Uid != null)
            {
               hashCode += this.Uid.GetHashCode();
            }

            if (this.PersonType != null)
            {
               hashCode += this.PersonType.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address == string.Empty ? "" : this.Address)}");
            toStringOutput.Add($"this.Age = {this.Age}");
            toStringOutput.Add($"this.Birthday = {this.Birthday}");
            toStringOutput.Add($"this.Birthtime = {this.Birthtime}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid == string.Empty ? "" : this.Uid)}");
            toStringOutput.Add($"this.PersonType = {(this.PersonType == null ? "null" : this.PersonType == string.Empty ? "" : this.PersonType)}");

            base.ToString(toStringOutput);
        }
    }
}