using Microsoft.Extensions.DependencyInjection;
using Pinjet.Application.Services;
using Pinjet.Application.Interface;

namespace Pinjet.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IWelcomeService, WelcomeService>();
            return services;
        }
    }
}
