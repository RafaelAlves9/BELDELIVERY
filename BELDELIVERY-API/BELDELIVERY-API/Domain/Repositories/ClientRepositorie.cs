using Microsoft.EntityFrameworkCore;
using BELDELIVERY_API.Data;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Domain.Repositories
{
    public class ClientRepositorie : IClientRepositorie
    {
        private readonly BelDeliveryContext _belDelivery;
        private readonly IClientProfileRepositorie _profile;

        public ClientRepositorie(BelDeliveryContext belDelivery, IClientProfileRepositorie profile)
        {
            _belDelivery = belDelivery;
            _profile = profile;
        }

        public async Task<bool> Delete(int id)
        {
            Client ClientById = await GetById(id);

            if (ClientById == null)
            {
                throw new Exception("Usuário não encontrado");
            }

            _belDelivery.Client.Remove(ClientById);
            await _belDelivery.SaveChangesAsync();

            return true;
        }

        public async Task<List<Client>> GetAll()
        {
            return await _belDelivery.Client.ToListAsync();
        }
        public async Task<Client> Login(string email, string password)
        {
            Client clientByEmail = await _belDelivery.Client.FirstOrDefaultAsync(x => x.Email == email);
            Client clientByPassword = await _belDelivery.Client.FirstOrDefaultAsync(x => x.Password == password);

            if (clientByEmail != null && clientByPassword != null && clientByEmail == clientByPassword)
            {
                return clientByEmail;
            } else
            {
                throw new Exception("Usuário não encontrado");
            }
        }

        public async Task<Client> GetById(int id)
        {
            return await _belDelivery.Client.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Client> Create(Client client)
        {
            Client clientP = client;
            clientP.CreatedAt = DateTime.Now;
            clientP.TypeAccountAcess = 3;

            await _belDelivery.Client.AddAsync(clientP);
            await _belDelivery.SaveChangesAsync();

            return clientP;
        }

        public async Task<Client> Update(Client Client, int id)
        {
            Client ClientById = await GetById(id);

            ClientById = Client;

            _belDelivery.Client.Update(ClientById);
            await _belDelivery.SaveChangesAsync();

            return ClientById;
        }
    }
}