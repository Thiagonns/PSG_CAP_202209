using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.Estoque
{
    public class SubcategoriaPoco : BaseEstoque
    {
        private int codigoCategoria;

        public int CodigoCategoria { get => codigoCategoria; set => codigoCategoria = value; }

        public SubcategoriaPoco() : base()
        {
        }

        public SubcategoriaPoco(int codigo, string descricao, bool ativo, DateTime datainclusao, int codigoCategoria) : base(codigo, descricao, ativo, datainclusao)
        {
            this.codigoCategoria = codigoCategoria;
        }


    }
}
