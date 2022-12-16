
namespace TecnoShop.Poco
{
    public class ClientePoco
    {
        public int CodigoCliente { get; set; }
        public string PrimeiroNome { get; set; } = null!;
        public string Sobrenome { get; set; } = null!;
        public string? Telefone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int CodigoEndereco { get; set; }
        public bool Ativo { get; set; }
    }
}
