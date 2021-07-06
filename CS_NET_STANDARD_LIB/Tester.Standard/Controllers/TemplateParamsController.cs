// <copyright file="TemplateParamsController.cs" company="APIMatic">
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
    /// TemplateParamsController.
    /// </summary>
    internal class TemplateParamsController : BaseController, ITemplateParamsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateParamsController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal TemplateParamsController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// Send String Array EndPoint.
        /// </summary>
        /// <param name="strings">Required parameter: Example: .</param>
        /// <returns>Returns the Models.EchoResponse response from the API call.</returns>
        public Models.EchoResponse SendStringArray(
                List<string> strings)
        {
            Task<Models.EchoResponse> t = this.SendStringArrayAsync(strings);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send String Array EndPoint.
        /// </summary>
        /// <param name="strings">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EchoResponse response from the API call.</returns>
        public async Task<Models.EchoResponse> SendStringArrayAsync(
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
            queryBuilder.Append("/template/{strings}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "strings", strings },
            });

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

            return ApiHelper.JsonDeserialize<Models.EchoResponse>(response.Body);
        }

        /// <summary>
        /// Send Integer Array EndPoint.
        /// </summary>
        /// <param name="integers">Required parameter: Example: .</param>
        /// <returns>Returns the Models.EchoResponse response from the API call.</returns>
        public Models.EchoResponse SendIntegerArray(
                List<int> integers)
        {
            Task<Models.EchoResponse> t = this.SendIntegerArrayAsync(integers);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Send Integer Array EndPoint.
        /// </summary>
        /// <param name="integers">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EchoResponse response from the API call.</returns>
        public async Task<Models.EchoResponse> SendIntegerArrayAsync(
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
            queryBuilder.Append("/template/{integers}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "integers", integers },
            });

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

            return ApiHelper.JsonDeserialize<Models.EchoResponse>(response.Body);
        }
    }
}