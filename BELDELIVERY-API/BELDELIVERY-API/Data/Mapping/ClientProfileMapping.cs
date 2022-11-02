using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Data.Mapping
{
    public class ClientProfileMapping : IEntityTypeConfiguration<ClientProfile>
    {
        public void Configure(EntityTypeBuilder<ClientProfile> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdClient).IsRequired();
            builder.Property(x => x.Orders).IsRequired();
            builder.Property(x => x.TittleStatus).IsRequired(false);
            builder.Property(x => x.Document).IsRequired(false);
            builder.Property(x => x.CellPhone).IsRequired(false);
            builder.Property(x => x.TellPhone).IsRequired(false);
            builder.Property(x => x.UpdateAt).IsRequired();
        }
    }
}
