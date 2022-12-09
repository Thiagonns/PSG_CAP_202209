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
    public class TipoUsuarioServico : GenericService<TipoUsuario, TipoUsuarioPoco>
    {
        public TipoUsuarioServico(ViajeFacilContexto contexto) : base(contexto)
        { }

        public override List<TipoUsuarioPoco> Consultar(Expression<Func<TipoUsuario, bool>>? predicate = null)
        {
            IQueryable<TipoUsuario> query;
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

        public override List<TipoUsuarioPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<TipoUsuario> query;
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

        public override List<TipoUsuarioPoco> ConverterPara(IQueryable<TipoUsuario> query)
        {
            return query.Select(tip =>
                new TipoUsuarioPoco()
                {
                    TipoUsuarioId = tip.TipoUsuarioId,
                    Descricao = tip.Descricao

                }).ToList();
        }
    }
}