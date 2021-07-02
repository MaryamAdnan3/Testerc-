// <copyright file="DeleteBody.cs" company="APIMatic">
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
    /// DeleteBody.
    /// </summary>
    public class DeleteBody : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteBody"/> class.
        /// </summary>
        public DeleteBody()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteBody"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="field">field.</param>
        public DeleteBody(
            string name,
            string field)
        {
            this.Name = name;
            this.Field = field;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeleteBody : ({string.Join(", ", toStringOutput)})";
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

            return obj is DeleteBody other &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Field == null && other.Field == null) || (this.Field?.Equals(other.Field) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 990737963;

            if (this.Name != null)
            {
               hashCode += this.Name.GetHashCode();
            }

            if (this.Field != null)
            {
               hashCode += this.Field.GetHashCode();
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

            base.ToString(toStringOutput);
        }
    }
}