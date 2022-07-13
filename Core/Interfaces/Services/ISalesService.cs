using Core.DTO;
using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface ISalesService
    {
        Task SaveSale(SaleDTO sale);

        Task<List<Sale>> GetSalesFromLastDay();
    }
}
