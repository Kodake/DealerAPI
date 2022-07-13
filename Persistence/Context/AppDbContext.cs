using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //Applying config for entities
            //modelBuilder.ApplyConfiguration(new Seller());
            //modelBuilder.ApplyConfiguration(new VehicleModel());
            //modelBuilder.ApplyConfiguration(new Sale());
        }

        #region DbSets
        public DbSet<Sale> Sales { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        #endregion
    }
}
