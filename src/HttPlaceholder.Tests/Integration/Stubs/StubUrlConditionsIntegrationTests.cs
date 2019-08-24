﻿using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace HttPlaceholder.Tests.Integration.Stubs
{
    [TestClass]
    public class StubUrlConditionsIntegrationTests : StubIntegrationTestBase
    {
        [TestInitialize]
        public void Initialize()
        {
            InitializeStubIntegrationTest("integration.yml");
        }

        [TestCleanup]
        public void Cleanup()
        {
            CleanupIntegrationTest();
        }

        [TestMethod]
        public async Task StubIntegration_RegularGet_FullPath()
        {
            // arrange
            string url = $"{TestServer.BaseAddress}index.php?success=true";
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };

            // act / assert
            using (var response = await Client.SendAsync(request))
            {
                string content = await response.Content.ReadAsStringAsync();
                Assert.IsFalse(string.IsNullOrEmpty(content));
                Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                Assert.AreEqual("text/plain", response.Content.Headers.ContentType.ToString());
            }
        }

        [TestMethod]
        public async Task StubIntegration_RegularGet_FullPath_StubNotFound()
        {
            // arrange
            string url = $"{TestServer.BaseAddress}index.php?success=false";
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };

            // act / assert
            using (var response = await Client.SendAsync(request))
            {
                string content = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(string.IsNullOrEmpty(content));
                Assert.AreEqual(HttpStatusCode.InternalServerError, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task StubIntegration_RegularGet_ReturnsJson_Scenario1()
        {
            // arrange
            string url = $"{TestServer.BaseAddress}locatieserver/v3/suggest?q=9761BP";

            // act / assert
            using (var response = await Client.GetAsync(url))
            {
                string content = await response.Content.ReadAsStringAsync();
                Assert.IsFalse(string.IsNullOrEmpty(content));
                JObject.Parse(content);
                Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                Assert.AreEqual("application/json", response.Content.Headers.ContentType.ToString());
            }
        }

        [TestMethod]
        public async Task StubIntegration_RegularGet_ReturnsJson_Scenario2()
        {
            // arrange
            string url = $"{TestServer.BaseAddress}locatieserver/v3/suggest?q=9752EM";

            // act / assert
            using (var response = await Client.GetAsync(url))
            {
                string content = await response.Content.ReadAsStringAsync();
                Assert.IsFalse(string.IsNullOrEmpty(content));
                JObject.Parse(content);
                Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                Assert.AreEqual("application/json", response.Content.Headers.ContentType.ToString());
            }
        }

        [TestMethod]
        public async Task StubIntegration_RegularGet_ReturnsJson_ConflictingNegativeCondition_ShouldReturnHttp500()
        {
            // arrange
            string url = $"{TestServer.BaseAddress}locatieserver/v3/suggest?q=9761BP&filter=postcode";

            // act / assert
            using (var response = await Client.GetAsync(url))
            {
                string content = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(string.IsNullOrEmpty(content));
                Assert.AreEqual(HttpStatusCode.InternalServerError, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task StubIntegration_RegularGet_ReturnsJson_Scenario3_JsonResponseTag()
        {
            // arrange
            string url = $"{TestServer.BaseAddress}locatieserver/v3/suggest?q=9468BA";

            // act / assert
            using (var response = await Client.GetAsync(url))
            {
                string content = await response.Content.ReadAsStringAsync();
                Assert.IsFalse(string.IsNullOrEmpty(content));
                JObject.Parse(content);
                Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                Assert.AreEqual("application/json", response.Content.Headers.ContentType.ToString());
            }
        }
    }
}