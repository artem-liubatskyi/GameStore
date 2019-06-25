using GameStore.Data;
using System.Threading.Tasks;

namespace GameStore.DataAccess
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        Task<TEntity> GetAsync(long id);
        Task<TEntity> AddAsync(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
