// <copyright file="Advanced.cs" company="APIMatic">
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
    /// Advanced.
    /// </summary>
    public class Advanced : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Advanced"/> class.
        /// </summary>
        public Advanced()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Advanced"/> class.
        /// </summary>
        /// <param name="tags">tags.</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="requiredSignatures">requiredSignatures.</param>
        /// <param name="getSocialSecurityNumber">getSocialSecurityNumber.</param>
        /// <param name="timeToLive">timeToLive.</param>
        public Advanced(
            List<string> tags,
            int attachments,
            int requiredSignatures,
            bool getSocialSecurityNumber,
            Models.TimeToLive timeToLive)
        {
            this.Tags = tags;
            this.Attachments = attachments;
            this.RequiredSignatures = requiredSignatures;
            this.GetSocialSecurityNumber = getSocialSecurityNumber;
            this.TimeToLive = timeToLive;
        }

        /// <summary>
        /// Gets or sets Tags.
        /// </summary>
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets Attachments.
        /// </summary>
        [JsonProperty("attachments")]
        public int Attachments { get; set; }

        /// <summary>
        /// Gets or sets RequiredSignatures.
        /// </summary>
        [JsonProperty("requiredSignatures")]
        public int RequiredSignatures { get; set; }

        /// <summary>
        /// Gets or sets GetSocialSecurityNumber.
        /// </summary>
        [JsonProperty("getSocialSecurityNumber")]
        public bool GetSocialSecurityNumber { get; set; }

        /// <summary>
        /// Gets or sets TimeToLive.
        /// </summary>
        [JsonProperty("timeToLive")]
        public Models.TimeToLive TimeToLive { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Advanced : ({string.Join(", ", toStringOutput)})";
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

            return obj is Advanced other &&
                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true)) &&
                this.Attachments.Equals(other.Attachments) &&
                this.RequiredSignatures.Equals(other.RequiredSignatures) &&
                this.GetSocialSecurityNumber.Equals(other.GetSocialSecurityNumber) &&
                ((this.TimeToLive == null && other.TimeToLive == null) || (this.TimeToLive?.Equals(other.TimeToLive) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1344157184;

            if (this.Tags != null)
            {
               hashCode += this.Tags.GetHashCode();
            }

            hashCode += this.Attachments.GetHashCode();
            hashCode += this.RequiredSignatures.GetHashCode();
            hashCode += this.GetSocialSecurityNumber.GetHashCode();

            if (this.TimeToLive != null)
            {
               hashCode += this.TimeToLive.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : $"[{string.Join(", ", this.Tags)} ]")}");
            toStringOutput.Add($"this.Attachments = {this.Attachments}");
            toStringOutput.Add($"this.RequiredSignatures = {this.RequiredSignatures}");
            toStringOutput.Add($"this.GetSocialSecurityNumber = {this.GetSocialSecurityNumber}");
            toStringOutput.Add($"this.TimeToLive = {(this.TimeToLive == null ? "null" : this.TimeToLive.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}