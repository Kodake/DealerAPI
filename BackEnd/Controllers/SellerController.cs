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
    public class SellerController : ControllerBase
    {
        private readonly ISellersService _sellersService;

        // POST api/<SellerController>
        public SellerController(ISellersService sellersService)
        {
            _sellersService = sellersService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SellerDTO seller)
        {
            try
            {
                if (seller == null)
                {
                    return BadRequest();
                }

                await _sellersService.SaveSeller(seller);
                return Ok(new { message = "Se agregó el vendedor satisfactoriamente" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("sellers-ranking")]
        [HttpGet]
        public async Task<IActionResult> GetSellersSalesRanking()
        {
            try
            {
                var lastSales = await _sellersService.GetSellersSalesRanking();

                return Ok(lastSales);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
