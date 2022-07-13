using Core.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface ISellersRepository
    {
        /// <summary>
        /// Save the seller on Selle's table
        /// </summary>
        /// <param name="seller">Entity that contains the attibutes to save the selected entity</param>
        /// <returns></returns>
        Task SaveSeller(SellerDTO seller);

        /// <summary>
        /// Returns the all the Seller's sales ranking
        /// </summary>
        /// <returns></returns>
        Task<List<SellerSalesDTO>> GetSellersSalesRanking();
    }
}
