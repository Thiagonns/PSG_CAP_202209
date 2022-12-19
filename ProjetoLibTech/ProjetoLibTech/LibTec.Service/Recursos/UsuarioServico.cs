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
    public class UsuarioServico : GenericService<Usuario, UsuarioPoco>
    {
        public UsuarioServico(LibTecContext contexto) : base(contexto)
        { }

        public override List<UsuarioPoco> Consultar(Expression<Func<Usuario, bool>>? predicate = null)
        {
            IQueryable<Usuario> query;
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

        public override List<UsuarioPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Usuario> query;
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

        public override List<UsuarioPoco> ConverterPara(IQueryable<Usuario> query)
        {
            return query.Select(cat =>
                new UsuarioPoco()
                {
                    CodigoUsuario = cat.CodigoUsuario,
                    Nome = cat.Nome,
                    Sobrenome = cat.Sobrenome,
                    Senha = cat.Senha,
                    Email = cat.Email,
                    MaxEmprestimo = cat.MaxEmprestimo,
                    CodigoTipoUsuario = cat.CodigoTipoUsuario,
                    Ativo = cat.Ativo,
                    DataInclusao = cat.DataInclusao,
                    DataAlteracao = cat.DataAlteracao,
                    DataExclusao = cat.DataExclusao
                }).ToList();
        }
    }
}