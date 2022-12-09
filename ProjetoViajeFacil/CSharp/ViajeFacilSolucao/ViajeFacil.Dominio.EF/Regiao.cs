using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Dominio.EF
{
    [Table("regiao", Schema = "dbo")]
    public partial class Regiao
    {
        [Key]
        [Column(name: "id_regiao")]
        public int RegiaoId { get; set; }

        [Column(name: "nome")]
        [StringLength(100)]
        public string Nome { get; set; } = null!;

        [Column(name: "id_pais")]
        public int PaisId { get; set; }
    }
}
