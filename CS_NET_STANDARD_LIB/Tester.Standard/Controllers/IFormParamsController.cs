// <copyright file="IFormParamsController.cs" company="APIMatic">
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
    /// IFormParamsController.
    /// </summary>
    public interface IFormParamsController
    {
        /// <summary>
        /// send delete Form EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendDeleteForm(
                Models.DeleteBody body);

        /// <summary>
        /// send delete Form EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendDeleteFormAsync(
                Models.DeleteBody body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// send Delete Multipart EndPoint.
        /// </summary>
        /// <param name="file">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendDeleteMultipart(
                FileStreamInfo file);

        /// <summary>
        /// send Delete Multipart EndPoint.
        /// </summary>
        /// <param name="file">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendDeleteMultipartAsync(
                FileStreamInfo file,
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
        /// Send Long EndPoint.
        /// </summary>
        /// <param name="mValue">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendLong(
                long mValue);

        /// <summary>
        /// Send Long EndPoint.
        /// </summary>
        /// <param name="mValue">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendLongAsync(
                long mValue,
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
        /// Send String Array EndPoint.
        /// </summary>
        /// <param name="strings">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendStringArray(
                List<string> strings);

        /// <summary>
        /// Send String Array EndPoint.
        /// </summary>
        /// <param name="strings">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendStringArrayAsync(
                List<string> strings,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Allow Dynamic Form Fields EndPoint.
        /// </summary>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint.</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse AllowDynamicFormFields(
                string name,
                Dictionary<string, object> fieldParameters = null);

        /// <summary>
        /// Allow Dynamic Form Fields EndPoint.
        /// </summary>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> AllowDynamicFormFieldsAsync(
                string name,
                Dictionary<string, object> fieldParameters = null,
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
        /// Send File EndPoint.
        /// </summary>
        /// <param name="file">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendFile(
                FileStreamInfo file);

        /// <summary>
        /// Send File EndPoint.
        /// </summary>
        /// <param name="file">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendFileAsync(
                FileStreamInfo file,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Multiple files EndPoint.
        /// </summary>
        /// <param name="file">Required parameter: Example: .</param>
        /// <param name="file1">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendMultipleFiles(
                FileStreamInfo file,
                FileStreamInfo file1);

        /// <summary>
        /// Send Multiple files EndPoint.
        /// </summary>
        /// <param name="file">Required parameter: Example: .</param>
        /// <param name="file1">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendMultipleFilesAsync(
                FileStreamInfo file,
                FileStreamInfo file1,
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
        /// Send a variety for form params. Returns file count and body params.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendMixedArray(
                Models.SendMixedArrayInput input);

        /// <summary>
        /// Send a variety for form params. Returns file count and body params.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendMixedArrayAsync(
                Models.SendMixedArrayInput input,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Model with Form EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse UpdateModelWithForm(
                Models.Employee model);

        /// <summary>
        /// Update Model with Form EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> UpdateModelWithFormAsync(
                Models.Employee model,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// send delete Form1 EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendDeleteForm1(
                Models.Employee model);

        /// <summary>
        /// send delete Form1 EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendDeleteForm1Async(
                Models.Employee model,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Delete Form with Model Array EndPoint.
        /// </summary>
        /// <param name="models">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendDeleteFormWithModelArray(
                List<Models.Employee> models);

        /// <summary>
        /// Send Delete Form with Model Array EndPoint.
        /// </summary>
        /// <param name="models">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendDeleteFormWithModelArrayAsync(
                List<Models.Employee> models,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Model Array with Form EndPoint.
        /// </summary>
        /// <param name="models">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse UpdateModelArrayWithForm(
                List<Models.Employee> models);

        /// <summary>
        /// Update Model Array with Form EndPoint.
        /// </summary>
        /// <param name="models">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> UpdateModelArrayWithFormAsync(
                List<Models.Employee> models,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// update String with Form EndPoint.
        /// </summary>
        /// <param name="mValue">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse UpdateStringWithForm(
                string mValue);

        /// <summary>
        /// update String with Form EndPoint.
        /// </summary>
        /// <param name="mValue">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> UpdateStringWithFormAsync(
                string mValue,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Update String Array with Form EndPoint.
        /// </summary>
        /// <param name="strings">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse UpdateStringArrayWithForm(
                List<string> strings);

        /// <summary>
        /// Update String Array with Form EndPoint.
        /// </summary>
        /// <param name="strings">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> UpdateStringArrayWithFormAsync(
                List<string> strings,
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
        /// send string in form with new line EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendStringInFormWithNewLine(
                Models.TestNstringEncoding body);

        /// <summary>
        /// send string in form with new line EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendStringInFormWithNewLineAsync(
                Models.TestNstringEncoding body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// send String  in form with \r EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendStringInFormWithR(
                Models.TestRstringEncoding body);

        /// <summary>
        /// send String  in form with \r EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendStringInFormWithRAsync(
                Models.TestRstringEncoding body,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Send String in Form with \r\n EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Models.ServerResponse SendStringInFormWithRN(
                Models.TestRNstringEncoding body);

        /// <summary>
        /// Send String in Form with \r\n EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        Task<Models.ServerResponse> SendStringInFormWithRNAsync(
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