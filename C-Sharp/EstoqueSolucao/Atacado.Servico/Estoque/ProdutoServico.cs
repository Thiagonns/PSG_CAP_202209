using Atacado.DB.EF.Database;
using Atacado.Poco.Estoque;
using Atacado.Repositorio.Estoque;
using Atacado.Servico.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Servico.Estoque
{
    public class ProdutoServico : BaseServico<ProdutoPoco, Produto>
    {
        private ProdutoRepo repo;

        public ProdutoServico() : base()
        {
            this.repo = new ProdutoRepo();
        }
        public override ProdutoPoco Add(ProdutoPoco poco)
        {
            Produto nova = this.ConvertTo(poco);
            Produto criada = this.repo.Create(nova);
            return this.ConvertTo(criada);
        }

        public override List<ProdutoPoco> Browse()
        {
            //List<Categoria> lista = this.repo.Read();
            //List<CategoriaPoco> listaPoco = new List<CategoriaPoco>();

            //foreach (Categoria item in lista)
            //{
            //    CategoriaPoco poco = this.ConvertTo(item);
            //    listaPoco.Add(poco);
            //}
            //return listaPoco;

            List<ProdutoPoco> ListaPoco = this.repo.Read().Select(cat => new ProdutoPoco()
            {
                Codigo = cat.Codigo,
                CodigoCategoria = cat.CodigoCategoria,
                CodigoSubcategoria = cat.CodigoSubcategoria,                
                Descricao = cat.Descricao,
                Ativo = cat.Ativo,
                DataInsert = cat.DataInsert
            }
            ).ToList();
            return ListaPoco;
        }

        public override List<ProdutoPoco> Browse(Expression<Func<Produto, bool>> filtro = null)
        {
            List<ProdutoPoco> listaPoco;
            IQueryable<Produto> query;
            if (filtro == null)
            {
                query = this.repo.Read(null);
            }
            else
            {
                query = this.repo.Read(filtro);
            }
            listaPoco = query.Select(cat => new ProdutoPoco()
            {
                Codigo = cat.Codigo,
                Descricao = cat.Descricao,
                Ativo = cat.Ativo,
                DataInsert = cat.DataInsert
            }
            ).ToList();
            return listaPoco;
        }

        public override ProdutoPoco ConvertTo(Produto dominio)
        {
            return new ProdutoPoco()
            {
                Codigo = dominio.Codigo,
                CodigoCategoria=dominio.CodigoCategoria,
                CodigoSubcategoria=dominio.CodigoSubcategoria,                
                Descricao = dominio.Descricao,
                Ativo = dominio.Ativo,
                DataInsert = dominio.DataInsert
            };
        }

        public override Produto ConvertTo(ProdutoPoco poco)
        {
            return new Produto()
            {
                Codigo = poco.Codigo,
                CodigoCategoria = poco.CodigoCategoria,
                CodigoSubcategoria = poco.CodigoSubcategoria,                
                Descricao = poco.Descricao,
                Ativo = poco.Ativo,
                DataInsert = poco.DataInsert
            };
        }

        public override ProdutoPoco Delete(int chave)
        {
            Produto del = this.repo.Delete(chave);
            ProdutoPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override ProdutoPoco Delete(ProdutoPoco poco)
        {
            Produto del = this.repo.Delete(poco.Codigo);
            ProdutoPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override ProdutoPoco Edit(ProdutoPoco poco)
        {
            Produto editada = this.ConvertTo(poco);
            Produto alterada = this.repo.Update(editada);
            ProdutoPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override ProdutoPoco Read(int chave)
        {
            Produto lida = this.repo.Read(chave);
            ProdutoPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
