// <copyright file="ResponseTypesControllerTest.cs" company="APIMatic">
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
    /// ResponseTypesControllerTest.
    /// </summary>
    [TestFixture]
    public class ResponseTypesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private IResponseTypesController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ResponseTypesController;
        }

        /// <summary>
        /// TestGetDateArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetDateArray()
        {
            // Perform API call
            List<DateTime> result = null;
            try
            {
                result = await this.controller.GetDateArrayAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            // Deserialize expected output
            List<DateTime> expected = ApiHelper.JsonDeserialize<List<DateTime>>(
                    "[\"1994-02-13\",\"1994-02-13\"]", new CustomDateTimeConverter("yyyy'-'MM'-'dd"));

            Assert.IsTrue(result.IsSuperSetOf(expected), "Response array should have matching values");
        }

        /// <summary>
        /// TestGetDate.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetDate()
        {
            // Perform API call
            DateTime? result = null;
            try
            {
                result = await this.controller.GetDateAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.AreEqual(DateTime.ParseExact("1994-02-13", "yyyy'-'MM'-'dd", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind), result, "Response should match expected value");
        }

        /// <summary>
        /// TestReturnCompanyModel.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestReturnCompanyModel()
        {
            // Perform API call
            Standard.Models.Company result = null;
            try
            {
                result = await this.controller.ReturnCompanyModelAsync();
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
                    "{\n	\"company name\" : \"APIMatic\",\n	\"address\" : \"nust\",\n	\"cell number\" : \"090078601\"\n}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestReturnBossModel.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestReturnBossModel()
        {
            // Perform API call
            Standard.Models.BossCompany result = null;
            try
            {
                result = await this.controller.ReturnBossModelAsync();
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
                    "{\n	\"company name\" : \"APIMatic\",\n	\"address\" : \"nust\",\n	\"cell number\" : \"090078601\",\n	\"first name\" : \"Adeel\",\n	\"last name\" : \"Ali\",\n	\"address_boss\" : \"nust\"\n}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestReturnEmployeeModel.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestReturnEmployeeModel()
        {
            // Perform API call
            Standard.Models.EmployeeComp result = null;
            try
            {
                result = await this.controller.ReturnEmployeeModelAsync();
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
                    "{\n	\"company name\" : \"APIMatic\",\n	\"address\" : \"nust\",\n	\"cell number\" : \"090078601\",\n	\"first name\" : \"Nauman\",\n	\"last name\" : \"Ali\",\n	\"id\" : \"123456\"\n}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestReturnDeveloperModel.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestReturnDeveloperModel()
        {
            // Perform API call
            Standard.Models.Developer result = null;
            try
            {
                result = await this.controller.ReturnDeveloperModelAsync();
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
                    "{\n	\"company name\" : \"APIMatic\",\n	\"address\" : \"nust\",\n	\"cell number\" : \"090078601\",\n	\"first name\" : \"Nauman\",\n	\"last name\" : \"Ali\",\n	\"id\" : \"123456\",\n	\"team\" : \"CORE\",\n	\"designation\" : \"Manager\",\n	\"role\" : \"Team Lead\"\n}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestReturnTesterModel.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestReturnTesterModel()
        {
            // Perform API call
            Standard.Models.SoftwareTester result = null;
            try
            {
                result = await this.controller.ReturnTesterModelAsync();
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
                    "{\n	\"company name\" : \"APIMatic\",\n	\"address\" : \"nust\",\n	\"cell number\" : \"090078601\",\n	\"first name\" : \"Muhammad\",\n	\"last name\" : \"Farhan\",\n	\"id\" : \"123456\",\n	\"team\" : \"Testing\",\n	\"designation\" : \"Tester\",\n	\"role\" : \"Testing\"\n}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestReturnComplex1Object.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestReturnComplex1Object()
        {
            // Perform API call
            Standard.Models.Complex1 result = null;
            try
            {
                result = await this.controller.ReturnComplex1ObjectAsync();
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
                    "{\n        \"medications\":[{\n                \"aceInhibitors\":[{\n                    \"name\":\"lisinopril\",\n                    \"strength\":\"10 mg Tab\",\n                    \"dose\":\"1 tab\",\n                    \"route\":\"PO\",\n                    \"sig\":\"daily\",\n                    \"pillCount\":\"#90\",\n                    \"refills\":\"Refill 3\"\n                }],\n                \"antianginal\":[{\n                    \"name\":\"nitroglycerin\",\n                    \"strength\":\"0.4 mg Sublingual Tab\",\n                    \"dose\":\"1 tab\",\n                    \"route\":\"SL\",\n                    \"sig\":\"q15min PRN\",\n                    \"pillCount\":\"#30\",\n                    \"refills\":\"Refill 1\"\n                }],\n                \"anticoagulants\":[{\n                    \"name\":\"warfarin sodium\",\n                    \"strength\":\"3 mg Tab\",\n                    \"dose\":\"1 tab\",\n                    \"route\":\"PO\",\n                    \"sig\":\"daily\",\n                    \"pillCount\":\"#90\",\n                    \"refills\":\"Refill 3\"\n                }],\n                \"betaBlocker\":[{\n                    \"name\":\"metoprolol tartrate\",\n                    \"strength\":\"25 mg Tab\",\n                    \"dose\":\"1 tab\",\n                    \"route\":\"PO\",\n                    \"sig\":\"daily\",\n                    \"pillCount\":\"#90\",\n                    \"refills\":\"Refill 3\"\n                }],\n                \"diuretic\":[{\n                    \"name\":\"furosemide\",\n                    \"strength\":\"40 mg Tab\",\n                    \"dose\":\"1 tab\",\n                    \"route\":\"PO\",\n                    \"sig\":\"daily\",\n                    \"pillCount\":\"#90\",\n                    \"refills\":\"Refill 3\"\n                }],\n                \"mineral\":[{\n                    \"name\":\"potassium chloride ER\",\n                    \"strength\":\"10 mEq Tab\",\n                    \"dose\":\"1 tab\",\n                    \"route\":\"PO\",\n                    \"sig\":\"daily\",\n                    \"pillCount\":\"#90\",\n                    \"refills\":\"Refill 3\"\n                }]\n            }\n        ],\n        \"labs\":[{\n            \"name\":\"Arterial Blood Gas\",\n            \"time\":\"Today\",\n            \"location\":\"Main Hospital Lab\"      \n            },\n            {\n            \"name\":\"BMP\",\n            \"time\":\"Today\",\n            \"location\":\"Primary Care Clinic\"    \n            },\n            {\n            \"name\":\"BNP\",\n            \"time\":\"3 Weeks\",\n            \"location\":\"Primary Care Clinic\"    \n            },\n            {\n            \"name\":\"BUN\",\n            \"time\":\"1 Year\",\n            \"location\":\"Primary Care Clinic\"    \n            },\n            {\n            \"name\":\"Cardiac Enzymes\",\n            \"time\":\"Today\",\n            \"location\":\"Primary Care Clinic\"    \n            },\n            {\n            \"name\":\"CBC\",\n            \"time\":\"1 Year\",\n            \"location\":\"Primary Care Clinic\"    \n            },\n            {\n            \"name\":\"Creatinine\",\n            \"time\":\"1 Year\",\n            \"location\":\"Main Hospital Lab\"  \n            },\n            {\n            \"name\":\"Electrolyte Panel\",\n            \"time\":\"1 Year\",\n            \"location\":\"Primary Care Clinic\"    \n            },\n            {\n            \"name\":\"Glucose\",\n            \"time\":\"1 Year\",\n            \"location\":\"Main Hospital Lab\"  \n            },\n            {\n            \"name\":\"PT/INR\",\n            \"time\":\"3 Weeks\",\n            \"location\":\"Primary Care Clinic\"    \n            },\n            {\n            \"name\":\"PTT\",\n            \"time\":\"3 Weeks\",\n            \"location\":\"Coumadin Clinic\"    \n            },\n            {\n            \"name\":\"TSH\",\n            \"time\":\"1 Year\",\n            \"location\":\"Primary Care Clinic\"    \n            }\n        ],\n        \"imaging\":[{\n            \"name\":\"Chest X-Ray\",\n            \"time\":\"Today\",\n            \"location\":\"Main Hospital Radiology\"    \n            },\n            {\n            \"name\":\"Chest X-Ray\",\n            \"time\":\"Today\",\n            \"location\":\"Main Hospital Radiology\"    \n            },\n            {\n            \"name\":\"Chest X-Ray\",\n            \"time\":\"Today\",\n            \"location\":\"Main Hospital Radiology\"    \n            }\n        ]\n    }",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestReturnResponseWithEnumObject.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestReturnResponseWithEnumObject()
        {
            // Perform API call
            Standard.Models.ResponseWithEnum result = null;
            try
            {
                result = await this.controller.ReturnResponseWithEnumsAsync();
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
                    "{\n        \"paramFormat\": \"Template\",\n        \"optional\": false,\n        \"type\": \"Long\",\n        \"constant\": false,\n        \"isArray\": false,\n        \"isStream\": false,\n        \"isAttribute\": false,\n        \"isMap\": false,\n        \"attributes\": {\n          \"exclusiveMaximum\": false,\n          \"exclusiveMinimum\": false,\n          \"id\": \"5a9fcb01caacc310dc6bab51\"\n        },\n        \"nullable\": false,\n        \"id\": \"5a9fcb01caacc310dc6bab50\",\n        \"name\": \"petId\",\n        \"description\": \"ID of pet to update\"\n    }",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestReturnComplex2Object.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestReturnComplex2Object()
        {
            // Perform API call
            Standard.Models.Complex2 result = null;
            try
            {
                result = await this.controller.ReturnComplex2ObjectAsync();
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
                    "{\n        \"glossary\": {\n            \"title\": \"example glossary\",\n            \"GlossDiv\": {\n                \"title\": \"S\",\n                \"GlossList\": {\n                    \"GlossEntry\": {\n                        \"ID\": \"SGML\",\n                        \"SortAs\": \"SGML\",\n                        \"GlossTerm\": \"Standard Generalized Markup Language\",\n                        \"Acronym\": \"SGML\",\n                        \"Abbrev\": \"ISO 8879:1986\",\n                        \"GlossDef\": {\n                            \"para\": \"A meta-markup language, used to create markup languages such as DocBook.\",\n                            \"GlossSeeAlso\": [\"GML\", \"XML\"]\n                        },\n                        \"GlossSee\": \"markup\"\n                    }\n                }\n            }\n        }\n    }",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestReturnComplex3Object.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestReturnComplex3Object()
        {
            // Perform API call
            Standard.Models.Complex3 result = null;
            try
            {
                result = await this.controller.ReturnComplex3ObjectAsync();
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
                    "{\n  \"documentId\": \"099cceda-38a8-4b01-87b9-a8f2007675d6\",\n  \"signers\": [\n    {\n      \"id\": \"1bef97d1-0704-4eb2-a490-a8f2007675db\",\n      \"url\": \"https://sign-test.idfy.io/start?jwt=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzM4NCJ9.eyJrdmVyc2lvbiI6IjdmNzhjNzNkMmQ1MjQzZWRiYjdiNDI0MmI2MDE1MWU4IiwiZG9jaWQiOiIwOTljY2VkYS0zOGE4LTRiMDEtODdiOS1hOGYyMDA3Njc1ZDYiLCJhaWQiOiJjMGNlMTQ2OC1hYzk0LTRiMzQtODc2ZS1hODg1MDBjMmI5YTEiLCJsZyI6ImVuIiwiZXJyIjpudWxsLCJpZnIiOmZhbHNlLCJ3Ym1zZyI6ZmFsc2UsInNmaWQiOiIxYmVmOTdkMS0wNzA0LTRlYjItYTQ5MC1hOGYyMDA3Njc1ZGIiLCJ1cmxleHAiOm51bGwsImF0aCI6bnVsbCwiZHQiOiJUZXN0IGRvY3VtZW50IiwidmYiOmZhbHNlLCJhbiI6IklkZnkgU0RLIGRlbW8iLCJ0aCI6IlBpbmsiLCJzcCI6IkN1YmVzIiwiZG9tIjpudWxsLCJyZGlyIjpmYWxzZSwidXQiOiJ3ZWIiLCJ1dHYiOm51bGwsInNtIjoidGVzdEB0ZXN0LmNvbSJ9.Dyy2RSeR6dmU8qxOEi-2gEX3Gg7wry6JhkZIWOuADDdu5jJWidQLcxfJn_qAHNpb\",\n      \"links\": [],\n      \"externalSignerId\": \"uoiahsd321982983jhrmnec2wsadm32\",\n      \"redirectSettings\": {\n        \"redirectMode\": \"donot_redirect\"\n      },\n      \"signatureType\": {\n        \"mechanism\": \"pkisignature\",\n        \"onEacceptUseHandWrittenSignature\": false\n      },\n      \"ui\": {\n        \"dialogs\": {\n          \"before\": {\n            \"useCheckBox\": false,\n            \"title\": \"Info\",\n            \"message\": \"Please read the contract on the next pages carefully. Pay some extra attention to paragraph 5.\"\n          }\n        },\n        \"language\": \"EN\",\n        \"styling\": {\n          \"colorTheme\": \"Pink\",\n          \"spinner\": \"Cubes\"\n        }\n      },\n      \"tags\": [],\n      \"order\": 0,\n      \"required\": false\n    }\n  ],\n  \"status\": {\n    \"documentStatus\": \"unsigned\",\n    \"completedPackages\": [],\n    \"attachmentPackages\": {}\n  },\n  \"title\": \"Test document\",\n  \"description\": \"This is an important document\",\n  \"externalId\": \"ae7b9ca7-3839-4e0d-a070-9f14bffbbf55\",\n  \"dataToSign\": {\n    \"fileName\": \"sample.txt\",\n    \"convertToPDF\": false\n  },\n  \"contactDetails\": {\n    \"email\": \"test@test.com\",\n    \"url\": \"https://idfy.io\"\n  },\n  \"advanced\": {\n    \"tags\": [\n      \"develop\",\n      \"fun_with_documents\"\n    ],\n    \"attachments\": 0,\n    \"requiredSignatures\": 0,\n    \"getSocialSecurityNumber\": false,\n    \"timeToLive\": {\n      \"deadline\": \"2018-06-29T14:57:25Z\",\n      \"deleteAfterHours\": 1\n    }\n  }\n}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestGetLong.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetLong()
        {
            // Perform API call
            long? result = null;
            try
            {
                result = await this.controller.GetLongAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.AreEqual(5147483647L, result, "Response should match expected value");
        }

        /// <summary>
        /// TestGetModel.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetModel()
        {
            // Perform API call
            Standard.Models.Person result = null;
            try
            {
                result = await this.controller.GetModelAsync();
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
                    "{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"personType\":\"Boss\",\"name\":\"Zeeshan Ejaz\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\",\"promotedAt\":1484719381},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\"}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestGetStringEnumArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetStringEnumArray()
        {
            // Perform API call
            List<Standard.Models.Days> result = null;
            try
            {
                result = await this.controller.GetStringEnumArrayAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            // Deserialize expected output
            List<Standard.Models.Days> expected = ApiHelper.JsonDeserialize<List<Standard.Models.Days>>(
                    "[\"Tuesday\", \"Saturday\", \"Wednesday\", \"Monday\", \"Sunday\"]");

            Assert.IsTrue(result.IsSuperSetOf(expected), "Response array should have matching values");
        }

        /// <summary>
        /// TestGetStringEnum.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetStringEnum()
        {
            // Perform API call
            Standard.Models.Days? result = null;
            try
            {
                result = await this.controller.GetStringEnumAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.AreEqual((Standard.Models.Days)Enum.Parse(typeof(Standard.Models.Days), "Monday"), result, "Response should match expected value");
        }

        /// <summary>
        /// TestGetModelArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetModelArray()
        {
            // Perform API call
            List<Standard.Models.Person> result = null;
            try
            {
                result = await this.controller.GetModelArrayAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsArrayOfJsonObjectsProperSubsetOf(
                    "[{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"personType\":\"Boss\",\"name\":\"Zeeshan Ejaz\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\",\"promotedAt\":1484719381},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\"},{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"personType\":\"Boss\",\"name\":\"Zeeshan Ejaz\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\",\"promotedAt\":1484719381},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\",\"birthday\":\"1994-02-13\",\"birthtime\":\"1994-02-13T14:01:54.9571247Z\"}],\"hiredAt\":\"Sun, 06 Nov 1994 08:49:37 GMT\"}]",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestGetIntEnum.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetIntEnum()
        {
            // Perform API call
            Standard.Models.SuiteCode? result = null;
            try
            {
                result = await this.controller.GetIntEnumAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.AreEqual((Standard.Models.SuiteCode)int.Parse("3"), result, "Response should match expected value");
        }

        /// <summary>
        /// TestGetIntEnumArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetIntEnumArray()
        {
            // Perform API call
            List<Standard.Models.SuiteCode> result = null;
            try
            {
                result = await this.controller.GetIntEnumArrayAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            // Deserialize expected output
            List<Standard.Models.SuiteCode> expected = ApiHelper.JsonDeserialize<List<Standard.Models.SuiteCode>>(
                    "[1, 3, 4, 2, 3]");

            Assert.IsTrue(result.IsSuperSetOf(expected), "Response array should have matching values");
        }

        /// <summary>
        /// TestGetPrecision.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetPrecision()
        {
            // Perform API call
            double? result = null;
            try
            {
                result = await this.controller.GetPrecisionAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.AreEqual(4.999, result, AssertPrecision, "Response should match expected value");
        }

        /// <summary>
        /// TestGetBinary.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetBinary()
        {
            // Perform API call
            Stream result = null;
            try
            {
                result = await this.controller.GetBinaryAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(TestHelper.IsSameAsFile("http://localhost:3000/response/image", result), "Binary result content should match the given file");
        }

        /// <summary>
        /// TestGetInteger.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetInteger()
        {
            // Perform API call
            int? result = null;
            try
            {
                result = await this.controller.GetIntegerAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.AreEqual(4, result, "Response should match expected value");
        }

        /// <summary>
        /// TestGetIntegerArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetIntegerArray()
        {
            // Perform API call
            List<int> result = null;
            try
            {
                result = await this.controller.GetIntegerArrayAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            // Deserialize expected output
            List<int> expected = ApiHelper.JsonDeserialize<List<int>>(
                    "[1,2,3,4,5]");

            Assert.IsTrue(result.IsSuperSetOf(expected), "Response array should have matching values");
        }

        /// <summary>
        /// TestGetDynamic.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetDynamic()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.GetDynamicAsync();
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
                    "{\"method\":\"GET\",\"body\":{},\"uploadCount\":0}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestGetDynamicArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetDynamicArray()
        {
            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.GetDynamicArrayAsync();
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
                    "{\"method\":\"GET\",\"body\":{},\"uploadCount\":0}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    true,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestGet3339Datetime.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGet3339Datetime()
        {
            // Perform API call
            DateTime? result = null;
            try
            {
                result = await this.controller.Get3339DatetimeAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.AreEqual(DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind), result, "Response should match expected value");
        }

        /// <summary>
        /// TestGet3339DatetimeArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGet3339DatetimeArray()
        {
            // Perform API call
            List<DateTime> result = null;
            try
            {
                result = await this.controller.Get3339DatetimeArrayAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            // Deserialize expected output
            List<DateTime> expected = ApiHelper.JsonDeserialize<List<DateTime>>(
                    "[\"2016-03-13T12:52:32.123Z\",\"2016-03-13T12:52:32.123Z\",\"2016-03-13T12:52:32.123Z\"]", new IsoDateTimeConverter());

            Assert.IsTrue(result.IsSuperSetOf(expected), "Response array should have matching values");
        }

        /// <summary>
        /// TestGetBoolean.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetBoolean()
        {
            // Perform API call
            bool? result = null;
            try
            {
                result = await this.controller.GetBooleanAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.AreEqual(true, result, "Response should match expected value");
        }

        /// <summary>
        /// TestGetBooleanArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetBooleanArray()
        {
            // Perform API call
            List<bool> result = null;
            try
            {
                result = await this.controller.GetBooleanArrayAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            // Deserialize expected output
            List<bool> expected = ApiHelper.JsonDeserialize<List<bool>>(
                    "[true, false, true, true, false]");

            Assert.IsTrue(result.IsSuperSetOf(expected), "Response array should have matching values");
        }

        /// <summary>
        /// TestGetHeadersAllowExtra.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetHeadersAllowExtra()
        {
            // Perform API call
            try
            {
                await this.controller.GetHeadersAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("NauManAli", null);
            headers.Add("WaseemHasAn", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    this.HttpCallBackHandler.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// TestGet1123DateTime.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGet1123DateTime()
        {
            // Perform API call
            DateTime? result = null;
            try
            {
                result = await this.controller.Get1123DateTimeAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.AreEqual(DateTime.ParseExact("Sun, 06 Nov 1994 08:49:37 GMT", "r", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind), result, "Response should match expected value");
        }

        /// <summary>
        /// TestGetUnixDateTime.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetUnixDateTime()
        {
            // Perform API call
            DateTime? result = null;
            try
            {
                result = await this.controller.GetUnixDateTimeAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.AreEqual(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(double.Parse("1484719381")), result, "Response should match expected value");
        }

        /// <summary>
        /// TestGet1123DateTimeArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGet1123DateTimeArray()
        {
            // Perform API call
            List<DateTime> result = null;
            try
            {
                result = await this.controller.Get1123DateTimeArrayAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            // Deserialize expected output
            List<DateTime> expected = ApiHelper.JsonDeserialize<List<DateTime>>(
                    "[\"Sun, 06 Nov 1994 08:49:37 GMT\",\"Sun, 06 Nov 1994 08:49:37 GMT\"]", new CustomDateTimeConverter("r"));

            Assert.IsTrue(result.IsSuperSetOf(expected), "Response array should have matching values");
        }

        /// <summary>
        /// TestGetUnixDateTimeArray.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetUnixDateTimeArray()
        {
            // Perform API call
            List<DateTime> result = null;
            try
            {
                result = await this.controller.GetUnixDateTimeArrayAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            // Deserialize expected output
            List<DateTime> expected = ApiHelper.JsonDeserialize<List<DateTime>>(
                    "[1484719381,1484719381]", new Tester.Standard.Utilities.UnixDateTimeConverter());

            Assert.IsTrue(result.IsSuperSetOf(expected), "Response array should have matching values");
        }

        /// <summary>
        /// TestGetContentTypeInResponse.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGetContentTypeInResponse()
        {
            // Perform API call
            try
            {
                await this.controller.GetContentTypeHeadersAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/responseType");
            headers.Add("Accept", "application/noTerm");
            headers.Add("Accept-Encoding", "UTF-8");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    this.HttpCallBackHandler.Response.Headers),
                    "Headers should match");
        }
    }
}