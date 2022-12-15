using ExameCAP.Dominio.EF;
using ExameCAP.Poco;
using ExameCAP.Servico.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExameCAP.Servico.Exame
{
    public class BilheteServico : GenericService<Bilhete, BilhetePoco>
    {
        public BilheteServico(ExameContext contexto) : base(contexto)
        { }

        public override List<BilhetePoco> Consultar(Expression<Func<Bilhete, bool>>? predicate = null)
        {
            IQueryable<Bilhete> query;
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

        public override List<BilhetePoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Bilhete> query;
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

        public override List<BilhetePoco> ConverterPara(IQueryable<Bilhete> query)
        {
            return query.Select(age =>
                new BilhetePoco()
                {
                    CodigoBilhete = age.CodigoBilhete,
                    NumeroBilhete = age.NumeroBilhete,
                    Assento = age.Assento
                }).ToList();
        }
    }
}