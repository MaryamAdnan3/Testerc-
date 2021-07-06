// <copyright file="ITemplateParamsController.cs" company="APIMatic">
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
    /// ITemplateParamsController.
    /// </summary>
    public interface ITemplateParamsController
    {
        /// <summary>
        /// Send String Array EndPoint.
        /// </summary>
        /// <param name="strings">Required parameter: Example: .</param>
        /// <returns>Returns the Models.EchoResponse response from the API call.</returns>
        Models.EchoResponse SendStringArray(
                List<string> strings);

        /// <summary>
        /// Send String Array EndPoint.
        /// </summary>
        /// <param name="strings">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EchoResponse response from the API call.</returns>
        Task<Models.EchoResponse> SendStringArrayAsync(
                List<string> strings,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Integer Array EndPoint.
        /// </summary>
        /// <param name="integers">Required parameter: Example: .</param>
        /// <returns>Returns the Models.EchoResponse response from the API call.</returns>
        Models.EchoResponse SendIntegerArray(
                List<int> integers);

        /// <summary>
        /// Send Integer Array EndPoint.
        /// </summary>
        /// <param name="integers">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EchoResponse response from the API call.</returns>
        Task<Models.EchoResponse> SendIntegerArrayAsync(
                List<int> integers,
                CancellationToken cancellationToken = default);
    }
}