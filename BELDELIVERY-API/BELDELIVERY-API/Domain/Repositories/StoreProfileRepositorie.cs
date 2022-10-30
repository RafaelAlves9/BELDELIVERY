using Microsoft.EntityFrameworkCore;
using BELDELIVERY_API.Data;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Domain.Repositories
{
    public class StoreProfileRepositorie : IStoreProfileRepositorie
    {
        private readonly BelDeliveryContext _belDelivery;

        public StoreProfileRepositorie(BelDeliveryContext belDelivery)
        {
            _belDelivery = belDelivery;
        }

        public async Task<bool> Delete(int id)
        {
            StoreProfile StoreProfileById = await GetById(id);

            if (StoreProfileById == null)
            {
                throw new Exception("Usuário não encontrado");
            }

            _belDelivery.StoreProfile.Remove(StoreProfileById);
            await _belDelivery.SaveChangesAsync();

            return true;
        }

        public async Task<List<StoreProfile>> GetAll()
        {
            return await _belDelivery.StoreProfile.ToListAsync();
        }

        public async Task<StoreProfile> GetById(int id)
        {
            return await _belDelivery.StoreProfile.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<StoreProfile> Create(StoreProfile StoreAddress)
        {
            await _belDelivery.StoreProfile.AddAsync(StoreAddress);
            await _belDelivery.SaveChangesAsync();

            return StoreAddress;
        }

        public async Task<StoreProfile> Update(StoreProfile StoreProfile, int id)
        {
            StoreProfile StoreProfileById = await GetById(id);

            StoreProfileById = StoreProfile;

            _belDelivery.StoreProfile.Update(StoreProfileById);
            await _belDelivery.SaveChangesAsync();

            return StoreProfileById;
        }
    }
}
