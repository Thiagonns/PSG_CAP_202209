
namespace LibTec.Poco
{
    public class AutorPoco
    {
        public int CodigoAutor { get; set; }
        public string Nome { get; set; } = null!;
        public bool? Ativo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public DateTime? DataExclusao { get; set; }
    }
}
