using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExameCAP.Servico.Base;
using ExameCAP.Dominio.EF;
using ExameCAP.Poco;
using System.Linq.Expressions;

namespace ExameCAP.Servico.Exame
{
    public class PassageiroServico : GenericService<Passageiro, PassageiroPoco>
    {
        public PassageiroServico(ExameContext contexto) : base(contexto)
        { }

        public override List<PassageiroPoco> Consultar(Expression<Func<Passageiro, bool>>? predicate = null)
        {
            IQueryable<Passageiro> query;
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

        public override List<PassageiroPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Passageiro> query;
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

        public override List<PassageiroPoco> ConverterPara(IQueryable<Passageiro> query)
        {
            return query.Select(pas =>
                new PassageiroPoco()
                {
                    CodigoPassageiro = pas.CodigoPassageiro,
                    Nome = pas.Nome,
                    Documento = pas.Documento,
                    NumeroCartao = pas.NumeroCartao,
                    Email = pas.Email,
                    Telefone = pas.Telefone,
                    DataNascimento = pas.DataNascimento
                }).ToList();
        }
    }
}