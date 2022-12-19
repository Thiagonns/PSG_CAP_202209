using LibTec.Domain.EF;
using LibTec.Poco;
using LibTec.Service.Recursos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace LibTecApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/LibTec/[controller]")]
    [ApiController]
    public class TipoItemController : ControllerBase
    {

        /// <summary>
        /// 
        /// </summary>
        public TipoItemServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public TipoItemController(LibTecContext context) : base()
        {
            this.servico = new TipoItemServico(context);
        }

        /// <summary>
        /// Lista todos os registros da tabela.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<TipoItemPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<TipoItemPoco> listaPoco = this.servico.Listar(take, skip);
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
        public ActionResult<TipoItemPoco> GetById(int chave)
        {
            try
            {
                TipoItemPoco poco = this.servico.PesquisarPelaChave(chave);
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
        public ActionResult<TipoItemPoco> Post([FromBody] TipoItemPoco poco)
        {
            try
            {
                TipoItemPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<TipoItemPoco> Put([FromBody] TipoItemPoco poco)
        {
            try
            {
                TipoItemPoco novoPoco = this.servico.Alterar(poco);
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
        public ActionResult<TipoItemPoco> DeleteById(int chave)
        {
            try
            {
                TipoItemPoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}