using Microsoft.EntityFrameworkCore;
using BELDELIVERY_API.Data.Mapping;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Data
{
    public class BelDeliveryContext : DbContext
    {
        public BelDeliveryContext(DbContextOptions<BelDeliveryContext> options) : base(options)
        {
        }

        public DbSet<Store> Store { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<StoreAddress> StoreAddress { get; set; }
        public DbSet<ClientAddress> ClientAddress { get; set; }
        public DbSet<StoreProfile> StoreProfile { get; set; }
        public DbSet<ClientProfile> ClientProfile { get; set; }
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StoreMapping());
            modelBuilder.ApplyConfiguration(new ClientMapping());
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new StoreProfileMapping());
            modelBuilder.ApplyConfiguration(new StoreAddressMapping());
            modelBuilder.ApplyConfiguration(new ClientAddressMapping());
            modelBuilder.ApplyConfiguration(new AdministratorMapping());
            modelBuilder.ApplyConfiguration(new ClientProfileMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
