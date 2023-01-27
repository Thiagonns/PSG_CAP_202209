
namespace Avaliar.Poco
{
    public class CorrentistaPoco
    {
        public int CodigoCorrentista { get; set; }
        public int? CodigoInstituicaoBancaria { get; set; }
        public string Nome { get; set; } = null!;
        public string Sobrenome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime? DataInclusao { get; set; }
        public bool? Ativo { get; set; }
    }
}
