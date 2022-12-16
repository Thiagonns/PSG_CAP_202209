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
    [Table("funcionario", Schema = "dbo")]
    public partial class Funcionario
    {
        /*
         	[funcionario_id] [int] IDENTITY(1,1) NOT NULL,
	        [primeiro_nome] [varchar](50) NOT NULL,
	        [sobrenome_nome] [varchar](50) NOT NULL,
	        [email] [varchar](255) NOT NULL,
	        [telefone] [varchar](25) NULL,
	        [ativo] [bit] NOT NULL,
	        [loja_id] [int] NOT NULL,
	        [gerente_id] [int] NOT NULL,
         */

        [Key]
        [Column(name: "funcionario_id")]
        public int CodigoFuncionario { get; set; }

        [Column(name: "primeiro_nome")]
        [Unicode(false)]
        [StringLength(50)]
        public string PrimeiroNome { get; set; } = null!;

        [Column(name: "sobrenome_nome")]
        [Unicode(false)]
        [StringLength(50)]
        public string Sobrenome { get; set; } = null!;

        [Column(name: "email")]
        [Unicode(false)]
        [StringLength(255)]
        public string Email { get; set; } = null!;

        [Column(name: "telefone")]
        [Unicode(false)]
        [StringLength(25)]
        public string? Telefone { get; set; } = null!;

        [Column(name: "ativo")]
        public bool Ativo { get; set; }

        [Column(name: "loja_id")]
        public int CodigoLoja { get; set; }

        [Column(name: "gerente_id")]
        public int CodigoGerente { get; set; }
    }
}
