using Core.DTO;
using Core.Entities;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TransactionController(AppDbContext context)
        {
            _context = context;
        }

        // POST api/<TransactionController>
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                var factura = new Factura()
                {
                    FechaCreacion = DateTime.Now
                };

                _context.Add(factura);
                await _context.SaveChangesAsync();

                //throw new ApplicationException("Esto es una prueba");

                var facturaDetalle = new List<FacturaDetalle>()
                {
                    new FacturaDetalle()
                    {
                        Producto = "Producto A",
                        Precio = 123,
                        FacturaId = factura.Id
                    },
                    new FacturaDetalle()
                    {
                        Producto = "Producto B",
                        Precio = 456,
                        FacturaId = factura.Id
                    },
                };

                _context.AddRange(facturaDetalle);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return Ok("Transaction completed successfully");
            }
            catch (Exception ex)
            {
                return BadRequest("Hubo un error " + ex.Message);
            }
        }
    }
}
