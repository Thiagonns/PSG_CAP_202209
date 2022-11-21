using Atacado.Poco.Pecuaria;
using Atacado.Servico.Pecuaria;
using Microsoft.AspNetCore.Mvc;
using Atacado.DB.EF.Database;
using Atacado.Servico.Estoque;

namespace AtacadoApi.Controllers
{
    [Route("api/pecuaria/[controller]")]
    [ApiController]
    public class RebanhoController : ControllerBase
    {

        private RebanhoServico servico;

        public RebanhoController(ProjetoAcademiaContext contexto) : base()
        {
            this.servico = new RebanhoServico(contexto);
        }

        /// <summary>
        /// 
        /// </summary>


        /// <summary>
        /// Lista todos os registros da tabela.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<RebanhoPoco>> Obter(int? take = null, int? skip = null)
        {
            try
            {
                List<RebanhoPoco> lista = servico.Listar(take, skip);
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
        public ActionResult<RebanhoPoco> ObterPorId(int codigo)
        {
            try
            {
                RebanhoPoco lista = servico.PesquisarPelaChave(codigo);
                return Ok(lista);
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
        public ActionResult<RebanhoPoco> Criar([FromBody] RebanhoPoco poco)
        {
            try
            {
                RebanhoPoco criarPoco = servico.Inserir(poco);
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
        public ActionResult<RebanhoPoco> Atualizar([FromBody] RebanhoPoco poco)
        {
            try
            {
                RebanhoPoco atualizarPoco = servico.Alterar(poco);
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
        public ActionResult<RebanhoPoco> ExcluirPorId(int codigo)
        {
            try
            {
                RebanhoPoco excluirPoco = servico.Excluir(codigo);
                return Ok(excluirPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
