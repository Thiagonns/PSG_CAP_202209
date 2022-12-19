using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LibTec.Domain.EF;
using LibTec.Poco;
using LibTec.Service.Base;

namespace LibTec.Service.Recursos
{
    public class AutorPorItemServico : GenericService<AutorPorItem, AutorPorItemPoco>
    {
        public AutorPorItemServico(LibTecContext contexto) : base(contexto)
        { }

        public override List<AutorPorItemPoco> Consultar(Expression<Func<AutorPorItem, bool>>? predicate = null)
        {
            IQueryable<AutorPorItem> query;
            if (predicate == null)
            {
                query = this.genrepo.Browseable(null);
            }
            else
            {
                query = this.genrepo.Browseable(predicate);
            }
            return this.ConverterPara(query);
        }

        public override List<AutorPorItemPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<AutorPorItem> query;
            if (skip == null)
            {
                query = this.genrepo.GetAll();
            }
            else
            {
                query = this.genrepo.GetAll(take, skip);
            }
            return this.ConverterPara(query);
        }

        public override List<AutorPorItemPoco> ConverterPara(IQueryable<AutorPorItem> query)
        {
            return query.Select(cat =>
                new AutorPorItemPoco()
                {
                    CodigoAutorPorItem = cat.CodigoAutorPorItem,
                    CodigoAutor = cat.CodigoAutor,
                    CodigoItem = cat.CodigoItem,
                    Ativo = cat.Ativo,
                    DataInclusao = cat.DataInclusao,
                    DataAlteracao = cat.DataAlteracao,
                    DataExclusao = cat.DataExclusao
                }).ToList();
        }
    }
}