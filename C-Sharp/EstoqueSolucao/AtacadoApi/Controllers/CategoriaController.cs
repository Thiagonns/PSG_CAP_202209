using Microsoft.AspNetCore.Mvc;
using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;


namespace AtacadoApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/estoque/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private CategoriaServico servico;

        /// <summary>
        /// 
        /// </summary>
        public CategoriaController() : base()
        {
            this.servico = new CategoriaServico();
        }
        
        /// <summary>
        /// Lista todos os registros da tabela.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<CategoriaPoco>> Obter()
        {
            try
            {
                List<CategoriaPoco>  lista = this.servico.Listar();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }            
        }

        /// <summary>
        /// Lista os registros filtrando por codigo ID.
        /// </summary>
        /// <param name="codigo">Identificador dos registros. </param>
        /// <returns></returns>
        [HttpGet("{codigo:int}")]
        public ActionResult<CategoriaPoco> ObterPorId(int codigo)
        {
            try
            {
                CategoriaPoco poco = this.servico.PesquisarPelaChave(codigo);
                return Ok(poco);
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
        public ActionResult<CategoriaPoco> Criar([FromBody] CategoriaPoco poco)
        {
            try
            {
                CategoriaPoco criarPoco = this.servico.Inserir(poco);
                return Ok(criarPoco);
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
        public ActionResult<CategoriaPoco> Atualizar([FromBody] CategoriaPoco poco)
        {
            try
            {
                CategoriaPoco atualizarPoco = this.servico.Alterar(poco);
                return Ok(atualizarPoco);
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
        public ActionResult<CategoriaPoco> ExcluirPorId(int codigo)
        {
            try
            {
                CategoriaPoco excluirPoco = this.servico.Excluir(codigo);
                return Ok(excluirPoco);
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
        public ActionResult<CategoriaPoco> ExcluirPorInstancia([FromBody] CategoriaPoco poco)
        {
            try
            {
                CategoriaPoco delPoco = this.servico.Excluir(poco.Codigo);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
