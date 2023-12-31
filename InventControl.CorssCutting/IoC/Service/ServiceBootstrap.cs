﻿using InventControl.Domain.Interfaces.Service;
using InventControl.Service;
using Microsoft.Extensions.DependencyInjection;

namespace InventControl.CorssCutting.IoC.Service;

public static class ServiceBootstrap
{
    public static void ServiceRegister(this IServiceCollection services)
    {
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IProductService, ProductService>();
    }
}
