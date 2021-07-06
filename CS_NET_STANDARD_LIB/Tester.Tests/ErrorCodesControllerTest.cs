// <copyright file="ErrorCodesControllerTest.cs" company="APIMatic">
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
    /// ErrorCodesControllerTest.
    /// </summary>
    [TestFixture]
    public class ErrorCodesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IErrorCodesController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ErrorCodesController;
        }

        /// <summary>
        /// TestGet412GlobalException.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGet412GlobalException()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.Catch412GlobalErrorAsync();
            }
            catch (NestedModelException)
            {
            }

            // Test response code
            Assert.AreEqual(412, this.HttpCallBackHandler.Response.StatusCode, "Status should be 412");
        }

        /// <summary>
        /// TestGet501.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGet501()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.Get501Async();
            }
            catch (NestedModelException)
            {
            }

            // Test response code
            Assert.AreEqual(501, this.HttpCallBackHandler.Response.StatusCode, "Status should be 501");
        }

        /// <summary>
        /// TestGet400.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGet400()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.Get400Async();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(400, this.HttpCallBackHandler.Response.StatusCode, "Status should be 400");
        }

        /// <summary>
        /// TestGet500.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGet500()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.Get500Async();
            }
            catch (GlobalTestException)
            {
            }

            // Test response code
            Assert.AreEqual(500, this.HttpCallBackHandler.Response.StatusCode, "Status should be 500");
        }

        /// <summary>
        /// TestReceiveUnixTimestampException.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestReceiveUnixTimestampException()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.ReceiveExceptionWithUnixtimestampExceptionAsync();
            }
            catch (UnixTimeStampException)
            {
            }

            // Test response code
            Assert.AreEqual(444, this.HttpCallBackHandler.Response.StatusCode, "Status should be 444");
        }

        /// <summary>
        /// TestReceiveRfc1123Exception.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestReceiveRfc1123Exception()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.ReceiveExceptionWithRfc1123DatetimeAsync();
            }
            catch (Rfc1123Exception)
            {
            }

            // Test response code
            Assert.AreEqual(444, this.HttpCallBackHandler.Response.StatusCode, "Status should be 444");
        }

        /// <summary>
        /// TestTestRfc3339DateTimeException.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRfc3339DateTimeException()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.ReceiveExceptionWithRfc3339DatetimeAsync();
            }
            catch (ExceptionWithRfc3339DateTimeException)
            {
            }

            // Test response code
            Assert.AreEqual(444, this.HttpCallBackHandler.Response.StatusCode, "Status should be 444");
        }

        /// <summary>
        /// TestCheckEndpointLevelException.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestCheckEndpointLevelException()
        {
            // Perform API call
            Standard.Models.Complex5 result = null;
            try
            {
                result = await this.controller.ReceiveEndpointLevelExceptionAsync();
            }
            catch (CustomErrorResponseException)
            {
            }

            // Test response code
            Assert.AreEqual(451, this.HttpCallBackHandler.Response.StatusCode, "Status should be 451");
        }

        /// <summary>
        /// TestCheckGlobalLevelException.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestCheckGlobalLevelException()
        {
            // Perform API call
            Standard.Models.Complex5 result = null;
            try
            {
                result = await this.controller.ReceiveGlobalLevelExceptionAsync();
            }
            catch (CustomErrorResponseException)
            {
            }

            // Test response code
            Assert.AreEqual(450, this.HttpCallBackHandler.Response.StatusCode, "Status should be 450");
        }

        /// <summary>
        /// TestDateInException.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDateInException()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.DateInExceptionAsync();
            }
            catch (ExceptionWithDateException)
            {
            }

            // Test response code
            Assert.AreEqual(444, this.HttpCallBackHandler.Response.StatusCode, "Status should be 444");
        }

        /// <summary>
        /// TestUUIDInException.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUUIDInException()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.UUIDInExceptionAsync();
            }
            catch (ExceptionWithUUIDException)
            {
            }

            // Test response code
            Assert.AreEqual(444, this.HttpCallBackHandler.Response.StatusCode, "Status should be 444");
        }

        /// <summary>
        /// TestDynamicInException.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDynamicInException()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.DynamicInExceptionAsync();
            }
            catch (ExceptionWithDynamicException)
            {
            }

            // Test response code
            Assert.AreEqual(444, this.HttpCallBackHandler.Response.StatusCode, "Status should be 444");
        }

        /// <summary>
        /// TestPrecisionInException.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestPrecisionInException()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.PrecisionInExceptionAsync();
            }
            catch (ExceptionWithPrecisionException)
            {
            }

            // Test response code
            Assert.AreEqual(444, this.HttpCallBackHandler.Response.StatusCode, "Status should be 444");
        }

        /// <summary>
        /// TestBooleanInException.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestBooleanInException()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.BooleanInExceptionAsync();
            }
            catch (ExceptionWithBooleanException)
            {
            }

            // Test response code
            Assert.AreEqual(444, this.HttpCallBackHandler.Response.StatusCode, "Status should be 444");
        }

        /// <summary>
        /// TestLongInException.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestLongInException()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.LongInExceptionAsync();
            }
            catch (ExceptionWithLongException)
            {
            }

            // Test response code
            Assert.AreEqual(444, this.HttpCallBackHandler.Response.StatusCode, "Status should be 444");
        }

        /// <summary>
        /// TestNumberInException.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestNumberInException()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.NumberInExceptionAsync();
            }
            catch (ExceptionWithNumberException)
            {
            }

            // Test response code
            Assert.AreEqual(444, this.HttpCallBackHandler.Response.StatusCode, "Status should be 444");
        }

        /// <summary>
        /// TestExceptionWithString.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestExceptionWithString()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.GetExceptionWithStringAsync();
            }
            catch (ExceptionWithStringException)
            {
            }

            // Test response code
            Assert.AreEqual(444, this.HttpCallBackHandler.Response.StatusCode, "Status should be 444");
        }
    }
}