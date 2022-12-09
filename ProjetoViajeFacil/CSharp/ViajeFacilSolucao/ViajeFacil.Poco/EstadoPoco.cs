using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Poco
{
    public class EstadoPoco
    {
        public long EstadoId { get; set; }
        public string Nome { get; set; } = null!;
        public long? CodigoUf { get; set; }
        public string UF { get; set; } = null!;
        public long RegiaoId { get; set; }
        public EstadoPoco()
        {
        }
    }
}
