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
    public class GerenteServico : GenericService<Gerente, GerentePoco>
    {
        public GerenteServico(TecnoShopContext contexto) : base(contexto)
        { }

        public override List<GerentePoco> Consultar(Expression<Func<Gerente, bool>>? predicate = null)
        {
            IQueryable<Gerente> query;
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

        public override List<GerentePoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Gerente> query;
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

        public override List<GerentePoco> ConverterPara(IQueryable<Gerente> query)
        {
            return query.Select(cli =>
                new GerentePoco()
                {
                    CodigoGerente = cli.CodigoGerente,
                    PrimeiroNome = cli.PrimeiroNome,
                    Sobrenome = cli.Sobrenome,
                    Email = cli.Email,
                    Telefone = cli.Telefone,
                    Ativo = cli.Ativo,
                    CodigoLoja = cli.CodigoLoja
                }).ToList();
        }
    }
}