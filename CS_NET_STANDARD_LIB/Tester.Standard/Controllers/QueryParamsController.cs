// <copyright file="QueryParamsController.cs" company="APIMatic">
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
    /// QueryParamsController.
    /// </summary>
    internal class QueryParamsController : BaseController, IQueryParamsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryParamsController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal QueryParamsController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// Send Number as optional EndPoint.
        /// </summary>
        /// <param name="number">Required parameter: Example: .</param>
        /// <param name="number1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendNumberAsOptional(
                int number,
                int? number1 = null)
        {
            Task<Models.ServerResponse> t = this.SendNumberAsOptionalAsync(number, number1);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Number as optional EndPoint.
        /// </summary>
        /// <param name="number">Required parameter: Example: .</param>
        /// <param name="number1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendNumberAsOptionalAsync(
                int number,
                int? number1 = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/numberAsOptional");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "number", number },
                { "number1", number1 },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

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
        /// send long as optional EndPoint.
        /// </summary>
        /// <param name="mLong">Required parameter: Example: .</param>
        /// <param name="long1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendLongAsOptional(
                long mLong,
                long? long1 = null)
        {
            Task<Models.ServerResponse> t = this.SendLongAsOptionalAsync(mLong, long1);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// send long as optional EndPoint.
        /// </summary>
        /// <param name="mLong">Required parameter: Example: .</param>
        /// <param name="long1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendLongAsOptionalAsync(
                long mLong,
                long? long1 = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/longAsOptional");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "long", mLong },
                { "long1", long1 },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

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
        /// <param name="precision">Required parameter: Example: .</param>
        /// <param name="precision1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse PrecisionAsOptional(
                double precision,
                double? precision1 = null)
        {
            Task<Models.ServerResponse> t = this.PrecisionAsOptionalAsync(precision, precision1);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// precision as optional EndPoint.
        /// </summary>
        /// <param name="precision">Required parameter: Example: .</param>
        /// <param name="precision1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> PrecisionAsOptionalAsync(
                double precision,
                double? precision1 = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/precisionAsOptional");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "precision", precision },
                { "precision1", precision1 },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

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
        /// Boolean as optional EndPoint.
        /// </summary>
        /// <param name="boolean">Required parameter: Example: .</param>
        /// <param name="boolean1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse BooleanAsOptional(
                bool boolean,
                bool? boolean1 = null)
        {
            Task<Models.ServerResponse> t = this.BooleanAsOptionalAsync(boolean, boolean1);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Boolean as optional EndPoint.
        /// </summary>
        /// <param name="boolean">Required parameter: Example: .</param>
        /// <param name="boolean1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> BooleanAsOptionalAsync(
                bool boolean,
                bool? boolean1 = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/booleanAsOptional");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "boolean", boolean },
                { "boolean1", boolean1 },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

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
        /// rfc1123 datetime as optional EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="dateTime1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse Rfc1123DatetimeAsOptional(
                DateTime dateTime,
                DateTime? dateTime1 = null)
        {
            Task<Models.ServerResponse> t = this.Rfc1123DatetimeAsOptionalAsync(dateTime, dateTime1);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// rfc1123 datetime as optional EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="dateTime1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> Rfc1123DatetimeAsOptionalAsync(
                DateTime dateTime,
                DateTime? dateTime1 = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/rfc1123dateTimeAsOptional");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "dateTime", dateTime.ToString("r") },
                { "dateTime1", dateTime1.HasValue ? dateTime1.Value.ToString("r") : null },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

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
        /// rfc3339 datetime as optional EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="dateTime1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse Rfc3339DatetimeAsOptional(
                DateTime dateTime,
                DateTime? dateTime1 = null)
        {
            Task<Models.ServerResponse> t = this.Rfc3339DatetimeAsOptionalAsync(dateTime, dateTime1);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// rfc3339 datetime as optional EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="dateTime1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> Rfc3339DatetimeAsOptionalAsync(
                DateTime dateTime,
                DateTime? dateTime1 = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/rfc3339dateTimeAsOptional");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "dateTime", dateTime.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") },
                { "dateTime1", dateTime1.HasValue ? dateTime1.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

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
        /// send date as optional EndPoint.
        /// </summary>
        /// <param name="date">Required parameter: Example: .</param>
        /// <param name="date1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendDateAsOptional(
                DateTime date,
                DateTime? date1 = null)
        {
            Task<Models.ServerResponse> t = this.SendDateAsOptionalAsync(date, date1);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// send date as optional EndPoint.
        /// </summary>
        /// <param name="date">Required parameter: Example: .</param>
        /// <param name="date1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendDateAsOptionalAsync(
                DateTime date,
                DateTime? date1 = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/dateAsOptional");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "date", date.ToString("yyyy'-'MM'-'dd") },
                { "date1", date1.HasValue ? date1.Value.ToString("yyyy'-'MM'-'dd") : null },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

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
        /// send string as optional EndPoint.
        /// </summary>
        /// <param name="mString">Required parameter: Example: .</param>
        /// <param name="string1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SendStringAsOptional(
                string mString,
                string string1 = null)
        {
            Task<Models.ServerResponse> t = this.SendStringAsOptionalAsync(mString, string1);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// send string as optional EndPoint.
        /// </summary>
        /// <param name="mString">Required parameter: Example: .</param>
        /// <param name="string1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SendStringAsOptionalAsync(
                string mString,
                string string1 = null,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (mString == null)
            {
                throw new ArgumentNullException("mString", "The parameter \"mString\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/stringAsOptional");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "string", mString },
                { "string1", string1 },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

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
        /// unixdatetime as optional EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="dateTime1">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse UnixdatetimeAsOptional(
                DateTime dateTime,
                DateTime? dateTime1 = null)
        {
            Task<Models.ServerResponse> t = this.UnixdatetimeAsOptionalAsync(dateTime, dateTime1);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// unixdatetime as optional EndPoint.
        /// </summary>
        /// <param name="dateTime">Required parameter: Example: .</param>
        /// <param name="dateTime1">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> UnixdatetimeAsOptionalAsync(
                DateTime dateTime,
                DateTime? dateTime1 = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/unixdateTimeAsOptional");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "dateTime", dateTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds },
                { "dateTime1", dateTime1.HasValue ? (double?)dateTime1.Value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds : null },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

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