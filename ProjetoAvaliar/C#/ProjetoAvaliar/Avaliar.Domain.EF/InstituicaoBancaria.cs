using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Avaliar.Domain.EF
{
    [Table("InstituicaoBancaria", Schema = "dbo")]
    public partial class InstituicaoBancaria
    {
        [Key]
        [Column(name: "IdInstituicaoBancaria")]
        public int CodigoInstituicaoBancaria { get; set; }

        [Column(name: "CodigoBanco")]
        public int? CodigoBanco { get; set; }

        [Column(name: "Descricao")]
        [Unicode(false)]
        public string Descricao { get; set; } = null!;

        [Column(name: "SiteWWW")]
        [Unicode(false)]
        public string SiteWWW { get; set; } = null!;

        [Column(name: "DataInsert")]
        public DateTime? DataInclusao { get; set; }

        [Column(name: "Ativo")]
        public bool? Ativo { get; set; }
    }
}
