using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Poco
{
    public class EventoPoco
    {
        public long EventoId { get; set; }
        public long UsuarioResponsavelId { get; set; }
        public string Titulo { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public long EnderecoId { get; set; }
        public DateTime DataIda { get; set; }
        public long RotaIdaId { get; set; }
        public DateTime DataVolta { get; set; }
        public long RotaVoltaId { get; set; }
        public long InstituicaoId { get; set; }
        public EventoPoco()
        {
        }
    }
}
