using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atacado.Dominio.Estoque;

namespace Atacado.DB.FakeDB.Estoque
{
    public class ProdutoFakeDB
    {
        private static List<Produto> produtos;

        public static List<Produto> Produtos
        {
            get
            {
                if(produtos == null)
                {
                    produtos = new List<Produto>();
                    Carregar();
                }
                return produtos;
            }            
        }
        private static void Carregar()
        {
            produtos.Add (new Produto(1, "Farinha de mandioca Mimosa", true, DateTime.Now, 1));
            produtos.Add(new Produto(2, "Farinha de mandioca Yoki", true, DateTime.Now, 1));
            produtos.Add(new Produto(3, "Farinha de mandioca Cuiabana", true, DateTime.Now, 1));
        }
    }
}
