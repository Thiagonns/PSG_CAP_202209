using Avaliar.Domain.EF;
using Avaliar.Poco;
using Avaliar.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Avaliar.Service.Recursos
{
    public class CorrentistaServico : ServicoGenerico<Correntista, CorrentistaPoco>
    {
        public CorrentistaServico(AvaliarContext contexto) : base(contexto)
        { }

        public override List<CorrentistaPoco> Consultar(Expression<Func<Correntista, bool>>? predicate = null)
        {
            IQueryable<Correntista> query;
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

        public override List<CorrentistaPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Correntista> query;
            if (skip == null)
            {
                query = this.genrepo.GetAll();
            }
            else
            {
                query = this.genrepo.GetAll(take, skip);
            }
            return ConverterPara(query);
        }

        public override List<CorrentistaPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Correntista, bool>>? predicate = null)
        {
            IQueryable<Correntista> query;
            if (skip == null)
            {
                if (predicate == null)
                {
                    query = this.genrepo.Browseable(null);
                }
                else
                {
                    query = this.genrepo.Browseable(predicate);
                }
            }
            else
            {
                if (predicate == null)
                {
                    query = this.genrepo.GetAll(take, skip);
                }
                else
                {
                    query = this.genrepo.Searchable(take, skip, predicate);
                }
            }
            return this.ConverterPara(query);
        }

        public override List<CorrentistaPoco> ConverterPara(IQueryable<Correntista> query)
        {
            return query.Select(cor =>
                new CorrentistaPoco()
                {
                    CodigoCorrentista = cor.CodigoCorrentista,
                    CodigoInstituicaoBancaria = cor.CodigoInstituicaoBancaria,
                    Nome = cor.Nome,
                    Sobrenome = cor.Sobrenome,
                    Email = cor.Email,
                    DataInclusao = cor.DataInclusao,
                    Ativo = cor.Ativo,
                }).ToList();
        }

        public override int ContarTotalRegistros(Expression<Func<Correntista, bool>>? predicate)
        {
            IQueryable<Correntista> query;
            if (predicate == null)
            {
                query = this.genrepo.Browseable(null);
            }
            else
            {
                query = this.genrepo.Browseable(predicate);
            }
            return query.Count();
        }
    }
}