using Avaliar.Domain.EF;
using Avaliar.Poco;
using Avaliar.Service.Recursos;
using LinqKit;
using Microsoft.AspNetCore.Mvc;
using Avaliar.Envelope.Modelo;
using Avaliar.Envelope.Motor;

namespace AvaliarApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/avaliar/[controller]")]
    public class InstituicaoBancariaController : ControllerBase
    {
        private InstituicaoBancariaServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public InstituicaoBancariaController(AvaliarContext context) : base()
        {
            this.servico = new InstituicaoBancariaServico(context);
        }

        /// <summary>
        /// Lista todos os registros de Intituição bancária por Paginação.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<InstituicaoBancariaPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<InstituicaoBancariaPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Lista os registro usando a chave de Intituição bancária.
        /// </summary>
        /// <param name="chave"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{chave:int}")]
        public ActionResult<InstituicaoBancariaPoco> GetById(int chave)
        {
            try
            {
                InstituicaoBancariaPoco poco = this.servico.PesquisarPorChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Inclui um novo dado na tabela Intituição bancária.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ActionResult<InstituicaoBancariaPoco> Post([FromBody] InstituicaoBancariaPoco poco)
        {
            try
            {
                InstituicaoBancariaPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Altera um dado existente na tabela Intituição bancária.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Altera o dado selecionado. </returns>
        [HttpPut]
        public ActionResult<InstituicaoBancariaPoco> Put([FromBody] InstituicaoBancariaPoco poco)
        {
            try
            {
                InstituicaoBancariaPoco novoPoco = this.servico.Alterar(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Exclui um registro existente em Intituição bancária, utilizando um id.
        /// </summary>
        /// <param name="chave"> Chave para localização. </param>
        /// <returns> Dado excluido por Id. </returns>
        [HttpDelete("{chave:int}")]
        public ActionResult<InstituicaoBancariaPoco> DeleteById(int chave)
        {
            try
            {
                InstituicaoBancariaPoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }








        /// <summary>
        /// Retorna todos os registros de modo envelopado para o arquivo JSON
        /// </summary>
        /// <param name="limite"></param>
        /// <param name="salto"></param>
        /// <returns></returns>
        [HttpGet("envelope/")]
        public ActionResult<EnvelopeGenerico<InstituicaoBancariaEnvelope>> GetAllEnvelope(int? limite = null, int? salto = null)
        {
            try
            {
                List<InstituicaoBancariaPoco> listaPoco = this.servico.Listar(limite, salto);
                int totalReg = listaPoco.Count;
                return Envelopamento(totalReg, limite, salto, listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        private ActionResult<EnvelopeGenerico<InstituicaoBancariaEnvelope>> Envelopamento(int? totalReg, int? limite, int? salto, List<InstituicaoBancariaPoco> listaPoco)
        {
            string linkPost = "POST /instituicaobancaria";

            ListEnvelope<InstituicaoBancariaEnvelope> list;

            if (limite > totalReg)
            {
                string erro = "Limite não pode ser maior que a quantidade de Registros.";
                list = new ListEnvelope<InstituicaoBancariaEnvelope>(null, 400, erro, linkPost, "1.0");
                return BadRequest(list.Etapa);
            }
            else
            {
                List<InstituicaoBancariaEnvelope> listaEnvelope = listaPoco.Select(est => new InstituicaoBancariaEnvelope(est)).ToList();
                listaEnvelope.ForEach(item => item.SetLinks());

                if (listaPoco.Count() == 0)
                {
                    list = new ListEnvelope<InstituicaoBancariaEnvelope>(listaEnvelope, 404, "Não existem mais registros a serem mostrados!.", linkPost, "1.0");
                    return Ok(list.Etapa);
                }

                if (salto == null)
                {
                    list = new ListEnvelope<InstituicaoBancariaEnvelope>(listaEnvelope, 200, "OK", linkPost, "1.0");
                    list.Etapa.Paginacao.TotalReg = totalReg;
                }
                else
                {
                    var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}");
                    string urlServidor = location.AbsoluteUri;
                    list = new ListEnvelope<InstituicaoBancariaEnvelope>(listaEnvelope, 200, "OK", linkPost, "1.0", urlServidor, salto, limite, totalReg);
                }
                return Ok(list.Etapa);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chave"></param>
        /// <returns></returns>
        [HttpGet("envelope/{chave:int}")]
        public ActionResult<InstituicaoBancariaEnvelope> GetByIdEnvelope(int chave)
        {
            try
            {
                InstituicaoBancariaPoco poco = this.servico.PesquisarPorChave(chave);
                InstituicaoBancariaEnvelope envelope = new InstituicaoBancariaEnvelope(poco);
                envelope.SetLinks();
                return Ok(envelope);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
