using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
namespace GameStore.DataAccess.Configuration
{
    public static class DataAccessConfiguration
    {
        public static void RegisterDataAccessDependencies(this IServiceCollection collection)
        {
            collection.AddTransient<IUnitOfWork, IUnitOfWork>();
        }
    }
}
