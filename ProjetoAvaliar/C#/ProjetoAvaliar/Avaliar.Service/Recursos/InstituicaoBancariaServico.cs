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
    public class InstituicaoBancariaServico : ServicoGenerico<InstituicaoBancaria, InstituicaoBancariaPoco>
    {
        public InstituicaoBancariaServico(AvaliarContext contexto) : base(contexto)
        { }

        public override List<InstituicaoBancariaPoco> Consultar(Expression<Func<InstituicaoBancaria, bool>>? predicate = null)
        {
            IQueryable<InstituicaoBancaria> query;
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

        public override List<InstituicaoBancariaPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<InstituicaoBancaria> query;
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

        public override List<InstituicaoBancariaPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<InstituicaoBancaria, bool>>? predicate = null)
        {
            IQueryable<InstituicaoBancaria> query;
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

        public override List<InstituicaoBancariaPoco> ConverterPara(IQueryable<InstituicaoBancaria> query)
        {
            return query.Select(inst =>
                new InstituicaoBancariaPoco()
                {
                    CodigoInstituicaoBancaria = inst.CodigoInstituicaoBancaria,
                    CodigoBanco = inst.CodigoBanco,
                    Descricao = inst.Descricao,
                    SiteWWW = inst.SiteWWW,
                    DataInclusao = inst.DataInclusao,
                    Ativo = inst.Ativo,
                }).ToList();
        }

        public override int ContarTotalRegistros(Expression<Func<InstituicaoBancaria, bool>>? predicate)
        {
            IQueryable<InstituicaoBancaria> query;
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