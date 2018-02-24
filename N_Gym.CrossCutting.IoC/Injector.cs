using Microsoft.Extensions.DependencyInjection;
using N_Base.Data.Infra;
using N_Gym.Data.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Diagnostics;
using AutoMapper;

namespace N_Gym.CrossCutting.IoC
{
    public class Injector
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContextBase>(options =>
               options.UseSqlServer(configuration.GetConnectionString("N_Base_DataBase"),
               b => b.MigrationsAssembly("N_Base_Application"))
               .ConfigureWarnings(warnings => warnings.Throw(CoreEventId.IncludeIgnoredWarning)));
            services.AddDbContext<ContextGym>(options =>
               options.UseSqlServer(configuration.GetConnectionString("N_Gym_DataBase"),
               b => b.MigrationsAssembly("N_Gym_Application"))
               .ConfigureWarnings(warnings => warnings.Throw(CoreEventId.IncludeIgnoredWarning)));
            // services.AddScoped<ICustomerAppService, CustomerAppService>();
        }
    }
}