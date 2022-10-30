using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Domain.Interfaces
{
    public interface IStoreProfileRepositorie
    {
        Task<List<StoreProfile>> GetAll();
        Task<StoreProfile> GetById(int id);
        Task<StoreProfile> Create(StoreProfile user);
        Task<StoreProfile> Update(StoreProfile user, int id);
        Task<bool> Delete(int id);
    }
}
