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
    [Table("rota", Schema = "dbo")]
    public partial class Rota
    {
        // [id_rota] [bigint] IDENTITY(1,1) NOT NULL,
        // [ponto_inicial] [varchar](255) NOT NULL,
        // [ponto_final] [varchar](255) NOT NULL,

        [Key]
        [Column(name: "id_rota")]
        public int RotaId { get; set; }

        [Column(name: "ponto_inicial")]
        [Unicode(false)]
        [StringLength(255)]
        public string PontoInicial { get; set; } = null!;

        [Column(name: "ponto_Final")]
        [Unicode(false)]
        [StringLength(255)]
        public string PontoFinal { get; set; } = null!;


    }
}
