using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Data.Mapping
{
    public class ClientMapping : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Document).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.TypeAccountAcess).IsRequired();
        }
    }
}
