using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Data.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdStore).IsRequired();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.CreateAt).IsRequired();
            builder.Property(x => x.Ingredients).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.UpdateAt).IsRequired();
            builder.Property(x => x.TypeProduct).IsRequired();
        }
    }
}
