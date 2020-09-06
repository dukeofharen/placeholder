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
    ///  Class for testing MetadataApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MetadataApiTests : IDisposable
    {
        private MetadataApi instance;

        public MetadataApiTests()
        {
            instance = new MetadataApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MetadataApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MetadataApi
            //Assert.IsType(typeof(MetadataApi), instance, "instance is a MetadataApi");
        }

        
        /// <summary>
        /// Test MetadataGet
        /// </summary>
        [Fact]
        public void MetadataGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.MetadataGet();
            //Assert.IsType<MetadataDto> (response, "response is MetadataDto");
        }
        
    }

}