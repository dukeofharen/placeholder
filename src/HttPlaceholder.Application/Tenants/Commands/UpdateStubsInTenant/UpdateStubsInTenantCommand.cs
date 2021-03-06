﻿using System.Collections.Generic;
using HttPlaceholder.Domain;
using MediatR;

namespace HttPlaceholder.Application.Tenants.Commands.UpdateStubsInTenant
{
    public class UpdateStubsInTenantCommand : IRequest
    {
        public IEnumerable<StubModel> Stubs { get; set; }
        public string Tenant { get; set; }
    }
}
