// <copyright file="SendMixedArrayInput.cs" company="APIMatic">
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
    using Tester.Standard.Http.Client;
    using Tester.Standard.Utilities;

    /// <summary>
    /// SendMixedArrayInput.
    /// </summary>
    public class SendMixedArrayInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendMixedArrayInput"/> class.
        /// </summary>
        public SendMixedArrayInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendMixedArrayInput"/> class.
        /// </summary>
        /// <param name="file">file.</param>
        /// <param name="integers">integers.</param>
        /// <param name="models">models.</param>
        /// <param name="strings">strings.</param>
        public SendMixedArrayInput(
            FileStreamInfo file,
            List<int> integers,
            List<Models.Employee> models,
            List<string> strings)
        {
            this.File = file;
            this.Integers = integers;
            this.Models = models;
            this.Strings = strings;
        }

        /// <summary>
        /// Gets or sets File.
        /// </summary>
        [JsonProperty("file")]
        public FileStreamInfo File { get; set; }

        /// <summary>
        /// Gets or sets Integers.
        /// </summary>
        [JsonProperty("integers")]
        public List<int> Integers { get; set; }

        /// <summary>
        /// Gets or sets Models.
        /// </summary>
        [JsonProperty("models")]
        public List<Models.Employee> Models { get; set; }

        /// <summary>
        /// Gets or sets Strings.
        /// </summary>
        [JsonProperty("strings")]
        public List<string> Strings { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SendMixedArrayInput : ({string.Join(", ", toStringOutput)})";
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

            return obj is SendMixedArrayInput other &&
                ((this.File == null && other.File == null) || (this.File?.Equals(other.File) == true)) &&
                ((this.Integers == null && other.Integers == null) || (this.Integers?.Equals(other.Integers) == true)) &&
                ((this.Models == null && other.Models == null) || (this.Models?.Equals(other.Models) == true)) &&
                ((this.Strings == null && other.Strings == null) || (this.Strings?.Equals(other.Strings) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1814521679;

            if (this.File != null)
            {
               hashCode += this.File.GetHashCode();
            }

            if (this.Integers != null)
            {
               hashCode += this.Integers.GetHashCode();
            }

            if (this.Models != null)
            {
               hashCode += this.Models.GetHashCode();
            }

            if (this.Strings != null)
            {
               hashCode += this.Strings.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.File = {(this.File == null ? "null" : this.File.ToString())}");
            toStringOutput.Add($"this.Integers = {(this.Integers == null ? "null" : $"[{string.Join(", ", this.Integers)} ]")}");
            toStringOutput.Add($"this.Models = {(this.Models == null ? "null" : $"[{string.Join(", ", this.Models)} ]")}");
            toStringOutput.Add($"this.Strings = {(this.Strings == null ? "null" : $"[{string.Join(", ", this.Strings)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}