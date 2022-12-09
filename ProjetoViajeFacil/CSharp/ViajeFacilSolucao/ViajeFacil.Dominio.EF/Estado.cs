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
    [Table("estado", Schema = "dbo")]
    public partial class Estado
    {
        [Key]
        [Column(name: "id_estado")]
        public int EstadoId { get; set; }

        [Column(name: "nome")]
        [Unicode(false)]
        [StringLength(100)]
        public string Nome { get; set; } = null!;

        [Column(name: "codigouf")]
        public int? CodigoUf { get; set; }

        [Column(name: "uf")]
        [Unicode(false)]
        [StringLength(2)]
        public string UF { get; set; } = null!;

        [Column(name: "id_regiao")]
        public int RegiaoId { get; set; }
    }
}
