using GameStore.Data;
using GameStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace GameStore.DataAccess.Implementations
{
    public class AppRepository : Repository<App>, IAppRepository
    {
        public AppRepository(GameStoreDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<App>> GetByCategory(long CategoryId)
        {
            return await context.Apps.Include(p => p.Categories)
                .Where(x => x.Categories.FirstOrDefault(c=>c.CategorieId==CategoryId)!=null)
                .AsNoTracking()
                .ToArrayAsync();
        }

        public async Task<IEnumerable<App>> GetBySearchQuery(string query)
        {
            return await context.Apps.Where(x => x.Name == query).ToArrayAsync();
        }

        public async Task<IEnumerable<App>> GetByType(long TypeId)
        {
            return await context.Apps.Where(x => x.TypeId == TypeId).ToArrayAsync();
        }

        public async Task<IEnumerable<App>> GetTopDownloaded(int topSize = 50)
        {
            return await context.Apps.OrderByDescending(x => x.DownloadCount).Take(topSize).ToArrayAsync();
        }
    }
}
