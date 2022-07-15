using Core.DTO;
using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    public class SalesService : ISalesService
    {
        private readonly ISalesRepository _salesRepository;

        public SalesService(ISalesRepository salesRepository)
        {
            _salesRepository = salesRepository;
        }

        /// <inheritdoc/>
        public async Task<List<SaleDetailsDTO>> GetSalesFromLastDay()
        {
            return await _salesRepository.GetSalesFromLastDay();
        }

        /// <inheritdoc/>
        public async Task SaveSale(SaleDTO sale)
        {
            await _salesRepository.SaveSale(sale);
        }
    }
}
