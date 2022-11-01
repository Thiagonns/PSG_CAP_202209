﻿using System;

namespace Atacado.Poco.Estoque
{

    public class CategoriaPoco
    {
        public CategoriaPoco()
        { }
        public int Codigo { get; set; }
        public string Descricao { get; set; } = null!;
        public DateTime DataInsert { get; set; }
    }
}
