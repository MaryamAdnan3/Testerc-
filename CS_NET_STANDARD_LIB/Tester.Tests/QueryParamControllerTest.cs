// <copyright file="QueryParamControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Tester.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;
    using Tester.Standard;
    using Tester.Standard.Controllers;
    using Tester.Standard.Exceptions;
    using Tester.Standard.Http.Client;
    using Tester.Standard.Http.Response;
    using Tester.Standard.Utilities;
    using Tester.Tests.Helpers;

    /// <summary>
    /// QueryParamControllerTest.
    /// </summary>
    [TestFixture]
    public class QueryParamControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IQueryParamController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.QueryParamController;
        }

        /// <summary>
        /// TestDateArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDateArray()
        {
            // Parameters for the API call
            List<DateTime> dates = ApiHelper.JsonDeserialize<List<DateTime>>("[\"1994-02-13\",\"1994-02-13\"]", new CustomDateTimeConverter("yyyy'-'MM'-'dd"));

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.DateArrayAsync(dates);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestOptionalDynamicQueryParam.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestOptionalDynamicQueryParam()
        {
            // Parameters for the API call
            string name = "farhan";

            // key-value map for optional query parameters
            Dictionary<string, object> queryParams = new Dictionary<string, object>();
            queryParams.Add("field", "QA");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.OptionalDynamicQueryParamAsync(name, queryParams);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestDate.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDate()
        {
            // Parameters for the API call
            DateTime date = DateTime.ParseExact("1994-02-13", "yyyy'-'MM'-'dd", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.DateAsync(date);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestUnixDateTimeArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUnixDateTimeArray()
        {
            // Parameters for the API call
            List<DateTime> datetimes = ApiHelper.JsonDeserialize<List<DateTime>>("[1484719381,1484719381]", new Tester.Standard.Utilities.UnixDateTimeConverter());

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.UnixDateTimeArrayAsync(datetimes);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestUnixDateTime.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUnixDateTime()
        {
            // Parameters for the API call
            DateTime datetime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(double.Parse("1484719381"));

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.UnixDateTimeAsync(datetime);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestRfc1123DateTime.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestRfc1123DateTime()
        {
            // Parameters for the API call
            DateTime datetime = DateTime.ParseExact("Sun, 06 Nov 1994 08:49:37 GMT", "r", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.Rfc1123DateTimeAsync(datetime);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestRfc1123DateTimeArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestRfc1123DateTimeArray()
        {
            // Parameters for the API call
            List<DateTime> datetimes = ApiHelper.JsonDeserialize<List<DateTime>>("[\"Sun, 06 Nov 1994 08:49:37 GMT\",\"Sun, 06 Nov 1994 08:49:37 GMT\"]", new CustomDateTimeConverter("r"));

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.Rfc1123DateTimeArrayAsync(datetimes);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestRfc3339DateTimeArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestRfc3339DateTimeArray()
        {
            // Parameters for the API call
            List<DateTime> datetimes = ApiHelper.JsonDeserialize<List<DateTime>>("[\"1994-02-13T14:01:54.9571247Z\",\"1994-02-13T14:01:54.9571247Z\"]", new IsoDateTimeConverter());

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.Rfc3339DateTimeArrayAsync(datetimes);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestRfc3339DateTime.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestRfc3339DateTime()
        {
            // Parameters for the API call
            DateTime datetime = DateTime.ParseExact("1994-02-13T14:01:54.9571247Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.Rfc3339DateTimeAsync(datetime);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestNoParams.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestNoParams()
        {
            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.NoParamsAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestStringParam.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestStringParam()
        {
            // Parameters for the API call
            string mString = "l;asd;asdwe[2304&&;'.d??\\a\\\\\\;sd//";

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.StringParamAsync(mString);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestUrlParam.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUrlParam()
        {
            // Parameters for the API call
            string url = "https://www.shahidisawesome.com/and/also/a/narcissist?thisis=aparameter&another=one";

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.UrlParamAsync(url);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestNumberArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestNumberArray()
        {
            // Parameters for the API call
            List<int> integers = ApiHelper.JsonDeserialize<List<int>>("[1,2,3,4,5]");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.NumberArrayAsync(integers);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.IsTrue(
                    (this.HttpCallBackHandler.Response.StatusCode >= 200)
                    && (this.HttpCallBackHandler.Response.StatusCode <= 208),
                    "Status should be between 200 and 208");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestStringArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestStringArray()
        {
            // Parameters for the API call
            List<string> strings = ApiHelper.JsonDeserialize<List<string>>("[\"abc\", \"def\"]");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.StringArrayAsync(strings);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestSimpleQuery.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSimpleQuery()
        {
            // Parameters for the API call
            bool boolean = true;
            int number = 4;
            string mString = "TestString";

            // key-value map for optional query parameters
            Dictionary<string, object> queryParams = new Dictionary<string, object>();

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SimpleQueryAsync(boolean, number, mString, queryParams);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestStringEnumArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestStringEnumArray()
        {
            // Parameters for the API call
            List<Standard.Models.Days> days = ApiHelper.JsonDeserialize<List<Standard.Models.Days>>("[\"Tuesday\", \"Saturday\", \"Wednesday\", \"Monday\", \"Sunday\"]");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.StringEnumArrayAsync(days);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestMultipleParams.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestMultipleParams()
        {
            // Parameters for the API call
            int number = 123412312;
            double precision = 1112.34;
            string mString = "\"\"test./;\";12&&3asl\"\";\"qw1&34\"///..//.";
            string url = "http://www.abc.com/test?a=b&c=\"http://lolol.com?param=no&another=lol\"";

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.MultipleParamsAsync(number, precision, mString, url);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestIntegerEnumArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestIntegerEnumArray()
        {
            // Parameters for the API call
            List<Standard.Models.SuiteCode> suites = ApiHelper.JsonDeserialize<List<Standard.Models.SuiteCode>>("[1, 3, 4, 2, 3]");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.IntegerEnumArrayAsync(suites);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"passed\":true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}