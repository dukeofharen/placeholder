﻿using HttPlaceholder.Models;
using System.Text;
using System.Threading.Tasks;

namespace HttPlaceholder.BusinessLogic.Implementations.ResponseWriters
{
   internal class HtmlResponseWriter : IResponseWriter
   {
      public Task<bool> WriteToResponseAsync(StubModel stub, ResponseModel response)
      {
         bool executed = false;
         if (stub.Response?.Html != null)
         {
            string body = stub.Response.Html;
            response.Body = Encoding.UTF8.GetBytes(body);
            string bodyForLogging = body.Length > 10 ? body.Substring(0, 10) : body;
            if (!response.Headers.TryGetValue("Content-Type", out string contentType))
            {
               response.Headers.Add("Content-Type", "text/html");
            }

            executed = true;
         }

         return Task.FromResult(executed);
      }
   }
}