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
    public class SubcategoriaServico : BaseServico<SubcategoriaPoco, Subcategoria>
    {
        private SubcategoriaRepo repo;

        public SubcategoriaServico() : base()
        {
            repo = new SubcategoriaRepo();
        }
        public override SubcategoriaPoco Add(SubcategoriaPoco poco)
        {
            Subcategoria nova = ConvertTo(poco);
            Subcategoria criada = repo.Create(nova);
            return ConvertTo(criada);
        }

        public override List<SubcategoriaPoco> Browse()
        {
            //List<Categoria> lista = this.repo.Read();
            //List<CategoriaPoco> listaPoco = new List<CategoriaPoco>();

            //foreach (Categoria item in lista)
            //{
            //    CategoriaPoco poco = this.ConvertTo(item);
            //    listaPoco.Add(poco);
            //}
            //return listaPoco;

            List<SubcategoriaPoco> ListaPoco = repo.Read().Select(cat => new SubcategoriaPoco()
            {
                Codigo = cat.Codigo,
                CodigoCategoria = cat.CodigoCategoria,
                Descricao = cat.Descricao,
                Ativo = cat.Ativo,
                DataInsert = cat.DataInsert
            }
            ).ToList();
            return ListaPoco;
        }

        public override List<SubcategoriaPoco> Browse(Expression<Func<Subcategoria, bool>> filtro = null)
        {
            List<SubcategoriaPoco> listaPoco;
            IQueryable<Subcategoria> query;
            if (filtro == null)
            {
                query = this.repo.Read(null);
            }
            else
            {
                query = this.repo.Read(filtro);
            }
            listaPoco = query.Select(cat => new SubcategoriaPoco()
            {
                Codigo = cat.Codigo,
                CodigoCategoria = cat.CodigoCategoria,                
                Descricao = cat.Descricao,
                Ativo = cat.Ativo,
                DataInsert = cat.DataInsert
            }
            ).ToList();
            return listaPoco;
        }

        public override SubcategoriaPoco ConvertTo(Subcategoria dominio)
        {
            return new SubcategoriaPoco()
            {
                Codigo = dominio.Codigo,
                CodigoCategoria = dominio.CodigoCategoria,
                Descricao = dominio.Descricao,
                Ativo = dominio.Ativo,
                DataInsert = dominio.DataInsert
            };
        }

        public override Subcategoria ConvertTo(SubcategoriaPoco poco)
        {
            return new Subcategoria()
            {
                Codigo = poco.Codigo,
                CodigoCategoria = poco.CodigoCategoria,
                Descricao = poco.Descricao,
                Ativo = poco.Ativo,
                DataInsert = poco.DataInsert
            };
        }

        public override SubcategoriaPoco Delete(int chave)
        {
            Subcategoria del = repo.Delete(chave);
            SubcategoriaPoco delPoco = ConvertTo(del);
            return delPoco;
        }

        public override SubcategoriaPoco Delete(SubcategoriaPoco poco)
        {
            Subcategoria del = repo.Delete(poco.Codigo);
            SubcategoriaPoco delPoco = ConvertTo(del);
            return delPoco;
        }

        public override SubcategoriaPoco Edit(SubcategoriaPoco poco)
        {
            Subcategoria editada = ConvertTo(poco);
            Subcategoria alterada = repo.Update(editada);
            SubcategoriaPoco alteradaPoco = ConvertTo(alterada);
            return alteradaPoco;
        }

        public override SubcategoriaPoco Read(int chave)
        {
            Subcategoria lida = repo.Read(chave);
            SubcategoriaPoco lidaPoco = ConvertTo(lida);
            return lidaPoco;
        }
    }
}
