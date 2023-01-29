using techpaymentapi.Models;
using Microsoft.EntityFrameworkCore;

namespace techpaymentapi.Context
{
    public class LojaVirtualContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "LojaVirtualContext");
    }
        public LojaVirtualContext(DbContextOptions<LojaVirtualContext> options) : base(options){
            
        }

        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Venda> Vendas { get; set; }
       
        public DbContextOptions<LojaVirtualContext> Options { get; }
        public object VendasItems;
       
    }
}