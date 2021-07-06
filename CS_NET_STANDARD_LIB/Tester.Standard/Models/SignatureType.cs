// <copyright file="SignatureType.cs" company="APIMatic">
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
    /// SignatureType.
    /// </summary>
    public class SignatureType : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureType"/> class.
        /// </summary>
        public SignatureType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureType"/> class.
        /// </summary>
        /// <param name="mechanism">mechanism.</param>
        /// <param name="onEacceptUseHandWrittenSignature">onEacceptUseHandWrittenSignature.</param>
        public SignatureType(
            string mechanism,
            bool onEacceptUseHandWrittenSignature)
        {
            this.Mechanism = mechanism;
            this.OnEacceptUseHandWrittenSignature = onEacceptUseHandWrittenSignature;
        }

        /// <summary>
        /// Gets or sets Mechanism.
        /// </summary>
        [JsonProperty("mechanism")]
        public string Mechanism { get; set; }

        /// <summary>
        /// Gets or sets OnEacceptUseHandWrittenSignature.
        /// </summary>
        [JsonProperty("onEacceptUseHandWrittenSignature")]
        public bool OnEacceptUseHandWrittenSignature { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SignatureType : ({string.Join(", ", toStringOutput)})";
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

            return obj is SignatureType other &&
                ((this.Mechanism == null && other.Mechanism == null) || (this.Mechanism?.Equals(other.Mechanism) == true)) &&
                this.OnEacceptUseHandWrittenSignature.Equals(other.OnEacceptUseHandWrittenSignature);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1227034337;

            if (this.Mechanism != null)
            {
               hashCode += this.Mechanism.GetHashCode();
            }

            hashCode += this.OnEacceptUseHandWrittenSignature.GetHashCode();

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Mechanism = {(this.Mechanism == null ? "null" : this.Mechanism == string.Empty ? "" : this.Mechanism)}");
            toStringOutput.Add($"this.OnEacceptUseHandWrittenSignature = {this.OnEacceptUseHandWrittenSignature}");

            base.ToString(toStringOutput);
        }
    }
}