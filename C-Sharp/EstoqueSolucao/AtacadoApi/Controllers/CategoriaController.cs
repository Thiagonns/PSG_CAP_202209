using Microsoft.AspNetCore.Mvc;

using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;

namespace AtacadoApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/estoque/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private CategoriaServico servico;

        /// <summary>
        /// 
        /// </summary>
        public CategoriaController() : base()
        {
            this.servico = new CategoriaServico();
        }
        
        /// <summary>
        /// Lista todos os registros da tabela.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<CategoriaPoco> Obter()
        {
            return this.servico.Browse();
        }

        /// <summary>
        /// Lista os registros filtrando por codigo ID.
        /// </summary>
        /// <param name="codigo">Identificador dos registros. </param>
        /// <returns></returns>
        [HttpGet("{codigo:int}")]
        public CategoriaPoco ObterPorId(int codigo)
        {
            return this.servico.Read(codigo);
        }

        /// <summary>
        /// Cria um novo registro na tabela.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public CategoriaPoco Criar([FromBody] CategoriaPoco poco)
        {
            return this.servico.Add(poco);
        }

        /// <summary>
        /// Altera um registro da tabela.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public CategoriaPoco Atualizar([FromBody] CategoriaPoco poco)
        {
            return this.servico.Edit(poco);
        }

        /// <summary>
        /// Exclui o registro associado ao Id informado.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpDelete("{codigo:int}")]
        public CategoriaPoco ExcluirPorId(int codigo)
        {
            return this.servico.Delete(codigo);
        }

        /// <summary>
        /// Exclui o registo de acordo com a instância informada.
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpDelete]
        public CategoriaPoco ExcluirPorInstancia([FromBody] CategoriaPoco poco)
        {
            return this.servico.Delete(poco);
        }
    }
}
