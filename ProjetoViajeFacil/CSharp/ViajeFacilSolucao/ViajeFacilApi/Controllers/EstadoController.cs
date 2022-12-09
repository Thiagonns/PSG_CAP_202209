using ViajeFacil.Dominio.EF;
using ViajeFacil.Poco;
using ViajeFacil.Servico.Agencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ViajeFacilApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/ViajeFacil/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {

        /// <summary>
        /// 
        /// </summary>
        public EstadoServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public EstadoController(ViajeFacilContexto context) : base()
        {
            this.servico = new EstadoServico(context);
        }

        /// <summary>
        /// Lista todos os registros da tabela.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<EstadoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<EstadoPoco> listaPoco = this.servico.Listar(take, skip);
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
        [HttpGet("{chave:long}")]
        public ActionResult<EstadoPoco> GetById(long chave)
        {
            try
            {
                EstadoPoco poco = this.servico.PesquisarPelaChave(chave);
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
        public ActionResult<EstadoPoco> Post([FromBody] EstadoPoco poco)
        {
            try
            {
                EstadoPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<EstadoPoco> Put([FromBody] EstadoPoco poco)
        {
            try
            {
                EstadoPoco novoPoco = this.servico.Alterar(poco);
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
        [HttpDelete("{chave:long}")]
        public ActionResult<EstadoPoco> DeleteById(long chave)
        {
            try
            {
                EstadoPoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}