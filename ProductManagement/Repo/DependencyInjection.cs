using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repo.Interface;
using Repo.Mappers;
using Repo.Models;
using Repo.Repository;

namespace Repo
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfractstructure(this IServiceCollection services, IConfiguration config)
        {
            //add DJ
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(typeof(MapperConfigs).Assembly);
            //Add DB local
            services.AddDbContext<FstoreDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("ProductManagement"), options => options.EnableRetryOnFailure()));


            return services;

            //add automapper
            
        }
    }
}
