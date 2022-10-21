using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Model.Estoque
{
    public abstract class BaseEstoque
    {
        protected int codigo;
        protected string descricao;
        protected bool ativo;
        protected DateTime datainclusao;

        public BaseEstoque()
        {
        }

        public BaseEstoque(int codigo, string descricao, bool ativo, DateTime datainclusao)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.ativo = ativo;
            this.datainclusao = datainclusao;
        }
    }

}
