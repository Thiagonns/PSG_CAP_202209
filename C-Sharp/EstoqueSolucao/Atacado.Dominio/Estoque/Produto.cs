﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.Estoque
{
    public class Produto : BaseEstoque
    {
        private int codigoSubcategoria;

        public int CodigoSubcategoria { get => codigoSubcategoria; set => codigoSubcategoria = value; }

        public Produto() : base()
        {
        }

        public Produto(int codigo, string descricao, bool ativo, DateTime datainclusao, int codigoSubcategoria) : base(codigo, descricao, ativo, datainclusao)
        {
            this.codigoSubcategoria = codigoSubcategoria;
        }


    }
}
