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
    public class VendaItemServico : GenericService<VendaItem, VendaItemPoco>
    {
        public VendaItemServico(TecnoShopContext contexto) : base(contexto)
        { }

        public override List<VendaItemPoco> Consultar(Expression<Func<VendaItem, bool>>? predicate = null)
        {
            IQueryable<VendaItem> query;
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

        public override List<VendaItemPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<VendaItem> query;
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

        public override List<VendaItemPoco> ConverterPara(IQueryable<VendaItem> query)
        {
            return query.Select(cli =>
                new VendaItemPoco()
                {
                    CodigoVendaItem = cli.CodigoVendaItem,
                    CodigoVenda = cli.CodigoVenda,
                    CodigoItem = cli.CodigoItem,
                    CodigoProduto = cli.CodigoProduto,
                    Quantidade = cli.Quantidade,
                    PrecoListado = cli.PrecoListado,
                    Desconto = cli.Desconto,
                    Ativo = cli.Ativo
                }).ToList();
        }
    }
}