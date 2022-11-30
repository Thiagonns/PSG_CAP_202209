using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Dominio.EF
{
    [Table("Servico", Schema = "dbo")]
    public partial class Servico
    {
        /*	[CodigoServico] [int] IDENTITY(1,1) NOT NULL,
           [Descricao] [varchar](max) NOT NULL,
           [Preco] [decimal](10, 2) NOT NULL,
           [MaterialUsado] [varchar](max) NULL,
           [DenteTratado] [int] NULL,
           [MedidaPreventiva] [varchar](max) NULL,
           [TipoExame] [varchar](max) NULL,
           [TipoServico] [char](2) NULL,
           [Situacao] [bit] NULL,
           [DataInclusao] [datetime] NULL,
           [DataAlteracao] [datetime] NULL,*/

        [Key]
        [Column(name: "CodigoServico")]
        public int CodigoServico { get; set; }

        [Column(name: "Descricao")]
        [Unicode(false)]
        public string Descricao { get; set; } = null!;

        [Column(name: "Preco")]
        public Double Preco { get; set; } 

        [Column(name: "MaterialUsado")]
        [Unicode(false)]
        public string? MaterialUsado { get; set; }

        [Column(name: "DenteTratado")]
        public int? DenteTratado { get; set; }

        [Column(name: "MedidaPreventiva")]
        [Unicode(false)]
        public string? MedidaPreventiva { get; set; }

        [Column(name: "TipoExame")]
        [Unicode(false)]
        public string? TipoExame { get; set; }

        [Column(name: "TipoServico")]
        [Unicode(false)]
        public string? TipoServico { get; set; }

        [Column(name: "Situacao")]
        public bool? Situacao { get; set; }

        [Column(name: "DataInclusao", TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }

        [Column(name: "DataAlteracao", TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }
    }
}
