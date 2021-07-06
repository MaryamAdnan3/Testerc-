// <copyright file="Complex5.cs" company="APIMatic">
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
    /// Complex5.
    /// </summary>
    public class Complex5 : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Complex5"/> class.
        /// </summary>
        public Complex5()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Complex5"/> class.
        /// </summary>
        /// <param name="responseData">responseData.</param>
        /// <param name="responseStatus">responseStatus.</param>
        /// <param name="responseDetails">responseDetails.</param>
        public Complex5(
            Models.ResponseData responseData,
            int responseStatus,
            string responseDetails = null)
        {
            this.ResponseData = responseData;
            this.ResponseDetails = responseDetails;
            this.ResponseStatus = responseStatus;
        }

        /// <summary>
        /// Gets or sets ResponseData.
        /// </summary>
        [JsonProperty("responseData")]
        public Models.ResponseData ResponseData { get; set; }

        /// <summary>
        /// Gets or sets ResponseDetails.
        /// </summary>
        [JsonProperty("responseDetails", NullValueHandling = NullValueHandling.Include)]
        public string ResponseDetails { get; set; }

        /// <summary>
        /// Gets or sets ResponseStatus.
        /// </summary>
        [JsonProperty("responseStatus")]
        public int ResponseStatus { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Complex5 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Complex5 other &&
                ((this.ResponseData == null && other.ResponseData == null) || (this.ResponseData?.Equals(other.ResponseData) == true)) &&
                ((this.ResponseDetails == null && other.ResponseDetails == null) || (this.ResponseDetails?.Equals(other.ResponseDetails) == true)) &&
                this.ResponseStatus.Equals(other.ResponseStatus);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 402239263;

            if (this.ResponseData != null)
            {
               hashCode += this.ResponseData.GetHashCode();
            }

            if (this.ResponseDetails != null)
            {
               hashCode += this.ResponseDetails.GetHashCode();
            }

            hashCode += this.ResponseStatus.GetHashCode();

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ResponseData = {(this.ResponseData == null ? "null" : this.ResponseData.ToString())}");
            toStringOutput.Add($"this.ResponseDetails = {(this.ResponseDetails == null ? "null" : this.ResponseDetails == string.Empty ? "" : this.ResponseDetails)}");
            toStringOutput.Add($"this.ResponseStatus = {this.ResponseStatus}");

            base.ToString(toStringOutput);
        }
    }
}