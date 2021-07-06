// <copyright file="EchoController.cs" company="APIMatic">
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
    /// EchoController.
    /// </summary>
    internal class EchoController : BaseController, IEchoController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EchoController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal EchoController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// Echo's back the request.
        /// </summary>
        /// <param name="input">Required parameter: Example: .</param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public dynamic JsonEcho(
                object input)
        {
            Task<dynamic> t = this.JsonEchoAsync(input);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Echo's back the request.
        /// </summary>
        /// <param name="input">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public async Task<dynamic> JsonEchoAsync(
                object input,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (input == null)
            {
                throw new ArgumentNullException("input", "The parameter \"input\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "echo", "true" },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(input);

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

            return ApiHelper.JsonDeserialize<dynamic>(response.Body);
        }

        /// <summary>
        /// Sends the request including any form params as JSON.
        /// </summary>
        /// <param name="input">Required parameter: Example: .</param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public dynamic FormEcho(
                object input)
        {
            Task<dynamic> t = this.FormEchoAsync(input);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Sends the request including any form params as JSON.
        /// </summary>
        /// <param name="input">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public async Task<dynamic> FormEchoAsync(
                object input,
                CancellationToken cancellationToken = default)
        {
            // validating required parameters.
            if (input == null)
            {
                throw new ArgumentNullException("input", "The parameter \"input\" is a required parameter and cannot be null.");
            }

            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>();
            fields.AddRange(ApiHelper.PrepareFormFieldsFromObject("input", input, arrayDeserializationFormat: this.ArrayDeserializationFormat));

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

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

            return ApiHelper.JsonDeserialize<dynamic>(response.Body);
        }

        /// <summary>
        /// QueryEcho EndPoint.
        /// </summary>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint.</param>
        /// <returns>Returns the Models.EchoResponse response from the API call.</returns>
        public Models.EchoResponse QueryEcho(
                Dictionary<string, object> queryParameters = null)
        {
            Task<Models.EchoResponse> t = this.QueryEchoAsync(queryParameters);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// QueryEcho EndPoint.
        /// </summary>
        /// <param name="queryParameters">Additional optional query parameters are supported by this endpoint.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EchoResponse response from the API call.</returns>
        public async Task<Models.EchoResponse> QueryEchoAsync(
                Dictionary<string, object> queryParameters = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParameters);

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

            return ApiHelper.JsonDeserialize<Models.EchoResponse>(response.Body);
        }
    }
}