// <copyright file="IErrorCodesController.cs" company="APIMatic">
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
    /// IErrorCodesController.
    /// </summary>
    public interface IErrorCodesController
    {
        /// <summary>
        /// catch 412 global error EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic Catch412GlobalError();

        /// <summary>
        /// catch 412 global error EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> Catch412GlobalErrorAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get501 EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic Get501();

        /// <summary>
        /// Get501 EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> Get501Async(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get400 EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic Get400();

        /// <summary>
        /// Get400 EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> Get400Async(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get500 EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic Get500();

        /// <summary>
        /// Get500 EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> Get500Async(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get401 EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic Get401();

        /// <summary>
        /// Get401 EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> Get401Async(CancellationToken cancellationToken = default);

        /// <summary>
        /// Receive Exception with unixtimestamp exception EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic ReceiveExceptionWithUnixtimestampException();

        /// <summary>
        /// Receive Exception with unixtimestamp exception EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> ReceiveExceptionWithUnixtimestampExceptionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Receive Exception with rfc 1123 datetime EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic ReceiveExceptionWithRfc1123Datetime();

        /// <summary>
        /// Receive Exception with rfc 1123 datetime EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> ReceiveExceptionWithRfc1123DatetimeAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Receive Exception with rfc 3339 datetime EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic ReceiveExceptionWithRfc3339Datetime();

        /// <summary>
        /// Receive Exception with rfc 3339 datetime EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> ReceiveExceptionWithRfc3339DatetimeAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// receive endpoint level exception EndPoint.
        /// </summary>
        /// <returns>Returns the Models.Complex5 response from the API call.</returns>
        Models.Complex5 ReceiveEndpointLevelException();

        /// <summary>
        /// receive endpoint level exception EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Complex5 response from the API call.</returns>
        Task<Models.Complex5> ReceiveEndpointLevelExceptionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Receive global level exception EndPoint.
        /// </summary>
        /// <returns>Returns the Models.Complex5 response from the API call.</returns>
        Models.Complex5 ReceiveGlobalLevelException();

        /// <summary>
        /// Receive global level exception EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Complex5 response from the API call.</returns>
        Task<Models.Complex5> ReceiveGlobalLevelExceptionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Date in exception EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic DateInException();

        /// <summary>
        /// Date in exception EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> DateInExceptionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// UUID in exception EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic UUIDInException();

        /// <summary>
        /// UUID in exception EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> UUIDInExceptionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Dynamic in Exception EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic DynamicInException();

        /// <summary>
        /// Dynamic in Exception EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> DynamicInExceptionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Precision in Exception EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic PrecisionInException();

        /// <summary>
        /// Precision in Exception EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> PrecisionInExceptionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Boolean in exception EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic BooleanInException();

        /// <summary>
        /// Boolean in exception EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> BooleanInExceptionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// long in exception EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic LongInException();

        /// <summary>
        /// long in exception EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> LongInExceptionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Number in exception EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic NumberInException();

        /// <summary>
        /// Number in exception EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> NumberInExceptionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// get exception with string EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        dynamic GetExceptionWithString();

        /// <summary>
        /// get exception with string EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        Task<dynamic> GetExceptionWithStringAsync(CancellationToken cancellationToken = default);
    }
}