using Avaliar.Service.Recursos;
using Microsoft.AspNetCore.Mvc;
using Avaliar.Domain.EF;
using Avaliar.Poco;
using Avaliar.Envelope.Modelo;
using Avaliar.Envelope.Motor;
using LinqKit;

namespace AvaliarApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/avaliar/[controller]")]
    [ApiController]
    public class CorrentistaController : ControllerBase
    {

        /// <summary>
        /// 
        /// </summary>
        public CorrentistaServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public CorrentistaController(AvaliarContext context) : base()
        {
            this.servico = new CorrentistaServico(context);
        }

        /// <summary>
        /// Lista todos os registros de correntista por Paginação.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<CorrentistaPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<CorrentistaPoco> listaPoco = this.servico.Listar(take, skip);
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros da tabela Correntista por código da Instituição.
        /// </summary>
        /// <param name="instcod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorInstituicaoBancaria/{instcod:int}")]
        public ActionResult<List<CorrentistaPoco>> GetByInstituicao(int instcod)
        {
            try
            {
                List<CorrentistaPoco> listaPoco = this.servico.Consultar(cid => (cid.CodigoInstituicaoBancaria == instcod)).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Lista os registro usando a chave de correntista.
        /// </summary>
        /// <param name="chave"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{chave:int}")]
        public ActionResult<CorrentistaPoco> GetById(int chave)
        {
            try
            {
                CorrentistaPoco poco = this.servico.PesquisarPorChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Inclui um novo dado em correntista.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ActionResult<CorrentistaPoco> Post([FromBody] CorrentistaPoco poco)
        {
            try
            {
                CorrentistaPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Altera um dado existente em correntista.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Altera o dado selecionado. </returns>
        [HttpPut]
        public ActionResult<CorrentistaPoco> Put([FromBody] CorrentistaPoco poco)
        {
            try
            {
                CorrentistaPoco novoPoco = this.servico.Alterar(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Exclui um registro existente em correntista, utilizando um id.
        /// </summary>
        /// <param name="chave"> Chave para localização. </param>
        /// <returns> Dado excluido por Id. </returns>
        [HttpDelete("{chave:int}")]
        public ActionResult<CorrentistaPoco> DeleteById(int chave)
        {
            try
            {
                CorrentistaPoco poco = this.servico.Excluir(chave);
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
        public ActionResult<EnvelopeGenerico<CorrentistaEnvelope>> GetAllEnvelope(int? limite = null, int? salto = null)
        {
            try
            {
                List<CorrentistaPoco> listaPoco = this.servico.Listar(limite, salto);
                int totalReg = listaPoco.Count;
                return Envelopamento(totalReg, limite, salto, listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Retorna todos os registros de modo envelopado para o arquivo JSON filtrados pelo código da instituição.
        /// </summary>
        /// <param name="instcod"></param>
        /// <param name="limite"></param>
        /// <param name="salto"></param>
        /// <returns></returns>
        [HttpGet("envelope/PorInstituicao/{instcod:int}")]
        public ActionResult<EnvelopeGenerico<CorrentistaEnvelope>> GetPorEstadoEnvelope(int instcod, int? limite = null, int? salto = null)
        {
            try
            {
                List<CorrentistaPoco> listaPoco;
                var predicado = PredicateBuilder.New<Correntista>(true);
                int totalReg = 0;
                if (limite == null)
                {
                    if (salto != null)
                    {
                        return BadRequest("Informe os parâmetros Take e Skip.");
                    }
                    else
                    {
                        predicado = predicado.And(s => s.CodigoInstituicaoBancaria == instcod);
                        listaPoco = this.servico.Consultar(predicado);
                        totalReg = listaPoco.Count;
                        return Envelopamento(totalReg, limite, salto, listaPoco);
                    }
                }
                else
                {
                    if (salto == null)
                    {
                        return BadRequest("Informe os parâmetros Take e Skip.");
                    }
                    else
                    {
                        predicado = predicado.And(s => s.CodigoInstituicaoBancaria == instcod);
                        totalReg = this.servico.ContarTotalRegistros(predicado);
                        listaPoco = this.servico.Vasculhar(limite, salto, predicado);
                        return Envelopamento(totalReg, limite, salto, listaPoco);
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        private ActionResult<EnvelopeGenerico<CorrentistaEnvelope>> Envelopamento(int? totalReg, int? limite, int? salto, List<CorrentistaPoco> listaPoco)
        {
            string linkPost = "POST /correntista";

            ListEnvelope<CorrentistaEnvelope> list;

            if (limite > totalReg)
            {
                string erro = "Limite não pode ser maior que a quantidade de Registros.";
                list = new ListEnvelope<CorrentistaEnvelope>(null, 400, erro, linkPost, "1.0");
                return BadRequest(list.Etapa);
            }
            else
            {
                List<CorrentistaEnvelope> listaEnvelope = listaPoco.Select(est => new CorrentistaEnvelope(est)).ToList();
                listaEnvelope.ForEach(item => item.SetLinks());

                if (listaPoco.Count() == 0)
                {
                    list = new ListEnvelope<CorrentistaEnvelope>(listaEnvelope, 404, "Não existem mais registros a serem mostrados!.", linkPost, "1.0");
                    return Ok(list.Etapa);
                }

                if (salto == null)
                {
                    list = new ListEnvelope<CorrentistaEnvelope>(listaEnvelope, 200, "OK", linkPost, "1.0");
                    list.Etapa.Paginacao.TotalReg = totalReg;
                }
                else
                {
                    var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}");
                    string urlServidor = location.AbsoluteUri;
                    list = new ListEnvelope<CorrentistaEnvelope>(listaEnvelope, 200, "OK", linkPost, "1.0", urlServidor, salto, limite, totalReg);
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
        public ActionResult<CorrentistaEnvelope> GetByIdEnvelope(int chave)
        {
            try
            {
                CorrentistaPoco poco = this.servico.PesquisarPorChave(chave);
                CorrentistaEnvelope envelope = new CorrentistaEnvelope(poco);
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
