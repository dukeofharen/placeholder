﻿using System.Threading.Tasks;
using HttPlaceholder.Domain;
using HttPlaceholder.Dto.Requests;
using Microsoft.AspNetCore.SignalR;

namespace HttPlaceholder.Hubs.Implementations
{
    public class RequestNotify : IRequestNotify
    {
        private readonly IHubContext<RequestHub> _hubContext;

        public RequestNotify(IHubContext<RequestHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task NewRequestReceivedAsync(RequestResultDto request)
        {
            await _hubContext.Clients.All.SendAsync("RequestReceived", request);
        }
    }
}