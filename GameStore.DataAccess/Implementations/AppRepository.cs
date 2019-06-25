using GameStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameStore.DataAccess.Implementations
{
    public class AppRepository : Repository<App>, IAppRepository
    {
        public AppRepository(DbContext context) : base(context)
        {
        }

        public Task<IEnumerable<App>> GetByCategory(long CategoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<App>> GetBySearchQuery(string query)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<App>> GetByType(long TypeId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<App>> GetTopDownloaded(int topSize = 50)
        {
            throw new NotImplementedException();
        }
    }
}
