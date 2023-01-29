using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using techpaymentapi.Context;
using techpaymentapi.Models;

namespace techpaymentapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendedorController : ControllerBase
    {
        private readonly LojaVirtualContext _context;

        public VendedorController(LojaVirtualContext context)
        {
            _context = context;
        }


        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var vendedor = _context.Vendedores.Find(id);
            if (vendedor == null)
                return NotFound();

            return Ok(vendedor);
        }

        [HttpPost]
        public IActionResult Criar(Vendedor vendedor)
       // public IActionResult Criar(Facade.Venda.Request.CriarVenda venda)
        {
            _context.Vendedores.Add(vendedor);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = vendedor.IdVendedor }, vendedor);
        }

    }

}