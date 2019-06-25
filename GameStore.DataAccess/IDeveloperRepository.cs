using GameStore.Data.Entities;
using System.Threading.Tasks;

namespace GameStore.DataAccess
{
    public interface IDeveloperRepository
    {
        Task<Developer> GetWithApps();
    }
}
