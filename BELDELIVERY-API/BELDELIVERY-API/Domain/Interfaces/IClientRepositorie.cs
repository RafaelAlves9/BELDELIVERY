using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Domain.Interfaces
{
    public interface IClientRepositorie
    {
        Task<List<Client>> GetAll();
        Task<Client> GetById(int id);
        Task<Client> Create(Client user);
        Task<Client> Update(Client user, int id);
        Task<bool> Delete(int id);
    }
}
