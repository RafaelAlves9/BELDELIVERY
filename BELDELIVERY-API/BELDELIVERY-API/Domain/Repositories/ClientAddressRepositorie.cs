using Microsoft.EntityFrameworkCore;
using BELDELIVERY_API.Data;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Domain.Repositories
{
    public class ClientAddressRepositorie : IClientAddressRepositorie
    {
        private readonly BelDeliveryContext _belDelivery;

        public ClientAddressRepositorie(BelDeliveryContext belDelivery)
        {
            _belDelivery = belDelivery;
        }

        public async Task<bool> Delete(int id)
        {
            ClientAddress CAddressById = await GetById(id);

            if (CAddressById == null)
            {
                throw new Exception("Usuário não encontrado");
            }

            _belDelivery.ClientAddress.Remove(CAddressById);
            await _belDelivery.SaveChangesAsync();

            return true;
        }

        public async Task<List<ClientAddress>> GetAll()
        {
            return await _belDelivery.ClientAddress.ToListAsync();
        }

        public async Task<ClientAddress> GetById(int id)
        {
            return await _belDelivery.ClientAddress.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ClientAddress> Create(ClientAddress client)
        {
            await _belDelivery.ClientAddress.AddAsync(client);
            await _belDelivery.SaveChangesAsync();

            return client;
        }

        public async Task<ClientAddress> Update(ClientAddress client, int id)
        {
            ClientAddress ClientById = await GetById(id);

            ClientById = client;

            _belDelivery.ClientAddress.Update(ClientById);
            await _belDelivery.SaveChangesAsync();

            return ClientById;
        }
    }
}
