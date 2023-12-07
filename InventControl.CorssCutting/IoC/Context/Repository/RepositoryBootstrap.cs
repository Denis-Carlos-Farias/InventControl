using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using InventControl.Infrastructure.Context;
using InventControl.Domain.Interfaces.Infrastructure;
using InventControl.Infrastructure.Repositories;

namespace InventControl.CorssCutting.IoC.Context.Repository;

public static class RepositoryBootstrap
{
    public static void ChildServiceRegister(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        //Cria conexão com a base de dados..
        services.AddDbContext<InventControlContext>(options =>
                options.UseSqlServer(
                connectionString,
                b => b.MigrationsAssembly(typeof(InventControlContext)
                .Assembly
                .FullName)
                ));

        services.AddScoped<IProductRepository, ProductRepository>();
    }
}
