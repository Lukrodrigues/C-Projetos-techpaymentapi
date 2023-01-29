
using techpaymentapi.Models.Enums;

namespace techpaymentapi.Models
{
    public class Venda : ModelBase
    {
      
            public int NumeroPedido { get; set; }
            public int IdVendedor { get; set; }
            public Vendedor Vendedor{ get; set; }
            public DateTime DataVenda { get; set; }
            public List<Item> Itens { get; set; }
            public EnumStatusVenda Status  { get; set; } = EnumStatusVenda.AguardandoPagamento;
        }
}
