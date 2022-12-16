using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoShop.Domain.EF
{
    [Table("estado", Schema = "dbo")]
    public partial class Estado
    {
        /*
         	[estado_id] [int] IDENTITY(1,1) NOT NULL,
	        [nome] [varchar](max) NOT NULL,
	        [uf] [char](2) NOT NULL,
         */

        [Key]
        [Column(name: "estado_id")]
        public int CodigoEstado { get; set; }

        [Column(name: "nome")]
        [Unicode(false)]
        public string Nome { get; set; } = null!;

        [Column(name: "uf")]
        [Unicode(false)]
        [StringLength(2)]
        public string UF { get; set; } = null!;
    }
}
