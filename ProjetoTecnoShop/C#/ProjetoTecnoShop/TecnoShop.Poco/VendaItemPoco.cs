
namespace TecnoShop.Poco
{
    public class VendaItemPoco
    {
        public int CodigoVendaItem { get; set; }
        public int CodigoVenda { get; set; }
        public int CodigoItem { get; set; }
        public int CodigoProduto { get; set; }
        public int Quantidade { get; set; }
        public Decimal PrecoListado { get; set; }
        public Decimal Desconto { get; set; }
        public bool Ativo { get; set; }
    }
}
