// <copyright file="ITesterClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Tester.Standard
{
    using System;
    using Tester.Standard.Controllers;

    /// <summary>
    /// ITesterClient.
    /// </summary>
    public interface ITesterClient : IConfiguration
    {
        /// <summary>
        /// Gets instance for IResponseTypesController.
        /// </summary>
        IResponseTypesController ResponseTypesController { get; }

        /// <summary>
        /// Gets instance for IFormParamsController.
        /// </summary>
        IFormParamsController FormParamsController { get; }

        /// <summary>
        /// Gets instance for IBodyParamsController.
        /// </summary>
        IBodyParamsController BodyParamsController { get; }

        /// <summary>
        /// Gets instance for IErrorCodesController.
        /// </summary>
        IErrorCodesController ErrorCodesController { get; }

        /// <summary>
        /// Gets instance for IQueryParamController.
        /// </summary>
        IQueryParamController QueryParamController { get; }

        /// <summary>
        /// Gets instance for IEchoController.
        /// </summary>
        IEchoController EchoController { get; }

        /// <summary>
        /// Gets instance for IHeaderController.
        /// </summary>
        IHeaderController HeaderController { get; }

        /// <summary>
        /// Gets instance for ITemplateParamsController.
        /// </summary>
        ITemplateParamsController TemplateParamsController { get; }

        /// <summary>
        /// Gets instance for IQueryParamsController.
        /// </summary>
        IQueryParamsController QueryParamsController { get; }
    }
}