using Microsoft.Extensions.DependencyInjection;
using PostModule.Domain.IRepositories;
using PostModule.Infrastructure.Repositories;

namespace PostModule.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IStateRepository, StateRepository>();
            services.AddTransient<iCityRepository, CityRepository>();

            return services;
        }
    }
}
