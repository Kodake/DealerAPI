using Core.DTO;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface ISellersService
    {
        Task SaveSeller(SellerDTO seller);
    }
}
