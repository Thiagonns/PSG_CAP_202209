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
    public class ProdutoServico : GenericService<Produto, ProdutoPoco>
    {
        public ProdutoServico(TecnoShopContext contexto) : base(contexto)
        { }

        public override List<ProdutoPoco> Consultar(Expression<Func<Produto, bool>>? predicate = null)
        {
            IQueryable<Produto> query;
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

        public override List<ProdutoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Produto> query;
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

        public override List<ProdutoPoco> ConverterPara(IQueryable<Produto> query)
        {
            return query.Select(cli =>
                new ProdutoPoco()
                {
                    CodigoProduto = cli.CodigoProduto,
                    ProdutoNome = cli.ProdutoNome,
                    CodigoMarca = cli.CodigoMarca,
                    CodigoCategoria = cli.CodigoCategoria,
                    AnoModelo = cli.AnoModelo,
                    PrecoListado = cli.PrecoListado,
                    Ativo = cli.Ativo
                }).ToList();
        }
    }
}
