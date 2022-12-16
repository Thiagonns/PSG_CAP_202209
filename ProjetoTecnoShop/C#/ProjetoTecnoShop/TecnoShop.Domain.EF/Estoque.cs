using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoShop.Domain.EF
{
    [Table("estoque", Schema = "dbo")]
    public partial class Estoque
    {
        /*
         	[estoque_id] [int] IDENTITY(1,1) NOT NULL,
	        [loja_id] [int] NULL,
	        [produto_id] [int] NULL,
	        [quantity] [int] NULL,
	        [ativo] [bit] NOT NULL,
         */

        [Key]
        [Column(name: "estoque_id")]
        public int CodigoEstoque { get; set; }

        [Column(name: "loja_id")]
        public int? CodigoLoja { get; set; }

        [Column(name: "produto_id")]
        public int? CodigoProduto { get; set; }

        [Column(name: "quantity")]
        public int? Quantidade { get; set; }


        [Column(name: "ativo")]
        public bool Ativo { get; set; }
    }
}
