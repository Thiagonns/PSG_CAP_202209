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
    public class TipoUsuarioServico : GenericService<TipoUsuario, TipoUsuarioPoco>
    {
        public TipoUsuarioServico(LibTecContext contexto) : base(contexto)
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
            return query.Select(cat =>
                new TipoUsuarioPoco()
                {
                    CodigoTipoUsuario = cat.CodigoTipoUsuario,
                    Descricao = cat.Descricao,
                    Ativo = cat.Ativo,
                    DataInclusao = cat.DataInclusao,
                    DataAlteracao = cat.DataAlteracao,
                    DataExclusao = cat.DataExclusao
                }).ToList();
        }
    }
}