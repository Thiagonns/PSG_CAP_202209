﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using ViajeFacil.Dominio.EF;
using ViajeFacil.Poco;
using ViajeFacil.Servico.Base;

namespace ViajeFacil.Servico.Agencia
{
    public class EstadoServico : GenericService<Estado, EstadoPoco>
    {
        public EstadoServico(ViajeFacilContexto contexto) : base(contexto)
        { }

        public override List<EstadoPoco> Consultar(Expression<Func<Estado, bool>>? predicate = null)
        {
            IQueryable<Estado> query;
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

        public override List<EstadoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Estado> query;
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

        public override List<EstadoPoco> ConverterPara(IQueryable<Estado> query)
        {
            return query.Select(est =>
                new EstadoPoco()
                {
                    EstadoId = est.EstadoId,
                    Nome = est.Nome,
                    CodigoUf = est.CodigoUf,
                    UF = est.UF,
                    RegiaoId = est.RegiaoId
                }).ToList();
        }
    }
}