using NetflixGang.Services;
using NetflixGang.Services.Interfaces;

namespace NetflixGang.Configuration
{
    public static class ConfigService
    {
        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            services.AddScoped<IBotService, BotService>();
            return services;
        }
    }
}
