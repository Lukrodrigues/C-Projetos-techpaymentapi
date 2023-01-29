

namespace techpaymentapi.Models
{
    public class Item : ModelBase
    {
        public int ItemId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public int VendaID { get; set; }

        public Item(string nome)
        {
            Nome = nome;
        }
    }
}