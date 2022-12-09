using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Dominio.EF
{
    [Table("usuario", Schema = "dbo")]
    public partial class Usuario
    {
        // [id_usuario] [bigint] IDENTITY(1,1) NOT NULL,
        // [nome] [varchar](100) NOT NULL,
        // [email] [varchar](50) NOT NULL,
        // [cpf] [varchar](50) NOT NULL,
        // [telefone] [varchar](20) NOT NULL,
        // [login] [varchar](50) NOT NULL,
        // [senha] [varchar](255) NOT NULL,
        // [id_instituicao] [bigint] NOT NULL,
        // [id_endereco] [bigint] NOT NULL,
        // [id_tipo_usuario] [bigint] NOT NULL,

        [Key]
        [Column(name: "id_usuario")]
        public long UsuarioId { get; set; }

        [Column(name: "nome")]
        [Unicode(false)]
        [StringLength(100)]
        public string Nome { get; set; } = null!;

        [Column(name: "email")]
        [Unicode(false)]
        [StringLength(50)]
        public string Email { get; set; } = null!;

        [Column(name: "cpf")]
        [Unicode(false)]
        [StringLength(50)]
        public string CPF { get; set; } = null!;

        [Column(name: "telefone")]
        [Unicode(false)]
        [StringLength(20)]
        public string Telefone { get; set; } = null!;

        [Column(name: "login")]
        [Unicode(false)]
        [StringLength(50)]
        public string login { get; set; } = null!;

        [Column(name: "senha")]
        [Unicode(false)]
        [StringLength(255)]
        public string Senha { get; set; } = null!;

        [Column(name: "id_instituicao")]
        public long InstituicaoId { get; set; }

        [Column(name: "id_endereco")]
        public long EnderecoId { get; set; }

        [Column(name: "id_tipo_usuario")]
        public long TipoUsuarioId { get; set; }
    }
}
