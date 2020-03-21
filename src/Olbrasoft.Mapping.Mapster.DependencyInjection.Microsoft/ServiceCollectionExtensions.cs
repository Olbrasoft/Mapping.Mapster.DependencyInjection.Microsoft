using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Olbrasoft.Mapping.Mapster.DependencyInjection.Microsoft
{
    public static class ServiceCollectionExtensions
    {
        public static void AddProjection(this IServiceCollection services, params Assembly[] assemblies)
        {
            services.AddMapster(assemblies);

            services.AddScoped<IMapper, MapsterMapper>();
        }
    }
}