// <copyright file="IHeaderController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Tester.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Tester.Standard;
    using Tester.Standard.Http.Client;
    using Tester.Standard.Http.Request;
    using Tester.Standard.Http.Response;
    using Tester.Standard.Utilities;

    /// <summary>
    /// IHeaderController.
    /// </summary>
    public interface IHeaderController
    {
        /// <summary>
        /// Sends a single header params.
        /// </summary>
        /// <param name="customHeader">Required parameter: Example: .</param>
        /// <param name="mValue">Required parameter: Represents the value of the custom header.</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendHeaders(
                string customHeader,
                string mValue);

        /// <summary>
        /// Sends a single header params.
        /// </summary>
        /// <param name="customHeader">Required parameter: Example: .</param>
        /// <param name="mValue">Required parameter: Represents the value of the custom header.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendHeadersAsync(
                string customHeader,
                string mValue,
                CancellationToken cancellationToken = default);
    }
}