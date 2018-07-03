﻿using System.Threading.Tasks;
using HttPlaceholder.Services;
using HttPlaceholder.Models;

namespace HttPlaceholder.Implementation.Implementations.ResponseWriters
{
   public class StatusCodeResponseWriter : IResponseWriter
   {
      private readonly IRequestLoggerFactory _requestLoggerFactory;

      public StatusCodeResponseWriter(IRequestLoggerFactory requestLoggerFactory)
      {
         _requestLoggerFactory = requestLoggerFactory;
      }

      public Task WriteToResponseAsync(StubModel stub, ResponseModel response)
      {
         var requestLogger = _requestLoggerFactory.GetRequestLogger();
         response.StatusCode = stub.Response?.StatusCode ?? 200;
         requestLogger.Log($"Found HTTP status code '{response.StatusCode}'.");

         return Task.CompletedTask;
      }
   }
}