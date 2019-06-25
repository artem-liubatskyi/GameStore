using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DataAccess
{
    public interface IUnitOfWork
    {

        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        Task<int> SaveChangesAsync();
    }
}
