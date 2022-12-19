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
    public class ReservaServico : GenericService<Reserva, ReservaPoco>
    {
        public ReservaServico(LibTecContext contexto) : base(contexto)
        { }

        public override List<ReservaPoco> Consultar(Expression<Func<Reserva, bool>>? predicate = null)
        {
            IQueryable<Reserva> query;
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

        public override List<ReservaPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Reserva> query;
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

        public override List<ReservaPoco> ConverterPara(IQueryable<Reserva> query)
        {
            return query.Select(cat =>
                new ReservaPoco()
                {
                    CodigoReserva = cat.CodigoReserva,
                    CodigoUsuario = cat.CodigoUsuario,
                    CodigoItem = cat.CodigoItem,
                    CodigoStatus = cat.CodigoStatus,
                    Ativo = cat.Ativo,
                    DataInclusao = cat.DataInclusao,
                    DataAlteracao = cat.DataAlteracao,
                    DataExclusao = cat.DataExclusao
                }).ToList();
        }
    }
}