using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Poco
{
    public class CidadePoco
    {
        public long CidadeId { get; set; }
        public string Nome { get; set; } = null!;
        public long CodigoIBGE7 { get; set; }
        public string? UF { get; set; } = null!;
        public long EstadoId { get; set; }
        public CidadePoco()
        {
        }
    }
}
