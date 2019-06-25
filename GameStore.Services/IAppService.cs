using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Services
{
    public interface IAppService
    {
        Task<IEnumerable<App>> Get(long id);
        Task<IEnumerable<App>> GetByCategory(long CategoryId);
        Task<IEnumerable<App>> GetByType(long TypeId);
        Task<IEnumerable<App>> GetBySearchQuery(string searchQuery);
        Task<IEnumerable<App>> GetTopDownloaded(int topSize = 50);
    }
}
