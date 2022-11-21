using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;
using Atacado.DB.EF.Database;

namespace AtacadoApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/estoque/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private ProdutoServico servico;

        /// <summary>
        /// 
        /// </summary>
        public ProdutoController(ProjetoAcademiaContext contexto) : base()
        {
            this.servico = new ProdutoServico(contexto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ProdutoPoco> Get()
        {
            return this.servico.Listar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public ProdutoPoco GetPorId(int id)
        {
            return this.servico.PesquisarPelaChave(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="catid"></param>
        /// <returns></returns>
        [HttpGet("PorCategoria/{catid:int}")]
        public List<ProdutoPoco> GetPorCategoriaId(int catid)
        {
            return this.servico.Consultar(prd => prd.CodigoCategoria == catid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subid"></param>
        /// <returns></returns>
        [HttpGet("PorSubcategoria/{subid:int}")]
        public List<ProdutoPoco> GetPorSubcategoriaId(int subid)
        {
            return this.servico.Consultar(prd => prd.CodigoSubcategoria == subid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="catid"></param>
        /// <param name="subid"></param>
        /// <returns></returns>
        [HttpGet("PorCategoria/{catid:int}/PorSubcategoria/{subid:int}")]
        public List<ProdutoPoco> GetPorCategoriaPorSubcategoria(int catid, int subid)
        {
            return this.servico.Consultar(prd => (prd.CodigoCategoria == catid) && (prd.CodigoSubcategoria == subid));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public ProdutoPoco Post([FromBody] ProdutoPoco poco)
        {
            return this.servico.Inserir(poco);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public ProdutoPoco Put([FromBody] ProdutoPoco poco)
        {
            return this.servico.Alterar(poco);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public ProdutoPoco Delete(int id)
        {
            return this.servico.Excluir(id);
        }
    }
}