// <copyright file="TemplateParamsControllerTest.cs" company="APIMatic">
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
    /// TemplateParamsControllerTest.
    /// </summary>
    [TestFixture]
    public class TemplateParamsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ITemplateParamsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.TemplateParamsController;
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
            Standard.Models.EchoResponse result = null;
            try
            {
                result = await this.controller.SendStringArrayAsync(strings);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
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
            Standard.Models.EchoResponse result = null;
            try
            {
                result = await this.controller.SendIntegerArrayAsync(integers);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }
    }
}