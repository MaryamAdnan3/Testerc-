// <copyright file="TimeToLive.cs" company="APIMatic">
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
    /// TimeToLive.
    /// </summary>
    public class TimeToLive : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeToLive"/> class.
        /// </summary>
        public TimeToLive()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeToLive"/> class.
        /// </summary>
        /// <param name="deadline">deadline.</param>
        /// <param name="deleteAfterHours">deleteAfterHours.</param>
        public TimeToLive(
            string deadline,
            int deleteAfterHours)
        {
            this.Deadline = deadline;
            this.DeleteAfterHours = deleteAfterHours;
        }

        /// <summary>
        /// Gets or sets Deadline.
        /// </summary>
        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        /// <summary>
        /// Gets or sets DeleteAfterHours.
        /// </summary>
        [JsonProperty("deleteAfterHours")]
        public int DeleteAfterHours { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TimeToLive : ({string.Join(", ", toStringOutput)})";
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

            return obj is TimeToLive other &&
                ((this.Deadline == null && other.Deadline == null) || (this.Deadline?.Equals(other.Deadline) == true)) &&
                this.DeleteAfterHours.Equals(other.DeleteAfterHours);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 960364568;

            if (this.Deadline != null)
            {
               hashCode += this.Deadline.GetHashCode();
            }

            hashCode += this.DeleteAfterHours.GetHashCode();

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Deadline = {(this.Deadline == null ? "null" : this.Deadline == string.Empty ? "" : this.Deadline)}");
            toStringOutput.Add($"this.DeleteAfterHours = {this.DeleteAfterHours}");

            base.ToString(toStringOutput);
        }
    }
}