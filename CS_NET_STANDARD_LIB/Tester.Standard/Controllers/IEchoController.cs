// <copyright file="IEchoController.cs" company="APIMatic">
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
    /// IEchoController.
    /// </summary>
    public interface IEchoController
    {
        /// <summary>
        /// Echo's back the request.
        /// </summary>
        /// <param name="input">Required parameter: Example: .</param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic JsonEcho(
                object input);

        /// <summary>
        /// Echo's back the request.
        /// </summary>
        /// <param name="input">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> JsonEchoAsync(
                object input,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends the request including any form params as JSON.
        /// </summary>
        /// <param name="input">Required parameter: Example: .</param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic FormEcho(
                object input);

        /// <summary>
        /// Sends the request including any form params as JSON.
        /// </summary>
        /// <param name="input">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> FormEchoAsync(
                object input,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// QueryEcho EndPoint.
        /// </summary>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint.</param>
        /// <returns>Returns the Models.EchoResponse response from the API call.</returns>
        Models.EchoResponse QueryEcho(
                Dictionary<string, object> queryParameters = null);

        /// <summary>
        /// QueryEcho EndPoint.
        /// </summary>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EchoResponse response from the API call.</returns>
        Task<Models.EchoResponse> QueryEchoAsync(
                Dictionary<string, object> queryParameters = null,
                CancellationToken cancellationToken = default);
    }
}