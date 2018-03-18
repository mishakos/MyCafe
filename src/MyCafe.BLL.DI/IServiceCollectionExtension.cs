using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyCafe.BLL.Services;
using MyCafe.BLL.Services.Interfaces;
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

            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IFirmService, FirmService>();
            return services;
        }
    }
}
