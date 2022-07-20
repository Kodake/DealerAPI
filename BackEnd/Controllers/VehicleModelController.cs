using BackEnd.Helpers;
using Core.DTO;
using Core.Interfaces.Services;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
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
        private IValidator<VehicleModelDTO> _validator;
        private readonly IVehicleModelsService _vehicleModelsService;
        
        // GET: api/<VehicleModelController>
        public VehicleModelController(IValidator<VehicleModelDTO> validator, IVehicleModelsService vehicleModelsService)
        {
            _validator = validator;
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

                ValidationResult result = await _validator.ValidateAsync(vehicleModel);

                if (!result.IsValid)
                {
                    return BadRequest(ValidatorErrorExtensions.GetValidatorErrors(result.Errors));
                }

                await _vehicleModelsService.SaveVehicleModel(vehicleModel);
                return Ok(new { message = "Se agregó el vehículo satisfactoriamente" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("save")]
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] VehicleModelDTO vehicleModel, IFormFile technicalDetails)
        {
            try
            {
                if (technicalDetails.Length == 0)
                {
                    return BadRequest("Please upload a file");
                }

                if (technicalDetails.ContentType != "application/json")
                {
                    return BadRequest("Please upload a json file");
                }

                byte[] details = await FormFileExtensions.GetBytesFromFile(technicalDetails);
                await _vehicleModelsService.SaveVehicleModelWithTechDetails(vehicleModel, details);

                return Ok(new { message = "Se agregó el vehículo satisfactoriamente" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("top-10")]
        [HttpGet]
        public async Task<IActionResult> GetTopTenVehicleModelSales()
        {
            try
            {
                var lastSales = await _vehicleModelsService.GetTopTenVehicleModelSales();

                return Ok(lastSales);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
