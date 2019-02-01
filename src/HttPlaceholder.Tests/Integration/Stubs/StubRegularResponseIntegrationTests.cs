﻿using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HttPlaceholder.Tests.Integration.Stubs
{
    [TestClass]
    public class StubRegularResponseIntegrationTests : StubIntegrationTestBase
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
        public async Task StubIntegration_RegularGet_Host()
        {
            // arrange
            string url = $"{TestServer.BaseAddress}client-ip-1";
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(url)
            };
            request.Headers.Add("X-Forwarded-Host", "httplaceholder.com");
            _clientIpResolverMock
                .Setup(m => m.GetClientIp())
                .Returns("127.0.0.1");

            // act / assert
            using (var response = await Client.SendAsync(request))
            {
                string content = await response.Content.ReadAsStringAsync();
                Assert.AreEqual("OK", content);
                Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task StubIntegration_RegularGet_Base64Content_HappyFlow()
        {
            // arrange
            string url = $"{TestServer.BaseAddress}image.jpg";

            // act / assert
            using (var response = await Client.GetAsync(url))
            {
                var content = await response.Content.ReadAsByteArrayAsync();
                Assert.AreEqual(75583, content.Length);
                Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task StubIntegration_RegularGet_File_HappyFlow()
        {
            // arrange
            string fileContents = "File contents yo!";
            string url = $"{TestServer.BaseAddress}text.txt";

            _fileServiceMock
               .Setup(m => m.FileExists("text.txt"))
               .Returns(true);
            _fileServiceMock
               .Setup(m => m.ReadAllBytes("text.txt"))
               .Returns(Encoding.UTF8.GetBytes(fileContents));

            // act / assert
            using (var response = await Client.GetAsync(url))
            {
                string content = await response.Content.ReadAsStringAsync();
                Assert.AreEqual(fileContents, content);
                Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task StubIntegration_RegularGet_Html()
        {
            // arrange
            string url = $"{TestServer.BaseAddress}index.html";

            // act / assert
            using (var response = await Client.GetAsync(url))
            {
                string content = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(content.Contains("Test page in HttPlaceholder"));
                Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                Assert.AreEqual("text/html", response.Content.Headers.ContentType.ToString());
            }
        }
    }
}
