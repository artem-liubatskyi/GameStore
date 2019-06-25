using GameStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace GameStore.DataAccess.Implementations
{
    public class DeveloperRepository : Repository<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(DbContext context) : base(context)
        {
        }

        public Task<Developer> GetWithApps()
        {
            throw new NotImplementedException();
        }
    }
}
