// <copyright file="ContactDetails.cs" company="APIMatic">
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
    /// ContactDetails.
    /// </summary>
    public class ContactDetails : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactDetails"/> class.
        /// </summary>
        public ContactDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactDetails"/> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="url">url.</param>
        public ContactDetails(
            string email,
            string url)
        {
            this.Email = email;
            this.Url = url;
        }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContactDetails : ({string.Join(", ", toStringOutput)})";
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

            return obj is ContactDetails other &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 337292817;

            if (this.Email != null)
            {
               hashCode += this.Email.GetHashCode();
            }

            if (this.Url != null)
            {
               hashCode += this.Url.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email == string.Empty ? "" : this.Email)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url == string.Empty ? "" : this.Url)}");

            base.ToString(toStringOutput);
        }
    }
}