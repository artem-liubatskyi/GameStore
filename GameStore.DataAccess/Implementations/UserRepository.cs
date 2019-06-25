using GameStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace GameStore.DataAccess.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }

        public Task<User> GetWithApps(long id)
        {
            throw new NotImplementedException();
        }
    }
}
