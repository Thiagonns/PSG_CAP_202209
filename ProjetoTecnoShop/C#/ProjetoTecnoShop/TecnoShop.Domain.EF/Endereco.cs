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
    [Table("endereco", Schema = "dbo")]
    public partial class Endereco
    {
        /*
        [endereco_id] [int] IDENTITY(1,1) NOT NULL,
	    [rua] [varchar](100) NOT NULL,
	    [numero] [int] NOT NULL,
	    [complemento] [varchar](255) NULL,
	    [bairro] [varchar](100) NOT NULL,
	    [cep] [varchar](9) NOT NULL,
	    [cidade_id] [int] NOT NULL,
         */

        [Key]
        [Column(name: "endereco_id")]
        public int CodigoEndereco { get; set; }

        [Column(name: "rua")]
        [Unicode(false)]
        [StringLength(100)]
        public string Rua { get; set; } = null!;

        [Column(name: "numero")]
        public int Numero { get; set; }

        [Column(name: "complemento")]
        [Unicode(false)]
        [StringLength(255)]
        public string? Complemento { get; set; } = null!;

        [Column(name: "bairro")]
        [Unicode(false)]
        [StringLength(100)]
        public string Bairro { get; set; } = null!;

        [Column(name: "cep")]
        [Unicode(false)]
        [StringLength(9)]
        public string CEP { get; set; } = null!;

        [Column(name: "cidade_id")]
        public int CodigoCidade { get; set; }
    }
}
