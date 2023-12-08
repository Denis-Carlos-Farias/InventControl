using InventControl.CorssCutting.IoC.Context.Repository;
using InventControl.CorssCutting.IoC.Context.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InventControl.CorssCutting.IoC;

public static class RootBootstrap
{
    public static void ServicesRegister(this IServiceCollection services, IConfiguration configuration)
    {
        services.RepositoryRegister(configuration);
        services.ServiceRegister();
        //new RepositoryBootstrapper().ChildServiceRegister(services, configuration);
    }
}
