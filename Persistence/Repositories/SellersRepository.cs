using Core.Entities;
using Core.Interfaces.Repositories;
using Core.DTO;
using Persistence.Context;
using System.Threading.Tasks;

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
