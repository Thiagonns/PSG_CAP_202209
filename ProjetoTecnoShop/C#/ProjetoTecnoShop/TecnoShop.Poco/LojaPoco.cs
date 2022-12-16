
namespace TecnoShop.Poco
{
    public class LojaPoco
    {
        public int CodigoLoja { get; set; }
        public string LojaNome { get; set; } = null!;
        public string? Telefone { get; set; } = null!;
        public string? Email { get; set; } = null!;
        public int CodigoEndereco { get; set; }
        public bool Ativo { get; set; }
    }
}
