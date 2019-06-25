using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GameStore.Data.Entities;
using GameStore.DataAccess;

namespace GameStore.Services.Implementations
{
    class AppService : IAppService
    {
        private readonly IUnitOfWork uow;

        public AppService(IUnitOfWork uow)
        {
            this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
        }

        public async Task<App> Get(long id)
        {
            return await uow.AppRepository.GetAsync(id);
        }

        public async Task<IEnumerable<App>> GetByCategory(long CategoryId)
        {
            return await uow.AppRepository.GetByCategory(CategoryId);
        }

        public async Task<IEnumerable<App>> GetBySearchQuery(string searchQuery)
        {
            return await uow.AppRepository.GetBySearchQuery(searchQuery);
        }

        public async Task<IEnumerable<App>> GetByType(long TypeId)
        {
            return await uow.AppRepository.GetByType(TypeId);
        }

        public async Task<IEnumerable<App>> GetTopDownloaded(int topSize = 50)
        {
            return await uow.AppRepository.GetTopDownloaded(topSize);
        }
    }
}
