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
    /// Sales repository with its mainly methods
    /// </summary>
    public sealed class SalesRepository : ISalesRepository
    {
        /// <summary>
        /// context prop
        /// </summary>
        private readonly AppDbContext _context;

        public SalesRepository(AppDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public async Task<List<Sale>> GetSalesFromLastDay()
        {
            return await _context.Sales.Where(x => x.SellDate > System.DateTime.Now.AddHours(-24))
                                                .ToListAsync();
        }

        /// <inheritdoc/>
        public async Task SaveSale(SaleDTO saleDTO)
        {
            Sale sale = new()
            {
                SellerId = saleDTO.SellerId,
                VehicleModelId = saleDTO.VehicleModelId,
                SellDate = saleDTO.SellDate
            };

            _context.Add(sale);
            await _context.SaveChangesAsync();
        }
    }
}
