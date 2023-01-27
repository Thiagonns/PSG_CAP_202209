using Avaliar.Poco;

namespace Avaliar.Envelope.Modelo
{
    public class CorrentistaEnvelope : BaseEnvelope
    {
        public int CodigoCorrentista { get; set; }
        public int? CodigoInstituicaoBancaria { get; set; }
        public string Nome { get; set; } = null!;
        public string Sobrenome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime? DataInclusao { get; set; }
        public bool? Ativo { get; set; }

        public CorrentistaEnvelope(CorrentistaPoco poco)
        {
            CodigoCorrentista = poco.CodigoCorrentista;
            CodigoInstituicaoBancaria = poco.CodigoInstituicaoBancaria;
            Nome = poco.Nome;
            Sobrenome = poco.Sobrenome;
            Email = poco.Email;
            DataInclusao = poco.DataInclusao;
            Ativo = poco.Ativo;
        }

        public override void SetLinks()
        {
            Links.List = "GET /correntista";
            Links.Self = "GET /correntista/" + CodigoCorrentista.ToString();
            Links.Exclude = "DELETE /correntista/" + CodigoCorrentista.ToString();
            Links.Update = "PUT /correntista";
        }
    }
}
