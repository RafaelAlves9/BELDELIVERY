using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Data.Mapping
{
    public class StoreMapping : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Document).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.TypeAccountAcess).IsRequired();
            builder.Property(x => x.TypeStore).IsRequired();
            builder.Property(x => x.UrlName).IsRequired();
        }
    }
}
