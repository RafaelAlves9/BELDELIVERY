using Microsoft.EntityFrameworkCore;
using BELDELIVERY_API.Data;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Domain.Repositories
{
    public class StoreRepositorie : IStoreRepositorie
    {
        private readonly BelDeliveryContext _belDelivery;

        public StoreRepositorie(BelDeliveryContext belDelivery)
        {
            _belDelivery = belDelivery;
        }

        public async Task<bool> Delete(int id)
        {
            Store storeById = await GetById(id);

            if (storeById == null)
            {
                throw new Exception("Usuário não encontrado");
            }

            _belDelivery.Store.Remove(storeById);
            await _belDelivery.SaveChangesAsync();

            return true;
        }

        public async Task<List<Store>> GetAll()
        {
            return await _belDelivery.Store.ToListAsync();
        }

        public async Task<Store> GetById(int id)
        {
            return await _belDelivery.Store.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Store> Create(Store store)
        {
            Store storeP = store;
            storeP.CreatedAt = DateTime.Now;
            storeP.TypeAccountAcess = 2;

            await _belDelivery.Store.AddAsync(storeP);
            await _belDelivery.SaveChangesAsync();

            return storeP;
        }

        public async Task<Store> Update(Store store, int id)
        {
            Store StoreProfileById = await GetById(id);

            StoreProfileById = store;

            _belDelivery.Store.Update(StoreProfileById);
            await _belDelivery.SaveChangesAsync();

            return StoreProfileById;
        }
    }
}
