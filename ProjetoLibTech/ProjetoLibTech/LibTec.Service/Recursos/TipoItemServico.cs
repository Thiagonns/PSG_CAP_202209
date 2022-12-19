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
    public class TipoItemServico : GenericService<TipoItem, TipoItemPoco>
    {
        public TipoItemServico(LibTecContext contexto) : base(contexto)
        { }

        public override List<TipoItemPoco> Consultar(Expression<Func<TipoItem, bool>>? predicate = null)
        {
            IQueryable<TipoItem> query;
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

        public override List<TipoItemPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<TipoItem> query;
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

        public override List<TipoItemPoco> ConverterPara(IQueryable<TipoItem> query)
        {
            return query.Select(cat =>
                new TipoItemPoco()
                {
                    CodigoTipoItem = cat.CodigoTipoItem,
                    Descricao = cat.Descricao,
                    Ativo = cat.Ativo,
                    DataInclusao = cat.DataInclusao,
                    DataAlteracao = cat.DataAlteracao,
                    DataExclusao = cat.DataExclusao
                }).ToList();
        }
    }
}