using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Domain.Interfaces
{
    public interface IStoreAddressRepositorie
    {
        Task<List<StoreAddress>> GetAll();
        Task<StoreAddress> GetById(int id);
        Task<StoreAddress> Create(StoreAddress user);
        Task<StoreAddress> Update(StoreAddress user, int id);
        Task<bool> Delete(int id);
    }
}
