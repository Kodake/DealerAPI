using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.DTO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Core.Entities;

namespace Core.Services
{
    public class SellersService : ISellersService
    {
        private readonly ISellersRepository _sellersRepository;

        public SellersService(ISellersRepository sellersRepository)
        {
            _sellersRepository = sellersRepository;
        }

        /// <inheritdoc/>
        public async Task<List<SellerSalesDTO>> GetSellersSalesRanking()
        {
            return await _sellersRepository.GetSellersSalesRanking();
        }

        /// <inheritdoc/>
        public async Task SaveSeller(SellerDTO seller)
        {
            await _sellersRepository.SaveSeller(seller);
        }
    }
}
