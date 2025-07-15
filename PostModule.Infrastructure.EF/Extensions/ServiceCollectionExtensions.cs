using Microsoft.Extensions.DependencyInjection;
using PostModule.Application.Queries.State;
using PostModule.Domain.IRepositories;
using PostModule.Infrastructure.Queries.State;
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

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IStateQueryService, StateQueryService>();
            return services;
        }
    }
}
