using GreenBox.Business.Interfaces;
using GreenBox.Business.Notificacoes;
using GreenBox.Business.Services;
using GreenBox.Data.Contexts;
using GreenBox.Data.Repositories;

namespace GreenBox.WebApi.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<GreenBoxDbContext>();
            services.AddScoped<INotificador, Notificador>();

            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
            services.AddScoped<IColaboradorService, ColaboradorService>();

            return services;
        }
    }
}
