using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.Estoque
{
    public abstract class BaseEstoque
    {
        protected int codigo;
        protected string descricao;
        protected bool ativo;
        protected DateTime datainclusao;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public DateTime DataInclusao { get => datainclusao; set => datainclusao = value; }

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
