// <copyright file="EchoControllerTest.cs" company="APIMatic">
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
    /// EchoControllerTest.
    /// </summary>
    [TestFixture]
    public class EchoControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IEchoController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.EchoController;
        }

        /// <summary>
        /// TestJsonEcho.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestJsonEcho()
        {
            // Parameters for the API call
            object input = ApiHelper.JsonDeserialize<dynamic>("{\"uid\": \"1123213\", \"name\": \"Shahid\"}");

            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.JsonEchoAsync(input);
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
                    "{\"body\": {\"uid\": \"1123213\", \"name\": \"Shahid\"}}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}