using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventControl.CorssCutting.IoC
{
    public static class RootBootstrap
    {
        public static void ServicesRegister(this IServiceCollection services, IConfiguration configuration)
        {
            //new ApplicationBootstraper().ChildServiceRegister(services);
            //new DomainBootstraper().ChildServiceRegister(services);
            //new RepositoryBootstrapper().ChildServiceRegister(services, configuration);
        }
    }
}
