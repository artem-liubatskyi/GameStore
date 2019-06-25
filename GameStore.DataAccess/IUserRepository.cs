using GameStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DataAccess
{
    public interface IUserRepository
    {
        Task<User> GetWithApps(long id);
    }
}
