// <copyright file="Ui.cs" company="APIMatic">
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
    /// Ui.
    /// </summary>
    public class Ui : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ui"/> class.
        /// </summary>
        public Ui()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ui"/> class.
        /// </summary>
        /// <param name="dialogs">dialogs.</param>
        /// <param name="language">language.</param>
        /// <param name="styling">styling.</param>
        public Ui(
            Models.Dialogs dialogs,
            Models.LanguageEnum language,
            Models.Styling styling)
        {
            this.Dialogs = dialogs;
            this.Language = language;
            this.Styling = styling;
        }

        /// <summary>
        /// Gets or sets Dialogs.
        /// </summary>
        [JsonProperty("dialogs")]
        public Models.Dialogs Dialogs { get; set; }

        /// <summary>
        /// Gets or sets Language.
        /// </summary>
        [JsonProperty("language", ItemConverterType = typeof(StringEnumConverter))]
        public Models.LanguageEnum Language { get; set; }

        /// <summary>
        /// Gets or sets Styling.
        /// </summary>
        [JsonProperty("styling")]
        public Models.Styling Styling { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Ui : ({string.Join(", ", toStringOutput)})";
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

            return obj is Ui other &&
                ((this.Dialogs == null && other.Dialogs == null) || (this.Dialogs?.Equals(other.Dialogs) == true)) &&
                this.Language.Equals(other.Language) &&
                ((this.Styling == null && other.Styling == null) || (this.Styling?.Equals(other.Styling) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 84597833;

            if (this.Dialogs != null)
            {
               hashCode += this.Dialogs.GetHashCode();
            }

            hashCode += this.Language.GetHashCode();

            if (this.Styling != null)
            {
               hashCode += this.Styling.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Dialogs = {(this.Dialogs == null ? "null" : this.Dialogs.ToString())}");
            toStringOutput.Add($"this.Language = {this.Language}");
            toStringOutput.Add($"this.Styling = {(this.Styling == null ? "null" : this.Styling.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}