using Core.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface IVehicleModelsService
    {
        /// <inheritdoc/>
        Task SaveVehicleModel(VehicleModelDTO vehicleModel);

        /// <inheritdoc/>
        Task<List<VehicleModelSalesDTO>> GetTopTenVehicleModelSales();
    }
}
