
namespace TecnoShop.Poco
{
    public class ProdutoPoco
    {
        public int CodigoProduto { get; set; }
        public string ProdutoNome { get; set; } = null!;
        public int CodigoMarca { get; set; }
        public int CodigoCategoria { get; set; }
        public int AnoModelo { get; set; }
        public Decimal PrecoListado { get; set; }
        public bool Ativo { get; set; }

    }
}
