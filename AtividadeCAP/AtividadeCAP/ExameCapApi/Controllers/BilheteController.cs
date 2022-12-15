using ExameCAP.Dominio.EF;
using ExameCAP.Poco;
using ExameCAP.Servico.Exame;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ExameCapApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/ExameCap/[controller]")]
    [ApiController]
    public class BilheteController : ControllerBase
    {

        /// <summary>
        /// 
        /// </summary>
        public BilheteServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public BilheteController(ExameContext context) : base()
        {
            this.servico = new BilheteServico(context);
        }

        /// <summary>
        /// Lista todos os registros da tabela.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<BilhetePoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<BilhetePoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Lista os registros filtrando por ID.
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("{chave:int}")]
        public ActionResult<BilhetePoco> GetById(int chave)
        {
            try
            {
                BilhetePoco poco = this.servico.PesquisarPelaChave(chave);
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
        public ActionResult<BilhetePoco> Post([FromBody] BilhetePoco poco)
        {
            try
            {
                BilhetePoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
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
        public ActionResult<BilhetePoco> Put([FromBody] BilhetePoco poco)
        {
            try
            {
                BilhetePoco novoPoco = this.servico.Alterar(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Exclui o registro associado ao Id informado.
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpDelete("{chave:int}")]
        public ActionResult<BilhetePoco> DeleteById(int chave)
        {
            try
            {
                BilhetePoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}