// <copyright file="Entry.cs" company="APIMatic">
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
    /// Entry.
    /// </summary>
    public class Entry : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entry"/> class.
        /// </summary>
        public Entry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Entry"/> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="link">link.</param>
        /// <param name="author">author.</param>
        /// <param name="publishedDate">publishedDate.</param>
        /// <param name="contentSnippet">contentSnippet.</param>
        /// <param name="content">content.</param>
        /// <param name="categories">categories.</param>
        public Entry(
            string title,
            string link,
            string author,
            string publishedDate,
            string contentSnippet,
            string content,
            List<string> categories)
        {
            this.Title = title;
            this.Link = link;
            this.Author = author;
            this.PublishedDate = publishedDate;
            this.ContentSnippet = contentSnippet;
            this.Content = content;
            this.Categories = categories;
        }

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
        /// Gets or sets PublishedDate.
        /// </summary>
        [JsonProperty("publishedDate")]
        public string PublishedDate { get; set; }

        /// <summary>
        /// Gets or sets ContentSnippet.
        /// </summary>
        [JsonProperty("contentSnippet")]
        public string ContentSnippet { get; set; }

        /// <summary>
        /// Gets or sets Content.
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets Categories.
        /// </summary>
        [JsonProperty("categories")]
        public List<string> Categories { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Entry : ({string.Join(", ", toStringOutput)})";
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

            return obj is Entry other &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Link == null && other.Link == null) || (this.Link?.Equals(other.Link) == true)) &&
                ((this.Author == null && other.Author == null) || (this.Author?.Equals(other.Author) == true)) &&
                ((this.PublishedDate == null && other.PublishedDate == null) || (this.PublishedDate?.Equals(other.PublishedDate) == true)) &&
                ((this.ContentSnippet == null && other.ContentSnippet == null) || (this.ContentSnippet?.Equals(other.ContentSnippet) == true)) &&
                ((this.Content == null && other.Content == null) || (this.Content?.Equals(other.Content) == true)) &&
                ((this.Categories == null && other.Categories == null) || (this.Categories?.Equals(other.Categories) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1258150639;

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

            if (this.PublishedDate != null)
            {
               hashCode += this.PublishedDate.GetHashCode();
            }

            if (this.ContentSnippet != null)
            {
               hashCode += this.ContentSnippet.GetHashCode();
            }

            if (this.Content != null)
            {
               hashCode += this.Content.GetHashCode();
            }

            if (this.Categories != null)
            {
               hashCode += this.Categories.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title == string.Empty ? "" : this.Title)}");
            toStringOutput.Add($"this.Link = {(this.Link == null ? "null" : this.Link == string.Empty ? "" : this.Link)}");
            toStringOutput.Add($"this.Author = {(this.Author == null ? "null" : this.Author == string.Empty ? "" : this.Author)}");
            toStringOutput.Add($"this.PublishedDate = {(this.PublishedDate == null ? "null" : this.PublishedDate == string.Empty ? "" : this.PublishedDate)}");
            toStringOutput.Add($"this.ContentSnippet = {(this.ContentSnippet == null ? "null" : this.ContentSnippet == string.Empty ? "" : this.ContentSnippet)}");
            toStringOutput.Add($"this.Content = {(this.Content == null ? "null" : this.Content == string.Empty ? "" : this.Content)}");
            toStringOutput.Add($"this.Categories = {(this.Categories == null ? "null" : $"[{string.Join(", ", this.Categories)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}