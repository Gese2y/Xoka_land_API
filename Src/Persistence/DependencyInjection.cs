using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using XOKA.Domain.Interfaces;
using XOKA.Persistence;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<XOKADbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("XOKADatabase")));

            services.AddScoped<IXOKADbContext>(provider => provider.GetService<XOKADbContext>());

            return services;
        }

        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddTransient<ISprocRepository, SprocRepository>();
            services.AddTransient<IProcedureAdabter, ProcedureAdabter>();

            return services;
        }
    }
}
