/*
 * 42videobricks
 *
 * 42videobricks is a Video Platform As A Service (VPaaS)
 *
 * The version of the OpenAPI document: 1.2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Api42Vb.Client;
using Api42Vb.Api;
// uncomment below to import models
//using Api42Vb.Model;

namespace Api42Vb.Test.Api
{
    /// <summary>
    ///  Class for testing DataApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DataApiTests : IDisposable
    {
        private DataApi instance;

        public DataApiTests()
        {
            instance = new DataApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DataApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DataApi
            //Assert.IsType<DataApi>(instance);
        }

        /// <summary>
        /// Test GetDataVideoUsage
        /// </summary>
        [Fact]
        public void GetDataVideoUsageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //int? offset = null;
            //string? interval = null;
            //string? startDate = null;
            //string? endDate = null;
            //var response = instance.GetDataVideoUsage(limit, offset, interval, startDate, endDate);
            //Assert.IsType<DataVideoUsageList>(response);
        }
    }
}
