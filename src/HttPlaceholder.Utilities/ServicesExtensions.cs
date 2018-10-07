﻿using Microsoft.Extensions.DependencyInjection;

namespace HttPlaceholder.Utilities
{
    public static class ServicesExtensions
    {
        public static TInterface GetService<TInterface>(this IServiceCollection services)
        {
            var provider = services.BuildServiceProvider();
            return provider.GetService<TInterface>();
        }
    }
}