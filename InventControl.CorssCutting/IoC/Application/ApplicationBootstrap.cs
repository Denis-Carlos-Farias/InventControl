using InventControl.Application;
using InventControl.Application.Interfaces;
using InventControl.Application.Interfaces.Application;
using Microsoft.Extensions.DependencyInjection;

namespace InventControl.CorssCutting.IoC.Application;

public static class ApplicationBootstrap
{
    public static void ApplicationRegister(this IServiceCollection services)
    {
        services.AddScoped<ICategoryApplication, CategoryApplication>();
        services.AddScoped<IProductApplication, ProductApplication>();
    }
}
