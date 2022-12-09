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
    [Table("evento", Schema = "dbo")]
    public partial class Evento
    {
        // [id_evento] [bigint] IDENTITY(1,1) NOT NULL,
        // [id_usuario_responsavel] [bigint] NOT NULL,
        // [titulo] [varchar](255) NOT NULL,
        // [descricao] [varchar](255) NOT NULL,
        // [id_endereco] [bigint] NOT NULL,
        // [data_ida] [date] NOT NULL,
        // [id_rota_ida] [bigint] NOT NULL,
        // [data_volta] [date] NOT NULL,
        // [id_rota_volta] [bigint] NOT NULL,
        // [id_instituicao] [bigint] NOT NULL,

        [Key]
        [Column(name: "id_evento")]
        public long EventoId { get; set; }

        [Column(name: "id_usuario_responsavel")]
        public long UsuarioResponsavelId { get; set; }

        [Column(name: "titulo")]
        [Unicode(false)]
        [StringLength(255)]
        public string Titulo { get; set; } = null!;

        [Column(name: "descricao")]
        [Unicode(false)]
        [StringLength(255)]
        public string Descricao { get; set; } = null!;

        [Column(name: "id_endereco")]
        public long EnderecoId { get; set; }

        [Column(name: "data_ida", TypeName = "date")]
        public DateTime DataIda { get; set; }

        [Column(name: "id_rota_ida")]
        public long RotaIdaId { get; set; }

        [Column(name: "data_volta", TypeName = "date")]
        public DateTime DataVolta { get; set; }

        [Column(name: "id_rota_volta")]
        public long RotaVoltaId { get; set; }

        [Column(name: "id_instituicao")]
        public long InstituicaoId { get; set; }
    }
}
