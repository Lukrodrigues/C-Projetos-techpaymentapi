
using Microsoft.AspNetCore.Mvc;
using techpaymentapi.Context;
using techpaymentapi.Models;




namespace techpaymentapi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VendaItemController : ControllerBase
    {
        private readonly LojaVirtualContext _context;
        private Vendedor vendasitems;

        public VendaItemController(LojaVirtualContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var vendaItem = _context.Vendas.Where(x => x.Vendedor == vendasitems);
            //var vendaItem = _context.VendasItems.Where(x => x.Vendedor == vendasitems);
            if (vendaItem == null)
                return NotFound();

            return Ok(vendaItem);
        }

        [HttpPost]
        public IActionResult Criar(Venda venda)
        {
            object value = _context.Vendas.Add(venda);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = venda.Id }, vendasitems);
        }
    }
}