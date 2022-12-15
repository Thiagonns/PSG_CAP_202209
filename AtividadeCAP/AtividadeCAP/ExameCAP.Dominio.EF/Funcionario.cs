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
    [Table("Funcionario", Schema = "dbo")]
    public partial class Funcionario
    {
        /*
            CodigoFuncionario BIGINT NOT NULL IDENTITY(1,1),
            Matricula VARCHAR(50) NOT NULL,
            Nome VARCHAR(50) NOT NULL,
	        ContaCorrente VARCHAR(50) NOT NULL,
	        Email VARCHAR(50) NOT NULL,
	        Telefone VARCHAR(20) NOT NULL,
	        Usuario VARCHAR(20) NOT NULL,
	        Senha VARCHAR(20) NOT NULL,
	        DataNascimento DATE NOT NULL
         */

        [Key]
        [Column(name: "CodigoFuncionario")]
        public int CodigoFuncionario { get; set; }

        [Column(name: "Matricula")]
        [Unicode(false)]
        [StringLength(50)]
        public string Matricula { get; set; } = null!;

        [Column(name: "Nome")]
        [Unicode(false)]
        [StringLength(50)]
        public string Nome { get; set; } = null!;

        [Column(name: "ContaCorrente")]
        [Unicode(false)]
        [StringLength(50)]
        public string ContaCorrente { get; set; } = null!;

        [Column(name: "Email")]
        [Unicode(false)]
        [StringLength(50)]
        public string Email { get; set; } = null!;

        [Column(name: "Telefone")]
        [Unicode(false)]
        [StringLength(20)]
        public string Telefone { get; set; } = null!;

        [Column(name: "Usuario")]
        [Unicode(false)]
        [StringLength(20)]
        public string Usuario { get; set; } = null!;

        [Column(name: "Senha")]
        [Unicode(false)]
        [StringLength(20)]
        public string Senha { get; set; } = null!;

        [Column(name: "DataNascimento", TypeName = "date")] //Verificar se é date ou datetime (Typename)
        public DateTime DataNascimento { get; set; }
    }
}
