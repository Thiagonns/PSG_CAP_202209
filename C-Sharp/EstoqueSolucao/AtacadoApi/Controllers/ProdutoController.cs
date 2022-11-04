using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/estoque/[controller]")]
    [ApiController]
    public class ProdutoController
    {
        private ProdutoServico servico;

        /// <summary>
        /// 
        /// </summary>
        public ProdutoController() : base()
        {
            this.servico = new ProdutoServico();
        }

        /// <summary>
        /// Lista todos os registros da tabela.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ProdutoPoco> Obter()
        {
            return this.servico.Browse();
        }

        /// <summary>
        /// Lista os registros filtrando por categoria.
        /// </summary>
        /// <param name="catid">Identificador da tabela categoria.</param>
        /// <returns></returns>
        [HttpGet("PorCategoria/{catid:int}")]
        public List<ProdutoPoco> ObterPorCategoria(int catid)
        {
            return this.servico.Browse(prod => prod.CodigoCategoria == catid).ToList();
        }

        /// <summary>
        /// Lista os registros filtrando por Subcategoria.
        /// </summary>
        /// <param name="subid">Identificador da tabela subcategoria.</param>
        /// <returns></returns>
        [HttpGet("PorSubcategoria/{subid:int}")]
        public List<ProdutoPoco> ObterPorSubcategoria(int subid)
        {
            return this.servico.Browse(prod => prod.CodigoSubcategoria == subid).ToList();
        }

        /// <summary>
        /// Lista os registros filtrando por categoria e subcategoria.
        /// </summary>
        /// <param name="catid">Identificador da tabela categoria.</param>
        /// <param name="subid">Identificador da tabela subcategoria.</param>
        /// <returns></returns>
        [HttpGet("PorCategoria/{catid:int}/PorSubcategoria/{subid:int}")]
        public List<ProdutoPoco> ObterPorCategoriaPorSubcategoria(int catid, int subid)
        {
            return this.servico.Browse(prod => (prod.CodigoCategoria == catid) && (prod.CodigoSubcategoria == subid)).ToList();
        }

        /// <summary>
        /// Lista os registros filtrando por codigo Id.
        /// </summary>
        /// <param name="codigo">Identificador dos registros na tabela.</param>
        /// <returns></returns>
        [HttpGet("{codigo:int}")]
        public ProdutoPoco ObterPorId(int codigo)
        {
            return this.servico.Read(codigo);
        }

        /// <summary>
        /// Cria um novo registro na tabela.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public ProdutoPoco Criar([FromBody] ProdutoPoco poco)
        {
            return this.servico.Add(poco);
        }

        /// <summary>
        /// Altera um registro da tabela.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public ProdutoPoco Atualizar([FromBody] ProdutoPoco poco)
        {
            return this.servico.Edit(poco);
        }

        /// <summary>
        /// Exclui o registro associado ao Id informado.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpDelete("{codigo:int}")]
        public ProdutoPoco ExcluirPorId(int codigo)
        {
            return this.servico.Delete(codigo);
        }

        /// <summary>
        /// Exclui o registo de acordo com a instância informada.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpDelete]
        public ProdutoPoco ExcluirPorInstancia([FromBody] ProdutoPoco poco)
        {
            return this.servico.Delete(poco);
        }
    }
}
