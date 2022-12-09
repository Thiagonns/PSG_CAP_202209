using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Poco
{
    public class PontoParadaPoco
    {
        public long PontoParadaId { get; set; }
        public string Descricao { get; set; } = null!;
        public string Latitude { get; set; } = null!;
        public string Longitude { get; set; } = null!;
        public long RotaId { get; set; }

        public PontoParadaPoco()
        {
        }
    }
}
