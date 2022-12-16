using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TecnoShop.Domain.EF;
using TecnoShop.Poco;
using TecnoShop.Service.Base;

namespace TecnoShop.Service.Shop
{
    public class EstoqueServico : GenericService<Estoque, EstoquePoco>
    {
        public EstoqueServico(TecnoShopContext contexto) : base(contexto)
        { }

        public override List<EstoquePoco> Consultar(Expression<Func<Estoque, bool>>? predicate = null)
        {
            IQueryable<Estoque> query;
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

        public override List<EstoquePoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Estoque> query;
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

        public override List<EstoquePoco> ConverterPara(IQueryable<Estoque> query)
        {
            return query.Select(cli =>
                new EstoquePoco()
                {
                    CodigoEstoque = cli.CodigoEstoque,
                    CodigoLoja = cli.CodigoLoja,
                    CodigoProduto = cli.CodigoProduto,
                    Quantidade = cli.Quantidade,
                    Ativo = cli.Ativo
                }).ToList();
        }
    }
}