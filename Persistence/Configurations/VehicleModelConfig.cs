using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class VehicleModelConfig : IEntityTypeConfiguration<VehicleModel>
    {
        public void Configure(EntityTypeBuilder<VehicleModel> builder)
        {
            builder.Property(prop => prop.Model).IsRequired().HasMaxLength(100);

            builder.Property(prop => prop.Brand).IsRequired().HasMaxLength(50);

            builder.Property(prop => prop.Year).IsRequired();

            builder.HasOne(p => p.Sale);
        }
    }
}
