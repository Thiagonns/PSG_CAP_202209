
namespace TecnoShop.Poco
{
    public class FuncionarioPoco
    {
        public int CodigoFuncionario { get; set; }
        public string PrimeiroNome { get; set; } = null!;
        public string Sobrenome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Telefone { get; set; } = null!;
        public bool Ativo { get; set; }
        public int CodigoLoja { get; set; }
        public int CodigoGerente { get; set; }
    }
}
