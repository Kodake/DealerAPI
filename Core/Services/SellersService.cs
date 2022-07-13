using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.DTO;
using System.Threading.Tasks;

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
        public async Task SaveSeller(SellerDTO seller)
        {
            await _sellersRepository.SaveSeller(seller);
        }
    }
}
