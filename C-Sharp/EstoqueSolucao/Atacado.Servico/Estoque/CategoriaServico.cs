using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atacado.Servico.Base;
using Atacado.Dominio.Estoque;
using Atacado.Poco.Estoque;
using Atacado.Repositorio.Estoque;

namespace Atacado.Servico.Estoque
{
    public class CategoriaServico : BaseServico<CategoriaPoco, Categoria>
    {
        private CategoriaPoco repo;

        public CategoriaServico() : base()
        {
            this.repo = new CategoriaRepo();
        }
        public override CategoriaPoco Add(CategoriaPoco poco)
        {
            Categoria nova = this.ConvertTo(poco);
            Categoria criada = this.repo.Create(nova);
            CategoriaPoco criadaPoco = this.ConvertTo(criada);
            return criadaPoco;
        }

        public override List<CategoriaPoco> Browse()
        {
            throw new NotImplementedException();
        }

        public override CategoriaPoco ConvertTo(Categoria dominio)
        {
            return new CategoriaPoco(dominio.Codigo, dominio.Descricao, dominio.Ativo, dominio.Datainclusao);
        }

        public override Categoria ConvertTo(CategoriaPoco poco)
        {
            return new Categoria(poco.Codigo, poco.Descricao, poco.Ativo, poco.Datainclusao);
        }

        public override CategoriaPoco Delete(int chave)
        {
            throw new NotImplementedException();
        }

        public override CategoriaPoco Delete(CategoriaPoco poco)
        {
            throw new NotImplementedException();
        }

        public override CategoriaPoco Edit(CategoriaPoco poco)
        {
            throw new NotImplementedException();
        }

        public override CategoriaPoco Read(int chave)
        {
            throw new NotImplementedException();
        }
    }
}
