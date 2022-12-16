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
    public class FuncionarioServico : GenericService<Funcionario, FuncionarioPoco>
    {
        public FuncionarioServico(TecnoShopContext contexto) : base(contexto)
        { }

        public override List<FuncionarioPoco> Consultar(Expression<Func<Funcionario, bool>>? predicate = null)
        {
            IQueryable<Funcionario> query;
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

        public override List<FuncionarioPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Funcionario> query;
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

        public override List<FuncionarioPoco> ConverterPara(IQueryable<Funcionario> query)
        {
            return query.Select(cli =>
                new FuncionarioPoco()
                {
                    CodigoFuncionario = cli.CodigoFuncionario,
                    PrimeiroNome = cli.PrimeiroNome,
                    Sobrenome = cli.Sobrenome,
                    Email = cli.Email,
                    Telefone = cli.Telefone,
                    Ativo = cli.Ativo,
                    CodigoLoja = cli.CodigoLoja,
                    CodigoGerente = cli.CodigoGerente
                }).ToList();
        }
    }
}