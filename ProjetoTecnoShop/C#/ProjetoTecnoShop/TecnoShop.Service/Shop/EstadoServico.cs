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
    public class EstadoServico : GenericService<Estado, EstadoPoco>
    {
        public EstadoServico(TecnoShopContext contexto) : base(contexto)
        { }

        public override List<EstadoPoco> Consultar(Expression<Func<Estado, bool>>? predicate = null)
        {
            IQueryable<Estado> query;
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

        public override List<EstadoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Estado> query;
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

        public override List<EstadoPoco> ConverterPara(IQueryable<Estado> query)
        {
            return query.Select(cli =>
                new EstadoPoco()
                {
                    CodigoEstado = cli.CodigoEstado,
                    Nome = cli.Nome,
                    UF = cli.UF
                }).ToList();
        }
    }
}