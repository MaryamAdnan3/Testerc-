// <copyright file="IQueryParamController.cs" company="APIMatic">
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
    /// IQueryParamController.
    /// </summary>
    public interface IQueryParamController
    {
        /// <summary>
        /// Date Array EndPoint.
        /// </summary>
        /// <param name="dates">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse DateArray(
                List<DateTime> dates);

        /// <summary>
        /// Date Array EndPoint.
        /// </summary>
        /// <param name="dates">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> DateArrayAsync(
                List<DateTime> dates,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// get optional dynamic query parameter.
        /// </summary>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint.</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse OptionalDynamicQueryParam(
                string name,
                Dictionary<string, object> queryParameters = null);

        /// <summary>
        /// get optional dynamic query parameter.
        /// </summary>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> OptionalDynamicQueryParamAsync(
                string name,
                Dictionary<string, object> queryParameters = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Date EndPoint.
        /// </summary>
        /// <param name="date">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse Date(
                DateTime date);

        /// <summary>
        /// Date EndPoint.
        /// </summary>
        /// <param name="date">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> DateAsync(
                DateTime date,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Unix DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse UnixDateTimeArray(
                List<DateTime> datetimes);

        /// <summary>
        /// Unix DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> UnixDateTimeArrayAsync(
                List<DateTime> datetimes,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Unix DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse UnixDateTime(
                DateTime datetime);

        /// <summary>
        /// Unix DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> UnixDateTimeAsync(
                DateTime datetime,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Rfc1123 DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse Rfc1123DateTime(
                DateTime datetime);

        /// <summary>
        /// Rfc1123 DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> Rfc1123DateTimeAsync(
                DateTime datetime,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Rfc1123 DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse Rfc1123DateTimeArray(
                List<DateTime> datetimes);

        /// <summary>
        /// Rfc1123 DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> Rfc1123DateTimeArrayAsync(
                List<DateTime> datetimes,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Rfc3339 DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse Rfc3339DateTimeArray(
                List<DateTime> datetimes);

        /// <summary>
        /// Rfc3339 DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> Rfc3339DateTimeArrayAsync(
                List<DateTime> datetimes,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Rfc3339 DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse Rfc3339DateTime(
                DateTime datetime);

        /// <summary>
        /// Rfc3339 DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> Rfc3339DateTimeAsync(
                DateTime datetime,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// NoParams EndPoint.
        /// </summary>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse NoParams();

        /// <summary>
        /// NoParams EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> NoParamsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// StringParam EndPoint.
        /// </summary>
        /// <param name="mString">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse StringParam(
                string mString);

        /// <summary>
        /// StringParam EndPoint.
        /// </summary>
        /// <param name="mString">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> StringParamAsync(
                string mString,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// UrlParam EndPoint.
        /// </summary>
        /// <param name="url">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse UrlParam(
                string url);

        /// <summary>
        /// UrlParam EndPoint.
        /// </summary>
        /// <param name="url">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> UrlParamAsync(
                string url,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Number Array EndPoint.
        /// </summary>
        /// <param name="integers">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse NumberArray(
                List<int> integers);

        /// <summary>
        /// Number Array EndPoint.
        /// </summary>
        /// <param name="integers">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> NumberArrayAsync(
                List<int> integers,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// String Array EndPoint.
        /// </summary>
        /// <param name="strings">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse StringArray(
                List<string> strings);

        /// <summary>
        /// String Array EndPoint.
        /// </summary>
        /// <param name="strings">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> StringArrayAsync(
                List<string> strings,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// SimpleQuery EndPoint.
        /// </summary>
        /// <param name="boolean">Required parameter: Example: .</param>
        /// <param name="number">Required parameter: Example: .</param>
        /// <param name="mString">Required parameter: Example: .</param>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint.</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SimpleQuery(
                bool boolean,
                int number,
                string mString,
                Dictionary<string, object> queryParameters = null);

        /// <summary>
        /// SimpleQuery EndPoint.
        /// </summary>
        /// <param name="boolean">Required parameter: Example: .</param>
        /// <param name="number">Required parameter: Example: .</param>
        /// <param name="mString">Required parameter: Example: .</param>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SimpleQueryAsync(
                bool boolean,
                int number,
                string mString,
                Dictionary<string, object> queryParameters = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// String Enum Array EndPoint.
        /// </summary>
        /// <param name="days">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse StringEnumArray(
                List<Models.Days> days);

        /// <summary>
        /// String Enum Array EndPoint.
        /// </summary>
        /// <param name="days">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> StringEnumArrayAsync(
                List<Models.Days> days,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// MultipleParams EndPoint.
        /// </summary>
        /// <param name="number">Required parameter: Example: .</param>
        /// <param name="precision">Required parameter: Example: .</param>
        /// <param name="mString">Required parameter: Example: .</param>
        /// <param name="url">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse MultipleParams(
                int number,
                double precision,
                string mString,
                string url);

        /// <summary>
        /// MultipleParams EndPoint.
        /// </summary>
        /// <param name="number">Required parameter: Example: .</param>
        /// <param name="precision">Required parameter: Example: .</param>
        /// <param name="mString">Required parameter: Example: .</param>
        /// <param name="url">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> MultipleParamsAsync(
                int number,
                double precision,
                string mString,
                string url,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Integer Enum Array EndPoint.
        /// </summary>
        /// <param name="suites">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse IntegerEnumArray(
                List<Models.SuiteCode> suites);

        /// <summary>
        /// Integer Enum Array EndPoint.
        /// </summary>
        /// <param name="suites">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> IntegerEnumArrayAsync(
                List<Models.SuiteCode> suites,
                CancellationToken cancellationToken = default);
    }
}