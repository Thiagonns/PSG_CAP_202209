
namespace ExameCAP.Poco
{
    public class PassageiroPoco
    {
        public int CodigoPassageiro { get; set; }
        public string Nome { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string NumeroCartao { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Telefone { get; set; } = null!;
        public DateTime DataNascimento { get; set; }
    }
}
