using Microsoft.Extensions.DependencyInjection;

namespace Piranha.Murmur.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMurmurDomain(
            this IServiceCollection services)
        {
            return services.AddSingleton<IMurmurDomain, MurmurDomain>();
        }
    }
}