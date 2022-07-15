using Core.DTO;
using Core.Entities;
using Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<List<VehicleModelSalesDTO>> GetTopTenVehicleModelSales()
        {
            List<VehicleModel> sales = await _context.VehicleModels
                .Include("Sales.Seller")
                .ToListAsync();

            List<VehicleModelSalesDTO> totalSales = sales.Take(10).Select(p => new VehicleModelSalesDTO
            {
                Brand = p.Brand,
                Model = p.Model,
                Year = p.Year,
                TotalSales = p.Sales.Count()
            })
            .ToList();

            var top10 = totalSales;
            top10.OrderBy(p => p.TotalSales).ToList();

            return totalSales;
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
