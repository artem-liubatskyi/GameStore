using GameStore.DataAccess.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace GameStore.Services.Configuration
{
    public static class ServicesConfiguration
    {
        public static void RegisterServicesDependencies(this IServiceCollection collection)
        {
            collection.RegisterDataAccessDependencies();

        }
    }
}
