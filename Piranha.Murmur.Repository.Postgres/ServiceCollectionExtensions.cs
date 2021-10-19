using Microsoft.Extensions.DependencyInjection;

namespace Piranha.Murmur.Repository.Postgres
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPostgresMurmurRepository(
            this IServiceCollection services)
        {
            return services.AddSingleton<IMurmurRepository, PostgresMurmurRepository>();
        }
    }
}