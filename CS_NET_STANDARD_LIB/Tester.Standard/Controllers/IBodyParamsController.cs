// <copyright file="IBodyParamsController.cs" company="APIMatic">
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
    /// IBodyParamsController.
    /// </summary>
    public interface IBodyParamsController
    {
        /// <summary>
        /// Send Delete PlainText EndPoint.
        /// </summary>
        /// <param name="textString">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendDeletePlainText(
                string textString);

        /// <summary>
        /// Send Delete PlainText EndPoint.
        /// </summary>
        /// <param name="textString">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendDeletePlainTextAsync(
                string textString,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// send Delete Body EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendDeleteBody(
                Models.DeleteBody body);

        /// <summary>
        /// send Delete Body EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendDeleteBodyAsync(
                Models.DeleteBody body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Date Array EndPoint.
        /// </summary>
        /// <param name="dates">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendDateArray(
                List<DateTime> dates);

        /// <summary>
        /// Send Date Array EndPoint.
        /// </summary>
        /// <param name="dates">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendDateArrayAsync(
                List<DateTime> dates,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Date EndPoint.
        /// </summary>
        /// <param name="date">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendDate(
                DateTime date);

        /// <summary>
        /// Send Date EndPoint.
        /// </summary>
        /// <param name="date">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendDateAsync(
                DateTime date,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send UnixDateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendUnixDateTime(
                DateTime datetime);

        /// <summary>
        /// Send UnixDateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendUnixDateTimeAsync(
                DateTime datetime,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Rfc1123 DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendRfc1123DateTime(
                DateTime datetime);

        /// <summary>
        /// Send Rfc1123 DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendRfc1123DateTimeAsync(
                DateTime datetime,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Rfc3339 DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendRfc3339DateTime(
                DateTime datetime);

        /// <summary>
        /// Send Rfc3339 DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendRfc3339DateTimeAsync(
                DateTime datetime,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send UnixDateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendUnixDateTimeArray(
                List<DateTime> datetimes);

        /// <summary>
        /// Send UnixDateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendUnixDateTimeArrayAsync(
                List<DateTime> datetimes,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Rfc1123 DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendRfc1123DateTimeArray(
                List<DateTime> datetimes);

        /// <summary>
        /// Send Rfc1123 DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendRfc1123DateTimeArrayAsync(
                List<DateTime> datetimes,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Rfc3339 DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendRfc3339DateTimeArray(
                List<DateTime> datetimes);

        /// <summary>
        /// Send Rfc3339 DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendRfc3339DateTimeArrayAsync(
                List<DateTime> datetimes,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// sends a string body param.
        /// </summary>
        /// <param name="sarray">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendStringArray(
                List<string> sarray);

        /// <summary>
        /// sends a string body param.
        /// </summary>
        /// <param name="sarray">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendStringArrayAsync(
                List<string> sarray,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// update String EndPoint.
        /// </summary>
        /// <param name="mValue">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse UpdateString(
                string mValue);

        /// <summary>
        /// update String EndPoint.
        /// </summary>
        /// <param name="mValue">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> UpdateStringAsync(
                string mValue,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Integer Array EndPoint.
        /// </summary>
        /// <param name="integers">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendIntegerArray(
                List<int> integers);

        /// <summary>
        /// Send Integer Array EndPoint.
        /// </summary>
        /// <param name="integers">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendIntegerArrayAsync(
                List<int> integers,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Wrap Body in Object EndPoint.
        /// </summary>
        /// <param name="field">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse WrapBodyInObject(
                string field,
                string name);

        /// <summary>
        /// Wrap Body in Object EndPoint.
        /// </summary>
        /// <param name="field">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> WrapBodyInObjectAsync(
                string field,
                string name,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Additional Model Parameters EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse AdditionalModelParameters(
                Models.AdditionalModelParameters model);

        /// <summary>
        /// Additional Model Parameters EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> AdditionalModelParametersAsync(
                Models.AdditionalModelParameters model,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// validate Required parameter EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <param name="option">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse ValidateRequiredParameter(
                Models.Validate model,
                string option = null);

        /// <summary>
        /// validate Required parameter EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <param name="option">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> ValidateRequiredParameterAsync(
                Models.Validate model,
                string option = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Additional Model Parameters1 EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse AdditionalModelParameters1(
                Models.AdditionalModelParameters model);

        /// <summary>
        /// Additional Model Parameters1 EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> AdditionalModelParameters1Async(
                Models.AdditionalModelParameters model,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Model EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendModel(
                Models.Employee model);

        /// <summary>
        /// Send Model EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendModelAsync(
                Models.Employee model,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Model Array EndPoint.
        /// </summary>
        /// <param name="models">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendModelArray(
                List<Models.Employee> models);

        /// <summary>
        /// Send Model Array EndPoint.
        /// </summary>
        /// <param name="models">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendModelArrayAsync(
                List<Models.Employee> models,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Dynamic EndPoint.
        /// </summary>
        /// <param name="mDynamic">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendDynamic(
                object mDynamic);

        /// <summary>
        /// Send Dynamic EndPoint.
        /// </summary>
        /// <param name="mDynamic">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendDynamicAsync(
                object mDynamic,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send String EndPoint.
        /// </summary>
        /// <param name="mValue">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendString(
                string mValue);

        /// <summary>
        /// Send String EndPoint.
        /// </summary>
        /// <param name="mValue">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendStringAsync(
                string mValue,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// SendStringEnumArray EndPoint.
        /// </summary>
        /// <param name="days">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendStringEnumArray(
                List<Models.Days> days);

        /// <summary>
        /// SendStringEnumArray EndPoint.
        /// </summary>
        /// <param name="days">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendStringEnumArrayAsync(
                List<Models.Days> days,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// SendIntegerEnumArray EndPoint.
        /// </summary>
        /// <param name="suites">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendIntegerEnumArray(
                List<Models.SuiteCode> suites);

        /// <summary>
        /// SendIntegerEnumArray EndPoint.
        /// </summary>
        /// <param name="suites">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendIntegerEnumArrayAsync(
                List<Models.SuiteCode> suites,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Model EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse UpdateModel(
                Models.Employee model);

        /// <summary>
        /// Update Model EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> UpdateModelAsync(
                Models.Employee model,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Delete Body with Model EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendDeleteBodyWithModel(
                Models.Employee model);

        /// <summary>
        /// Send Delete Body with Model EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendDeleteBodyWithModelAsync(
                Models.Employee model,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Delete Body with Model Array EndPoint.
        /// </summary>
        /// <param name="models">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendDeleteBodyWithModelArray(
                List<Models.Employee> models);

        /// <summary>
        /// Send Delete Body with Model Array EndPoint.
        /// </summary>
        /// <param name="models">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendDeleteBodyWithModelArrayAsync(
                List<Models.Employee> models,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Model Array EndPoint.
        /// </summary>
        /// <param name="models">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse UpdateModelArray(
                List<Models.Employee> models);

        /// <summary>
        /// Update Model Array EndPoint.
        /// </summary>
        /// <param name="models">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> UpdateModelArrayAsync(
                List<Models.Employee> models,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// update String1 EndPoint.
        /// </summary>
        /// <param name="mValue">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse UpdateString1(
                string mValue);

        /// <summary>
        /// update String1 EndPoint.
        /// </summary>
        /// <param name="mValue">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> UpdateString1Async(
                string mValue,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Update String Array EndPoint.
        /// </summary>
        /// <param name="strings">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse UpdateStringArray(
                List<string> strings);

        /// <summary>
        /// Update String Array EndPoint.
        /// </summary>
        /// <param name="strings">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> UpdateStringArrayAsync(
                List<string> strings,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// send string with new line EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendStringWithNewLine(
                Models.TestNstringEncoding body);

        /// <summary>
        /// send string with new line EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendStringWithNewLineAsync(
                Models.TestNstringEncoding body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// send String with \r EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendStringWithR(
                Models.TestRstringEncoding body);

        /// <summary>
        /// send String with \r EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendStringWithRAsync(
                Models.TestRstringEncoding body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send String in body with \r\n EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendStringInBodyWithRN(
                Models.TestRNstringEncoding body);

        /// <summary>
        /// Send String in body with \r\n EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendStringInBodyWithRNAsync(
                Models.TestRNstringEncoding body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Optional Unix DateTime In Body EndPoint.
        /// </summary>
        /// <param name="dateTime">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendOptionalUnixDateTimeInBody(
                DateTime? dateTime = null);

        /// <summary>
        /// Send Optional Unix DateTime In Body EndPoint.
        /// </summary>
        /// <param name="dateTime">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendOptionalUnixDateTimeInBodyAsync(
                DateTime? dateTime = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send optional rfc1123 in body EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendOptionalRfc1123InBody(
                DateTime body);

        /// <summary>
        /// Send optional rfc1123 in body EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendOptionalRfc1123InBodyAsync(
                DateTime body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// send datetime optional in endpoint EndPoint.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendDatetimeOptionalInEndpoint(
                DateTime? body = null);

        /// <summary>
        /// send datetime optional in endpoint EndPoint.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendDatetimeOptionalInEndpointAsync(
                DateTime? body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send optional unixTimeStamp in Model (body) EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendOptionalUnixTimeStampInModelBody(
                Models.UnixDateTime dateTime);

        /// <summary>
        /// Send optional unixTimeStamp in Model (body) EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendOptionalUnixTimeStampInModelBodyAsync(
                Models.UnixDateTime dateTime,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// send optional unixTimeStamp in nested model (body) EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendOptionalUnixTimeStampInNestedModelBody(
                Models.SendUnixDateTime dateTime);

        /// <summary>
        /// send optional unixTimeStamp in nested model (body) EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendOptionalUnixTimeStampInNestedModelBodyAsync(
                Models.SendUnixDateTime dateTime,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// send Rfc1123 dateTime in Nested Model EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendRfc1123DateTimeInNestedModel(
                Models.SendRfc1123DateTime body);

        /// <summary>
        /// send Rfc1123 dateTime in Nested Model EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendRfc1123DateTimeInNestedModelAsync(
                Models.SendRfc1123DateTime body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Rfc1123 dateTime in Model EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendRfc1123DateTimeInModel(
                Models.ModelWithOptionalRfc1123DateTime dateTime);

        /// <summary>
        /// Send Rfc1123 dateTime in Model EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendRfc1123DateTimeInModelAsync(
                Models.ModelWithOptionalRfc1123DateTime dateTime,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Optional Datetime in Model EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendOptionalDatetimeInModel(
                Models.ModelWithOptionalRfc3339DateTime body);

        /// <summary>
        /// Send Optional Datetime in Model EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendOptionalDatetimeInModelAsync(
                Models.ModelWithOptionalRfc3339DateTime body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send rfc339 dateTime in nestedModels EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendRfc339DateTimeInNestedModels(
                Models.SendRfc339DateTime body);

        /// <summary>
        /// Send rfc339 dateTime in nestedModels EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendRfc339DateTimeInNestedModelsAsync(
                Models.SendRfc339DateTime body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// uuid as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse UuidAsOptional(
                Models.UuidAsOptional body);

        /// <summary>
        /// uuid as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> UuidAsOptionalAsync(
                Models.UuidAsOptional body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// boolean as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse BooleanAsOptional(
                Models.BooleanAsOptional body);

        /// <summary>
        /// boolean as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> BooleanAsOptionalAsync(
                Models.BooleanAsOptional body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// date as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse DateAsOptional(
                Models.DateAsOptional body);

        /// <summary>
        /// date as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> DateAsOptionalAsync(
                Models.DateAsOptional body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// dynamic as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse DynamicAsOptional(
                Models.DynamicAsOptional body);

        /// <summary>
        /// dynamic as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> DynamicAsOptionalAsync(
                Models.DynamicAsOptional body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// string as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse StringAsOptional(
                Models.StringAsOptional body);

        /// <summary>
        /// string as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> StringAsOptionalAsync(
                Models.StringAsOptional body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// precision as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse PrecisionAsOptional(
                Models.PrecisionAsOptional body);

        /// <summary>
        /// precision as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> PrecisionAsOptionalAsync(
                Models.PrecisionAsOptional body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// long as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse LongAsOptional(
                Models.LongAsOptional body);

        /// <summary>
        /// long as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> LongAsOptionalAsync(
                Models.LongAsOptional body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// send number as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendNumberAsOptional(
                Models.NumberAsOptional body);

        /// <summary>
        /// send number as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendNumberAsOptionalAsync(
                Models.NumberAsOptional body,
                CancellationToken cancellationToken = default);
    }
}