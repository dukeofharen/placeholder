﻿using System;
using System.IO;
using System.Net.Http;
using HttPlaceholder.Application.Interfaces.Http;
using HttPlaceholder.Application.Interfaces.Persistence;
using HttPlaceholder.Common;
using HttPlaceholder.Common.Utilities;
using HttPlaceholder.Persistence.Implementations.StubSources;
using Microsoft.Extensions.Logging;
using Moq;
using RichardSzalay.MockHttp;

namespace HttPlaceholder.Tests.Integration.Stubs
{
    public abstract class StubIntegrationTestBase : IntegrationTestBase
    {
        private const string InputFilePath = @"D:\tmp\input.yml";
        protected Mock<IClientDataResolver> ClientIpResolverMock;
        protected Mock<IFileService> FileServiceMock;
        private YamlFileStubSource _stubSource;
        private Mock<IWritableStubSource> _writableStubSourceMock;
        protected Mock<IDateTime> DateTimeMock;
        protected MockHttpMessageHandler MockHttp;

        protected void InitializeStubIntegrationTest(string yamlFileName)
        {
            // Load the integration YAML file here.
            var path = Path.Combine(AssemblyHelper.GetCallingAssemblyRootPath(), yamlFileName);
            var integrationYml = File.ReadAllText(path);

            FileServiceMock = new Mock<IFileService>();
            FileServiceMock
                .Setup(m => m.ReadAllText(InputFilePath))
                .Returns(integrationYml);
            FileServiceMock
                .Setup(m => m.FileExists(InputFilePath))
                .Returns(true);

            DateTimeMock = new Mock<IDateTime>();
            DateTimeMock
                .Setup(m => m.Now)
                .Returns(() => DateTime.Now);
            DateTimeMock
                .Setup(m => m.UtcNow)
                .Returns(() => DateTime.UtcNow);

            ClientIpResolverMock = new Mock<IClientDataResolver>();
            Settings.Storage.InputFile = InputFilePath;

            _stubSource = new YamlFileStubSource(
                FileServiceMock.Object,
                new Mock<ILogger<YamlFileStubSource>>().Object,
                Options);
            _writableStubSourceMock = new Mock<IWritableStubSource>();

            MockHttp = new MockHttpMessageHandler();
            var mockHttpClientFactory = new Mock<IHttpClientFactory>();
            mockHttpClientFactory
                .Setup(m => m.CreateClient("proxy"))
                .Returns(() => MockHttp.ToHttpClient());

            InitializeIntegrationTest(
                new (Type, object)[]
                {
                    (typeof(IClientDataResolver), ClientIpResolverMock.Object),
                    (typeof(IFileService), FileServiceMock.Object), (typeof(IDateTime), DateTimeMock.Object),
                    (typeof(IHttpClientFactory), mockHttpClientFactory.Object),
                }, new IStubSource[] {_stubSource, _writableStubSourceMock.Object});
        }
    }
}
