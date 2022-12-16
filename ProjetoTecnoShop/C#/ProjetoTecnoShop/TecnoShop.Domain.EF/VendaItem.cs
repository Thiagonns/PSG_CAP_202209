using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoShop.Domain.EF
{
    [Table("venda_item", Schema = "dbo")]
    public partial class VendaItem
    {
        /*
         	[venda_item_id] [int] IDENTITY(1,1) NOT NULL,
			[venda_id] [int] NOT NULL,
			[item_id] [int] NOT NULL,
			[produto_id] [int] NOT NULL,
			[quantidade] [int] NOT NULL,
			[preco_listado] [decimal](10, 2) NOT NULL,
			[desconto] [decimal](4, 2) NOT NULL,
			[ativo] [bit] NOT NULL,
         */

        [Key]
        [Column(name: "venda_item_id")]
        public int CodigoVendaItem { get; set; }

        [Column(name: "venda_id")]
        public int CodigoVenda { get; set; }

        [Column(name: "item_id")]
        public int CodigoItem { get; set; }

        [Column(name: "produto_id")]
        public int CodigoProduto { get; set; }

        [Column(name: "quantidade")]
        public int Quantidade { get; set; }

        [Column(name: "preco_listado")]
        public Decimal PrecoListado { get; set; }

        [Column(name: "desconto")]
        public Decimal Desconto { get; set; }

        [Column(name: "ativo")]
        public bool Ativo { get; set; }
    }
}
