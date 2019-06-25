using GameStore.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DataAccess.Implementations
{
    class UnitOfWork : IUnitOfWork
    {
        private GameStoreDbContext context;
        private IAppRepository appRepository;

        public UnitOfWork(GameStoreDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IAppRepository AppRepository {
            get {
                if (appRepository == null)
                    appRepository = new AppRepository(context);
                return appRepository;
            }
        }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
