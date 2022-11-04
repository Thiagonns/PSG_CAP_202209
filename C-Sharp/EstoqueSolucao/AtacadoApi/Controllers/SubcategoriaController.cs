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
    public class SubcategoriaController
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
        public List<SubcategoriaPoco> Obter()
        {
            return this.servico.Browse();
        }

        /// <summary>
        /// Lista todos os registros de acordo com a categoria informada.
        /// </summary>
        /// <param name="catid"></param>
        /// <returns></returns>
        [HttpGet("PorCategoria/{catid:int}")]
        public List<SubcategoriaPoco> ObterPorCategoria(int catid)
        {
            return this.servico.Browse(cat => cat.CodigoCategoria == catid).ToList();
        }

        /// <summary>
        /// Lista todos os registros da tabela de acordo com o Id informado.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        public SubcategoriaPoco ObterPorId(int codigo)
        {
            return this.servico.Read(codigo);
        }

        /// <summary>
        /// Cria um novo registro na tabela.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public SubcategoriaPoco Criar([FromBody] SubcategoriaPoco poco)
        {
            return this.servico.Add(poco);
        }

        /// <summary>
        /// Altera um registro da tabela.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public SubcategoriaPoco Atualizar([FromBody] SubcategoriaPoco poco)
        {
            return this.servico.Edit(poco);
        }

        /// <summary>
        /// Exclui o registro associado ao Id informado.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpDelete("{codigo:int}")]
        public SubcategoriaPoco ExcluirPorId(int codigo)
        {
            return this.servico.Delete(codigo);
        }

        /// <summary>
        /// Exclui o registo de acordo com a instância informada.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpDelete]
        public SubcategoriaPoco ExcluirPorInstancia([FromBody] SubcategoriaPoco poco)
        {
            return this.servico.Delete(poco);
        }
    }
}
