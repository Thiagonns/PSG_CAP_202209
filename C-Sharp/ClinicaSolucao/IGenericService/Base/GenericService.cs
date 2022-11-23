using Clinica.Dominio.EF;
using Clinica.Mapping;
using Clinica.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Servico.Base
{
    public class GenericService<TDominio, TPoco>
            : IGenericService<TDominio, TPoco>
            where TDominio : class
            where TPoco : class
    {

        protected GenericRepository<TDominio> genrepo;

        protected GenericMap<TDominio, TPoco> genmap;

        public GenericService(ClinicaContext context)
        {
            genrepo = new GenericRepository<TDominio>(context);
            genmap = new GenericMap<TDominio, TPoco>();
        }

        public List<TPoco> Listar()
        {
            return Consultar(null);
        }

        public virtual List<TPoco> Listar(int? take = null, int? skip = null)
        {
            throw new NotImplementedException();
        }

        public virtual List<TPoco> Consultar(Expression<Func<TDominio, bool>>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public TPoco? PesquisarPelaChave(object chave)
        {
            TDominio? lida = genrepo.GetById(chave);
            TPoco? lidaPoco = null;
            if (lida != null)
            {
                lidaPoco = ConverterPara(lida);
            }
            return lidaPoco;
        }

        public TPoco? Inserir(TPoco poco)
        {
            TDominio? nova = ConverterPara(poco);
            TDominio? criada = genrepo.Insert(nova);
            TPoco? criadaPoco = null;
            if (criada != null)
            {
                criadaPoco = ConverterPara(criada);
            }
            return criadaPoco;
        }

        public TPoco? Alterar(TPoco poco)
        {
            TDominio? editada = ConverterPara(poco);
            TDominio? alterada = genrepo.Update(editada);
            TPoco? alteradaPoco = null;
            if (alterada != null)
            {
                alteradaPoco = ConverterPara(alterada);
            }
            return alteradaPoco;
        }

        public TPoco? Excluir(object chave)
        {
            TDominio? del = genrepo.Delete(chave);
            TPoco? delPoco = null;
            if (del != null)
            {
                delPoco = ConverterPara(del);
            }
            return delPoco;
        }

        public virtual TDominio ConverterPara(TPoco obj)
        {
            return this.genmap.Mapping.Map<TDominio>(obj);
        }

        public virtual TPoco ConverterPara(TDominio obj)
        {
            return this.genmap.Mapping.Map<TPoco>(obj);
        }

        public virtual List<TPoco> ConverterPara(IQueryable<TDominio> query)
        {
            throw new NotImplementedException();
        }
    }
}
