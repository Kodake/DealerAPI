using Core.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface ISellersService
    {
        /// <inheritdoc/>
        Task SaveSeller(SellerDTO seller);

        /// <inheritdoc/>
        Task<List<SellerSalesDTO>> GetSellersSalesRanking();
    }
}
