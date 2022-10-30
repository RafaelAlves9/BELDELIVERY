using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Domain.Interfaces
{
    public interface IClientAddressRepositorie
    {
        Task<List<ClientAddress>> GetAll();
        Task<ClientAddress> GetById(int id);
        Task<ClientAddress> Create(ClientAddress user);
        Task<ClientAddress> Update(ClientAddress user, int id);
        Task<bool> Delete(int id);
    }
}
