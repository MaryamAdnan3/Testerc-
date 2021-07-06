// <copyright file="FormParamsControllerTest.cs" company="APIMatic">
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
    /// FormParamsControllerTest.
    /// </summary>
    [TestFixture]
    public class FormParamsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IFormParamsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.FormParamsController;
        }

        /// <summary>
        /// TestDeleteFormTest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDeleteFormTest()
        {
            // Parameters for the API call
            Standard.Models.DeleteBody body = ApiHelper.JsonDeserialize<Standard.Models.DeleteBody>("{\"name\":\"farhan\",\"field\":\"QA\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendDeleteFormAsync(body);
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
        /// TestDeleteFormTestWithMultilinerName.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDeleteFormTestWithMultilinerName()
        {
            // Parameters for the API call
            Standard.Models.DeleteBody body = ApiHelper.JsonDeserialize<Standard.Models.DeleteBody>("{\"name\":\"farhan\\nnouman\",\"field\":\"QA\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendDeleteFormAsync(body);
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
        /// TestDeleteFormTestWithSpecialCharactersField.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDeleteFormTestWithSpecialCharactersField()
        {
            // Parameters for the API call
            Standard.Models.DeleteBody body = ApiHelper.JsonDeserialize<Standard.Models.DeleteBody>("{\"name\":\"farhan\",\"field\":\"&&&\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendDeleteFormAsync(body);
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
        /// TestDeleteFormTestWithBlankField.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDeleteFormTestWithBlankField()
        {
            // Parameters for the API call
            Standard.Models.DeleteBody body = ApiHelper.JsonDeserialize<Standard.Models.DeleteBody>("{\"name\":\"farhan\",\"field\":\" \"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendDeleteFormAsync(body);
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
        /// TestDeleteFormTestWithBlankNameField.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDeleteFormTestWithBlankNameField()
        {
            // Parameters for the API call
            Standard.Models.DeleteBody body = ApiHelper.JsonDeserialize<Standard.Models.DeleteBody>("{\"name\":\" \",\"field\":\" \"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendDeleteFormAsync(body);
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
        /// TestDeleteFormTestWithBlankName.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDeleteFormTestWithBlankName()
        {
            // Parameters for the API call
            Standard.Models.DeleteBody body = ApiHelper.JsonDeserialize<Standard.Models.DeleteBody>("{\"name\":\" \",\"field\":\"QA\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendDeleteFormAsync(body);
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
        /// TestSendDateArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendDateArray()
        {
            // Parameters for the API call
            List<DateTime> dates = ApiHelper.JsonDeserialize<List<DateTime>>("[\"1994-02-13\",\"1994-02-13\"]", new CustomDateTimeConverter("yyyy'-'MM'-'dd"));

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendDateArrayAsync(dates);
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
        /// TestSendDate.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendDate()
        {
            // Parameters for the API call
            DateTime date = DateTime.ParseExact("1994-02-13", "yyyy'-'MM'-'dd", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendDateAsync(date);
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
        /// TestSendUnixDateTime.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendUnixDateTime()
        {
            // Parameters for the API call
            DateTime datetime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(double.Parse("1484719381"));

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendUnixDateTimeAsync(datetime);
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
        /// TestSendRfc1123DateTime.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendRfc1123DateTime()
        {
            // Parameters for the API call
            DateTime datetime = DateTime.ParseExact("Sun, 06 Nov 1994 08:49:37 GMT", "r", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendRfc1123DateTimeAsync(datetime);
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
        /// TestSendRfc3339DateTime.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendRfc3339DateTime()
        {
            // Parameters for the API call
            DateTime datetime = DateTime.ParseExact("1994-02-13T14:01:54.9571247Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendRfc3339DateTimeAsync(datetime);
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
        /// TestSendUnixDateTimeArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendUnixDateTimeArray()
        {
            // Parameters for the API call
            List<DateTime> datetimes = ApiHelper.JsonDeserialize<List<DateTime>>("[1484719381,1484719381]", new Tester.Standard.Utilities.UnixDateTimeConverter());

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendUnixDateTimeArrayAsync(datetimes);
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
        /// TestSendRfc1123DateTimeArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendRfc1123DateTimeArray()
        {
            // Parameters for the API call
            List<DateTime> datetimes = ApiHelper.JsonDeserialize<List<DateTime>>("[\"Sun, 06 Nov 1994 08:49:37 GMT\",\"Sun, 06 Nov 1994 08:49:37 GMT\"]", new CustomDateTimeConverter("r"));

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendRfc1123DateTimeArrayAsync(datetimes);
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
        /// TestSendLong.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendLong()
        {
            // Parameters for the API call
            long mValue = 5147483647;

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendLongAsync(mValue);
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
        /// TestSendIntegerArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendIntegerArray()
        {
            // Parameters for the API call
            List<int> integers = ApiHelper.JsonDeserialize<List<int>>("[1,2,3,4,5]");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendIntegerArrayAsync(integers);
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
        /// TestSendStringArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendStringArray()
        {
            // Parameters for the API call
            List<string> strings = ApiHelper.JsonDeserialize<List<string>>("[\"abc\", \"def\"]");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendStringArrayAsync(strings);
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
        /// TestAllowDynamicFormFields.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestAllowDynamicFormFields()
        {
            // Parameters for the API call
            string name = "farhan";

            // key-value map for optional form parameters
            var formParams = new Dictionary<string, object>();
            formParams.Add("field", "QA");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.AllowDynamicFormFieldsAsync(name, formParams);
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
        /// TestSendModel.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendModel()
        {
            // Parameters for the API call
            Standard.Models.Employee model = ApiHelper.JsonDeserialize<Standard.Models.Employee>("{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"personType\":\"Boss\",\"name\":\"Zeeshan Ejaz\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\",\"promotedAt\":1484719381},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendModelAsync(model);
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
        /// TestSendModelArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendModelArray()
        {
            // Parameters for the API call
            List<Standard.Models.Employee> models = ApiHelper.JsonDeserialize<List<Standard.Models.Employee>>("[{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"personType\":\"Boss\",\"name\":\"Zeeshan Ejaz\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\",\"promotedAt\":1484719381},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\"},{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"personType\":\"Boss\",\"name\":\"Zeeshan Ejaz\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\",\"promotedAt\":1484719381},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\"}]");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendModelArrayAsync(models);
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
        /// TestSendFile.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendFile()
        {
            // Parameters for the API call
            FileStreamInfo file = TestHelper.GetFile("http://localhost:3000/response/image");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendFileAsync(file);
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
        /// TestSendMultipleFiles.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendMultipleFiles()
        {
            // Parameters for the API call
            FileStreamInfo file = TestHelper.GetFile("http://localhost:3000/response/image");
            FileStreamInfo file1 = TestHelper.GetFile("http://localhost:3000/response/image");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendMultipleFilesAsync(file, file1);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSendString.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendString()
        {
            // Parameters for the API call
            string mValue = "TestString";

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendStringAsync(mValue);
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
        /// TestSendMultilinerString.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendMultilinerString()
        {
            // Parameters for the API call
            string mValue = "TestString\nnouman";

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendStringAsync(mValue);
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
        /// TestSendStringWithSpecialCharacters.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendStringWithSpecialCharacters()
        {
            // Parameters for the API call
            string mValue = "$%^!@#$%^&*";

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendStringAsync(mValue);
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
        /// TestSendStringWithOnlySpace.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendStringWithOnlySpace()
        {
            // Parameters for the API call
            string mValue = " ";

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendStringAsync(mValue);
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
        /// TestSendEmptyString.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendEmptyString()
        {
            // Parameters for the API call
            string mValue = string.Empty;

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendStringAsync(mValue);
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
        /// TestSendRfc3339DateTimeArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendRfc3339DateTimeArray()
        {
            // Parameters for the API call
            List<DateTime> datetimes = ApiHelper.JsonDeserialize<List<DateTime>>("[\"1994-02-13T14:01:54.9571247Z\",\"1994-02-13T14:01:54.9571247Z\"]", new IsoDateTimeConverter());

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendRfc3339DateTimeArrayAsync(datetimes);
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
        /// TestSendMixedArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendMixedArray()
        {
            // Parameters for the API call
            var file = TestHelper.GetFile("http://localhost:3000/response/image");
            var integers = ApiHelper.JsonDeserialize<List<int>>("[1,2,3,4,5]");
            var models = ApiHelper.JsonDeserialize<List<Standard.Models.Employee>>("[{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"personType\":\"Boss\",\"name\":\"Zeeshan Ejaz\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\",\"promotedAt\":1484719381},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\"},{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"personType\":\"Boss\",\"name\":\"Zeeshan Ejaz\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\",\"promotedAt\":1484719381},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\"}]");
            var strings = ApiHelper.JsonDeserialize<List<string>>("[\"abc\", \"def\"]");
            Standard.Models.SendMixedArrayInput input = new Standard.Models.SendMixedArrayInput(file, integers, models, strings);

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendMixedArrayAsync(input);
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
        /// TestUpdateModelWithForm.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUpdateModelWithForm()
        {
            // Parameters for the API call
            Standard.Models.Employee model = ApiHelper.JsonDeserialize<Standard.Models.Employee>("{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"personType\":\"Boss\",\"name\":\"Zeeshan Ejaz\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\",\"promotedAt\":1484719381},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.UpdateModelWithFormAsync(model);
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
        /// TestDeleteFormTestWithModel.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDeleteFormTestWithModel()
        {
            // Parameters for the API call
            Standard.Models.Employee model = ApiHelper.JsonDeserialize<Standard.Models.Employee>("{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"personType\":\"Boss\",\"name\":\"Zeeshan Ejaz\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\",\"promotedAt\":1484719381},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendDeleteForm1Async(model);
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
        /// TestSendDeleteFormWithModelArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendDeleteFormWithModelArray()
        {
            // Parameters for the API call
            List<Standard.Models.Employee> models = ApiHelper.JsonDeserialize<List<Standard.Models.Employee>>("[{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"personType\":\"Boss\",\"name\":\"Zeeshan Ejaz\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\",\"promotedAt\":1484719381},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\"}, {\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"personType\":\"Boss\",\"name\":\"Zeeshan Ejaz\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\",\"promotedAt\":1484719381},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\"}]");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendDeleteFormWithModelArrayAsync(models);
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
        /// TestUpdateModelArrayWithForm.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUpdateModelArrayWithForm()
        {
            // Parameters for the API call
            List<Standard.Models.Employee> models = ApiHelper.JsonDeserialize<List<Standard.Models.Employee>>("[{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"personType\":\"Boss\",\"name\":\"Zeeshan Ejaz\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\",\"promotedAt\":1484719381},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\"}, {\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"personType\":\"Boss\",\"name\":\"Zeeshan Ejaz\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\",\"promotedAt\":1484719381},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\"}]");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.UpdateModelArrayWithFormAsync(models);
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
        /// TestUpdateStringWithForm.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUpdateStringWithForm()
        {
            // Parameters for the API call
            string mValue = "TestString";

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.UpdateStringWithFormAsync(mValue);
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
        /// TestUpdateSpecialStringWithForm.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUpdateSpecialStringWithForm()
        {
            // Parameters for the API call
            string mValue = "$%^!@#$%^&*";

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.UpdateStringWithFormAsync(mValue);
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
        /// TestUpdateMultilinerStringWithForm.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUpdateMultilinerStringWithForm()
        {
            // Parameters for the API call
            string mValue = "TestString\nnouman";

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.UpdateStringWithFormAsync(mValue);
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
        /// TestUpdateStringWithFormCornerCase.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUpdateStringWithFormCornerCase()
        {
            // Parameters for the API call
            string mValue = " ";

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.UpdateStringWithFormAsync(mValue);
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
        /// TestUpdateEmptyStringWithForm.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUpdateEmptyStringWithForm()
        {
            // Parameters for the API call
            string mValue = string.Empty;

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.UpdateStringWithFormAsync(mValue);
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
        /// TestUpdateStringArrayWithForm.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUpdateStringArrayWithForm()
        {
            // Parameters for the API call
            List<string> strings = ApiHelper.JsonDeserialize<List<string>>("[\"abc\", \"def\"]");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.UpdateStringArrayWithFormAsync(strings);
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
        /// TestSendIntegerEnumArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendIntegerEnumArray()
        {
            // Parameters for the API call
            List<Standard.Models.SuiteCode> suites = ApiHelper.JsonDeserialize<List<Standard.Models.SuiteCode>>("[1, 3, 4, 2, 3]");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendIntegerEnumArrayAsync(suites);
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
        /// TestSendStringEnumArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendStringEnumArray()
        {
            // Parameters for the API call
            List<Standard.Models.Days> days = ApiHelper.JsonDeserialize<List<Standard.Models.Days>>("[\"Tuesday\", \"Saturday\", \"Wednesday\", \"Monday\", \"Sunday\"]");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendStringEnumArrayAsync(days);
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
        /// TestSendStringInFormWithNewLine1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendStringInFormWithNewLine1()
        {
            // Parameters for the API call
            Standard.Models.TestNstringEncoding body = ApiHelper.JsonDeserialize<Standard.Models.TestNstringEncoding>("{\"name\":\"farhan\", \"field\":\"QA\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendStringInFormWithNewLineAsync(body);
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
        /// TestSendStringInFormWithNewLine2.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendStringInFormWithNewLine2()
        {
            // Parameters for the API call
            Standard.Models.TestNstringEncoding body = ApiHelper.JsonDeserialize<Standard.Models.TestNstringEncoding>("{\"name\":\"farhan\", \"field\":\"QA&Dev\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendStringInFormWithNewLineAsync(body);
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
        /// TestSendStringInFormWithNewLine3.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendStringInFormWithNewLine3()
        {
            // Parameters for the API call
            Standard.Models.TestNstringEncoding body = ApiHelper.JsonDeserialize<Standard.Models.TestNstringEncoding>("{\"name\":\"farhan&nouman\", \"field\":\"QA\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendStringInFormWithNewLineAsync(body);
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
        /// TestSendStringInFormWithR1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendStringInFormWithR1()
        {
            // Parameters for the API call
            Standard.Models.TestRstringEncoding body = ApiHelper.JsonDeserialize<Standard.Models.TestRstringEncoding>("{\"name\":\"farhan\",\"field\":\"QA\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendStringInFormWithRAsync(body);
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
        /// TestSendStringInFormWithR2.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendStringInFormWithR2()
        {
            // Parameters for the API call
            Standard.Models.TestRstringEncoding body = ApiHelper.JsonDeserialize<Standard.Models.TestRstringEncoding>("{\"name\":\"farhan\",\"field\":\"QA&Dev\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendStringInFormWithRAsync(body);
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
        /// TestSendStringInFormWithR3.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendStringInFormWithR3()
        {
            // Parameters for the API call
            Standard.Models.TestRstringEncoding body = ApiHelper.JsonDeserialize<Standard.Models.TestRstringEncoding>("{\"name\":\"farhan&nouman\",\"field\":\"QA\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendStringInFormWithRAsync(body);
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
        /// TestSendStringInFormWithRN1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendStringInFormWithRN1()
        {
            // Parameters for the API call
            Standard.Models.TestRNstringEncoding body = ApiHelper.JsonDeserialize<Standard.Models.TestRNstringEncoding>("{\"name\":\"farhan\",\"field\":\"QA\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendStringInFormWithRNAsync(body);
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
        /// TestSendStringInFormWithRN2.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendStringInFormWithRN2()
        {
            // Parameters for the API call
            Standard.Models.TestRNstringEncoding body = ApiHelper.JsonDeserialize<Standard.Models.TestRNstringEncoding>("{\"name\":\"farhan\",\"field\":\"QA&Dev\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendStringInFormWithRNAsync(body);
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
        /// TestSendStringInFormWithRN3.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendStringInFormWithRN3()
        {
            // Parameters for the API call
            Standard.Models.TestRNstringEncoding body = ApiHelper.JsonDeserialize<Standard.Models.TestRNstringEncoding>("{\"name\":\"farhan&nouman\",\"field\":\"QA\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendStringInFormWithRNAsync(body);
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
        /// TestSendOptionalUnixTimeStampInBody.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendOptionalUnixTimeStampInBody()
        {
            // Parameters for the API call
            DateTime? dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(double.Parse("1484719381"));

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendOptionalUnixDateTimeInBodyAsync(dateTime);
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
                    "{\"passed\" : true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestSendOptionalRfc1123InBody.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendOptionalRfc1123InBody()
        {
            // Parameters for the API call
            DateTime body = DateTime.ParseExact("Sun, 06 Nov 1994 08:49:37 GMT", "r", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendOptionalRfc1123InBodyAsync(body);
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
        /// TestTestSendingDatetimeAsOptionalInPlainTextBody.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestSendingDatetimeAsOptionalInPlainTextBody()
        {
            // Parameters for the API call
            DateTime? body = DateTime.ParseExact("1994-02-13T14:01:54.9571247Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendDatetimeOptionalInEndpointAsync(body);
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
        /// TestSendOptionalUnixTimeStampInModelBody.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendOptionalUnixTimeStampInModelBody()
        {
            // Parameters for the API call
            Standard.Models.UnixDateTime dateTime = ApiHelper.JsonDeserialize<Standard.Models.UnixDateTime>("{\"dateTime\" : 1484719381}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendOptionalUnixTimeStampInModelBodyAsync(dateTime);
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
                    "{\"passed\" : true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestSendOptionalUnixTimeStampInNestedModelBody.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendOptionalUnixTimeStampInNestedModelBody()
        {
            // Parameters for the API call
            Standard.Models.SendUnixDateTime dateTime = ApiHelper.JsonDeserialize<Standard.Models.SendUnixDateTime>("{\"dateTime\" : {\"dateTime\":1484719381}}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendOptionalUnixTimeStampInNestedModelBodyAsync(dateTime);
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
                    "{\"passed\" : true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestTestSendingRfc1123DateTimeInNestedMode.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestSendingRfc1123DateTimeInNestedMode()
        {
            // Parameters for the API call
            Standard.Models.SendRfc1123DateTime body = ApiHelper.JsonDeserialize<Standard.Models.SendRfc1123DateTime>("{\"dateTime\" : {\"dateTime\":\"Sun, 06 Nov 1994 08:49:37 GMT\"}}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendRfc1123DateTimeInNestedModelAsync(body);
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
                    "{\"passed\" : true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestSendOptionalRfc1123DateTimeInModelBody.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendOptionalRfc1123DateTimeInModelBody()
        {
            // Parameters for the API call
            Standard.Models.ModelWithOptionalRfc1123DateTime dateTime = ApiHelper.JsonDeserialize<Standard.Models.ModelWithOptionalRfc1123DateTime>("{\"dateTime\" : \"Sun, 06 Nov 1994 08:49:37 GMT\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendRfc1123DateTimeInModelAsync(dateTime);
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
        /// TestSendOptionalDatetimeInModelAsBody.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendOptionalDatetimeInModelAsBody()
        {
            // Parameters for the API call
            Standard.Models.ModelWithOptionalRfc3339DateTime body = ApiHelper.JsonDeserialize<Standard.Models.ModelWithOptionalRfc3339DateTime>("{\"dateTime\" : \"1994-02-13T14:01:54.9571247Z\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendOptionalDatetimeInModelAsync(body);
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
                    "{\"passed\" : true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestSendRfc3339DateTimeInNestedModel.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendRfc3339DateTimeInNestedModel()
        {
            // Parameters for the API call
            Standard.Models.SendRfc339DateTime body = ApiHelper.JsonDeserialize<Standard.Models.SendRfc339DateTime>("{\"dateTime\" : {\"dateTime\" : \"1994-02-13T14:01:54.9571247Z\"}}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendRfc339DateTimeInNestedModelsAsync(body);
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
        /// TestUuidAsOptional.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUuidAsOptional()
        {
            // Parameters for the API call
            Standard.Models.UuidAsOptional body = ApiHelper.JsonDeserialize<Standard.Models.UuidAsOptional>("{   \"uuid\" : \"123e4567-e89b-12d3-a456-426655440000\" }");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.UuidAsOptionalAsync(body);
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
                    "{\"passed\" : true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestBooleanAsOptional.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestBooleanAsOptional()
        {
            // Parameters for the API call
            Standard.Models.BooleanAsOptional body = ApiHelper.JsonDeserialize<Standard.Models.BooleanAsOptional>("{\"boolean\" : true}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.BooleanAsOptionalAsync(body);
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
                    "{\"passed\" : true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestDateAsOptional.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDateAsOptional()
        {
            // Parameters for the API call
            Standard.Models.DateAsOptional body = ApiHelper.JsonDeserialize<Standard.Models.DateAsOptional>("{ \"date\" : \"1994-02-13\" }");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.DateAsOptionalAsync(body);
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
                    "{\"passed\" : true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestDynamicAsOptional.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDynamicAsOptional()
        {
            // Parameters for the API call
            Standard.Models.DynamicAsOptional body = ApiHelper.JsonDeserialize<Standard.Models.DynamicAsOptional>("{   \"dynamic\" : {     \"dynamic\" : \"test\"   } }");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.DynamicAsOptionalAsync(body);
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
                    "{\"passed\" : true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestStringAsOptional.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestStringAsOptional()
        {
            // Parameters for the API call
            Standard.Models.StringAsOptional body = ApiHelper.JsonDeserialize<Standard.Models.StringAsOptional>("{\"string\" : \"test\"}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.StringAsOptionalAsync(body);
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
                    "{\"passed\" : true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestPrecisionAsOptional.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestPrecisionAsOptional()
        {
            // Parameters for the API call
            Standard.Models.PrecisionAsOptional body = ApiHelper.JsonDeserialize<Standard.Models.PrecisionAsOptional>("{\"precision\" : 1.23}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.PrecisionAsOptionalAsync(body);
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
                    "{\"passed\" : true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestLongAsOptional.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestLongAsOptional()
        {
            // Parameters for the API call
            Standard.Models.LongAsOptional body = ApiHelper.JsonDeserialize<Standard.Models.LongAsOptional>("{\"long\" : 123123}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.LongAsOptionalAsync(body);
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
                    "{\"passed\" : true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestNumberAsOptional.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestNumberAsOptional()
        {
            // Parameters for the API call
            Standard.Models.NumberAsOptional body = ApiHelper.JsonDeserialize<Standard.Models.NumberAsOptional>("{\"number\" : 1}");

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendNumberAsOptionalAsync(body);
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
                    "{\"passed\" : true}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}