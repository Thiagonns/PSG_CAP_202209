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
    [Table("produto", Schema = "dbo")]
    public partial class Produto
    {
        /*
         	[produto_id] [int] IDENTITY(1,1) NOT NULL,
	        [produto_nome] [varchar](255) NOT NULL,
	        [marca_id] [int] NOT NULL,
	        [categoria_id] [int] NOT NULL,
	        [ano_modelo] [int] NOT NULL,
	        [preco_listado] [decimal](10, 2) NOT NULL,
	        [ativo] [bit] NOT NULL,
         */

        [Key]
        [Column(name: "produto_id")]
        public int CodigoProduto { get; set; }

        [Column(name: "produto_nome")]
        [Unicode(false)]
        [StringLength(255)]
        public string ProdutoNome { get; set; } = null!;

        [Column(name: "marca_id")]
        public int CodigoMarca { get; set; }

        [Column(name: "categoria_id")]
        public int CodigoCategoria { get; set; }

        [Column(name: "ano_modelo")]
        public int AnoModelo { get; set; }

        [Column(name: "preco_listado")]
        public Decimal PrecoListado { get; set; }

        [Column(name: "ativo")]
        public bool Ativo { get; set; }

    }
}
