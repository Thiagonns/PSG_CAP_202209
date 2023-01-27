using Avaliar.Poco;

namespace Avaliar.Envelope.Modelo
{
    public class InstituicaoBancariaEnvelope : BaseEnvelope
    {
        public int CodigoInstituicaoBancaria { get; set; }
        public int? CodigoBanco { get; set; }
        public string Descricao { get; set; } = null!;
        public string SiteWWW { get; set; } = null!;
        public DateTime? DataInclusao { get; set; }
        public bool? Ativo { get; set; }

        public InstituicaoBancariaEnvelope(InstituicaoBancariaPoco poco)
        {
            CodigoInstituicaoBancaria = poco.CodigoInstituicaoBancaria;
            CodigoBanco = poco.CodigoBanco;
            Descricao = poco.Descricao;
            SiteWWW = poco.SiteWWW;
            DataInclusao = poco.DataInclusao;
            Ativo = poco.Ativo;
        }

        public override void SetLinks()
        {
            Links.List = "GET /instituicaobancaria";
            Links.Self = "GET /instituicaobancaria/" + CodigoInstituicaoBancaria.ToString();
            Links.Exclude = "DELETE /instituicaobancaria/" + CodigoInstituicaoBancaria.ToString();
            Links.Update = "PUT /instituicaobancaria";
        }
    }
}
