using Microsoft.EntityFrameworkCore;
using BELDELIVERY_API.Data;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Domain.Repositories
{
    public class StoreAddressRepositorie : IStoreAddressRepositorie
    {
        private readonly BelDeliveryContext _belDelivery;

        public StoreAddressRepositorie(BelDeliveryContext belDelivery)
        {
            _belDelivery = belDelivery;
        }

        public async Task<bool> Delete(int id)
        {
            StoreAddress StoreAddressById = await GetById(id);

            if (StoreAddressById == null)
            {
                throw new Exception("Usuário não encontrado");
            }

            _belDelivery.StoreAddress.Remove(StoreAddressById);
            await _belDelivery.SaveChangesAsync();

            return true;
        }

        public async Task<List<StoreAddress>> GetAll()
        {
            return await _belDelivery.StoreAddress.ToListAsync();
        }

        public async Task<StoreAddress> GetById(int id)
        {
            return await _belDelivery.StoreAddress.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<StoreAddress> Create(StoreAddress StoreAddress)
        {
            await _belDelivery.StoreAddress.AddAsync(StoreAddress);
            await _belDelivery.SaveChangesAsync();

            return StoreAddress;
        }

        public async Task<StoreAddress> Update(StoreAddress StoreAddress, int id)
        {
            StoreAddress StoreAddressById = await GetById(id);

            StoreAddressById = StoreAddress;

            _belDelivery.StoreAddress.Update(StoreAddressById);
            await _belDelivery.SaveChangesAsync();

            return StoreAddressById;
        }
    }
}
