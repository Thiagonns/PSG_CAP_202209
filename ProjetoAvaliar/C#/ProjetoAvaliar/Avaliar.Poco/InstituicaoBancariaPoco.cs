
namespace Avaliar.Poco
{
    public class InstituicaoBancariaPoco
    {
        public int CodigoInstituicaoBancaria { get; set; }
        public int? CodigoBanco { get; set; }
        public string Descricao { get; set; } = null!;
        public string SiteWWW { get; set; } = null!;
        public DateTime? DataInclusao { get; set; }
        public bool? Ativo { get; set; }
    }
}