using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.Estoque
{
    public class Categoria : BaseEstoque
    {
 

 
        public Categoria() : base()
        {
        }

        public Categoria(int codigo, string descricao, bool ativo, DateTime datainclusao) 
            : base(codigo, descricao, ativo, datainclusao)
        {
        }

        
    }
}
