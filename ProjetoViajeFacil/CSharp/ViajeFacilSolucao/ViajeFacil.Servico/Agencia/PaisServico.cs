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
    public class PaisServico : GenericService<Pais, PaisPoco>
    {
        public PaisServico(ViajeFacilContexto contexto) : base(contexto)
        { }

        public override List<PaisPoco> Consultar(Expression<Func<Pais, bool>>? predicate = null)
        {
            IQueryable<Pais> query;
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

        public override List<PaisPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Pais> query;
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

        public override List<PaisPoco> ConverterPara(IQueryable<Pais> query)
        {
            return query.Select(pai =>
                new PaisPoco()
                {
                    PaisId = pai.PaisId,
                    Nome = pai.Nome                   

                }).ToList();
        }
    }
}