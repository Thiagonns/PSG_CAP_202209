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
    public class ItemController : ControllerBase
    {

        /// <summary>
        /// 
        /// </summary>
        public ItemServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ItemController(LibTecContext context) : base()
        {
            this.servico = new ItemServico(context);
        }

        /// <summary>
        /// Lista todos os registros da tabela.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<ItemPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<ItemPoco> listaPoco = this.servico.Listar(take, skip);
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
        public ActionResult<ItemPoco> GetById(int chave)
        {
            try
            {
                ItemPoco poco = this.servico.PesquisarPelaChave(chave);
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
        public ActionResult<ItemPoco> Post([FromBody] ItemPoco poco)
        {
            try
            {
                ItemPoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<ItemPoco> Put([FromBody] ItemPoco poco)
        {
            try
            {
                ItemPoco novoPoco = this.servico.Alterar(poco);
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
        public ActionResult<ItemPoco> DeleteById(int chave)
        {
            try
            {
                ItemPoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}