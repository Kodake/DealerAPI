using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class SellerConfig : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.Property(prop => prop.FirstName).IsRequired().HasMaxLength(100);

            builder.Property(prop => prop.LastName).IsRequired().HasMaxLength(50);

            builder.Property(prop => prop.IdentificationNumber).IsRequired().HasMaxLength(20);

            builder.HasIndex(u => u.IdentificationNumber).IsUnique();

            builder.HasOne(p => p.Sale);
        }
    }
}
