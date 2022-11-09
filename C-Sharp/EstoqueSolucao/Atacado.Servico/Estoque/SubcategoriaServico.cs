using Atacado.DB.EF.Database;
using Atacado.Poco.Estoque;
using Atacado.Repositorio.Base;
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
        private GenericRepository<Subcategoria> genrepo;

        public SubcategoriaServico() : base()
        {
            this.genrepo = new GenericRepository<Subcategoria>();
        }
        public override SubcategoriaPoco Add(SubcategoriaPoco poco)
        {
            Subcategoria nova = ConvertTo(poco);
            Subcategoria criada = genrepo.Insert(nova);
            return ConvertTo(criada);
        }

        public override List<SubcategoriaPoco> Browse()
        {
            return this.Browse(null);
        }

        public override List<SubcategoriaPoco> Browse(Expression<Func<Subcategoria, bool>> filtro = null)
        {
            List<SubcategoriaPoco> listaPoco;
            IQueryable<Subcategoria> query;
            if (filtro == null)
            {
                query = this.genrepo.Browseable(null);
            }
            else
            {
                query = this.genrepo.Browseable(filtro);
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
            Subcategoria del = genrepo.Delete(chave);
            SubcategoriaPoco delPoco = ConvertTo(del);
            return delPoco;
        }

        public override SubcategoriaPoco Delete(SubcategoriaPoco poco)
        {
            Subcategoria del = genrepo.Delete(poco.Codigo);
            SubcategoriaPoco delPoco = ConvertTo(del);
            return delPoco;
        }

        public override SubcategoriaPoco Edit(SubcategoriaPoco poco)
        {
            Subcategoria editada = ConvertTo(poco);
            Subcategoria alterada = genrepo.Update(editada);
            SubcategoriaPoco alteradaPoco = ConvertTo(alterada);
            return alteradaPoco;
        }

        public override SubcategoriaPoco Read(int chave)
        {
            Subcategoria lida = genrepo.GetById(chave);
            SubcategoriaPoco lidaPoco = ConvertTo(lida);
            return lidaPoco;
        }
    }
}
