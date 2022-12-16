﻿using Microsoft.AspNetCore.Mvc;
using TecnoShop.Domain.EF;
using TecnoShop.Poco;
using TecnoShop.Service.Shop;

namespace TecnoShopApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/TecnoShop/[controller]")]
    [ApiController]
    public class CidadeController : ControllerBase
    {

        /// <summary>
        /// 
        /// </summary>
        public CidadeServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public CidadeController(TecnoShopContext context) : base()
        {
            this.servico = new CidadeServico(context);
        }

        /// <summary>
        /// Lista todos os registros da tabela.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<CidadePoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<CidadePoco> listaPoco = this.servico.Listar(take, skip);
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
        public ActionResult<CidadePoco> GetById(int chave)
        {
            try
            {
                CidadePoco poco = this.servico.PesquisarPelaChave(chave);
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
        public ActionResult<CidadePoco> Post([FromBody] CidadePoco poco)
        {
            try
            {
                CidadePoco novoPoco = this.servico.Inserir(poco);
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
        public ActionResult<CidadePoco> Put([FromBody] CidadePoco poco)
        {
            try
            {
                CidadePoco novoPoco = this.servico.Alterar(poco);
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
        public ActionResult<CidadePoco> DeleteById(int chave)
        {
            try
            {
                CidadePoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
