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
    public class SubcategoriaController : ControllerBase
    {
        private SubcategoriaServico servico;

        /// <summary>
        /// 
        /// </summary>
        public SubcategoriaController() : base()
        {
            this.servico = new SubcategoriaServico();
        }

        /// <summary>
        /// Lista todos os registros da tabela.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<SubcategoriaPoco>> Obter()
        {
            try
            {
                List<SubcategoriaPoco> list = this.servico.Browse();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Lista todos os registros de acordo com a categoria informada.
        /// </summary>
        /// <param name="catid"></param>
        /// <returns></returns>
        [HttpGet("PorCategoria/{catid:int}")]
        public ActionResult<List<SubcategoriaPoco>> ObterPorCategoria(int catid)
        {
            try
            {
                List<SubcategoriaPoco> list = this.servico.Browse(cat => cat.CodigoCategoria == catid).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Lista todos os registros da tabela de acordo com o Id informado.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        public ActionResult<SubcategoriaPoco> ObterPorId(int codigo)
        {
            try
            {
                SubcategoriaPoco readPoco = this.servico.Read(codigo);
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
        public ActionResult<SubcategoriaPoco> Criar([FromBody] SubcategoriaPoco poco)
        {
            try
            {
                SubcategoriaPoco addPoco = this.servico.Add(poco);
                return Ok(addPoco);
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
        public ActionResult<SubcategoriaPoco> Atualizar([FromBody] SubcategoriaPoco poco)
        {
            try
            {
                SubcategoriaPoco editPoco = this.servico.Edit(poco);
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
        public ActionResult<SubcategoriaPoco> ExcluirPorId(int codigo)
        {
            try
            {
                SubcategoriaPoco delPoco = this.servico.Delete(codigo);
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
        public ActionResult<SubcategoriaPoco> ExcluirPorInstancia([FromBody] SubcategoriaPoco poco)
        {
            try
            {
                SubcategoriaPoco delPoco = this.servico.Delete(poco);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
