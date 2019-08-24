﻿using System.Collections.Generic;
using HttPlaceholder.Application.Interfaces.Http;
using HttPlaceholder.Application.StubExecution.VariableHandling.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HttPlaceholder.Application.Tests.StubExecution.VariableHandling
{
    [TestClass]
    public class RequestHeaderVariableHandlerFacts
    {
        private readonly Mock<IHttpContextService> _httpContextServiceMock = new Mock<IHttpContextService>();
        private RequestHeaderVariableHandler _handler;

        [TestInitialize]
        public void Initialize()
        {
            _handler = new RequestHeaderVariableHandler(_httpContextServiceMock.Object);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _httpContextServiceMock.VerifyAll();
        }

        [TestMethod]
        public void RequestHeaderVariableHandler_Parse_HappyFlow()
        {
            // arrange
            string input = "Header var 1: ((request_header:var1)), header var 2: ((request_header:var2)), header var 3: ((request_header:var3))";
            var headerDict = new Dictionary<string, string>
            {
                { "var1", "https://google.com" },
                { "var3", "value3" },
            };
            string expectedResult = "Header var 1: https://google.com, header var 2: , header var 3: value3";

            _httpContextServiceMock
                .Setup(m => m.GetHeaders())
                .Returns(headerDict);

            // act
            var matches = VariableParser.VarRegex.Matches(input);
            string result = _handler.Parse(input, matches);

            // assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}