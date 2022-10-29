using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.AtacadoFrota
{
    public class Carro : BasePesoCarga
    {
        private string numeroPassageiros;
        public string NumeroPassageiros { get => numeroPassageiros; set => numeroPassageiros = value; }

        public Carro()
        {
        }

        public Carro(bool ativo, int codigo, DateTime dataInclusao, string chassi, string cor, string marca, string modelo, string placa, double pesoBruto, double pesoLiquido, double pesoTotal, string numeroPassageiros) : base(ativo, codigo, dataInclusao, chassi, cor, marca, modelo, placa, pesoBruto, pesoLiquido, pesoTotal)
        {
            this.numeroPassageiros = numeroPassageiros;
        }
    }
}
