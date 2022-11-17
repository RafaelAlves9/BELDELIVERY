using Microsoft.EntityFrameworkCore;
using BELDELIVERY_API.Data;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Domain.Repositories
{
    public class ClientProfileRepositorie : IClientProfileRepositorie
    {
        private readonly BelDeliveryContext _belDelivery;

        public ClientProfileRepositorie(BelDeliveryContext belDelivery)
        {
            _belDelivery = belDelivery;
        }

        public async Task<bool> DeleteByClientId(int id)
        {
            ClientProfile CAddressById = await GetByIdClient(id);

            if (CAddressById == null)
            {
                throw new Exception("Usuário não encontrado");
            }

            _belDelivery.ClientProfile.Remove(CAddressById);
            await _belDelivery.SaveChangesAsync();

            return true;
        }
        public async Task<bool> Delete(int id)
        {
            ClientProfile CAddressById = await GetById(id);

            if (CAddressById == null)
            {
                throw new Exception("Usuário não encontrado");
            }

            _belDelivery.ClientProfile.Remove(CAddressById);
            await _belDelivery.SaveChangesAsync();

            return true;
        }

        public async Task<List<ClientProfile>> GetAll()
        {
            return await _belDelivery.ClientProfile.ToListAsync();
        }

        public async Task<ClientProfile> GetById(int id)
        {
            return await _belDelivery.ClientProfile.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ClientProfile> GetByIdClient(int id)
        {
            return await _belDelivery.ClientProfile.FirstOrDefaultAsync(x => x.IdClient == id);
        }

        public async Task<ClientProfile> Create(ClientProfile client)
        {
            await _belDelivery.ClientProfile.AddAsync(client);
            await _belDelivery.SaveChangesAsync();

            return client;
        }

        public async Task<ClientProfile> Update(ClientProfile client, int id)
        {
            ClientProfile ClientById = await GetById(id);

            ClientById = client;

            _belDelivery.ClientProfile.Update(ClientById);
            await _belDelivery.SaveChangesAsync();

            return ClientById;
        }
    }
}
