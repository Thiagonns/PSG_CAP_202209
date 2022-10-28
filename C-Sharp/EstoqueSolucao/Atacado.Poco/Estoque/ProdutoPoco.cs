﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.Estoque
{
    public class ProdutoPoco : BaseEstoque
    {
        private int codigoSubcategoria;

        public int CodigoSubcategoria { get => codigoSubcategoria; set => codigoSubcategoria = value; }

        public ProdutoPoco() : base()
        {
        }

        public ProdutoPoco(int codigo, string descricao, bool ativo, DateTime datainclusao, int codigoSubcategoria) : base(codigo, descricao, ativo, datainclusao)
        {
            this.codigoSubcategoria = codigoSubcategoria;
        }


    }
}
