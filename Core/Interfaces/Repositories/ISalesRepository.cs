using Core.DTO;
using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface ISalesRepository
    {
        /// <summary>
        /// Save the sale on Sales table
        /// </summary>
        /// <param name="sale">Entity that contains the attibutes to save the selected entity</param>
        /// <returns></returns>
        Task SaveSale(SaleDTO sale);

        /// <summary>
        /// Returns the all the sales for the last 24 hours
        /// </summary>
        /// <returns></returns>
        Task<List<Sale>> GetSalesFromLastDay();
    }
}
