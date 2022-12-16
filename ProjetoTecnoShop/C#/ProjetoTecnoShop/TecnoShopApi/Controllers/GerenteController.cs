using Microsoft.AspNetCore.Mvc;
using TecnoShop.Service.Shop;
using TecnoShop.Domain.EF;
using TecnoShop.Poco;


namespace TecnoShopApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/TecnoShop/[controller]")]
    [ApiController]
    public class GerenteController : ControllerBase
    {

        /// <summary>
        /// 
        /// </summary>
        public GerenteServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public GerenteController(TecnoShopContext context) : base()
        {
            this.servico = new GerenteServico(context);
        }

        /// <summary>
        /// Lista todos os registros da tabela.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<GerentePoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<GerentePoco> listaPoco = this.servico.Listar(take, skip);
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
        public ActionResult<GerentePoco> GetById(int chave)
        {
            try
            {
                GerentePoco poco = this.servico.PesquisarPelaChave(chave);
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
        public ActionResult<GerentePoco> Post([FromBody] GerentePoco poco)
        {
            try
            {
                GerentePoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<GerentePoco> Put([FromBody] GerentePoco poco)
        {
            try
            {
                GerentePoco novoPoco = this.servico.Alterar(poco);
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
        public ActionResult<GerentePoco> DeleteById(int chave)
        {
            try
            {
                GerentePoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
