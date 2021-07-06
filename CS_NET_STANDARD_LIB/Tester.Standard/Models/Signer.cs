// <copyright file="Signer.cs" company="APIMatic">
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
    /// Signer.
    /// </summary>
    public class Signer : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Signer"/> class.
        /// </summary>
        public Signer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Signer"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="url">url.</param>
        /// <param name="links">links.</param>
        /// <param name="externalSignerId">externalSignerId.</param>
        /// <param name="redirectSettings">redirectSettings.</param>
        /// <param name="signatureType">signatureType.</param>
        /// <param name="ui">ui.</param>
        /// <param name="tags">tags.</param>
        /// <param name="order">order.</param>
        /// <param name="required">required.</param>
        public Signer(
            string id,
            string url,
            List<string> links,
            string externalSignerId,
            Models.RedirectSettings redirectSettings,
            Models.SignatureType signatureType,
            Models.Ui ui,
            List<string> tags,
            int order,
            bool required)
        {
            this.Id = id;
            this.Url = url;
            this.Links = links;
            this.ExternalSignerId = externalSignerId;
            this.RedirectSettings = redirectSettings;
            this.SignatureType = signatureType;
            this.Ui = ui;
            this.Tags = tags;
            this.Order = order;
            this.Required = required;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets Links.
        /// </summary>
        [JsonProperty("links")]
        public List<string> Links { get; set; }

        /// <summary>
        /// Gets or sets ExternalSignerId.
        /// </summary>
        [JsonProperty("externalSignerId")]
        public string ExternalSignerId { get; set; }

        /// <summary>
        /// Gets or sets RedirectSettings.
        /// </summary>
        [JsonProperty("redirectSettings")]
        public Models.RedirectSettings RedirectSettings { get; set; }

        /// <summary>
        /// Gets or sets SignatureType.
        /// </summary>
        [JsonProperty("signatureType")]
        public Models.SignatureType SignatureType { get; set; }

        /// <summary>
        /// Gets or sets Ui.
        /// </summary>
        [JsonProperty("ui")]
        public Models.Ui Ui { get; set; }

        /// <summary>
        /// Gets or sets Tags.
        /// </summary>
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets Order.
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets Required.
        /// </summary>
        [JsonProperty("required")]
        public bool Required { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Signer : ({string.Join(", ", toStringOutput)})";
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

            return obj is Signer other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.Links == null && other.Links == null) || (this.Links?.Equals(other.Links) == true)) &&
                ((this.ExternalSignerId == null && other.ExternalSignerId == null) || (this.ExternalSignerId?.Equals(other.ExternalSignerId) == true)) &&
                ((this.RedirectSettings == null && other.RedirectSettings == null) || (this.RedirectSettings?.Equals(other.RedirectSettings) == true)) &&
                ((this.SignatureType == null && other.SignatureType == null) || (this.SignatureType?.Equals(other.SignatureType) == true)) &&
                ((this.Ui == null && other.Ui == null) || (this.Ui?.Equals(other.Ui) == true)) &&
                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true)) &&
                this.Order.Equals(other.Order) &&
                this.Required.Equals(other.Required);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -2012605625;

            if (this.Id != null)
            {
               hashCode += this.Id.GetHashCode();
            }

            if (this.Url != null)
            {
               hashCode += this.Url.GetHashCode();
            }

            if (this.Links != null)
            {
               hashCode += this.Links.GetHashCode();
            }

            if (this.ExternalSignerId != null)
            {
               hashCode += this.ExternalSignerId.GetHashCode();
            }

            if (this.RedirectSettings != null)
            {
               hashCode += this.RedirectSettings.GetHashCode();
            }

            if (this.SignatureType != null)
            {
               hashCode += this.SignatureType.GetHashCode();
            }

            if (this.Ui != null)
            {
               hashCode += this.Ui.GetHashCode();
            }

            if (this.Tags != null)
            {
               hashCode += this.Tags.GetHashCode();
            }

            hashCode += this.Order.GetHashCode();
            hashCode += this.Required.GetHashCode();

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url == string.Empty ? "" : this.Url)}");
            toStringOutput.Add($"this.Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"this.ExternalSignerId = {(this.ExternalSignerId == null ? "null" : this.ExternalSignerId == string.Empty ? "" : this.ExternalSignerId)}");
            toStringOutput.Add($"this.RedirectSettings = {(this.RedirectSettings == null ? "null" : this.RedirectSettings.ToString())}");
            toStringOutput.Add($"this.SignatureType = {(this.SignatureType == null ? "null" : this.SignatureType.ToString())}");
            toStringOutput.Add($"this.Ui = {(this.Ui == null ? "null" : this.Ui.ToString())}");
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : $"[{string.Join(", ", this.Tags)} ]")}");
            toStringOutput.Add($"this.Order = {this.Order}");
            toStringOutput.Add($"this.Required = {this.Required}");

            base.ToString(toStringOutput);
        }
    }
}