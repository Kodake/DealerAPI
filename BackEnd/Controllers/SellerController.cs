using BackEnd.Helpers;
using Core.DTO;
using Core.Interfaces.Services;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private IValidator<SellerDTO> _validator;
        private readonly ISellersService _sellersService;

        // POST api/<SellerController>
        public SellerController(IValidator<SellerDTO> validator, ISellersService sellersService)
        {
            _validator = validator;
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

                ValidationResult result = await _validator.ValidateAsync(seller);

                if (!result.IsValid)
                {
                    return BadRequest(ValidatorErrorExtensions.GetValidatorErrors(result.Errors));
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
