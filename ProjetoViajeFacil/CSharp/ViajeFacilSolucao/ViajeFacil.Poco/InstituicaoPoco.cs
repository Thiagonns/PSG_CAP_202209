﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Poco
{
    public class InstituicaoPoco
    {
        public long InstituicaoId { get; set; }
        public string Nome { get; set; } = null!;
        public string Telefone { get; set; } = null!;
        public long EnderecoId { get; set; }
        public InstituicaoPoco()
        {
        }
    }
}
