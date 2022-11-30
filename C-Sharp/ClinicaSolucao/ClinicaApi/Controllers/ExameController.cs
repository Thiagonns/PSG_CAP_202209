using Clinica.Dominio.EF;
using Clinica.Poco;
using Clinica.Servico.Odonto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace ClinicaApi.Controllers
{
    [Route("api/clinica/[controller]")]
    [ApiController]
    public class ExameController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private ProcedimentosServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ExameController(ClinicaContext context) : base()
        {
            this.servico = new ProcedimentosServico(context);
        }

        /// <summary>
        /// Retorna todos os registros 
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<ServicoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<ServicoPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
