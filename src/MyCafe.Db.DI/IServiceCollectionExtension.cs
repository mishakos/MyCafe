using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using MyCafe.Db.Context;
using MyCafe.Db.Repository;
using MyCafe.Db.Repository.Interfaces;

namespace MyCafe.Db.DI
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddMyCafeDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyCafeContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("MyCafe"), b => b.MigrationsAssembly("MyCafe.Web"));
            });
            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IFirmRepository, FirmRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductUnitRepository, ProductUnitRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IInvoiceDetailRepository, IInvoiceDetailRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            return services;
        }
    }
}
