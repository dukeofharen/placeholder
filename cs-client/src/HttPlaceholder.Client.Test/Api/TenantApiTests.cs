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
    ///  Class for testing TenantApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TenantApiTests : IDisposable
    {
        private TenantApi instance;

        public TenantApiTests()
        {
            instance = new TenantApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TenantApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TenantApi
            //Assert.IsType(typeof(TenantApi), instance, "instance is a TenantApi");
        }

        
        /// <summary>
        /// Test TenantDeleteAll
        /// </summary>
        [Fact]
        public void TenantDeleteAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenant = null;
            //instance.TenantDeleteAll(tenant);
            
        }
        
        /// <summary>
        /// Test TenantGetAll
        /// </summary>
        [Fact]
        public void TenantGetAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenant = null;
            //var response = instance.TenantGetAll(tenant);
            //Assert.IsType<List<FullStubDto>> (response, "response is List<FullStubDto>");
        }
        
        /// <summary>
        /// Test TenantGetTenantNames
        /// </summary>
        [Fact]
        public void TenantGetTenantNamesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.TenantGetTenantNames();
            //Assert.IsType<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test TenantUpdateAll
        /// </summary>
        [Fact]
        public void TenantUpdateAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenant = null;
            //List<StubDto> stubDto = null;
            //instance.TenantUpdateAll(tenant, stubDto);
            
        }
        
    }

}
