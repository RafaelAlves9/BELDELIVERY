using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Domain.Interfaces
{
    public interface IClientProfileRepositorie
    {
        Task<List<ClientProfile>> GetAll();
        Task<ClientProfile> GetById(int id);
        Task<ClientProfile> GetByIdClient(int id);
        Task<ClientProfile> Create(ClientProfile user);
        Task<ClientProfile> Update(ClientProfile user, int id);
        Task<bool> DeleteByClientId(int id);
        Task<bool> Delete(int id);
    }
}
