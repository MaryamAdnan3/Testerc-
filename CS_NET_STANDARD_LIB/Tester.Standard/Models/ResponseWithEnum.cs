// <copyright file="ResponseWithEnum.cs" company="APIMatic">
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
    /// ResponseWithEnum.
    /// </summary>
    public class ResponseWithEnum : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseWithEnum"/> class.
        /// </summary>
        public ResponseWithEnum()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseWithEnum"/> class.
        /// </summary>
        /// <param name="paramFormat">paramFormat.</param>
        /// <param name="optional">optional.</param>
        /// <param name="type">type.</param>
        /// <param name="constant">constant.</param>
        /// <param name="isArray">isArray.</param>
        /// <param name="isStream">isStream.</param>
        /// <param name="isAttribute">isAttribute.</param>
        /// <param name="isMap">isMap.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="nullable">nullable.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        public ResponseWithEnum(
            Models.ParamFormat paramFormat,
            bool optional,
            Models.Type type,
            bool constant,
            bool isArray,
            bool isStream,
            bool isAttribute,
            bool isMap,
            Models.Attributes attributes,
            bool nullable,
            string id,
            string name,
            string description)
        {
            this.ParamFormat = paramFormat;
            this.Optional = optional;
            this.Type = type;
            this.Constant = constant;
            this.IsArray = isArray;
            this.IsStream = isStream;
            this.IsAttribute = isAttribute;
            this.IsMap = isMap;
            this.Attributes = attributes;
            this.Nullable = nullable;
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Gets or sets ParamFormat.
        /// </summary>
        [JsonProperty("paramFormat", ItemConverterType = typeof(StringEnumConverter))]
        public Models.ParamFormat ParamFormat { get; set; }

        /// <summary>
        /// Gets or sets Optional.
        /// </summary>
        [JsonProperty("optional")]
        public bool Optional { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter))]
        public Models.Type Type { get; set; }

        /// <summary>
        /// Gets or sets Constant.
        /// </summary>
        [JsonProperty("constant")]
        public bool Constant { get; set; }

        /// <summary>
        /// Gets or sets IsArray.
        /// </summary>
        [JsonProperty("isArray")]
        public bool IsArray { get; set; }

        /// <summary>
        /// Gets or sets IsStream.
        /// </summary>
        [JsonProperty("isStream")]
        public bool IsStream { get; set; }

        /// <summary>
        /// Gets or sets IsAttribute.
        /// </summary>
        [JsonProperty("isAttribute")]
        public bool IsAttribute { get; set; }

        /// <summary>
        /// Gets or sets IsMap.
        /// </summary>
        [JsonProperty("isMap")]
        public bool IsMap { get; set; }

        /// <summary>
        /// Gets or sets Attributes.
        /// </summary>
        [JsonProperty("attributes")]
        public Models.Attributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets Nullable.
        /// </summary>
        [JsonProperty("nullable")]
        public bool Nullable { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseWithEnum : ({string.Join(", ", toStringOutput)})";
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

            return obj is ResponseWithEnum other &&
                this.ParamFormat.Equals(other.ParamFormat) &&
                this.Optional.Equals(other.Optional) &&
                this.Type.Equals(other.Type) &&
                this.Constant.Equals(other.Constant) &&
                this.IsArray.Equals(other.IsArray) &&
                this.IsStream.Equals(other.IsStream) &&
                this.IsAttribute.Equals(other.IsAttribute) &&
                this.IsMap.Equals(other.IsMap) &&
                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true)) &&
                this.Nullable.Equals(other.Nullable) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 336596805;
            hashCode += this.ParamFormat.GetHashCode();
            hashCode += this.Optional.GetHashCode();
            hashCode += this.Type.GetHashCode();
            hashCode += this.Constant.GetHashCode();
            hashCode += this.IsArray.GetHashCode();
            hashCode += this.IsStream.GetHashCode();
            hashCode += this.IsAttribute.GetHashCode();
            hashCode += this.IsMap.GetHashCode();

            if (this.Attributes != null)
            {
               hashCode += this.Attributes.GetHashCode();
            }

            hashCode += this.Nullable.GetHashCode();

            if (this.Id != null)
            {
               hashCode += this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
               hashCode += this.Name.GetHashCode();
            }

            if (this.Description != null)
            {
               hashCode += this.Description.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ParamFormat = {this.ParamFormat}");
            toStringOutput.Add($"this.Optional = {this.Optional}");
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.Constant = {this.Constant}");
            toStringOutput.Add($"this.IsArray = {this.IsArray}");
            toStringOutput.Add($"this.IsStream = {this.IsStream}");
            toStringOutput.Add($"this.IsAttribute = {this.IsAttribute}");
            toStringOutput.Add($"this.IsMap = {this.IsMap}");
            toStringOutput.Add($"this.Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
            toStringOutput.Add($"this.Nullable = {this.Nullable}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");

            base.ToString(toStringOutput);
        }
    }
}