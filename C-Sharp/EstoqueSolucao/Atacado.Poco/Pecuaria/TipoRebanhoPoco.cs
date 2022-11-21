namespace Atacado.Poco.Pecuaria
{
    public class TipoRebanhoPoco
    {
        public int CodigoTipo { get; set; }

        public string Descricao { get; set; } = null!;

        public bool? Situacao { get; set; }

        public DateTime? DataInclusao { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public DateTime? DataExclusao { get; set; }
    }
}
