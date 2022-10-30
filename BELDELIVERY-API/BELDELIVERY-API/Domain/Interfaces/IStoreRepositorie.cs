using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Domain.Interfaces
{
    public interface IStoreRepositorie
    {
        Task<List<Store>> GetAll();
        Task<Store> GetById(int id);
        Task<Store> Create(Store user);
        Task<Store> Update(Store user, int id);
        Task<bool> Delete(int id);
    }
}
