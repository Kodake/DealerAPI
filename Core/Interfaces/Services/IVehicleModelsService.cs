using Core.DTO;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface IVehicleModelsService
    {
        Task SaveVehicleModel(VehicleModelDTO vehicleModel);
    }
}
