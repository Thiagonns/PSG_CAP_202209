
using Atacado.DB.EF.Database;
using Atacado.Poco.Pecuaria;
using Atacado.Servico.Pecuaria;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/pecuaria/[controller]")]
    [ApiController]
    public class TipoRebanhoController : ControllerBase
    {
        private TipoRebanhoServico servico;

        /// <summary>
        /// 
        /// </summary>
        public TipoRebanhoController(ProjetoAcademiaContext contexto) : base()
        {
            servico = new TipoRebanhoServico(contexto);
        }

        /// <summary>
        /// Lista todos os registros da tabela.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<TipoRebanhoPoco>> Obter()
        {
            try
            {
                List<TipoRebanhoPoco> lista = servico.Listar();
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
        public ActionResult<TipoRebanhoPoco> ObterPorId(int codigo)
        {
            try
            {
                TipoRebanhoPoco poco = servico.PesquisarPelaChave(codigo);
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
        public ActionResult<TipoRebanhoPoco> Criar([FromBody] TipoRebanhoPoco poco)
        {
            try
            {
                TipoRebanhoPoco criarPoco = servico.Inserir(poco);
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
        public ActionResult<TipoRebanhoPoco> Atualizar([FromBody] TipoRebanhoPoco poco)
        {
            try
            {
                TipoRebanhoPoco atualizarPoco = servico.Alterar(poco);
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
        public ActionResult<TipoRebanhoPoco> ExcluirPorId(int codigo)
        {
            try
            {
                TipoRebanhoPoco excluirPoco = servico.Excluir(codigo);
                return Ok(excluirPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
