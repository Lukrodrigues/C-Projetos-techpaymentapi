
namespace techpaymentapi.Models
{
    public class Vendedor : ModelBase
    {
        public int IdVendedor { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Vendedor()
        {

        }
        public Vendedor(string nome, string cpf, string email, string telefone)
        {
            CheckCpf verificadorCpf = new CheckCpf();
            var cpfEhValido = verificadorCpf.validaCPF(cpf);

            if (cpfEhValido == true)
            {
                this.Nome = nome;
                this.Cpf = cpf;
                this.Email = email;
                this.Telefone = telefone;
            }
            else if (cpfEhValido == false)
            {
                throw new ArgumentException("CPF incorreto");
            }
        }

    

        public Vendedor(int idVendedor, string cpf, string telefone)
        {
            this.IdVendedor = idVendedor;
            this.Cpf = cpf;
            this.Telefone = telefone;

        }
    }
}