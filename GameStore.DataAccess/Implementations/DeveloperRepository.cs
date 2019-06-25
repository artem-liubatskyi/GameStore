using GameStore.Data;
using GameStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace GameStore.DataAccess.Implementations
{
    public class DeveloperRepository : Repository<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(GameStoreDbContext context) : base(context)
        {
        }

        public async Task<Developer> GetWithApps(long id)
        {
            return await context.Developers.Where(x => x.Id == id).Include(x => x.Apps).FirstOrDefaultAsync();
        }
    }
}
