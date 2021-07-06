// <copyright file="QueryParamController.cs" company="APIMatic">
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
    /// QueryParamController.
    /// </summary>
    internal class QueryParamController : BaseController, IQueryParamController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryParamController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal QueryParamController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// Date Array EndPoint.
        /// </summary>
        /// <param name="dates">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse DateArray(
                List<DateTime> dates)
        {
            Task<Models.ServerResponse> t = this.DateArrayAsync(dates);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Date Array EndPoint.
        /// </summary>
        /// <param name="dates">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> DateArrayAsync(
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
            queryBuilder.Append("/query/datearray");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "dates", dates.Select(x => x.ToString("yyyy'-'MM'-'dd")).ToList() },
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
        /// get optional dynamic query parameter.
        /// </summary>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint.</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse OptionalDynamicQueryParam(
                string name,
                Dictionary<string, object> queryParameters = null)
        {
            Task<Models.ServerResponse> t = this.OptionalDynamicQueryParamAsync(name, queryParameters);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// get optional dynamic query parameter.
        /// </summary>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> OptionalDynamicQueryParamAsync(
                string name,
                Dictionary<string, object> queryParameters = null,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (name == null)
            {
                throw new ArgumentNullException("name", "The parameter \"name\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/optionalQueryParam");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "name", name },
            };

            // prepare optional query parameters.
            if (queryParameters != null)
            {
                queryParams = queryParams.Concat(queryParameters).ToDictionary(x => x.Key, x => x.Value);
            }

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
        /// Date EndPoint.
        /// </summary>
        /// <param name="date">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse Date(
                DateTime date)
        {
            Task<Models.ServerResponse> t = this.DateAsync(date);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Date EndPoint.
        /// </summary>
        /// <param name="date">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> DateAsync(
                DateTime date,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/date");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "date", date.ToString("yyyy'-'MM'-'dd") },
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
        /// Unix DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse UnixDateTimeArray(
                List<DateTime> datetimes)
        {
            Task<Models.ServerResponse> t = this.UnixDateTimeArrayAsync(datetimes);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Unix DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> UnixDateTimeArrayAsync(
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
            queryBuilder.Append("/query/unixdatetimearray");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "datetimes", datetimes.Select(x => x.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds).ToList() },
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
        /// Unix DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse UnixDateTime(
                DateTime datetime)
        {
            Task<Models.ServerResponse> t = this.UnixDateTimeAsync(datetime);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Unix DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> UnixDateTimeAsync(
                DateTime datetime,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/unixdatetime");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "datetime", datetime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds },
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
        /// Rfc1123 DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse Rfc1123DateTime(
                DateTime datetime)
        {
            Task<Models.ServerResponse> t = this.Rfc1123DateTimeAsync(datetime);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Rfc1123 DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> Rfc1123DateTimeAsync(
                DateTime datetime,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/rfc1123datetime");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "datetime", datetime.ToString("r") },
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
        /// Rfc1123 DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse Rfc1123DateTimeArray(
                List<DateTime> datetimes)
        {
            Task<Models.ServerResponse> t = this.Rfc1123DateTimeArrayAsync(datetimes);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Rfc1123 DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> Rfc1123DateTimeArrayAsync(
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
            queryBuilder.Append("/query/rfc1123datetimearray");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "datetimes", datetimes.Select(x => x.ToString("r")).ToList() },
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
        /// Rfc3339 DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse Rfc3339DateTimeArray(
                List<DateTime> datetimes)
        {
            Task<Models.ServerResponse> t = this.Rfc3339DateTimeArrayAsync(datetimes);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Rfc3339 DateTime Array EndPoint.
        /// </summary>
        /// <param name="datetimes">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> Rfc3339DateTimeArrayAsync(
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
            queryBuilder.Append("/query/rfc3339datetimearray");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "datetimes", datetimes.Select(x => x.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK")).ToList() },
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
        /// Rfc3339 DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse Rfc3339DateTime(
                DateTime datetime)
        {
            Task<Models.ServerResponse> t = this.Rfc3339DateTimeAsync(datetime);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Rfc3339 DateTime EndPoint.
        /// </summary>
        /// <param name="datetime">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> Rfc3339DateTimeAsync(
                DateTime datetime,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/rfc3339datetime");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "datetime", datetime.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") },
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
        /// NoParams EndPoint.
        /// </summary>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse NoParams()
        {
            Task<Models.ServerResponse> t = this.NoParamsAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// NoParams EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> NoParamsAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/noparams");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

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
        /// StringParam EndPoint.
        /// </summary>
        /// <param name="mString">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse StringParam(
                string mString)
        {
            Task<Models.ServerResponse> t = this.StringParamAsync(mString);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// StringParam EndPoint.
        /// </summary>
        /// <param name="mString">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> StringParamAsync(
                string mString,
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
            queryBuilder.Append("/query/stringparam");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "string", mString },
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
        /// UrlParam EndPoint.
        /// </summary>
        /// <param name="url">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse UrlParam(
                string url)
        {
            Task<Models.ServerResponse> t = this.UrlParamAsync(url);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// UrlParam EndPoint.
        /// </summary>
        /// <param name="url">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> UrlParamAsync(
                string url,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (url == null)
            {
                throw new ArgumentNullException("url", "The parameter \"url\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/urlparam");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "url", url },
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
        /// Number Array EndPoint.
        /// </summary>
        /// <param name="integers">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse NumberArray(
                List<int> integers)
        {
            Task<Models.ServerResponse> t = this.NumberArrayAsync(integers);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Number Array EndPoint.
        /// </summary>
        /// <param name="integers">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> NumberArrayAsync(
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
            queryBuilder.Append("/query/numberarray");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "integers", integers },
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
        /// String Array EndPoint.
        /// </summary>
        /// <param name="strings">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse StringArray(
                List<string> strings)
        {
            Task<Models.ServerResponse> t = this.StringArrayAsync(strings);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// String Array EndPoint.
        /// </summary>
        /// <param name="strings">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> StringArrayAsync(
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
            queryBuilder.Append("/query/stringarray");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "strings", strings },
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
        /// SimpleQuery EndPoint.
        /// </summary>
        /// <param name="boolean">Required parameter: Example: .</param>
        /// <param name="number">Required parameter: Example: .</param>
        /// <param name="mString">Required parameter: Example: .</param>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint.</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse SimpleQuery(
                bool boolean,
                int number,
                string mString,
                Dictionary<string, object> queryParameters = null)
        {
            Task<Models.ServerResponse> t = this.SimpleQueryAsync(boolean, number, mString, queryParameters);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// SimpleQuery EndPoint.
        /// </summary>
        /// <param name="boolean">Required parameter: Example: .</param>
        /// <param name="number">Required parameter: Example: .</param>
        /// <param name="mString">Required parameter: Example: .</param>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> SimpleQueryAsync(
                bool boolean,
                int number,
                string mString,
                Dictionary<string, object> queryParameters = null,
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
            queryBuilder.Append("/query");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "boolean", boolean },
                { "number", number },
                { "string", mString },
            };

            // prepare optional query parameters.
            if (queryParameters != null)
            {
                queryParams = queryParams.Concat(queryParameters).ToDictionary(x => x.Key, x => x.Value);
            }

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
        /// String Enum Array EndPoint.
        /// </summary>
        /// <param name="days">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse StringEnumArray(
                List<Models.Days> days)
        {
            Task<Models.ServerResponse> t = this.StringEnumArrayAsync(days);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// String Enum Array EndPoint.
        /// </summary>
        /// <param name="days">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> StringEnumArrayAsync(
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
            queryBuilder.Append("/query/stringenumarray");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "days", days.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList() },
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
        /// MultipleParams EndPoint.
        /// </summary>
        /// <param name="number">Required parameter: Example: .</param>
        /// <param name="precision">Required parameter: Example: .</param>
        /// <param name="mString">Required parameter: Example: .</param>
        /// <param name="url">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse MultipleParams(
                int number,
                double precision,
                string mString,
                string url)
        {
            Task<Models.ServerResponse> t = this.MultipleParamsAsync(number, precision, mString, url);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// MultipleParams EndPoint.
        /// </summary>
        /// <param name="number">Required parameter: Example: .</param>
        /// <param name="precision">Required parameter: Example: .</param>
        /// <param name="mString">Required parameter: Example: .</param>
        /// <param name="url">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> MultipleParamsAsync(
                int number,
                double precision,
                string mString,
                string url,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (mString == null)
            {
                throw new ArgumentNullException("mString", "The parameter \"mString\" is a required parameter and cannot be null.");
            }

            if (url == null)
            {
                throw new ArgumentNullException("url", "The parameter \"url\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/query/multipleparams");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "number", number },
                { "precision", precision },
                { "string", mString },
                { "url", url },
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
        /// Integer Enum Array EndPoint.
        /// </summary>
        /// <param name="suites">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public Models.ServerResponse IntegerEnumArray(
                List<Models.SuiteCode> suites)
        {
            Task<Models.ServerResponse> t = this.IntegerEnumArrayAsync(suites);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Integer Enum Array EndPoint.
        /// </summary>
        /// <param name="suites">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerResponse response from the API call.</returns>
        public async Task<Models.ServerResponse> IntegerEnumArrayAsync(
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
            queryBuilder.Append("/query/integerenumarray");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "suites", suites.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList() },
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