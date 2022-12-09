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
    [Table("instituicao", Schema = "dbo")]
    public partial class Instituicao
    {
        //[id_instituicao][bigint] IDENTITY(1,1) NOT NULL,

        //[id_endereco] [bigint] NOT NULL,

        //[nome] [varchar] (100) NOT NULL,

        //[telefone] [varchar] (20) NOT NULL,


        [Key]
        [Column(name: "id_instituicao")]
        public int InstituicaoId { get; set; }

        [Column(name: "nome")]
        [Unicode(false)]
        [StringLength(100)]
        public string Nome { get; set; } = null!;

        [Column(name: "telefone")]
        [Unicode(false)]
        [StringLength(20)]
        public string Telefone { get; set; } = null!;

        [Column(name: "id_endereco")]
        public int EnderecoId { get; set; }
    }
}
