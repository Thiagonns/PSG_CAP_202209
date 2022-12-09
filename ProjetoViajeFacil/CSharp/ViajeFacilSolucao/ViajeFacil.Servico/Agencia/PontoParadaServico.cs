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
    public class PontoParadaServico : GenericService<PontoParada, PontoParadaPoco>
    {
        public PontoParadaServico(ViajeFacilContexto contexto) : base(contexto)
        { }

        public override List<PontoParadaPoco> Consultar(Expression<Func<PontoParada, bool>>? predicate = null)
        {
            IQueryable<PontoParada> query;
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

        public override List<PontoParadaPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<PontoParada> query;
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

        public override List<PontoParadaPoco> ConverterPara(IQueryable<PontoParada> query)
        {
            return query.Select(pon =>
                new PontoParadaPoco()
                {
                    PontoParadaId = pon.PontoParadaId,
                    Descricao = pon.Descricao,
                    Latitude = pon.Latitude,
                    Longitude = pon.Longitude,
                    RotaId = pon.RotaId

                }).ToList();
        }
    }
}