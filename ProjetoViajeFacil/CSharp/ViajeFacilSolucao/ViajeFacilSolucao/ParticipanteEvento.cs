using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Dominio.EF
{
    [Table("participante_evento", Schema = "dbo")]
    public partial class ParticipanteEvento
    {
        // [id_participante_evento] [bigint] IDENTITY(1,1) NOT NULL,
        // [id_evento] [bigint] NOT NULL,
        // [pagamento] [int] NOT NULL,
        // [sugestao] [varchar](255) NOT NULL,
        // [avaliacao] [int] NULL,
        // [id_usuario] [bigint] NOT NULL,

        [Key]
        [Column(name: "id_participante_evento")]
        public int ParticipanteEventoId { get; set; }

        [Column(name: "id_evento")]
        public int EventoId { get; set; }
        
        [Column(name: "pagamento")]
        public int Pagamento { get; set; }

        [Column(name: "sugestao")]
        [Unicode(false)]
        [StringLength(255)]
        public string Sugestao { get; set; } = null!;

        [Column(name: "avaliacao")]
        public int? Avaliacao { get; set; }

        [Column(name: "id_usuario")]
        public int? UsuarioId { get; set; }
    }
}
