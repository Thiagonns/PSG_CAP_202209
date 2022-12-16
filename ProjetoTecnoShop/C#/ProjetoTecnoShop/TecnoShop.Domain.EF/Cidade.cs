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
    [Table("cidade", Schema = "dbo")]
    public partial class Cidade
    {
        /*
         	[cidade_id] [int] IDENTITY(1,1) NOT NULL,
	        [nome] [varchar](max) NOT NULL,
	        [codigo_ibge7] [int] NOT NULL,
	        [estado_id] [int] NOT NULL,
         */

        [Key]
        [Column(name: "cidade_id")]
        public int CodigoCidade { get; set; }

        [Column(name: "nome")]
        [Unicode(false)]
        public string Nome { get; set; } = null!;

        [Column(name: "codigo_ibge7")]
        public int CodigoIBGE7 { get; set; }

        [Column(name: "estado_id")]
        public int CodigoEstado { get; set; }
    }
}
