using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyCafe.Db.DI;
using System;

namespace MyCafe.BLL.DI
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddBLLServises(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMyCafeDb(configuration);
            services.AddRepository();

            return services;
        }
    }
}
