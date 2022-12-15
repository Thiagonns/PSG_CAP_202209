using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExameCAP.Dominio.EF
{
    [Table("Passageiro", Schema = "dbo")]
    public partial class Passageiro
    {
        /*
            CodigoPassageiro NT NOT NULL IDENTITY(1,1),
            Nome VARCHAR(50) NOT NULL,
	        Documento VARCHAR(20) NOT NULL,
	        NumeroCartao VARCHAR(20) NOT NULL,
	        Email VARCHAR(50) NOT NULL,
	        Telefone VARCHAR(20) NOT NULL,
	        DataNascimento DATE NOT NULL,
         */

        [Key]
        [Column(name: "CodigoPassageiro")]
        public int CodigoPassageiro { get; set; }

        [Column(name: "Nome")]
        [Unicode(false)]
        [StringLength(50)]
        public string Nome { get; set; } = null!;

        [Column(name: "Documento")]
        [Unicode(false)]
        [StringLength(20)]
        public string Documento { get; set; } = null!;

        [Column(name: "NumeroCartao")]
        [Unicode(false)]
        [StringLength(20)]
        public string NumeroCartao { get; set; } = null!;

        [Column(name: "Email")]
        [Unicode(false)]
        [StringLength(50)]
        public string Email { get; set; } = null!;

        [Column(name: "Telefone")]
        [Unicode(false)]
        [StringLength(20)]
        public string Telefone { get; set; } = null!;

        [Column(name: "DataNascimento", TypeName = "date")] 
        public DateTime DataNascimento { get; set; }
    }
}
