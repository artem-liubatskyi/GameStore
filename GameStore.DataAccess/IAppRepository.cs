using GameStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DataAccess
{
    public interface IAppRepository
    {
        Task<IEnumerable<App>> GetByCategory(long CategoryId);
        Task<IEnumerable<App>> GetBySearchQuery(string query);
        Task<IEnumerable<App>> GetByType(long TypeId);
        Task<IEnumerable<App>> GetTopDownloaded(int topSize = 50);

    }
}
