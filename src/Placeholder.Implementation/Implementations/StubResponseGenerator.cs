﻿using System;
using System.Text;
using Placeholder.Implementation.Services;
using Placeholder.Models;

namespace Placeholder.Implementation.Implementations
{
   internal class StubResponseGenerator : IStubResponseGenerator
   {
      private readonly IRequestLoggerFactory _requestLoggerFactory;

      public StubResponseGenerator(IRequestLoggerFactory requestLoggerFactory)
      {
         _requestLoggerFactory = requestLoggerFactory;
      }

      public ResponseModel GenerateResponse(StubModel stub)
      {
         var requestLogger = _requestLoggerFactory.GetRequestLogger();
         requestLogger.Log($"Stub with ID '{stub.Id}' found; returning response.");
         var response = new ResponseModel
         {
            StatusCode = 200
         };

         response.StatusCode = stub.Response?.StatusCode ?? 200;
         requestLogger.Log($"Found HTTP status code '{response.StatusCode}'.");

         if (stub.Response?.Text != null)
         {
            response.Body = Encoding.UTF8.GetBytes(stub.Response.Text);
            requestLogger.Log($"Found body '{stub.Response?.Text}'");
         }
         else if (stub.Response?.Base64 != null)
         {
            string base64Body = stub.Response.Base64;
            response.Body = Convert.FromBase64String(base64Body);
            string bodyForLogging = base64Body.Length > 10 ? base64Body.Substring(0, 10) : base64Body;
            requestLogger.Log($"Found base64 body: {bodyForLogging}");
         }

         var stubResponseHeaders = stub.Response?.Headers;
         if (stubResponseHeaders != null)
         {
            foreach (var header in stubResponseHeaders)
            {
               requestLogger.Log($"Found header '{header.Key}' with value '{header.Value}'.");
               response.Headers.Add(header.Key, header.Value);
            }
         }

         return response;
      }
   }
}