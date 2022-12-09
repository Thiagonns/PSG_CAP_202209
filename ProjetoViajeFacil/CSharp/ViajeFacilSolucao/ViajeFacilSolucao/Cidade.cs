using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Dominio.EF
{
    [Table("cidade", Schema = "dbo")]
    public partial class Cidade
    {
        [Key]
        [Column(name: "id_cidade")]
        public int CidadeId { get; set; }

        [Column(name: "nome")]
        [Unicode(false)]
        [StringLength(100)]
        public string Nome { get; set; } = null!;

        [Column(name: "codigo_ibge7")]
        public int CodigoIBGE7 { get; set; }

        [Column(name: "uf")]
        [Unicode(false)]
        [StringLength(2)]
        public string? UF { get; set; } = null!;

        [Column(name: "id_estado")]
        public int EstadoId { get; set; }
    }
}
