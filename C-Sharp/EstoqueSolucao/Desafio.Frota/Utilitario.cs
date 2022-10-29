using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Frota
{
    internal class Utilitario : BasePesoCarga
    {
        public Utilitario() : base()
        {
        }
        public Utilitario(bool ativo, int codigo, DateTime dataInclusao, string chassi, string cor, string marca, string modelo, string placa, double pesoBruto, double pesoLiquido, double pesoTotal)
            : base(ativo, codigo, dataInclusao, chassi, cor, marca, modelo, placa, pesoBruto, pesoLiquido, pesoTotal)
        {
        }
    }
}
