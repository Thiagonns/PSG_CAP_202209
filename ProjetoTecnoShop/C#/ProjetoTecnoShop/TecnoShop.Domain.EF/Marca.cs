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
    [Table("marca", Schema = "dbo")]
    public partial class Marca
    {
        /*
         	[marca_id] [int] IDENTITY(1,1) NOT NULL,
	        [marca_nome] [varchar](255) NOT NULL,
	        [ativo] [bit] NOT NULL,
         */

        [Key]
        [Column(name: "marca_id")]
        public int CodigoMarca { get; set; }

        [Column(name: "marca_nome")]
        [Unicode(false)]
        [StringLength(255)]
        public string MarcaNome { get; set; } = null!;

        [Column(name: "ativo")]
        public bool Ativo { get; set; }
    }
}
