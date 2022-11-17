using Microsoft.EntityFrameworkCore;
using BELDELIVERY_API.Data;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Domain.Repositories
{
    public class AdministratorRepositorie : IAdministratorRepositorie
    {
        private readonly BelDeliveryContext _belDelivery;

        public AdministratorRepositorie(BelDeliveryContext belDelivery)
        {
            _belDelivery = belDelivery;
        }

        public async Task<bool> Delete(int id)
        {
            Administrator AdminById = await GetById(id);

            if (AdminById == null)
            {
                throw new Exception("Usuário não encontrado");
            }

            _belDelivery.Administrator.Remove(AdminById);
            await _belDelivery.SaveChangesAsync();

            return true;
        }

        public async Task<List<Administrator>> GetAll()
        {
            return await _belDelivery.Administrator.ToListAsync();
        }
        public async Task<Administrator> Login(string email, string password)
        {
            Administrator adminByEmail =  await _belDelivery.Administrator.FirstOrDefaultAsync(x => x.Email == email);
            Administrator adminByPassword = await _belDelivery.Administrator.FirstOrDefaultAsync(x => x.Password == password);

            if (adminByEmail == null)
            {
                throw new Exception("Email não cadastrado");
            } 
            else if(adminByEmail == adminByPassword)
            {
                return adminByEmail;
            }
            else throw new Exception("Email ou senha incorretos");
        }


        public async Task<Administrator> GetById(int id)
        {
            return await _belDelivery.Administrator.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Administrator> Create(Administrator client)
        {
            await _belDelivery.Administrator.AddAsync(client);
            await _belDelivery.SaveChangesAsync();

            return client;
        }

        public async Task<Administrator> Update(Administrator admin, int id)
        {
            Administrator AdministratorById = await GetById(id);

            AdministratorById = admin;

            _belDelivery.Administrator.Update(AdministratorById);
            await _belDelivery.SaveChangesAsync();

            return AdministratorById;
        }
    }
}
