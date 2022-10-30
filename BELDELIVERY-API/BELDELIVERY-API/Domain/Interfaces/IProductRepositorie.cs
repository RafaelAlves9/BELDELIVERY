using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Domain.Interfaces
{
    public interface IProductRepositorie
    {
        Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<Product> Create(Product user);
        Task<Product> Update(Product user, int id);
        Task<bool> Delete(int id);
    }
}
