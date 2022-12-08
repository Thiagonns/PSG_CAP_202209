using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinica.Poco
{
    public  class ServicoPoco
    {

        public int CodigoServico { get; set; }
        public string Descricao { get; set; } = null!;
        public Decimal Preco { get; set; }
        public string? MaterialUsado { get; set; }
        public int? DenteTratado { get; set; }
        public int? DenteExtraido { get; set; }
        public int? DenteCanalPar { get; set; }
        public string? MedidaPreventiva { get; set; }
        public string? TipoExame { get; set; }
        public string? TipoServico { get; set; }
        public bool? Situacao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? CodigoTipoServico { get; set; }
        public ServicoPoco()
        {
        }
    }
}

