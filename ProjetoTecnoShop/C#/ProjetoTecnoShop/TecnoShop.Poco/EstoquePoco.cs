
namespace TecnoShop.Poco
{
    public class EstoquePoco
    {
        public int CodigoEstoque { get; set; }
        public int? CodigoLoja { get; set; }
        public int? CodigoProduto { get; set; }
        public int? Quantidade { get; set; }
        public bool Ativo { get; set; }
    }
}
