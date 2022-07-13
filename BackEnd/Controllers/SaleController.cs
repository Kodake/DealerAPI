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
    public class SaleController : ControllerBase
    {
        private readonly ISalesService _salessService;

        public SaleController(ISalesService salessService)
        {
            _salessService = salessService;
        }

        // POST api/<SaleController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SaleDTO sale)
        {
            try
            {
                if (sale == null)
                {
                    return BadRequest();
                }

                await _salessService.SaveSale(sale);
                return Ok(new { message = "Se agregó la venta satisfactoriamente" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("GetSalesFromLastDay")]
        [HttpGet]
        public async Task<IActionResult> GetSalesFromLastDay()
        {
            try
            {
                var lastSales = await _salessService.GetSalesFromLastDay();
                return Ok(lastSales);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
