// <copyright file="TestNstringEncoding.cs" company="APIMatic">
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
    /// TestNstringEncoding.
    /// </summary>
    public class TestNstringEncoding : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestNstringEncoding"/> class.
        /// </summary>
        public TestNstringEncoding()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestNstringEncoding"/> class.
        /// </summary>
        /// <param name="field">field.</param>
        /// <param name="name">name.</param>
        public TestNstringEncoding(
            string field,
            string name)
        {
            this.Field = field;
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets Field.
        /// </summary>
        [JsonProperty("field")]
        public string Field { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TestNstringEncoding : ({string.Join(", ", toStringOutput)})";
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

            return obj is TestNstringEncoding other &&
                ((this.Field == null && other.Field == null) || (this.Field?.Equals(other.Field) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 177504469;

            if (this.Field != null)
            {
               hashCode += this.Field.GetHashCode();
            }

            if (this.Name != null)
            {
               hashCode += this.Name.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Field = {(this.Field == null ? "null" : this.Field == string.Empty ? "" : this.Field)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");

            base.ToString(toStringOutput);
        }
    }
}