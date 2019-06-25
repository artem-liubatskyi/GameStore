using GameStore.Data;
using GameStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.DataAccess.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(GameStoreDbContext context) : base(context)
        {
        }

        public async Task<User> GetWithApps(long id)
        {
            return await context.Users.Where(x => x.Id == id).Include(x => x.Apps).FirstOrDefaultAsync();

        }
    }
}
