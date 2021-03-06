using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class SaleConfig : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            //builder.HasOne(s => s.Seller).WithMany().HasForeignKey(x => x.SellerId);

            builder.HasOne(e => e.Seller).WithMany(c => c.Sales);

            builder.HasOne(e => e.VehicleModel).WithMany(c => c.Sales);

            //builder.HasOne(s => s.VehicleModel).WithMany().HasForeignKey(x => x.VehicleModelId);
        }
    }
}
