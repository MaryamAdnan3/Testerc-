// <copyright file="Dialogs.cs" company="APIMatic">
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
    /// Dialogs.
    /// </summary>
    public class Dialogs : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dialogs"/> class.
        /// </summary>
        public Dialogs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dialogs"/> class.
        /// </summary>
        /// <param name="before">before.</param>
        public Dialogs(
            Models.Before before)
        {
            this.Before = before;
        }

        /// <summary>
        /// Gets or sets Before.
        /// </summary>
        [JsonProperty("before")]
        public Models.Before Before { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Dialogs : ({string.Join(", ", toStringOutput)})";
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

            return obj is Dialogs other &&
                ((this.Before == null && other.Before == null) || (this.Before?.Equals(other.Before) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1883809465;

            if (this.Before != null)
            {
               hashCode += this.Before.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Before = {(this.Before == null ? "null" : this.Before.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}