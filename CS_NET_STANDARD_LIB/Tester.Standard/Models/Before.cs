// <copyright file="Before.cs" company="APIMatic">
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
    /// Before.
    /// </summary>
    public class Before : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Before"/> class.
        /// </summary>
        public Before()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Before"/> class.
        /// </summary>
        /// <param name="useCheckBox">useCheckBox.</param>
        /// <param name="title">title.</param>
        /// <param name="message">message.</param>
        public Before(
            bool useCheckBox,
            string title,
            string message)
        {
            this.UseCheckBox = useCheckBox;
            this.Title = title;
            this.Message = message;
        }

        /// <summary>
        /// Gets or sets UseCheckBox.
        /// </summary>
        [JsonProperty("useCheckBox")]
        public bool UseCheckBox { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Before : ({string.Join(", ", toStringOutput)})";
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

            return obj is Before other &&
                this.UseCheckBox.Equals(other.UseCheckBox) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 114235800;
            hashCode += this.UseCheckBox.GetHashCode();

            if (this.Title != null)
            {
               hashCode += this.Title.GetHashCode();
            }

            if (this.Message != null)
            {
               hashCode += this.Message.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UseCheckBox = {this.UseCheckBox}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title == string.Empty ? "" : this.Title)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message == string.Empty ? "" : this.Message)}");

            base.ToString(toStringOutput);
        }
    }
}