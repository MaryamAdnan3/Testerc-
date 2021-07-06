// <copyright file="BaseController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Tester.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Tester.Standard;
    using Tester.Standard.Authentication;
    using Tester.Standard.Exceptions;
    using Tester.Standard.Http.Client;
    using Tester.Standard.Http.Response;
    using Tester.Standard.Utilities;

    /// <summary>
    /// The base class for all controller classes.
    /// </summary>
    internal class BaseController
    {
        /// <summary>
        /// HttpClient instance.
        /// </summary>
        private readonly IHttpClient httpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseController"/> class.
        /// </summary>
        /// <param name="config">Configuration for the API.</param>
        /// <param name="httpCallBack">HTTP callback to catch before/after HTTP request/response events.</param>
        /// <param name="httpClient">HttpClient for the API.</param>
        /// <param name="authManagers">AuthManagers for the API.</param>
        internal BaseController(
            IConfiguration config,
            IHttpClient httpClient,
            IDictionary<string, IAuthManager> authManagers,
            HttpCallBack httpCallBack = null)
        {
            this.Config = config;
            this.httpClient = httpClient;
            this.AuthManagers = authManagers;
            this.HttpCallBack = httpCallBack;
        }

        /// <summary>
        /// Gets AuthManager instance.
        /// </summary>
        internal IDictionary<string, IAuthManager> AuthManagers { get; }

        /// <summary>
        /// Gets HttpCallBack instance.
        /// </summary>
        internal HttpCallBack HttpCallBack { get; }

        /// <summary>
        /// Gets array deserialization format.
        /// </summary>
        protected ArrayDeserialization ArrayDeserializationFormat => ArrayDeserialization.Indexed;

        /// <summary>
        /// Gets configuration instance.
        /// </summary>
        protected IConfiguration Config { get; }

        /// <summary>
        ///  Gets User-Agent header value.
        /// </summary>
        protected string UserAgent => "APIMATIC 3.0";

        /// <summary>
        /// Create JSON-encoded multipart content from input.
        /// </summary>
        /// <param name="input"> input object. </param>
        /// <param name="headers"> Headers dictionary. </param>
        /// <returns> MultipartContent. </returns>
        internal static MultipartContent CreateJsonEncodedMultipartContent(object input, Dictionary<string, IReadOnlyCollection<string>> headers)
        {
            return new MultipartByteArrayContent(Encoding.ASCII.GetBytes(ApiHelper.JsonSerialize(input)), headers);
        }

        /// <summary>
        /// Create binary multipart content from file.
        /// </summary>
        /// <param name="input"> FileStreamInfo object. </param>
        /// <param name="headers"> Headers dictionary. </param>
        /// <returns> MultipartContent. </returns>
        internal static MultipartContent CreateFileMultipartContent(FileStreamInfo input, Dictionary<string, IReadOnlyCollection<string>> headers = null)
        {
            if (headers == null)
            {
                return new MultipartFileContent(input);
            }
            else
            {
                return new MultipartFileContent(input, headers);
            }
        }

        /// <summary>
        /// Get default HTTP client instance.
        /// </summary>
        /// <returns> IHttpClient. </returns>
        internal IHttpClient GetClientInstance()
        {
            return this.httpClient;
        }

        /// <summary>
        /// Validates the response against HTTP errors defined at the API level.
        /// </summary>
        /// <param name="response">The response recieved.</param>
        /// <param name="context">Context of the request and the recieved response.</param>
        protected void ValidateResponse(HttpResponse response, HttpContext context)
        {
            if (response.StatusCode == 400)
            {
                throw new ApiException("400 Global", context);
            }

            if (response.StatusCode == 402)
            {
                throw new ApiException("402 Global", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ApiException("403 Global", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiException("404 Global", context);
            }

            if (response.StatusCode == 412)
            {
                throw new NestedModelException("Precondition Failed", context);
            }

            if (response.StatusCode == 450)
            {
                throw new CustomErrorResponseException("caught global exception", context);
            }

            if (response.StatusCode == 452)
            {
                throw new ExceptionWithStringException("global exception with string", context);
            }

            if (response.StatusCode == 453)
            {
                throw new ExceptionWithBooleanException("boolean in global exception", context);
            }

            if (response.StatusCode == 454)
            {
                throw new ExceptionWithDynamicException("dynamic in global exception", context);
            }

            if (response.StatusCode == 455)
            {
                throw new ExceptionWithUUIDException("uuid in global exception", context);
            }

            if (response.StatusCode == 456)
            {
                throw new ExceptionWithDateException("date in global exception", context);
            }

            if (response.StatusCode == 457)
            {
                throw new ExceptionWithNumberException("number in global  exception", context);
            }

            if (response.StatusCode == 458)
            {
                throw new ExceptionWithLongException("long in global exception", context);
            }

            if (response.StatusCode == 459)
            {
                throw new ExceptionWithPrecisionException("precision in global  exception", context);
            }

            if (response.StatusCode == 460)
            {
                throw new ExceptionWithRfc3339DateTimeException("rfc3339 in global exception", context);
            }

            if (response.StatusCode == 461)
            {
                throw new UnixTimeStampException("unix time stamp in global exception", context);
            }

            if (response.StatusCode == 462)
            {
                throw new Rfc1123Exception("rfc1123 in global exception", context);
            }

            if (response.StatusCode == 463)
            {
                throw new SendBooleanInModelAsException("boolean in model as global exception", context);
            }

            if (response.StatusCode == 464)
            {
                throw new SendRfc3339InModelAsException("rfc3339 in model as global exception", context);
            }

            if (response.StatusCode == 465)
            {
                throw new SendRfc1123InModelAsException("rfc1123 in model as global exception", context);
            }

            if (response.StatusCode == 466)
            {
                throw new SendUnixTimeStampInModelAsException("unix time stamp in model as global exception", context);
            }

            if (response.StatusCode == 467)
            {
                throw new SendDateInModelAsException("send date in model as global exception", context);
            }

            if (response.StatusCode == 468)
            {
                throw new SendDynamicInModelAsException("send dynamic in model as global exception", context);
            }

            if (response.StatusCode == 469)
            {
                throw new SendStringInModelAsException("send string in model as global exception", context);
            }

            if (response.StatusCode == 470)
            {
                throw new SendLongInModelAsException("send long in model as global exception", context);
            }

            if (response.StatusCode == 471)
            {
                throw new SendNumberInModelAsException("send number in model as global exception", context);
            }

            if (response.StatusCode == 472)
            {
                throw new SendPrecisionInModelAsException("send precision in model as global exception", context);
            }

            if (response.StatusCode == 473)
            {
                throw new SendUuidInModelAsException("send uuid in model as global exception", context);
            }

            if (response.StatusCode == 500)
            {
                throw new GlobalTestException("500 Global", context);
            }

            // [200, 208] = HTTP OK
            if ((response.StatusCode < 200) || (response.StatusCode > 208))
            {
                throw new GlobalTestException(@"Invalid response.", context);
            }
        }
    }
}