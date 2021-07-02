// <copyright file="HeaderControllerTest.cs" company="APIMatic">
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
    /// HeaderControllerTest.
    /// </summary>
    [TestFixture]
    public class HeaderControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IHeaderController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.HeaderController;
        }

        /// <summary>
        /// TestSendHeaders.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendHeaders()
        {
            // Parameters for the API call
            string customHeader = "TestString";
            string mValue = "TestString";

            // Perform API call
            Standard.Models.ServerResponse result = null;
            try
            {
                result = await this.controller.SendHeadersAsync(customHeader, mValue);
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