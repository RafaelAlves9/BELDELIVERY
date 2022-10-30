using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Data.Mapping
{
    public class StoreAddressMapping : IEntityTypeConfiguration<StoreAddress>
    {
        public void Configure(EntityTypeBuilder<StoreAddress> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdStore).IsRequired();
            builder.Property(x => x.Cep).IsRequired();
            builder.Property(x => x.State).IsRequired();
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.Distrity).IsRequired();
            builder.Property(x => x.Street).IsRequired();
            builder.Property(x => x.Number).IsRequired();
            builder.Property(x => x.MainAddress).IsRequired();
        }
    }
}
