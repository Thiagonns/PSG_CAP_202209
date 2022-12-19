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
    public class ItemServico : GenericService<Item, ItemPoco>
    {
        public ItemServico(LibTecContext contexto) : base(contexto)
        { }

        public override List<ItemPoco> Consultar(Expression<Func<Item, bool>>? predicate = null)
        {
            IQueryable<Item> query;
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

        public override List<ItemPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Item> query;
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

        public override List<ItemPoco> ConverterPara(IQueryable<Item> query)
        {
            return query.Select(cat =>
                new ItemPoco()
                {
                    CodigoItem = cat.CodigoItem,
                    Descricao = cat.Descricao,
                    ISBN = cat.ISBN,
                    Observacoes = cat.Observacoes,
                    CodigoTipoItem = cat.CodigoTipoItem,
                    Ativo = cat.Ativo,
                    DataInclusao = cat.DataInclusao,
                    DataAlteracao = cat.DataAlteracao,
                    DataExclusao = cat.DataExclusao
                }).ToList();
        }
    }
}