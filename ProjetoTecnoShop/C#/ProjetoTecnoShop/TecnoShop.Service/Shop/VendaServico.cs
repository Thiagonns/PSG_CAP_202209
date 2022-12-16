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
    public class VendaServico : GenericService<Venda, VendaPoco>
    {
        public VendaServico(TecnoShopContext contexto) : base(contexto)
        { }

        public override List<VendaPoco> Consultar(Expression<Func<Venda, bool>>? predicate = null)
        {
            IQueryable<Venda> query;
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

        public override List<VendaPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Venda> query;
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

        public override List<VendaPoco> ConverterPara(IQueryable<Venda> query)
        {
            return query.Select(cli =>
                new VendaPoco()
                {
                    CodigoVenda = cli.CodigoVenda,
                    CodigoCliente = cli.CodigoCliente,
                    VendaStatus = cli.VendaStatus,
                    DataVenda = cli.DataVenda,
                    DataPreparo = cli.DataPreparo,
                    DataEnvio = cli.DataEnvio,
                    CodigoLoja = cli.CodigoLoja,
                    CodigoFuncionario = cli.CodigoFuncionario,
                    Ativo = cli.Ativo
                }).ToList();
        }
    }
}