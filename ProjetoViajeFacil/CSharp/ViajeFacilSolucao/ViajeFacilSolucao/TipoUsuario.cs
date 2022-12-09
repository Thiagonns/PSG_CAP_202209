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
    [Table("tipo_usuario", Schema = "dbo")]
    public partial class TipoUsuario
    {
        // [id_tipo_usuario] [bigint] IDENTITY(1,1) NOT NULL,
        // [descricao] [varchar](255) NOT NULL,

        [Key]
        [Column(name: "id_tipo_usuario")]
        public int TipoUsuarioId { get; set; }

        [Column(name: "descricao")]
        [Unicode(false)]
        [StringLength(255)]
        public string Descricao { get; set; } = null!;
    }
}
