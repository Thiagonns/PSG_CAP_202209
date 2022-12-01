using Clinica.Dominio.EF;
using Clinica.Poco;
using Clinica.Servico.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Servico.Odonto
{
    public class ProcedimentosServico : GenericService<Clinica.Dominio.EF.Servico, ServicoPoco>
    {
        public ProcedimentosServico(ClinicaContext context) : base(context)
        {
        }

        public override List<ServicoPoco> Consultar(Expression<Func<Clinica.Dominio.EF.Servico, bool>>? predicate = null)
        {
            IQueryable<Clinica.Dominio.EF.Servico> query;
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

        public override List<ServicoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Clinica.Dominio.EF.Servico> query;
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

        public override List<ServicoPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Dominio.EF.Servico, bool>>? predicate = null)
        {
            IQueryable<Clinica.Dominio.EF.Servico> query;

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
                    query = this.genrepo.Searshable(take, skip, predicate);
                }
            }
            return ConverterPara(query);
        }

        public override List<ServicoPoco> ConverterPara(IQueryable<Clinica.Dominio.EF.Servico> query)
        {
            return query.Select(pro =>
                    new ServicoPoco()
                    {
                        CodigoServico = pro.CodigoServico,
                        Descricao = pro.Descricao,
                        Preco = pro.Preco,
                        MaterialUsado = pro.MaterialUsado,
                        DenteTratado = pro.DenteTratado,
                        MedidaPreventiva = pro.MedidaPreventiva,
                        TipoExame = pro.TipoExame,
                        TipoServico = pro.TipoServico,
                        Situacao = pro.Situacao,
                        DataInclusao = pro.DataInclusao,
                        DataAlteracao = pro.DataAlteracao
                    }
            )
            .ToList();
        }
    }
}
