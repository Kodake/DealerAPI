using Core.DTO;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using System.Threading.Tasks;

namespace Core.Services
{
    public class VehicleModelsService : IVehicleModelsService
    {
        private readonly IVehicleModelsRepository _vehicleModelsRepository;

        public VehicleModelsService(IVehicleModelsRepository vehicleModelsRepository)
        {
            _vehicleModelsRepository = vehicleModelsRepository;
        }

        /// <inheritdoc/>
        public async Task SaveVehicleModel(VehicleModelDTO vehicleModel)
        {
            await _vehicleModelsRepository.SaveVehicleModel(vehicleModel);
        }
    }
}
