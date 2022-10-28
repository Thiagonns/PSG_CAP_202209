using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.Estoque
{
    public class Categoria : BaseEstoque
    {
        private List<Subcategoria> subcategorias;

        public List<Subcategoria> Subcategorias { get => subcategorias; set => subcategorias = value; }

        public Categoria() : base()
        {
            this.Subcategorias = new List<Subcategoria>();  
        }

        public Categoria(int codigo, string descricao, bool ativo, DateTime datainclusao) 
            : base(codigo, descricao, ativo, datainclusao)
        {
            this.Subcategorias = new List<Subcategoria>();
        }        
    }
}
