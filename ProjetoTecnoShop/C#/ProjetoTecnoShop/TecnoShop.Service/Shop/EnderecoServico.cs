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
    public class EnderecoServico : GenericService<Endereco, EnderecoPoco>
    {
        public EnderecoServico(TecnoShopContext contexto) : base(contexto)
        { }

        public override List<EnderecoPoco> Consultar(Expression<Func<Endereco, bool>>? predicate = null)
        {
            IQueryable<Endereco> query;
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

        public override List<EnderecoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Endereco> query;
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

        public override List<EnderecoPoco> ConverterPara(IQueryable<Endereco> query)
        {
            return query.Select(cli =>
                new EnderecoPoco()
                {
                    CodigoEndereco = cli.CodigoEndereco,
                    Rua = cli.Rua,
                    Numero = cli.Numero,
                    Complemento = cli.Complemento,
                    Bairro = cli.Bairro,
                    CEP = cli.CEP,
                    CodigoCidade = cli.CodigoCidade
                }).ToList();
        }
    }
}