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
    [Table("categoria", Schema = "dbo")]
    public partial class Categoria
    {
        //[categoria_id][int] IDENTITY(1,1) NOT NULL,

        //[categoria_nome] [varchar] (255) NOT NULL,

        //[ativo] [bit] NOT NULL,

        [Key]
        [Column(name: "categoria_id")]
        public int CodigoCategoria { get; set; }

        [Column(name: "categoria_nome")]
        [Unicode(false)]
        [StringLength(255)]
        public string CategoriaNome { get; set; } = null!;

        [Column(name: "ativo")]
        public bool Ativo { get; set; }
    }
}
