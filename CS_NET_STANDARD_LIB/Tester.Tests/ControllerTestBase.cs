// <copyright file="ControllerTestBase.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Tester.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using Tester.Standard;
    using Tester.Standard.Http.Client;
    using Tester.Standard.Models;
    using Tester.Tests.Helpers;

    /// <summary>
    /// ControllerTestBase Class.
    /// </summary>
    [TestFixture]
    public class ControllerTestBase
    {
        /// <summary>
        /// Assert precision.
        /// </summary>
        protected const double AssertPrecision = 0.1;

        /// <summary>
        /// Gets HttpCallBackHandler.
        /// </summary>
        internal HttpCallBack HttpCallBackHandler { get; private set; }

        /// <summary>
        /// Gets TesterClient Client.
        /// </summary>
        protected TesterClient Client { get; private set; }

        /// <summary>
        /// Set up the client.
        /// </summary>
        [OneTimeSetUp]
        public void SetUp()
        {
            this.HttpCallBackHandler = new HttpCallBack();
            this.Client = TesterClient.CreateFromEnvironment().ToBuilder()
                .HttpCallBack(this.HttpCallBackHandler)
                .Environment(Tester.Standard.Environment.Testing)
                .Port("3000")
                .Suites(Standard.Models.SuiteCode.Diamonds)
                .Build();
        }
    }
}