using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Frota
{
    public class Frota : BaseCampos
    {
        private string finalidade;
        private int veiculos;
        public string Finalidade { get => finalidade; set => finalidade = value; }
        public int Veiculos { get => veiculos; set => veiculos = value; }

        public Frota() : base()
        {
        }

        public Frota(string finalidade, int veiculo)
        {
            this.finalidade = finalidade;
            this.veiculos = veiculos;
        }
    }
}
