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
    [Table("ponto_parada", Schema = "dbo")]
    public partial class PontoParada
    {
        // [id_ponto_parada] [bigint] IDENTITY(1,1) NOT NULL,
        // [descricao] [varchar](255) NOT NULL,
        // [latitude] [varchar](50) NOT NULL,
        // [longitude] [varchar](50) NOT NULL,
        // [id_rota] [bigint] NOT NULL,

        [Key]
        [Column(name: "id_ponto_parada")]
        public long PontoParadaId { get; set; }

        [Column(name: "descricao")]
        [Unicode(false)]
        [StringLength(255)]
        public string Descricao { get; set; } = null!;

        [Column(name: "latitude")]
        [Unicode(false)]
        [StringLength(50)]
        public string Latitude { get; set; } = null!;

        [Column(name: "longitude")]
        [Unicode(false)]
        [StringLength(50)]
        public string Longitude { get; set; } = null!;

        [Column(name: "id_rota")]
        public long RotaId { get; set; }
    }
}
