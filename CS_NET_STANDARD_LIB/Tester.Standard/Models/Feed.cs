// <copyright file="Feed.cs" company="APIMatic">
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
    /// Feed.
    /// </summary>
    public class Feed : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Feed"/> class.
        /// </summary>
        public Feed()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Feed"/> class.
        /// </summary>
        /// <param name="feedUrl">feedUrl.</param>
        /// <param name="title">title.</param>
        /// <param name="link">link.</param>
        /// <param name="author">author.</param>
        /// <param name="description">description.</param>
        /// <param name="type">type.</param>
        /// <param name="entries">entries.</param>
        public Feed(
            string feedUrl,
            string title,
            string link,
            string author,
            string description,
            string type,
            List<Models.Entry> entries)
        {
            this.FeedUrl = feedUrl;
            this.Title = title;
            this.Link = link;
            this.Author = author;
            this.Description = description;
            this.Type = type;
            this.Entries = entries;
        }

        /// <summary>
        /// Gets or sets FeedUrl.
        /// </summary>
        [JsonProperty("feedUrl")]
        public string FeedUrl { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Link.
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// Gets or sets Author.
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Entries.
        /// </summary>
        [JsonProperty("entries")]
        public List<Models.Entry> Entries { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Feed : ({string.Join(", ", toStringOutput)})";
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

            return obj is Feed other &&
                ((this.FeedUrl == null && other.FeedUrl == null) || (this.FeedUrl?.Equals(other.FeedUrl) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Link == null && other.Link == null) || (this.Link?.Equals(other.Link) == true)) &&
                ((this.Author == null && other.Author == null) || (this.Author?.Equals(other.Author) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Entries == null && other.Entries == null) || (this.Entries?.Equals(other.Entries) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1601690144;

            if (this.FeedUrl != null)
            {
               hashCode += this.FeedUrl.GetHashCode();
            }

            if (this.Title != null)
            {
               hashCode += this.Title.GetHashCode();
            }

            if (this.Link != null)
            {
               hashCode += this.Link.GetHashCode();
            }

            if (this.Author != null)
            {
               hashCode += this.Author.GetHashCode();
            }

            if (this.Description != null)
            {
               hashCode += this.Description.GetHashCode();
            }

            if (this.Type != null)
            {
               hashCode += this.Type.GetHashCode();
            }

            if (this.Entries != null)
            {
               hashCode += this.Entries.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FeedUrl = {(this.FeedUrl == null ? "null" : this.FeedUrl == string.Empty ? "" : this.FeedUrl)}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title == string.Empty ? "" : this.Title)}");
            toStringOutput.Add($"this.Link = {(this.Link == null ? "null" : this.Link == string.Empty ? "" : this.Link)}");
            toStringOutput.Add($"this.Author = {(this.Author == null ? "null" : this.Author == string.Empty ? "" : this.Author)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Entries = {(this.Entries == null ? "null" : $"[{string.Join(", ", this.Entries)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}