using GameStore.Data;
using GameStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace GameStore.DataAccess.Implementations
{
    public class Repository<TEntity> : IRepository<IEntity>
    {
        protected readonly GameStoreDbContext context;

        public Repository(GameStoreDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEntity> AddAsync(IEntity entity)
        {
            await context.Set<IEntity>().AddAsync(entity);
            return entity;
        }

        public void Delete(IEntity entity)
        {
            context.Set<IEntity>().Remove(entity);
        }

        public async Task<IEntity> GetAsync(long id)
        {
            return await context.Set<IEntity>().FindAsync(id);
        }

        public void Update(IEntity entity)
        {
            context.Set<IEntity>().Update(entity);
        }
    }
}
