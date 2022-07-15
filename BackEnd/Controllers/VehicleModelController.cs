using Core.DTO;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

                byte[] details = await GetBytesFromFile(technicalDetails);
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

        private static async Task<byte[]> GetBytesFromFile(IFormFile technicalDetails)
        {
            await using var memoryStream = new MemoryStream();
            await technicalDetails.CopyToAsync(memoryStream);
            return memoryStream.ToArray();
        }
    }
}
