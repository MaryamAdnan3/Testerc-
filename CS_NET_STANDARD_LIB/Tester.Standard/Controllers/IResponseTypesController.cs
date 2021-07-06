// <copyright file="IResponseTypesController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Tester.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Tester.Standard;
    using Tester.Standard.Http.Client;
    using Tester.Standard.Http.Request;
    using Tester.Standard.Http.Response;
    using Tester.Standard.Utilities;

    /// <summary>
    /// IResponseTypesController.
    /// </summary>
    public interface IResponseTypesController
    {
        /// <summary>
        /// Get Date Array EndPoint.
        /// </summary>
        /// <returns>Returns the List<DateTime> response from the API call.</returns>
        List<DateTime> GetDateArray();

        /// <summary>
        /// Get Date Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List<DateTime> response from the API call.</returns>
        Task<List<DateTime>> GetDateArrayAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Date EndPoint.
        /// </summary>
        /// <returns>Returns the DateTime? response from the API call.</returns>
        DateTime? GetDate();

        /// <summary>
        /// Get Date EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the DateTime? response from the API call.</returns>
        Task<DateTime?> GetDateAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// return company model EndPoint.
        /// </summary>
        /// <returns>Returns the Models.Company response from the API call.</returns>
        Models.Company ReturnCompanyModel();

        /// <summary>
        /// return company model EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Company response from the API call.</returns>
        Task<Models.Company> ReturnCompanyModelAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// return boss model EndPoint.
        /// </summary>
        /// <returns>Returns the Models.BossCompany response from the API call.</returns>
        Models.BossCompany ReturnBossModel();

        /// <summary>
        /// return boss model EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BossCompany response from the API call.</returns>
        Task<Models.BossCompany> ReturnBossModelAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// return employee model EndPoint.
        /// </summary>
        /// <returns>Returns the Models.EmployeeComp response from the API call.</returns>
        Models.EmployeeComp ReturnEmployeeModel();

        /// <summary>
        /// return employee model EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EmployeeComp response from the API call.</returns>
        Task<Models.EmployeeComp> ReturnEmployeeModelAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// return developer model EndPoint.
        /// </summary>
        /// <returns>Returns the Models.Developer response from the API call.</returns>
        Models.Developer ReturnDeveloperModel();

        /// <summary>
        /// return developer model EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Developer response from the API call.</returns>
        Task<Models.Developer> ReturnDeveloperModelAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// return Tester model EndPoint.
        /// </summary>
        /// <returns>Returns the Models.SoftwareTester response from the API call.</returns>
        Models.SoftwareTester ReturnTesterModel();

        /// <summary>
        /// return Tester model EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SoftwareTester response from the API call.</returns>
        Task<Models.SoftwareTester> ReturnTesterModelAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Return complex1 object EndPoint.
        /// </summary>
        /// <returns>Returns the Models.Complex1 response from the API call.</returns>
        Models.Complex1 ReturnComplex1Object();

        /// <summary>
        /// Return complex1 object EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Complex1 response from the API call.</returns>
        Task<Models.Complex1> ReturnComplex1ObjectAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// return response with enums EndPoint.
        /// </summary>
        /// <returns>Returns the Models.ResponseWithEnum response from the API call.</returns>
        Models.ResponseWithEnum ReturnResponseWithEnums();

        /// <summary>
        /// return response with enums EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseWithEnum response from the API call.</returns>
        Task<Models.ResponseWithEnum> ReturnResponseWithEnumsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Return complex2 object EndPoint.
        /// </summary>
        /// <returns>Returns the Models.Complex2 response from the API call.</returns>
        Models.Complex2 ReturnComplex2Object();

        /// <summary>
        /// Return complex2 object EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Complex2 response from the API call.</returns>
        Task<Models.Complex2> ReturnComplex2ObjectAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// return complex3 object EndPoint.
        /// </summary>
        /// <returns>Returns the Models.Complex3 response from the API call.</returns>
        Models.Complex3 ReturnComplex3Object();

        /// <summary>
        /// return complex3 object EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Complex3 response from the API call.</returns>
        Task<Models.Complex3> ReturnComplex3ObjectAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Long EndPoint.
        /// </summary>
        /// <returns>Returns the long? response from the API call.</returns>
        long? GetLong();

        /// <summary>
        /// Get Long EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the long? response from the API call.</returns>
        Task<long?> GetLongAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Model EndPoint.
        /// </summary>
        /// <returns>Returns the Models.Person response from the API call.</returns>
        Models.Person GetModel();

        /// <summary>
        /// Get Model EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Person response from the API call.</returns>
        Task<Models.Person> GetModelAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get String Enum Array EndPoint.
        /// </summary>
        /// <returns>Returns the List<Models.Days> response from the API call.</returns>
        List<Models.Days> GetStringEnumArray();

        /// <summary>
        /// Get String Enum Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List<Models.Days> response from the API call.</returns>
        Task<List<Models.Days>> GetStringEnumArrayAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get String Enum EndPoint.
        /// </summary>
        /// <returns>Returns the Models.Days? response from the API call.</returns>
        Models.Days? GetStringEnum();

        /// <summary>
        /// Get String Enum EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Days? response from the API call.</returns>
        Task<Models.Days?> GetStringEnumAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Model Array EndPoint.
        /// </summary>
        /// <returns>Returns the List<Models.Person> response from the API call.</returns>
        List<Models.Person> GetModelArray();

        /// <summary>
        /// Get Model Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List<Models.Person> response from the API call.</returns>
        Task<List<Models.Person>> GetModelArrayAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Int Enum EndPoint.
        /// </summary>
        /// <returns>Returns the Models.SuiteCode? response from the API call.</returns>
        Models.SuiteCode? GetIntEnum();

        /// <summary>
        /// Get Int Enum EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SuiteCode? response from the API call.</returns>
        Task<Models.SuiteCode?> GetIntEnumAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Int Enum Array EndPoint.
        /// </summary>
        /// <returns>Returns the List<Models.SuiteCode> response from the API call.</returns>
        List<Models.SuiteCode> GetIntEnumArray();

        /// <summary>
        /// Get Int Enum Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List<Models.SuiteCode> response from the API call.</returns>
        Task<List<Models.SuiteCode>> GetIntEnumArrayAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Precision EndPoint.
        /// </summary>
        /// <returns>Returns the double? response from the API call.</returns>
        double? GetPrecision();

        /// <summary>
        /// Get Precision EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the double? response from the API call.</returns>
        Task<double?> GetPrecisionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// gets a binary object.
        /// </summary>
        /// <returns>Returns the Stream response from the API call.</returns>
        Stream GetBinary();

        /// <summary>
        /// gets a binary object.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Stream response from the API call.</returns>
        Task<Stream> GetBinaryAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a integer response.
        /// </summary>
        /// <returns>Returns the int? response from the API call.</returns>
        int? GetInteger();

        /// <summary>
        /// Gets a integer response.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the int? response from the API call.</returns>
        Task<int?> GetIntegerAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get an array of integers..
        /// </summary>
        /// <returns>Returns the List<int> response from the API call.</returns>
        List<int> GetIntegerArray();

        /// <summary>
        /// Get an array of integers..
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List<int> response from the API call.</returns>
        Task<List<int>> GetIntegerArrayAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Dynamic EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic GetDynamic();

        /// <summary>
        /// Get Dynamic EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> GetDynamicAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Dynamic Array EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic GetDynamicArray();

        /// <summary>
        /// Get Dynamic Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> GetDynamicArrayAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get 3339Datetime EndPoint.
        /// </summary>
        /// <returns>Returns the DateTime? response from the API call.</returns>
        DateTime? Get3339Datetime();

        /// <summary>
        /// Get 3339Datetime EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the DateTime? response from the API call.</returns>
        Task<DateTime?> Get3339DatetimeAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get 3339Datetime Array EndPoint.
        /// </summary>
        /// <returns>Returns the List<DateTime> response from the API call.</returns>
        List<DateTime> Get3339DatetimeArray();

        /// <summary>
        /// Get 3339Datetime Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List<DateTime> response from the API call.</returns>
        Task<List<DateTime>> Get3339DatetimeArrayAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Boolean EndPoint.
        /// </summary>
        /// <returns>Returns the bool? response from the API call.</returns>
        bool? GetBoolean();

        /// <summary>
        /// Get Boolean EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the bool? response from the API call.</returns>
        Task<bool?> GetBooleanAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Boolean Array EndPoint.
        /// </summary>
        /// <returns>Returns the List<bool> response from the API call.</returns>
        List<bool> GetBooleanArray();

        /// <summary>
        /// Get Boolean Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List<bool> response from the API call.</returns>
        Task<List<bool>> GetBooleanArrayAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Headers EndPoint.
        /// </summary>
        void GetHeaders();

        /// <summary>
        /// Get Headers EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        Task GetHeadersAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get 1123DateTime EndPoint.
        /// </summary>
        /// <returns>Returns the DateTime? response from the API call.</returns>
        DateTime? Get1123DateTime();

        /// <summary>
        /// Get 1123DateTime EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the DateTime? response from the API call.</returns>
        Task<DateTime?> Get1123DateTimeAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get UnixDateTime EndPoint.
        /// </summary>
        /// <returns>Returns the DateTime? response from the API call.</returns>
        DateTime? GetUnixDateTime();

        /// <summary>
        /// Get UnixDateTime EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the DateTime? response from the API call.</returns>
        Task<DateTime?> GetUnixDateTimeAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get 1123DateTime Array EndPoint.
        /// </summary>
        /// <returns>Returns the List<DateTime> response from the API call.</returns>
        List<DateTime> Get1123DateTimeArray();

        /// <summary>
        /// Get 1123DateTime Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List<DateTime> response from the API call.</returns>
        Task<List<DateTime>> Get1123DateTimeArrayAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get UnixDateTime Array EndPoint.
        /// </summary>
        /// <returns>Returns the List<DateTime> response from the API call.</returns>
        List<DateTime> GetUnixDateTimeArray();

        /// <summary>
        /// Get UnixDateTime Array EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List<DateTime> response from the API call.</returns>
        Task<List<DateTime>> GetUnixDateTimeArrayAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// get content type headers EndPoint.
        /// </summary>
        void GetContentTypeHeaders();

        /// <summary>
        /// get content type headers EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        Task GetContentTypeHeadersAsync(CancellationToken cancellationToken = default);
    }
}