using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Dominio.EF
{
    [Table("pais", Schema = "dbo")]
    public partial class Pais
    {
        [Key]
        [Column(name: "id_pais")]
        public int PaisId { get; set; }

        [Column(name: "nome")]
        [StringLength(100)]
        public string Nome { get; set; } = null!;
    }
}
