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
    [Table("cliente", Schema = "dbo")]
    public partial class Cliente
    {
        /*
         	[cliente_id] [int] IDENTITY(1,1) NOT NULL,
	        [primeiro_nome] [varchar](255) NOT NULL,
	        [sobre_nome] [varchar](255) NOT NULL,
	        [telefone] [varchar](25) NULL,
	        [email] [varchar](255) NOT NULL,
	        [endereco_id] [int] NOT NULL,
	        [ativo] [bit] NOT NULL,
         */

        [Key]
        [Column(name: "cliente_id")]
        public int CodigoCliente { get; set; }

        [Column(name: "primeiro_nome")]
        [Unicode(false)]
        [StringLength(255)]
        public string PrimeiroNome { get; set; } = null!;

        [Column(name: "sobre_nome")]
        [Unicode(false)]
        [StringLength(255)]
        public string Sobrenome { get; set; } = null!;

        [Column(name: "telefone")]
        [Unicode(false)]
        [StringLength(25)]
        public string? Telefone { get; set; } = null!;

        [Column(name: "email")]
        [Unicode(false)]
        [StringLength(255)]
        public string Email { get; set; } = null!;

        [Column(name: "endereco_id")]
        public int CodigoEndereco { get; set; }

        [Column(name: "ativo")]
        public bool Ativo { get; set; }
    }
}
