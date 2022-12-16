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
    public class ClienteServico : GenericService<Cliente, ClientePoco>
    {
        public ClienteServico(TecnoShopContext contexto) : base(contexto)
        { }

        public override List<ClientePoco> Consultar(Expression<Func<Cliente, bool>>? predicate = null)
        {
            IQueryable<Cliente> query;
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

        public override List<ClientePoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Cliente> query;
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

        public override List<ClientePoco> ConverterPara(IQueryable<Cliente> query)
        {
            return query.Select(cli =>
                new ClientePoco()
                {
                    CodigoCliente = cli.CodigoCliente,
                    PrimeiroNome = cli.PrimeiroNome,
                    Sobrenome = cli.Sobrenome,
                    Telefone = cli.Telefone,
                    Email = cli.Email,
                    CodigoEndereco = cli.CodigoEndereco,
                    Ativo = cli.Ativo
                }).ToList();
        }
    }
}