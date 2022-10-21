﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.Estoque
{
    public class Subcategoria : BaseEstoque
    {
        private int codigoCategoria;

        public int CodigoCategoria { get => codigoCategoria; set => codigoCategoria = value; }

        public Subcategoria() : base()
        {
        }

        public Subcategoria(int codigo, string descricao, bool ativo, DateTime datainclusao, int codigoCategoria) : base(codigo, descricao, ativo, datainclusao)
        {
            this.codigoCategoria = codigoCategoria;
        }


    }
}
