using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Poco
{
    public class RegiaoPoco
    {
        public long RegiaoId { get; set; }
        public string Nome { get; set; } = null!;
        public long PaisId { get; set; }

        public RegiaoPoco()
        {
        }
    }
}
