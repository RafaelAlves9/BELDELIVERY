using Microsoft.EntityFrameworkCore;
using BELDELIVERY_API.Data;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Domain.Repositories
{
    public class ProductRepositorie : IProductRepositorie
    {
        private readonly BelDeliveryContext _belDelivery;

        public ProductRepositorie(BelDeliveryContext belDelivery)
        {
            _belDelivery = belDelivery;
        }

        public async Task<bool> Delete(int id)
        {
            Product AdminById = await GetById(id);

            if (AdminById == null)
            {
                throw new Exception("Usuário não encontrado");
            }

            _belDelivery.Product.Remove(AdminById);
            await _belDelivery.SaveChangesAsync();

            return true;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _belDelivery.Product.ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await _belDelivery.Product.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Product> Create(Product Product)
        {
            await _belDelivery.Product.AddAsync(Product);
            await _belDelivery.SaveChangesAsync();

            return Product;
        }

        public async Task<Product> Update(Product Product, int id)
        {
            Product ProductById = await GetById(id);

            ProductById = Product;

            _belDelivery.Product.Update(ProductById);
            await _belDelivery.SaveChangesAsync();

            return ProductById;
        }
    }
}
