using GameStore.DataAccess.Configuration;
using GameStore.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;
namespace GameStore.Services.Configuration
{
    public static class ServicesConfiguration
    {
        public static void RegisterServicesDependencies(this IServiceCollection collection)
        {
            collection.RegisterDataAccessDependencies();

            collection.AddTransient<IAppService, AppService>();
        }
    }
}
