using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avaliar.Domain.EF
{
    [Table("Correntista", Schema = "dbo")]
    public partial class Correntista
    {
        //[IdCorrentista][int] IDENTITY(1,1) NOT NULL,
        //[IdInstituicaoBancaria] [int] NULL,
        //[Nome][varchar] (255) NOT NULL,
        //[Sobrenome] [varchar] (255) NOT NULL,
        //[Email] [varchar] (255) NOT NULL,
        //[Ativo] [bit] NULL,
        //[DataInclusao][datetime] NULL,

        [Key]
        [Column(name: "IdCorrentista")]
        public int CodigoCorrentista { get; set; }

        [Column(name: "IdInstituicaoBancaria")]
        public int? CodigoInstituicaoBancaria { get; set; }

        [Column(name: "Nome")]
        [Unicode(false)]
        [StringLength(255)]
        public string Nome { get; set; } = null!;

        [Column(name: "Sobrenome")]
        [Unicode(false)]
        [StringLength(255)]
        public string Sobrenome { get; set; } = null!;

        [Column(name: "Email")]
        [Unicode(false)]
        [StringLength(255)]
        public string Email { get; set; } = null!;

        [Column(name: "DataInclusao")]
        public DateTime? DataInclusao { get; set; }

        [Column(name: "Ativo")]
        public bool? Ativo { get; set; }
    }
}
