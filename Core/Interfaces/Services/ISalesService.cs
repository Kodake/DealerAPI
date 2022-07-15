using Core.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface ISalesService
    {
        /// <inheritdoc/>
        Task SaveSale(SaleDTO sale);

        /// <inheritdoc/>
        Task<List<SaleDetailsDTO>> GetSalesFromLastDay();
    }
}
