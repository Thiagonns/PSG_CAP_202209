using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Atacado.DB.EF.Database;
using System.Security.Principal;

namespace Atacado.DB.EF.Database
{
    public partial class Rebanho
    {
        [Key]
        [Column(name: "ID_Rebanho")]
        public int CodigoRebanho { get; set; }

        [Column(name: "Ano_Ref")]
        public int AnoRef { get; set; }

        [Column(name: "ID_Municipio")]
        public int CodigoMunicipio { get; set; }

        [Column(name: "ID_Tipo_Rebanho")]
        public int CodigoTipoRebanho { get; set; }

        [Column(name: "Tipo_Rebanho")]
        [Unicode(false)]
        public string TipoRebanho { get; set; } = null!;

        [Column(name: "Quantidade")]
        public int? Quantidade { get; set; }

        [Column(name: "Situacao")]
        public bool? Situacao { get; set; }

        [Column(name: "DataInclusao", TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }

        [Column(name: "DataAlteracao", TypeName = "datetime")]
        public DateTime? DataAlteracao { get; set; }

        [Column(name: "DataExclusao", TypeName = "datetime")]
        public DateTime? DataExclusao { get; set; }
    }
}