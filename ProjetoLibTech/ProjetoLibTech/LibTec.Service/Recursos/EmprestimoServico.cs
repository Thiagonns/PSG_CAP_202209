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
    public class EmprestimoServico : GenericService<Emprestimo, EmprestimoPoco>
    {
        public EmprestimoServico(LibTecContext contexto) : base(contexto)
        { }

        public override List<EmprestimoPoco> Consultar(Expression<Func<Emprestimo, bool>>? predicate = null)
        {
            IQueryable<Emprestimo> query;
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

        public override List<EmprestimoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Emprestimo> query;
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

        public override List<EmprestimoPoco> ConverterPara(IQueryable<Emprestimo> query)
        {
            return query.Select(cat =>
                new EmprestimoPoco()
                {
                    CodigoEmprestimo = cat.CodigoEmprestimo,
                    CodigoUsuario = cat.CodigoUsuario,
                    CodigoItem = cat.CodigoItem,
                    QuantidadeRenovado = cat.QuantidadeRenovado,
                    DataSaida = cat.DataSaida,
                    DataExpiracao = cat.DataExpiracao,
                    DataRetorno = cat.DataRetorno,
                    CodigoStatus = cat.CodigoStatus,
                    Ativo = cat.Ativo,
                    DataInclusao = cat.DataInclusao,
                    DataAlteracao = cat.DataAlteracao,
                    DataExclusao = cat.DataExclusao
                }).ToList();
        }
    }
}