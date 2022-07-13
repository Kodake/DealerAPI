using Core.DTO;
using Core.Entities;
using Core.Interfaces.Repositories;
using Persistence.Context;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    /// <summary>
    /// Vehicle models repository with its mainly methods
    /// </summary>
    public sealed class VehicleModelsRepository : IVehicleModelsRepository
    {
        /// <summary>
        /// context prop
        /// </summary>
        private readonly AppDbContext _context;

        public VehicleModelsRepository(AppDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public async Task SaveVehicleModel(VehicleModelDTO vehicleModelDTO)
        {
            VehicleModel vehicleModel = new()
            {
                Brand = vehicleModelDTO.Brand,
                Model = vehicleModelDTO.Model,
                Year = vehicleModelDTO.Year,
                TechnicalDetails = vehicleModelDTO.TechnicalDetails
            };

            _context.Add(vehicleModel);
            await _context.SaveChangesAsync();
        }
    }
}
