// <copyright file="IQueryParamsController.cs" company="APIMatic">
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
    /// IQueryParamsController.
    /// </summary>
    public interface IQueryParamsController
    {
        /// <summary>
        /// Send Number as optional EndPoint.
        /// </summary>
        /// <param name="number">Required parameter: Example: .</param>
        /// <param name="number1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendNumberAsOptional(
                int number,
                int? number1 = null);

        /// <summary>
        /// Send Number as optional EndPoint.
        /// </summary>
        /// <param name="number">Required parameter: Example: .</param>
        /// <param name="number1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendNumberAsOptionalAsync(
                int number,
                int? number1 = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// send long as optional EndPoint.
        /// </summary>
        /// <param name="mLong">Required parameter: Example: .</param>
        /// <param name="long1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendLongAsOptional(
                long mLong,
                long? long1 = null);

        /// <summary>
        /// send long as optional EndPoint.
        /// </summary>
        /// <param name="mLong">Required parameter: Example: .</param>
        /// <param name="long1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendLongAsOptionalAsync(
                long mLong,
                long? long1 = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// precision as optional EndPoint.
        /// </summary>
        /// <param name="precision">Required parameter: Example: .</param>
        /// <param name="precision1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse PrecisionAsOptional(
                double precision,
                double? precision1 = null);

        /// <summary>
        /// precision as optional EndPoint.
        /// </summary>
        /// <param name="precision">Required parameter: Example: .</param>
        /// <param name="precision1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> PrecisionAsOptionalAsync(
                double precision,
                double? precision1 = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Boolean as optional EndPoint.
        /// </summary>
        /// <param name="boolean">Required parameter: Example: .</param>
        /// <param name="boolean1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse BooleanAsOptional(
                bool boolean,
                bool? boolean1 = null);

        /// <summary>
        /// Boolean as optional EndPoint.
        /// </summary>
        /// <param name="boolean">Required parameter: Example: .</param>
        /// <param name="boolean1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> BooleanAsOptionalAsync(
                bool boolean,
                bool? boolean1 = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// rfc1123 datetime as optional EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="dateTime1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse Rfc1123DatetimeAsOptional(
                DateTime dateTime,
                DateTime? dateTime1 = null);

        /// <summary>
        /// rfc1123 datetime as optional EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="dateTime1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> Rfc1123DatetimeAsOptionalAsync(
                DateTime dateTime,
                DateTime? dateTime1 = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// rfc3339 datetime as optional EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="dateTime1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse Rfc3339DatetimeAsOptional(
                DateTime dateTime,
                DateTime? dateTime1 = null);

        /// <summary>
        /// rfc3339 datetime as optional EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="dateTime1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> Rfc3339DatetimeAsOptionalAsync(
                DateTime dateTime,
                DateTime? dateTime1 = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// send date as optional EndPoint.
        /// </summary>
        /// <param name="date">Required parameter: Example: .</param>
        /// <param name="date1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendDateAsOptional(
                DateTime date,
                DateTime? date1 = null);

        /// <summary>
        /// send date as optional EndPoint.
        /// </summary>
        /// <param name="date">Required parameter: Example: .</param>
        /// <param name="date1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendDateAsOptionalAsync(
                DateTime date,
                DateTime? date1 = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// send string as optional EndPoint.
        /// </summary>
        /// <param name="mString">Required parameter: Example: .</param>
        /// <param name="string1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendStringAsOptional(
                string mString,
                string string1 = null);

        /// <summary>
        /// send string as optional EndPoint.
        /// </summary>
        /// <param name="mString">Required parameter: Example: .</param>
        /// <param name="string1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendStringAsOptionalAsync(
                string mString,
                string string1 = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// unixdatetime as optional EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="dateTime1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse UnixdatetimeAsOptional(
                DateTime dateTime,
                DateTime? dateTime1 = null);

        /// <summary>
        /// unixdatetime as optional EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="dateTime1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> UnixdatetimeAsOptionalAsync(
                DateTime dateTime,
                DateTime? dateTime1 = null,
                CancellationToken cancellationToken = default);
    }
}