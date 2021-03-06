/* 
 * HttPlaceholder API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
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

using HttPlaceholder.Client.Client;
using HttPlaceholder.Client.Api;
using HttPlaceholder.Client.Model;

namespace HttPlaceholder.Client.Test
{
    /// <summary>
    ///  Class for testing RequestApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RequestApiTests : IDisposable
    {
        private RequestApi instance;

        public RequestApiTests()
        {
            instance = new RequestApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RequestApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RequestApi
            //Assert.IsType(typeof(RequestApi), instance, "instance is a RequestApi");
        }

        
        /// <summary>
        /// Test RequestCreateStubForRequest
        /// </summary>
        [Fact]
        public void RequestCreateStubForRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string correlationId = null;
            //var response = instance.RequestCreateStubForRequest(correlationId);
            //Assert.IsType<FullStubDto> (response, "response is FullStubDto");
        }
        
        /// <summary>
        /// Test RequestDeleteAll
        /// </summary>
        [Fact]
        public void RequestDeleteAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.RequestDeleteAll();
            
        }
        
        /// <summary>
        /// Test RequestGetAll
        /// </summary>
        [Fact]
        public void RequestGetAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.RequestGetAll();
            //Assert.IsType<List<RequestResultDto>> (response, "response is List<RequestResultDto>");
        }
        
        /// <summary>
        /// Test RequestGetByStubId
        /// </summary>
        [Fact]
        public void RequestGetByStubIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stubId = null;
            //var response = instance.RequestGetByStubId(stubId);
            //Assert.IsType<List<RequestResultDto>> (response, "response is List<RequestResultDto>");
        }
        
    }

}
