using Core.DTO;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface IVehicleModelsService
    {
        /// <inheritdoc/>
        Task SaveVehicleModel(VehicleModelDTO vehicleModel);
    }
}
