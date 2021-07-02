// <copyright file="Complex3.cs" company="APIMatic">
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
    /// Complex3.
    /// </summary>
    public class Complex3 : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Complex3"/> class.
        /// </summary>
        public Complex3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Complex3"/> class.
        /// </summary>
        /// <param name="documentId">documentId.</param>
        /// <param name="signers">signers.</param>
        /// <param name="status">status.</param>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        /// <param name="externalId">externalId.</param>
        /// <param name="dataToSign">dataToSign.</param>
        /// <param name="contactDetails">contactDetails.</param>
        /// <param name="advanced">advanced.</param>
        public Complex3(
            string documentId,
            List<Models.Signer> signers,
            Models.Status status,
            string title,
            string description,
            string externalId,
            Models.DataToSign dataToSign,
            Models.ContactDetails contactDetails,
            Models.Advanced advanced)
        {
            this.DocumentId = documentId;
            this.Signers = signers;
            this.Status = status;
            this.Title = title;
            this.Description = description;
            this.ExternalId = externalId;
            this.DataToSign = dataToSign;
            this.ContactDetails = contactDetails;
            this.Advanced = advanced;
        }

        /// <summary>
        /// Gets or sets DocumentId.
        /// </summary>
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        /// <summary>
        /// Gets or sets Signers.
        /// </summary>
        [JsonProperty("signers")]
        public List<Models.Signer> Signers { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public Models.Status Status { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets ExternalId.
        /// </summary>
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or sets DataToSign.
        /// </summary>
        [JsonProperty("dataToSign")]
        public Models.DataToSign DataToSign { get; set; }

        /// <summary>
        /// Gets or sets ContactDetails.
        /// </summary>
        [JsonProperty("contactDetails")]
        public Models.ContactDetails ContactDetails { get; set; }

        /// <summary>
        /// Gets or sets Advanced.
        /// </summary>
        [JsonProperty("advanced")]
        public Models.Advanced Advanced { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Complex3 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Complex3 other &&
                ((this.DocumentId == null && other.DocumentId == null) || (this.DocumentId?.Equals(other.DocumentId) == true)) &&
                ((this.Signers == null && other.Signers == null) || (this.Signers?.Equals(other.Signers) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.ExternalId == null && other.ExternalId == null) || (this.ExternalId?.Equals(other.ExternalId) == true)) &&
                ((this.DataToSign == null && other.DataToSign == null) || (this.DataToSign?.Equals(other.DataToSign) == true)) &&
                ((this.ContactDetails == null && other.ContactDetails == null) || (this.ContactDetails?.Equals(other.ContactDetails) == true)) &&
                ((this.Advanced == null && other.Advanced == null) || (this.Advanced?.Equals(other.Advanced) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 2107610320;

            if (this.DocumentId != null)
            {
               hashCode += this.DocumentId.GetHashCode();
            }

            if (this.Signers != null)
            {
               hashCode += this.Signers.GetHashCode();
            }

            if (this.Status != null)
            {
               hashCode += this.Status.GetHashCode();
            }

            if (this.Title != null)
            {
               hashCode += this.Title.GetHashCode();
            }

            if (this.Description != null)
            {
               hashCode += this.Description.GetHashCode();
            }

            if (this.ExternalId != null)
            {
               hashCode += this.ExternalId.GetHashCode();
            }

            if (this.DataToSign != null)
            {
               hashCode += this.DataToSign.GetHashCode();
            }

            if (this.ContactDetails != null)
            {
               hashCode += this.ContactDetails.GetHashCode();
            }

            if (this.Advanced != null)
            {
               hashCode += this.Advanced.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DocumentId = {(this.DocumentId == null ? "null" : this.DocumentId == string.Empty ? "" : this.DocumentId)}");
            toStringOutput.Add($"this.Signers = {(this.Signers == null ? "null" : $"[{string.Join(", ", this.Signers)} ]")}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title == string.Empty ? "" : this.Title)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.ExternalId = {(this.ExternalId == null ? "null" : this.ExternalId == string.Empty ? "" : this.ExternalId)}");
            toStringOutput.Add($"this.DataToSign = {(this.DataToSign == null ? "null" : this.DataToSign.ToString())}");
            toStringOutput.Add($"this.ContactDetails = {(this.ContactDetails == null ? "null" : this.ContactDetails.ToString())}");
            toStringOutput.Add($"this.Advanced = {(this.Advanced == null ? "null" : this.Advanced.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}