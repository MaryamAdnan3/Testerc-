// <copyright file="BodyParamsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Tester.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Converters;
    using Tester.Standard;
    using Tester.Standard.Authentication;
    using Tester.Standard.Http.Client;
    using Tester.Standard.Http.Request;
    using Tester.Standard.Http.Response;
    using Tester.Standard.Utilities;

    /// <summary>
    /// BodyParamsController.
    /// </summary>
    internal class BodyParamsController : BaseController, IBodyParamsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyParamsController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal BodyParamsController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// Send Delete PlainText EndPoint.
        /// </summary>
        /// <param name="textString">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendDeletePlainText(
                string textString)
        {
            Task<Models.ServerResponse> t = this.SendDeletePlainTextAsync(textString);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Delete PlainText EndPoint.
        /// </summary>
        /// <param name="textString">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendDeletePlainTextAsync(
                string textString,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (textString == null)
            {
                throw new ArgumentNullException("textString", "The parameter \"textString\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/deletePlainTextBody");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "text/plain; charset=utf-8" },
            };

            // append body params.
            var bodyText = textString;

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().DeleteBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// send Delete Body EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendDeleteBody(
                Models.DeleteBody body)
        {
            Task<Models.ServerResponse> t = this.SendDeleteBodyAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// send Delete Body EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendDeleteBodyAsync(
                Models.DeleteBody body,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (body == null)
            {
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/deleteBody");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().DeleteBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send Date Array EndPoint.
        /// </summary>
        /// <param name="dates">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendDateArray(
                List<DateTime> dates)
        {
            Task<Models.ServerResponse> t = this.SendDateArrayAsync(dates);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Date Array EndPoint.
        /// </summary>
        /// <param name="dates">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendDateArrayAsync(
                List<DateTime> dates,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (dates == null)
            {
                throw new ArgumentNullException("dates", "The parameter \"dates\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/date");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(dates, new CustomDateTimeConverter("yyyy'-'MM'-'dd"));

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send Date EndPoint.
        /// </summary>
        /// <param name="date">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendDate(
                DateTime date)
        {
            Task<Models.ServerResponse> t = this.SendDateAsync(date);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Date EndPoint.
        /// </summary>
        /// <param name="date">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendDateAsync(
                DateTime date,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/date");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "text/plain; charset=utf-8" },
            };

            // append body params.
            var bodyText = date.ToString("yyyy'-'MM'-'dd");

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send UnixDateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendUnixDateTime(
                DateTime datetime)
        {
            Task<Models.ServerResponse> t = this.SendUnixDateTimeAsync(datetime);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send UnixDateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendUnixDateTimeAsync(
                DateTime datetime,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/unixdatetime");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "text/plain; charset=utf-8" },
            };

            // append body params.
            var bodyText = datetime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds.ToString();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send Rfc1123 DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendRfc1123DateTime(
                DateTime datetime)
        {
            Task<Models.ServerResponse> t = this.SendRfc1123DateTimeAsync(datetime);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Rfc1123 DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendRfc1123DateTimeAsync(
                DateTime datetime,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/rfc1123datetime");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "text/plain; charset=utf-8" },
            };

            // append body params.
            var bodyText = datetime.ToString("r");

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send Rfc3339 DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendRfc3339DateTime(
                DateTime datetime)
        {
            Task<Models.ServerResponse> t = this.SendRfc3339DateTimeAsync(datetime);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Rfc3339 DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendRfc3339DateTimeAsync(
                DateTime datetime,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/rfc3339datetime");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "text/plain; charset=utf-8" },
            };

            // append body params.
            var bodyText = datetime.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK");

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send UnixDateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendUnixDateTimeArray(
                List<DateTime> datetimes)
        {
            Task<Models.ServerResponse> t = this.SendUnixDateTimeArrayAsync(datetimes);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send UnixDateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendUnixDateTimeArrayAsync(
                List<DateTime> datetimes,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (datetimes == null)
            {
                throw new ArgumentNullException("datetimes", "The parameter \"datetimes\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/unixdatetime");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(datetimes, new Tester.Standard.Utilities.UnixDateTimeConverter());

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send Rfc1123 DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendRfc1123DateTimeArray(
                List<DateTime> datetimes)
        {
            Task<Models.ServerResponse> t = this.SendRfc1123DateTimeArrayAsync(datetimes);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Rfc1123 DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendRfc1123DateTimeArrayAsync(
                List<DateTime> datetimes,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (datetimes == null)
            {
                throw new ArgumentNullException("datetimes", "The parameter \"datetimes\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/rfc1123datetime");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(datetimes, new CustomDateTimeConverter("r"));

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send Rfc3339 DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendRfc3339DateTimeArray(
                List<DateTime> datetimes)
        {
            Task<Models.ServerResponse> t = this.SendRfc3339DateTimeArrayAsync(datetimes);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Rfc3339 DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendRfc3339DateTimeArrayAsync(
                List<DateTime> datetimes,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (datetimes == null)
            {
                throw new ArgumentNullException("datetimes", "The parameter \"datetimes\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/rfc3339datetime");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(datetimes, new IsoDateTimeConverter());

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// sends a string body param.
        /// </summary>
        /// <param name="sarray">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendStringArray(
                List<string> sarray)
        {
            Task<Models.ServerResponse> t = this.SendStringArrayAsync(sarray);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// sends a string body param.
        /// </summary>
        /// <param name="sarray">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendStringArrayAsync(
                List<string> sarray,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (sarray == null)
            {
                throw new ArgumentNullException("sarray", "The parameter \"sarray\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/string");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(sarray);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// update String EndPoint.
        /// </summary>
        /// <param name="mValue">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse UpdateString(
                string mValue)
        {
            Task<Models.ServerResponse> t = this.UpdateStringAsync(mValue);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// update String EndPoint.
        /// </summary>
        /// <param name="mValue">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> UpdateStringAsync(
                string mValue,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (mValue == null)
            {
                throw new ArgumentNullException("mValue", "The parameter \"mValue\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/updateString");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "text/plain; charset=utf-8" },
            };

            // append body params.
            var bodyText = mValue;

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PutBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send Integer Array EndPoint.
        /// </summary>
        /// <param name="integers">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendIntegerArray(
                List<int> integers)
        {
            Task<Models.ServerResponse> t = this.SendIntegerArrayAsync(integers);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Integer Array EndPoint.
        /// </summary>
        /// <param name="integers">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendIntegerArrayAsync(
                List<int> integers,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (integers == null)
            {
                throw new ArgumentNullException("integers", "The parameter \"integers\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/number");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(integers);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Wrap Body in Object EndPoint.
        /// </summary>
        /// <param name="field">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse WrapBodyInObject(
                string field,
                string name)
        {
            Task<Models.ServerResponse> t = this.WrapBodyInObjectAsync(field, name);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Wrap Body in Object EndPoint.
        /// </summary>
        /// <param name="field">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> WrapBodyInObjectAsync(
                string field,
                string name,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (field == null)
            {
                throw new ArgumentNullException("field", "The parameter \"field\" is a required parameter and cannot be null.");
            }

            if (name == null)
            {
                throw new ArgumentNullException("name", "The parameter \"name\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/wrapParamInObject");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(new Dictionary<string, object>
            {
                { "field", field },
                { "name", name },
            });

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Additional Model Parameters EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse AdditionalModelParameters(
                Models.AdditionalModelParameters model)
        {
            Task<Models.ServerResponse> t = this.AdditionalModelParametersAsync(model);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Additional Model Parameters EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> AdditionalModelParametersAsync(
                Models.AdditionalModelParameters model,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (model == null)
            {
                throw new ArgumentNullException("model", "The parameter \"model\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/additionalModelProperties");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(model);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// validate Required parameter EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <param name="option">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse ValidateRequiredParameter(
                Models.Validate model,
                string option = null)
        {
            Task<Models.ServerResponse> t = this.ValidateRequiredParameterAsync(model, option);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// validate Required parameter EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <param name="option">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> ValidateRequiredParameterAsync(
                Models.Validate model,
                string option = null,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (model == null)
            {
                throw new ArgumentNullException("model", "The parameter \"model\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/validateRequiredParam");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "option", option },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(model);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Additional Model Parameters1 EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse AdditionalModelParameters1(
                Models.AdditionalModelParameters model)
        {
            Task<Models.ServerResponse> t = this.AdditionalModelParameters1Async(model);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Additional Model Parameters1 EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> AdditionalModelParameters1Async(
                Models.AdditionalModelParameters model,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (model == null)
            {
                throw new ArgumentNullException("model", "The parameter \"model\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/additionalModelProperties");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(model);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send Model EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendModel(
                Models.Employee model)
        {
            Task<Models.ServerResponse> t = this.SendModelAsync(model);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Model EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendModelAsync(
                Models.Employee model,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (model == null)
            {
                throw new ArgumentNullException("model", "The parameter \"model\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/model");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(model);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send Model Array EndPoint.
        /// </summary>
        /// <param name="models">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendModelArray(
                List<Models.Employee> models)
        {
            Task<Models.ServerResponse> t = this.SendModelArrayAsync(models);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Model Array EndPoint.
        /// </summary>
        /// <param name="models">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendModelArrayAsync(
                List<Models.Employee> models,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (models == null)
            {
                throw new ArgumentNullException("models", "The parameter \"models\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/model");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(models);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send Dynamic EndPoint.
        /// </summary>
        /// <param name="mDynamic">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendDynamic(
                object mDynamic)
        {
            Task<Models.ServerResponse> t = this.SendDynamicAsync(mDynamic);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Dynamic EndPoint.
        /// </summary>
        /// <param name="mDynamic">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendDynamicAsync(
                object mDynamic,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (mDynamic == null)
            {
                throw new ArgumentNullException("mDynamic", "The parameter \"mDynamic\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/dynamic");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(mDynamic);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send String EndPoint.
        /// </summary>
        /// <param name="mValue">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendString(
                string mValue)
        {
            Task<Models.ServerResponse> t = this.SendStringAsync(mValue);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send String EndPoint.
        /// </summary>
        /// <param name="mValue">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendStringAsync(
                string mValue,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (mValue == null)
            {
                throw new ArgumentNullException("mValue", "The parameter \"mValue\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/string");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "text/plain; charset=utf-8" },
            };

            // append body params.
            var bodyText = mValue;

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// SendStringEnumArray EndPoint.
        /// </summary>
        /// <param name="days">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendStringEnumArray(
                List<Models.Days> days)
        {
            Task<Models.ServerResponse> t = this.SendStringEnumArrayAsync(days);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// SendStringEnumArray EndPoint.
        /// </summary>
        /// <param name="days">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendStringEnumArrayAsync(
                List<Models.Days> days,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (days == null)
            {
                throw new ArgumentNullException("days", "The parameter \"days\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/stringenum");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(days);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// SendIntegerEnumArray EndPoint.
        /// </summary>
        /// <param name="suites">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendIntegerEnumArray(
                List<Models.SuiteCode> suites)
        {
            Task<Models.ServerResponse> t = this.SendIntegerEnumArrayAsync(suites);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// SendIntegerEnumArray EndPoint.
        /// </summary>
        /// <param name="suites">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendIntegerEnumArrayAsync(
                List<Models.SuiteCode> suites,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (suites == null)
            {
                throw new ArgumentNullException("suites", "The parameter \"suites\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/integerenum");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(suites);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Update Model EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse UpdateModel(
                Models.Employee model)
        {
            Task<Models.ServerResponse> t = this.UpdateModelAsync(model);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update Model EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> UpdateModelAsync(
                Models.Employee model,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (model == null)
            {
                throw new ArgumentNullException("model", "The parameter \"model\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/updateModel");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(model);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PutBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send Delete Body with Model EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendDeleteBodyWithModel(
                Models.Employee model)
        {
            Task<Models.ServerResponse> t = this.SendDeleteBodyWithModelAsync(model);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Delete Body with Model EndPoint.
        /// </summary>
        /// <param name="model">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendDeleteBodyWithModelAsync(
                Models.Employee model,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (model == null)
            {
                throw new ArgumentNullException("model", "The parameter \"model\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/deleteBody1");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(model);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().DeleteBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send Delete Body with Model Array EndPoint.
        /// </summary>
        /// <param name="models">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendDeleteBodyWithModelArray(
                List<Models.Employee> models)
        {
            Task<Models.ServerResponse> t = this.SendDeleteBodyWithModelArrayAsync(models);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Delete Body with Model Array EndPoint.
        /// </summary>
        /// <param name="models">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendDeleteBodyWithModelArrayAsync(
                List<Models.Employee> models,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (models == null)
            {
                throw new ArgumentNullException("models", "The parameter \"models\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/deleteBody1");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(models);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().DeleteBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Update Model Array EndPoint.
        /// </summary>
        /// <param name="models">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse UpdateModelArray(
                List<Models.Employee> models)
        {
            Task<Models.ServerResponse> t = this.UpdateModelArrayAsync(models);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update Model Array EndPoint.
        /// </summary>
        /// <param name="models">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> UpdateModelArrayAsync(
                List<Models.Employee> models,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (models == null)
            {
                throw new ArgumentNullException("models", "The parameter \"models\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/updateModel");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(models);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PutBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// update String1 EndPoint.
        /// </summary>
        /// <param name="mValue">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse UpdateString1(
                string mValue)
        {
            Task<Models.ServerResponse> t = this.UpdateString1Async(mValue);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// update String1 EndPoint.
        /// </summary>
        /// <param name="mValue">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> UpdateString1Async(
                string mValue,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (mValue == null)
            {
                throw new ArgumentNullException("mValue", "The parameter \"mValue\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/updateString");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "text/plain; charset=utf-8" },
            };

            // append body params.
            var bodyText = mValue;

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PutBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Update String Array EndPoint.
        /// </summary>
        /// <param name="strings">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse UpdateStringArray(
                List<string> strings)
        {
            Task<Models.ServerResponse> t = this.UpdateStringArrayAsync(strings);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update String Array EndPoint.
        /// </summary>
        /// <param name="strings">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> UpdateStringArrayAsync(
                List<string> strings,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (strings == null)
            {
                throw new ArgumentNullException("strings", "The parameter \"strings\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/updateString");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(strings);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PutBody(queryBuilder.ToString(), headers, bodyText, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// send string with new line EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendStringWithNewLine(
                Models.TestNstringEncoding body)
        {
            Task<Models.ServerResponse> t = this.SendStringWithNewLineAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// send string with new line EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendStringWithNewLineAsync(
                Models.TestNstringEncoding body,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (body == null)
            {
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/stringEncoding");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// send String with \r EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendStringWithR(
                Models.TestRstringEncoding body)
        {
            Task<Models.ServerResponse> t = this.SendStringWithRAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// send String with \r EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendStringWithRAsync(
                Models.TestRstringEncoding body,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (body == null)
            {
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/stringEncoding");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send String in body with \r\n EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendStringInBodyWithRN(
                Models.TestRNstringEncoding body)
        {
            Task<Models.ServerResponse> t = this.SendStringInBodyWithRNAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send String in body with \r\n EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendStringInBodyWithRNAsync(
                Models.TestRNstringEncoding body,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (body == null)
            {
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/stringEncoding");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send Optional Unix DateTime In Body EndPoint.
        /// </summary>
        /// <param name="dateTime">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendOptionalUnixDateTimeInBody(
                DateTime? dateTime = null)
        {
            Task<Models.ServerResponse> t = this.SendOptionalUnixDateTimeInBodyAsync(dateTime);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Optional Unix DateTime In Body EndPoint.
        /// </summary>
        /// <param name="dateTime">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendOptionalUnixDateTimeInBodyAsync(
                DateTime? dateTime = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/optionalUnixTimeStamp");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "text/plain; charset=utf-8" },
            };

            // append body params.
            var bodyText = dateTime.HasValue ? dateTime.Value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds.ToString() : null;

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send optional rfc1123 in body EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendOptionalRfc1123InBody(
                DateTime body)
        {
            Task<Models.ServerResponse> t = this.SendOptionalRfc1123InBodyAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send optional rfc1123 in body EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendOptionalRfc1123InBodyAsync(
                DateTime body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/optionlRfc1123");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "text/plain; charset=utf-8" },
            };

            // append body params.
            var bodyText = body.ToString("r");

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// send datetime optional in endpoint EndPoint.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendDatetimeOptionalInEndpoint(
                DateTime? body = null)
        {
            Task<Models.ServerResponse> t = this.SendDatetimeOptionalInEndpointAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// send datetime optional in endpoint EndPoint.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendDatetimeOptionalInEndpointAsync(
                DateTime? body = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/optionalDateTime");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "text/plain; charset=utf-8" },
            };

            // append body params.
            var bodyText = body.HasValue ? body.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null;

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send optional unixTimeStamp in Model (body) EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendOptionalUnixTimeStampInModelBody(
                Models.UnixDateTime dateTime)
        {
            Task<Models.ServerResponse> t = this.SendOptionalUnixTimeStampInModelBodyAsync(dateTime);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send optional unixTimeStamp in Model (body) EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendOptionalUnixTimeStampInModelBodyAsync(
                Models.UnixDateTime dateTime,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (dateTime == null)
            {
                throw new ArgumentNullException("dateTime", "The parameter \"dateTime\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/optionalUnixDateTimeInModel");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(dateTime);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// send optional unixTimeStamp in nested model (body) EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendOptionalUnixTimeStampInNestedModelBody(
                Models.SendUnixDateTime dateTime)
        {
            Task<Models.ServerResponse> t = this.SendOptionalUnixTimeStampInNestedModelBodyAsync(dateTime);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// send optional unixTimeStamp in nested model (body) EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendOptionalUnixTimeStampInNestedModelBodyAsync(
                Models.SendUnixDateTime dateTime,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (dateTime == null)
            {
                throw new ArgumentNullException("dateTime", "The parameter \"dateTime\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/optionalUnixTimeStampInNestedModel");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(dateTime);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// send Rfc1123 dateTime in Nested Model EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendRfc1123DateTimeInNestedModel(
                Models.SendRfc1123DateTime body)
        {
            Task<Models.ServerResponse> t = this.SendRfc1123DateTimeInNestedModelAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// send Rfc1123 dateTime in Nested Model EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendRfc1123DateTimeInNestedModelAsync(
                Models.SendRfc1123DateTime body,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (body == null)
            {
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/rfc1123InNestedModel");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send Rfc1123 dateTime in Model EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendRfc1123DateTimeInModel(
                Models.ModelWithOptionalRfc1123DateTime dateTime)
        {
            Task<Models.ServerResponse> t = this.SendRfc1123DateTimeInModelAsync(dateTime);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Rfc1123 dateTime in Model EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendRfc1123DateTimeInModelAsync(
                Models.ModelWithOptionalRfc1123DateTime dateTime,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (dateTime == null)
            {
                throw new ArgumentNullException("dateTime", "The parameter \"dateTime\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/OptionalRfc1123InModel");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(dateTime);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send Optional Datetime in Model EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendOptionalDatetimeInModel(
                Models.ModelWithOptionalRfc3339DateTime body)
        {
            Task<Models.ServerResponse> t = this.SendOptionalDatetimeInModelAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Optional Datetime in Model EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendOptionalDatetimeInModelAsync(
                Models.ModelWithOptionalRfc3339DateTime body,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (body == null)
            {
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/optionalDateTimeInBody");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// Send rfc339 dateTime in nestedModels EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendRfc339DateTimeInNestedModels(
                Models.SendRfc339DateTime body)
        {
            Task<Models.ServerResponse> t = this.SendRfc339DateTimeInNestedModelsAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send rfc339 dateTime in nestedModels EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendRfc339DateTimeInNestedModelsAsync(
                Models.SendRfc339DateTime body,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (body == null)
            {
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/dateTimeInNestedModel");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// uuid as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse UuidAsOptional(
                Models.UuidAsOptional body)
        {
            Task<Models.ServerResponse> t = this.UuidAsOptionalAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// uuid as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> UuidAsOptionalAsync(
                Models.UuidAsOptional body,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (body == null)
            {
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/optionalUUIDInModel");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// boolean as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse BooleanAsOptional(
                Models.BooleanAsOptional body)
        {
            Task<Models.ServerResponse> t = this.BooleanAsOptionalAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// boolean as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> BooleanAsOptionalAsync(
                Models.BooleanAsOptional body,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (body == null)
            {
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/optionalBooleanInModel");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// date as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse DateAsOptional(
                Models.DateAsOptional body)
        {
            Task<Models.ServerResponse> t = this.DateAsOptionalAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// date as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> DateAsOptionalAsync(
                Models.DateAsOptional body,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (body == null)
            {
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/optionalDateInModel");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// dynamic as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse DynamicAsOptional(
                Models.DynamicAsOptional body)
        {
            Task<Models.ServerResponse> t = this.DynamicAsOptionalAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// dynamic as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> DynamicAsOptionalAsync(
                Models.DynamicAsOptional body,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (body == null)
            {
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/optionalDynamicInModel");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// string as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse StringAsOptional(
                Models.StringAsOptional body)
        {
            Task<Models.ServerResponse> t = this.StringAsOptionalAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// string as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> StringAsOptionalAsync(
                Models.StringAsOptional body,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (body == null)
            {
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/optionalStringInModel");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// precision as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse PrecisionAsOptional(
                Models.PrecisionAsOptional body)
        {
            Task<Models.ServerResponse> t = this.PrecisionAsOptionalAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// precision as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> PrecisionAsOptionalAsync(
                Models.PrecisionAsOptional body,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (body == null)
            {
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/optionalPrecisionInModel");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// long as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse LongAsOptional(
                Models.LongAsOptional body)
        {
            Task<Models.ServerResponse> t = this.LongAsOptionalAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// long as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> LongAsOptionalAsync(
                Models.LongAsOptional body,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (body == null)
            {
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/optionalLongInModel");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }

        /// <summary>
        /// send number as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendNumberAsOptional(
                Models.NumberAsOptional body)
        {
            Task<Models.ServerResponse> t = this.SendNumberAsOptionalAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// send number as optional EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendNumberAsOptionalAsync(
                Models.NumberAsOptional body,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (body == null)
            {
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/body/optionalNumberInModel");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // return null on 404.
            if (response.StatusCode == 404)
            {
                return null;
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ServerResponse>(response.Body);
        }
    }
}