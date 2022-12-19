using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LibTec.Domain.EF;
using LibTec.Poco;
using LibTec.Service.Base;

namespace LibTec.Service.Recursos
{
    public class TipoStatusEmprestimoServico : GenericService<TipoStatusEmprestimo, TipoStatusEmprestimoPoco>
    {
        public TipoStatusEmprestimoServico(LibTecContext contexto) : base(contexto)
        { }

        public override List<TipoStatusEmprestimoPoco> Consultar(Expression<Func<TipoStatusEmprestimo, bool>>? predicate = null)
        {
            IQueryable<TipoStatusEmprestimo> query;
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

        public override List<TipoStatusEmprestimoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<TipoStatusEmprestimo> query;
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

        public override List<TipoStatusEmprestimoPoco> ConverterPara(IQueryable<TipoStatusEmprestimo> query)
        {
            return query.Select(cat =>
                new TipoStatusEmprestimoPoco()
                {
                    CodigoTipoStatusEmprestimo = cat.CodigoTipoStatusEmprestimo,
                    Descricao = cat.Descricao,
                    Ativo = cat.Ativo,
                    DataInclusao = cat.DataInclusao,
                    DataAlteracao = cat.DataAlteracao,
                    DataExclusao = cat.DataExclusao
                }).ToList();
        }
    }
}