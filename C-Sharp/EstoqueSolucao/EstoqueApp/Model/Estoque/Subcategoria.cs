﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Model.Estoque
{
    public class Subcategoria : BaseEstoque
    {
        private int codigoCategoria;
        private List<Produto> produtos;

        public int CodigoCategoria { get => codigoCategoria; set => codigoCategoria = value; }
        public List<Produto> Produtos { get => produtos; set => produtos = value; }

        public Subcategoria(int codigoCategoria) : base()
        {
            this.codigoCategoria = codigoCategoria;
            this.produtos = new List<Produto>();
        }

        public Subcategoria(int codigo, string descricao, bool ativo, DateTime datainclusao, int codigoCategoria) : base(codigo, descricao, ativo, datainclusao)
        {
            this.codigoCategoria = codigoCategoria;
            this.produtos = new List<Produto>();
        }


    }
}
