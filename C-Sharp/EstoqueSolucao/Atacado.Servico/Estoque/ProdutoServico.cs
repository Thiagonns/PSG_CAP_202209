﻿using Atacado.DB.EF.Database;
using Atacado.Poco.Estoque;
using Atacado.Repositorio.Base;
using Atacado.Repositorio.Estoque;
using Atacado.Servico.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Servico.Estoque
{
    public class ProdutoServico : BaseServico<ProdutoPoco, Produto>
    {
        private GenericRepository<Produto> genrepo;

        public ProdutoServico() : base()
        {
            this.genrepo = new GenericRepository<Produto>();
        }
        public override ProdutoPoco Add(ProdutoPoco poco)
        {
            Produto nova = this.ConvertTo(poco);
            Produto criada = this.genrepo.Insert(nova);
            return this.ConvertTo(criada);
        }

        public override List<ProdutoPoco> Browse()
        {
            return this.Browse(null);
        }

        public override List<ProdutoPoco> Browse(Expression<Func<Produto, bool>> filtro = null)
        {
            List<ProdutoPoco> listaPoco;
            IQueryable<Produto> query;
            if (filtro == null)
            {
                query = this.genrepo.Browseable(null);
            }
            else
            {
                query = this.genrepo.Browseable(filtro);
            }
            listaPoco = query.Select(cat => new ProdutoPoco()
            {
                Codigo = cat.Codigo,
                Descricao = cat.Descricao,
                Ativo = cat.Ativo,
                DataInsert = cat.DataInsert
            }
            ).ToList();
            return listaPoco;
        }

        public override ProdutoPoco ConvertTo(Produto dominio)
        {
            return new ProdutoPoco()
            {
                Codigo = dominio.Codigo,
                CodigoCategoria=dominio.CodigoCategoria,
                CodigoSubcategoria=dominio.CodigoSubcategoria,                
                Descricao = dominio.Descricao,
                Ativo = dominio.Ativo,
                DataInsert = dominio.DataInsert
            };
        }

        public override Produto ConvertTo(ProdutoPoco poco)
        {
            return new Produto()
            {
                Codigo = poco.Codigo,
                CodigoCategoria = poco.CodigoCategoria,
                CodigoSubcategoria = poco.CodigoSubcategoria,                
                Descricao = poco.Descricao,
                Ativo = poco.Ativo,
                DataInsert = poco.DataInsert
            };
        }

        public override ProdutoPoco Delete(int chave)
        {
            Produto del = this.genrepo.Delete(chave);
            ProdutoPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override ProdutoPoco Delete(ProdutoPoco poco)
        {
            Produto del = this.genrepo.Delete(poco.Codigo);
            ProdutoPoco delPoco = this.ConvertTo(del);
            return delPoco;
        }

        public override ProdutoPoco Edit(ProdutoPoco poco)
        {
            Produto editada = this.ConvertTo(poco);
            Produto alterada = this.genrepo.Update(editada);
            ProdutoPoco alteradaPoco = this.ConvertTo(alterada);
            return alteradaPoco;
        }

        public override ProdutoPoco Read(int chave)
        {
            Produto lida = this.genrepo.GetById(chave);
            ProdutoPoco lidaPoco = this.ConvertTo(lida);
            return lidaPoco;
        }
    }
}
