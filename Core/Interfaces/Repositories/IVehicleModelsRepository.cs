using Core.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface IVehicleModelsRepository
    {
        /// <summary>
        /// Save the vehicleModel on VehicleModel's table
        /// </summary>
        /// <param name="vehicleModel">Entity that contains the attibutes to save the selected entity</param>
        /// <returns></returns>
        Task SaveVehicleModel(VehicleModelDTO vehicleModel);

        /// <summary>
        /// Returns the all the Seller's sales ranking
        /// </summary>
        /// <returns></returns>
        Task<List<VehicleModelSalesDTO>> GetTopTenVehicleModelSales();

        /// <summary>
        /// Save technical details for some specific vehicle
        /// </summary>
        /// <returns></returns>
        Task SaveVehicleModelWithTechDetails(VehicleModelDTO vehicleModel, byte[] details);
    }
}
