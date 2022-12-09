using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using ViajeFacil.Dominio.EF;
using ViajeFacil.Poco;
using ViajeFacil.Servico.Base;

namespace ViajeFacil.Servico.Agencia
{
    public class RegiaoServico : GenericService<Regiao, RegiaoPoco>
    {
        public RegiaoServico(ViajeFacilContexto contexto) : base(contexto)
        { }

        public override List<RegiaoPoco> Consultar(Expression<Func<Regiao, bool>>? predicate = null)
        {
            IQueryable<Regiao> query;
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

        public override List<RegiaoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Regiao> query;
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

        public override List<RegiaoPoco> ConverterPara(IQueryable<Regiao> query)
        {
            return query.Select(reg =>
                new RegiaoPoco()
                {
                    RegiaoId = reg.RegiaoId,
                    Nome = reg.Nome,
                    PaisId = reg.PaisId

                }).ToList();
        }
    }
}