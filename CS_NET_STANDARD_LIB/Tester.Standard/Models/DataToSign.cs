// <copyright file="DataToSign.cs" company="APIMatic">
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
    /// DataToSign.
    /// </summary>
    public class DataToSign : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataToSign"/> class.
        /// </summary>
        public DataToSign()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataToSign"/> class.
        /// </summary>
        /// <param name="fileName">fileName.</param>
        /// <param name="convertToPDF">convertToPDF.</param>
        public DataToSign(
            string fileName,
            bool convertToPDF)
        {
            this.FileName = fileName;
            this.ConvertToPDF = convertToPDF;
        }

        /// <summary>
        /// Gets or sets FileName.
        /// </summary>
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets ConvertToPDF.
        /// </summary>
        [JsonProperty("convertToPDF")]
        public bool ConvertToPDF { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DataToSign : ({string.Join(", ", toStringOutput)})";
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

            return obj is DataToSign other &&
                ((this.FileName == null && other.FileName == null) || (this.FileName?.Equals(other.FileName) == true)) &&
                this.ConvertToPDF.Equals(other.ConvertToPDF);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1066319898;

            if (this.FileName != null)
            {
               hashCode += this.FileName.GetHashCode();
            }

            hashCode += this.ConvertToPDF.GetHashCode();

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FileName = {(this.FileName == null ? "null" : this.FileName == string.Empty ? "" : this.FileName)}");
            toStringOutput.Add($"this.ConvertToPDF = {this.ConvertToPDF}");

            base.ToString(toStringOutput);
        }
    }
}