using Core.DTO;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleModelController : ControllerBase
    {
        private readonly IVehicleModelsService _vehicleModelsService;
        
        // GET: api/<VehicleModelController>
        public VehicleModelController(IVehicleModelsService vehicleModelsService)
        {
            _vehicleModelsService = vehicleModelsService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] VehicleModelDTO vehicleModel)
        {
            try
            {
                if (vehicleModel == null)
                {
                    return BadRequest();
                }

                await _vehicleModelsService.SaveVehicleModel(vehicleModel);
                return Ok(new { message = "Se agregó el vehículo satisfactoriamente" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
