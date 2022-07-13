using Core.DTO;
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
    }
}
