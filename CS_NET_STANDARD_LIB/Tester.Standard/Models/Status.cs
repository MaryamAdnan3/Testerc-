// <copyright file="Status.cs" company="APIMatic">
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
    /// Status.
    /// </summary>
    public class Status : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Status"/> class.
        /// </summary>
        public Status()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Status"/> class.
        /// </summary>
        /// <param name="documentStatus">documentStatus.</param>
        /// <param name="completedPackages">completedPackages.</param>
        /// <param name="attachmentPackages">attachmentPackages.</param>
        public Status(
            string documentStatus,
            List<string> completedPackages,
            object attachmentPackages)
        {
            this.DocumentStatus = documentStatus;
            this.CompletedPackages = completedPackages;
            this.AttachmentPackages = attachmentPackages;
        }

        /// <summary>
        /// Gets or sets DocumentStatus.
        /// </summary>
        [JsonProperty("documentStatus")]
        public string DocumentStatus { get; set; }

        /// <summary>
        /// Gets or sets CompletedPackages.
        /// </summary>
        [JsonProperty("completedPackages")]
        public List<string> CompletedPackages { get; set; }

        /// <summary>
        /// Gets or sets AttachmentPackages.
        /// </summary>
        [JsonProperty("attachmentPackages")]
        public object AttachmentPackages { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Status : ({string.Join(", ", toStringOutput)})";
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

            return obj is Status other &&
                ((this.DocumentStatus == null && other.DocumentStatus == null) || (this.DocumentStatus?.Equals(other.DocumentStatus) == true)) &&
                ((this.CompletedPackages == null && other.CompletedPackages == null) || (this.CompletedPackages?.Equals(other.CompletedPackages) == true)) &&
                ((this.AttachmentPackages == null && other.AttachmentPackages == null) || (this.AttachmentPackages?.Equals(other.AttachmentPackages) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1020846974;

            if (this.DocumentStatus != null)
            {
               hashCode += this.DocumentStatus.GetHashCode();
            }

            if (this.CompletedPackages != null)
            {
               hashCode += this.CompletedPackages.GetHashCode();
            }

            if (this.AttachmentPackages != null)
            {
               hashCode += this.AttachmentPackages.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DocumentStatus = {(this.DocumentStatus == null ? "null" : this.DocumentStatus == string.Empty ? "" : this.DocumentStatus)}");
            toStringOutput.Add($"this.CompletedPackages = {(this.CompletedPackages == null ? "null" : $"[{string.Join(", ", this.CompletedPackages)} ]")}");
            toStringOutput.Add($"AttachmentPackages = {(this.AttachmentPackages == null ? "null" : this.AttachmentPackages.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}