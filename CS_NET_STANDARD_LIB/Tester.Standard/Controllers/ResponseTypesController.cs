// <copyright file="ResponseTypesController.cs" company="APIMatic">
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
    /// ResponseTypesController.
    /// </summary>
    internal class ResponseTypesController : BaseController, IResponseTypesController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTypesController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal ResponseTypesController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// Get Date Array EndPoint.
        /// </summary>
        /// <returns>Returns the List of DateTime response from the API call.</returns>
        public List<DateTime> GetDateArray()
        {
            Task<List<DateTime>> t = this.GetDateArrayAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Date Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of DateTime response from the API call.</returns>
        public async Task<List<DateTime>> GetDateArrayAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/date");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
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

            return ApiHelper.JsonDeserialize<List<DateTime>>(response.Body, new CustomDateTimeConverter("yyyy'-'MM'-'dd"));
        }

        /// <summary>
        /// Get Date EndPoint.
        /// </summary>
        /// <returns>Returns the DateTime? response from the API call.</returns>
        public DateTime? GetDate()
        {
            Task<DateTime?> t = this.GetDateAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Date EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the DateTime? response from the API call.</returns>
        public async Task<DateTime?> GetDateAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/date");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>();

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

            return DateTime.ParseExact(response.Body, "yyyy'-'MM'-'dd", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
        }

        /// <summary>
        /// return company model EndPoint.
        /// </summary>
        /// <returns>Returns the Models.Company response from the API call.</returns>
        public Models.Company ReturnCompanyModel()
        {
            Task<Models.Company> t = this.ReturnCompanyModelAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// return company model EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Company response from the API call.</returns>
        public async Task<Models.Company> ReturnCompanyModelAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/company");

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

            return ApiHelper.JsonDeserialize<Models.Company>(response.Body);
        }

        /// <summary>
        /// return boss model EndPoint.
        /// </summary>
        /// <returns>Returns the Models.BossCompany response from the API call.</returns>
        public Models.BossCompany ReturnBossModel()
        {
            Task<Models.BossCompany> t = this.ReturnBossModelAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// return boss model EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BossCompany response from the API call.</returns>
        public async Task<Models.BossCompany> ReturnBossModelAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/boss");

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

            return ApiHelper.JsonDeserialize<Models.BossCompany>(response.Body);
        }

        /// <summary>
        /// return employee model EndPoint.
        /// </summary>
        /// <returns>Returns the Models.EmployeeComp response from the API call.</returns>
        public Models.EmployeeComp ReturnEmployeeModel()
        {
            Task<Models.EmployeeComp> t = this.ReturnEmployeeModelAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// return employee model EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EmployeeComp response from the API call.</returns>
        public async Task<Models.EmployeeComp> ReturnEmployeeModelAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/employee");

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

            return ApiHelper.JsonDeserialize<Models.EmployeeComp>(response.Body);
        }

        /// <summary>
        /// return developer model EndPoint.
        /// </summary>
        /// <returns>Returns the Models.Developer response from the API call.</returns>
        public Models.Developer ReturnDeveloperModel()
        {
            Task<Models.Developer> t = this.ReturnDeveloperModelAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// return developer model EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Developer response from the API call.</returns>
        public async Task<Models.Developer> ReturnDeveloperModelAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/developer");

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

            return ApiHelper.JsonDeserialize<Models.Developer>(response.Body);
        }

        /// <summary>
        /// return Tester model EndPoint.
        /// </summary>
        /// <returns>Returns the Models.SoftwareTester response from the API call.</returns>
        public Models.SoftwareTester ReturnTesterModel()
        {
            Task<Models.SoftwareTester> t = this.ReturnTesterModelAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// return Tester model EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SoftwareTester response from the API call.</returns>
        public async Task<Models.SoftwareTester> ReturnTesterModelAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/tester");

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

            return ApiHelper.JsonDeserialize<Models.SoftwareTester>(response.Body);
        }

        /// <summary>
        /// Return complex1 object EndPoint.
        /// </summary>
        /// <returns>Returns the Models.Complex1 response from the API call.</returns>
        public Models.Complex1 ReturnComplex1Object()
        {
            Task<Models.Complex1> t = this.ReturnComplex1ObjectAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Return complex1 object EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Complex1 response from the API call.</returns>
        public async Task<Models.Complex1> ReturnComplex1ObjectAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/complex1");

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

            return ApiHelper.JsonDeserialize<Models.Complex1>(response.Body);
        }

        /// <summary>
        /// return response with enums EndPoint.
        /// </summary>
        /// <returns>Returns the Models.ResponseWithEnum response from the API call.</returns>
        public Models.ResponseWithEnum ReturnResponseWithEnums()
        {
            Task<Models.ResponseWithEnum> t = this.ReturnResponseWithEnumsAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// return response with enums EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseWithEnum response from the API call.</returns>
        public async Task<Models.ResponseWithEnum> ReturnResponseWithEnumsAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/responseWitEnum");

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

            return ApiHelper.JsonDeserialize<Models.ResponseWithEnum>(response.Body);
        }

        /// <summary>
        /// Return complex2 object EndPoint.
        /// </summary>
        /// <returns>Returns the Models.Complex2 response from the API call.</returns>
        public Models.Complex2 ReturnComplex2Object()
        {
            Task<Models.Complex2> t = this.ReturnComplex2ObjectAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Return complex2 object EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Complex2 response from the API call.</returns>
        public async Task<Models.Complex2> ReturnComplex2ObjectAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/complex2");

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

            return ApiHelper.JsonDeserialize<Models.Complex2>(response.Body);
        }

        /// <summary>
        /// return complex3 object EndPoint.
        /// </summary>
        /// <returns>Returns the Models.Complex3 response from the API call.</returns>
        public Models.Complex3 ReturnComplex3Object()
        {
            Task<Models.Complex3> t = this.ReturnComplex3ObjectAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// return complex3 object EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Complex3 response from the API call.</returns>
        public async Task<Models.Complex3> ReturnComplex3ObjectAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/complex3");

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

            return ApiHelper.JsonDeserialize<Models.Complex3>(response.Body);
        }

        /// <summary>
        /// Get Long EndPoint.
        /// </summary>
        /// <returns>Returns the long? response from the API call.</returns>
        public long? GetLong()
        {
            Task<long?> t = this.GetLongAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Long EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the long? response from the API call.</returns>
        public async Task<long?> GetLongAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Default);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/long");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>();

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

            return long.Parse(response.Body);
        }

        /// <summary>
        /// Get Model EndPoint.
        /// </summary>
        /// <returns>Returns the Models.Person response from the API call.</returns>
        public Models.Person GetModel()
        {
            Task<Models.Person> t = this.GetModelAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Model EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Person response from the API call.</returns>
        public async Task<Models.Person> GetModelAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/model");

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

            return ApiHelper.JsonDeserialize<Models.Person>(response.Body);
        }

        /// <summary>
        /// Get String Enum Array EndPoint.
        /// </summary>
        /// <returns>Returns the List of Models.Days response from the API call.</returns>
        public List<Models.Days> GetStringEnumArray()
        {
            Task<List<Models.Days>> t = this.GetStringEnumArrayAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get String Enum Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Days response from the API call.</returns>
        public async Task<List<Models.Days>> GetStringEnumArrayAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/enum");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
                { "type", "string" },
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

            return ApiHelper.JsonDeserialize<List<Models.Days>>(response.Body);
        }

        /// <summary>
        /// Get String Enum EndPoint.
        /// </summary>
        /// <returns>Returns the Models.Days? response from the API call.</returns>
        public Models.Days? GetStringEnum()
        {
            Task<Models.Days?> t = this.GetStringEnumAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get String Enum EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Days? response from the API call.</returns>
        public async Task<Models.Days?> GetStringEnumAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/enum");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "type", "string" },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>();

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

            return (Models.Days)Enum.Parse(typeof(Models.Days), response.Body);
        }

        /// <summary>
        /// Get Model Array EndPoint.
        /// </summary>
        /// <returns>Returns the List of Models.Person response from the API call.</returns>
        public List<Models.Person> GetModelArray()
        {
            Task<List<Models.Person>> t = this.GetModelArrayAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Model Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Person response from the API call.</returns>
        public async Task<List<Models.Person>> GetModelArrayAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/model");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
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

            return ApiHelper.JsonDeserialize<List<Models.Person>>(response.Body);
        }

        /// <summary>
        /// Get Int Enum EndPoint.
        /// </summary>
        /// <returns>Returns the Models.SuiteCode? response from the API call.</returns>
        public Models.SuiteCode? GetIntEnum()
        {
            Task<Models.SuiteCode?> t = this.GetIntEnumAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Int Enum EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SuiteCode? response from the API call.</returns>
        public async Task<Models.SuiteCode?> GetIntEnumAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/enum");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "type", "int" },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>();

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

            return (Models.SuiteCode)int.Parse(response.Body);
        }

        /// <summary>
        /// Get Int Enum Array EndPoint.
        /// </summary>
        /// <returns>Returns the List of Models.SuiteCode response from the API call.</returns>
        public List<Models.SuiteCode> GetIntEnumArray()
        {
            Task<List<Models.SuiteCode>> t = this.GetIntEnumArrayAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Int Enum Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.SuiteCode response from the API call.</returns>
        public async Task<List<Models.SuiteCode>> GetIntEnumArrayAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/enum");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
                { "type", "int" },
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

            return ApiHelper.JsonDeserialize<List<Models.SuiteCode>>(response.Body);
        }

        /// <summary>
        /// Get Precision EndPoint.
        /// </summary>
        /// <returns>Returns the double? response from the API call.</returns>
        public double? GetPrecision()
        {
            Task<double?> t = this.GetPrecisionAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Precision EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the double? response from the API call.</returns>
        public async Task<double?> GetPrecisionAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/precision");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>();

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

            return double.Parse(response.Body);
        }

        /// <summary>
        /// gets a binary object.
        /// </summary>
        /// <returns>Returns the Stream response from the API call.</returns>
        public Stream GetBinary()
        {
            Task<Stream> t = this.GetBinaryAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// gets a binary object.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public async Task<Stream> GetBinaryAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/binary");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpResponse response = await this.GetClientInstance().ExecuteAsBinaryAsync(httpRequest, cancellationToken).ConfigureAwait(false);
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

            return response.RawBody;
        }

        /// <summary>
        /// Gets a integer response.
        /// </summary>
        /// <returns>Returns the int? response from the API call.</returns>
        public int? GetInteger()
        {
            Task<int?> t = this.GetIntegerAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets a integer response.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the int? response from the API call.</returns>
        public async Task<int?> GetIntegerAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/integer");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>();

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

            return int.Parse(response.Body);
        }

        /// <summary>
        /// Get an array of integers..
        /// </summary>
        /// <returns>Returns the List of int response from the API call.</returns>
        public List<int> GetIntegerArray()
        {
            Task<List<int>> t = this.GetIntegerArrayAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get an array of integers..
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of int response from the API call.</returns>
        public async Task<List<int>> GetIntegerArrayAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/integer");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
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

            return ApiHelper.JsonDeserialize<List<int>>(response.Body);
        }

        /// <summary>
        /// Get Dynamic EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public dynamic GetDynamic()
        {
            Task<dynamic> t = this.GetDynamicAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Dynamic EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public async Task<dynamic> GetDynamicAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/dynamic");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "echo", "true" },
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

            return ApiHelper.JsonDeserialize<dynamic>(response.Body);
        }

        /// <summary>
        /// Get Dynamic Array EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public dynamic GetDynamicArray()
        {
            Task<dynamic> t = this.GetDynamicArrayAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Dynamic Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public async Task<dynamic> GetDynamicArrayAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/dynamic");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
                { "echo", "true" },
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

            return ApiHelper.JsonDeserialize<dynamic>(response.Body);
        }

        /// <summary>
        /// Get 3339Datetime EndPoint.
        /// </summary>
        /// <returns>Returns the DateTime? response from the API call.</returns>
        public DateTime? Get3339Datetime()
        {
            Task<DateTime?> t = this.Get3339DatetimeAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get 3339Datetime EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the DateTime? response from the API call.</returns>
        public async Task<DateTime?> Get3339DatetimeAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/3339datetime");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>();

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

            return DateTime.ParseExact(response.Body, "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
        }

        /// <summary>
        /// Get 3339Datetime Array EndPoint.
        /// </summary>
        /// <returns>Returns the List of DateTime response from the API call.</returns>
        public List<DateTime> Get3339DatetimeArray()
        {
            Task<List<DateTime>> t = this.Get3339DatetimeArrayAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get 3339Datetime Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of DateTime response from the API call.</returns>
        public async Task<List<DateTime>> Get3339DatetimeArrayAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/3339datetime");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
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

            return ApiHelper.JsonDeserialize<List<DateTime>>(response.Body, new IsoDateTimeConverter());
        }

        /// <summary>
        /// Get Boolean EndPoint.
        /// </summary>
        /// <returns>Returns the bool? response from the API call.</returns>
        public bool? GetBoolean()
        {
            Task<bool?> t = this.GetBooleanAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Boolean EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the bool? response from the API call.</returns>
        public async Task<bool?> GetBooleanAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/boolean");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>();

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

            return bool.Parse(response.Body);
        }

        /// <summary>
        /// Get Boolean Array EndPoint.
        /// </summary>
        /// <returns>Returns the List of bool response from the API call.</returns>
        public List<bool> GetBooleanArray()
        {
            Task<List<bool>> t = this.GetBooleanArrayAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Boolean Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of bool response from the API call.</returns>
        public async Task<List<bool>> GetBooleanArrayAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/boolean");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
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

            return ApiHelper.JsonDeserialize<List<bool>>(response.Body);
        }

        /// <summary>
        /// Get Headers EndPoint.
        /// </summary>
        public void GetHeaders()
        {
            Task t = this.GetHeadersAsync();
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Get Headers EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task GetHeadersAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/headers");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>();

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

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// Get 1123DateTime EndPoint.
        /// </summary>
        /// <returns>Returns the DateTime? response from the API call.</returns>
        public DateTime? Get1123DateTime()
        {
            Task<DateTime?> t = this.Get1123DateTimeAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get 1123DateTime EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the DateTime? response from the API call.</returns>
        public async Task<DateTime?> Get1123DateTimeAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/1123datetime");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>();

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

            return DateTime.ParseExact(response.Body, "r", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
        }

        /// <summary>
        /// Get UnixDateTime EndPoint.
        /// </summary>
        /// <returns>Returns the DateTime? response from the API call.</returns>
        public DateTime? GetUnixDateTime()
        {
            Task<DateTime?> t = this.GetUnixDateTimeAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get UnixDateTime EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the DateTime? response from the API call.</returns>
        public async Task<DateTime?> GetUnixDateTimeAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/unixdatetime");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>();

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

            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(double.Parse(response.Body));
        }

        /// <summary>
        /// Get 1123DateTime Array EndPoint.
        /// </summary>
        /// <returns>Returns the List of DateTime response from the API call.</returns>
        public List<DateTime> Get1123DateTimeArray()
        {
            Task<List<DateTime>> t = this.Get1123DateTimeArrayAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get 1123DateTime Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of DateTime response from the API call.</returns>
        public async Task<List<DateTime>> Get1123DateTimeArrayAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/1123datetime");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
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

            return ApiHelper.JsonDeserialize<List<DateTime>>(response.Body, new CustomDateTimeConverter("r"));
        }

        /// <summary>
        /// Get UnixDateTime Array EndPoint.
        /// </summary>
        /// <returns>Returns the List of DateTime response from the API call.</returns>
        public List<DateTime> GetUnixDateTimeArray()
        {
            Task<List<DateTime>> t = this.GetUnixDateTimeArrayAsync();
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get UnixDateTime Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of DateTime response from the API call.</returns>
        public async Task<List<DateTime>> GetUnixDateTimeArrayAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/unixdatetime");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "array", "true" },
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

            return ApiHelper.JsonDeserialize<List<DateTime>>(response.Body, new Tester.Standard.Utilities.UnixDateTimeConverter());
        }

        /// <summary>
        /// get content type headers EndPoint.
        /// </summary>
        public void GetContentTypeHeaders()
        {
            Task t = this.GetContentTypeHeadersAsync();
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// get content type headers EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task GetContentTypeHeadersAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/response/getContentType");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>();

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

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }
    }
}