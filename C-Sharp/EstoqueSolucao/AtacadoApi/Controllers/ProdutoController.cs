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
    public class ProdutoController : ControllerBase
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
        public ActionResult<List<ProdutoPoco>> Obter()
        {
            try
            {
                List<ProdutoPoco> list = this.servico.Browse();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Lista os registros filtrando por categoria.
        /// </summary>
        /// <param name="catid">Identificador da tabela categoria.</param>
        /// <returns></returns>
        [HttpGet("PorCategoria/{catid:int}")]
        public ActionResult<List<ProdutoPoco>> ObterPorCategoria(int catid)
        {
            try
            {
                List<ProdutoPoco> list = this.servico.Browse(prod => prod.CodigoCategoria == catid).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Lista os registros filtrando por Subcategoria.
        /// </summary>
        /// <param name="subid">Identificador da tabela subcategoria.</param>
        /// <returns></returns>
        [HttpGet("PorSubcategoria/{subid:int}")]
        public ActionResult<List<ProdutoPoco>> ObterPorSubcategoria(int subid)
        {
            try
            {
                List<ProdutoPoco> list = this.servico.Browse(prod => prod.CodigoSubcategoria == subid).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Lista os registros filtrando por categoria e subcategoria.
        /// </summary>
        /// <param name="catid">Identificador da tabela categoria.</param>
        /// <param name="subid">Identificador da tabela subcategoria.</param>
        /// <returns></returns>
        [HttpGet("PorCategoria/{catid:int}/PorSubcategoria/{subid:int}")]
        public ActionResult<List<ProdutoPoco>> ObterPorCategoriaPorSubcategoria(int catid, int subid)
        {
            try
            {
                List<ProdutoPoco> list = this.servico.Browse(prod => (prod.CodigoCategoria == catid) && (prod.CodigoSubcategoria == subid)).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            } 
        }

        /// <summary>
        /// Lista os registros filtrando por codigo Id.
        /// </summary>
        /// <param name="codigo">Identificador dos registros na tabela.</param>
        /// <returns></returns>
        [HttpGet("{codigo:int}")]
        public ActionResult<ProdutoPoco> ObterPorId(int codigo)
        {
            try
            {
                ProdutoPoco readPoco = this.servico.Read(codigo);
                return Ok(readPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Cria um novo registro na tabela.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<ProdutoPoco> Criar([FromBody] ProdutoPoco poco)
        {
            try
            {
                ProdutoPoco AddPoco = this.servico.Add(poco);
                return Ok(AddPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Altera um registro da tabela.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<ProdutoPoco> Atualizar([FromBody] ProdutoPoco poco)
        {
            try
            {
                ProdutoPoco editPoco = this.servico.Edit(poco);
                return Ok(editPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Exclui o registro associado ao Id informado.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpDelete("{codigo:int}")]
        public ActionResult<ProdutoPoco> ExcluirPorId(int codigo)
        {
            try
            {
                ProdutoPoco delPoco = this.servico.Delete(codigo);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Exclui o registo de acordo com a instância informada.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult<ProdutoPoco> ExcluirPorInstancia([FromBody] ProdutoPoco poco)
        {
            try
            {
                ProdutoPoco delPoco = this.servico.Delete(poco);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
