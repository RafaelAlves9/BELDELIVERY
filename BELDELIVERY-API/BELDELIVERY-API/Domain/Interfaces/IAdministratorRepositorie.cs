using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Domain.Interfaces
{
    public interface IAdministratorRepositorie
    {
        Task<List<Administrator>> GetAll();
        Task<Administrator> Login(string email, string password);
        Task<Administrator> GetById(int id);
        Task<Administrator> Create(Administrator user);
        Task<Administrator> Update(Administrator user, int id);
        Task<bool> Delete(int id);
    }
}
