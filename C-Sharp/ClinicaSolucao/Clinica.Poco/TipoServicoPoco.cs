﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Poco
{
    public class TipoServicoPoco
    {
        public TipoServicoPoco()
        {
        }

        public int CodigoTipoServico { get; set; }
        public string SiglaTipoServico { get; set; }
        public string DescricaoTipoServico { get; set; }
    }
}
