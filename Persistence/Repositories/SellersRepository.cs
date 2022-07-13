using Core.Entities;
using Core.Interfaces.Repositories;
using Core.DTO;
using Persistence.Context;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Persistence.Repositories
{
    /// <summary>
    /// Sellers repository with its mainly methods
    /// </summary>
    public sealed class SellersRepository : ISellersRepository
    {
        /// <summary>
        /// context prop
        /// </summary>
        private readonly AppDbContext _context;

        public SellersRepository(AppDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public async Task<List<SellerSalesDTO>> GetSellersSalesRanking()
        {
            var sales = await _context.Sellers
                .Include("Sales")
                .ToListAsync();

            var totalSales = sales.Select(p => new SellerSalesDTO
            {
                FirstName = p.FirstName,
                LastName = p.LastName,
                IdentificationNumber = p.IdentificationNumber,
                TotalSales = p.Sales.Count
            }).OrderByDescending(x => x.TotalSales).ToList();

            return totalSales;
        }

        /// <inheritdoc/>
        public async Task SaveSeller(SellerDTO sellerDTO)
        {
            Seller seller = new()
            {
                FirstName = sellerDTO.FirstName,
                LastName = sellerDTO.LastName,
                IdentificationNumber = sellerDTO.IdentificationNumber
            };

            _context.Add(seller);
            await _context.SaveChangesAsync();
        }
    }
}
