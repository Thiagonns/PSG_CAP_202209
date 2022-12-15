using ExameCAP.Servico.Base;
using ExameCAP.Dominio.EF;
using ExameCAP.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExameCAP.Servico.Exame
{
    public class FuncionarioServico : GenericService<Funcionario, FuncionarioPoco>
    {
        public FuncionarioServico(ExameContext contexto) : base(contexto)
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
            return query.Select(fun =>
                new FuncionarioPoco()
                {
                    CodigoFuncionario = fun.CodigoFuncionario,
                    Matricula = fun.Matricula,
                    Nome = fun.Nome,
                    ContaCorrente = fun.ContaCorrente,
                    Email = fun.Email,
                    Telefone = fun.Telefone,
                    Usuario = fun.Usuario,
                    Senha = fun.Senha,
                    DataNascimento = fun.DataNascimento
                }).ToList();
        }
    }
}