﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TecnoShop.Domain.EF;
using TecnoShop.Poco;
using TecnoShop.Service.Base;

namespace TecnoShop.Service.Shop
{
    public class CategoriaServico : GenericService<Categoria, CategoriaPoco>
    {
        public CategoriaServico(TecnoShopContext contexto) : base(contexto)
        { }

        public override List<CategoriaPoco> Consultar(Expression<Func<Categoria, bool>>? predicate = null)
        {
            IQueryable<Categoria> query;
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

        public override List<CategoriaPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Categoria> query;
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

        public override List<CategoriaPoco> ConverterPara(IQueryable<Categoria> query)
        {
            return query.Select(cat =>
                new CategoriaPoco()
                {
                    CodigoCategoria = cat.CodigoCategoria,
                    CategoriaNome = cat.CategoriaNome,
                    Ativo = cat.Ativo
                }).ToList();
        }
    }
}